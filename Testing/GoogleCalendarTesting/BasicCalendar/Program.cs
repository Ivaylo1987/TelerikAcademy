namespace BasicCalendar
{
    using Google.Apis.Auth.OAuth2;
    using Google.Apis.Calendar.v3;
    using Google.Apis.Calendar.v3.Data;
    using Google.Apis.Services;
    using System;
    using System.Security.Cryptography.X509Certificates;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Plus API - Service Account");
            Console.WriteLine("==========================");

            String serviceAccountEmail = "847753983802-6qbjred3ht7beabof68s9dapuq94912i@developer.gserviceaccount.com";

            var certificate = new X509Certificate2(@"../../certificate/CalendarApiTest-a03ab29c21cd.p12", "notasecret", X509KeyStorageFlags.Exportable);

            ServiceAccountCredential credential = new ServiceAccountCredential(
                new ServiceAccountCredential.Initializer(serviceAccountEmail)
                {
                    Scopes = new[] { CalendarService.Scope.Calendar }
                }.FromCertificate(certificate));


            var calendarService = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "CalendarApiTest"
            });


            var calendarList = calendarService.CalendarList.List().Execute().Items;

            if (calendarList.Count <= 0)
            {
                var cal = new Calendar();
                cal.Summary = "Service Owned Calendar";

                var serviceOwned = calendarService.Calendars.Insert(cal).Execute();
                Console.WriteLine(serviceOwned.Id);
            }

            var calendarId = calendarList.FirstOrDefault().Id;

            //calendarService.Calendars.Delete("dc37sl7l13vfp2pobmkdoqnnq0@group.calendar.google.com").Execute();
            var aclList = calendarService.Acl.List(calendarId).Execute().Items;

            if (aclList.Count <= 0)
            {
                AclRule rule = new AclRule();
                rule.Role = "owner";
                rule.Scope = new AclRule.ScopeData();
                rule.Scope.Type = "user";
                rule.Scope.Value = "dev.testing.ivo@gmail.com";

                calendarService.Acl.Insert(rule, calendarId).Execute();
            }

            var birthDays = new List<BirthDay>();

            using (StreamReader UCNFile = new StreamReader("../../Files/NamesAndUCN.txt"))
            {
                var fileLine = UCNFile.ReadLine();

                while (fileLine != null)
                {
                    var peopleUnits = fileLine.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var personUnit in peopleUnits)
                    {
                        try
                        {
                            var unitSplit = personUnit.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                            var name = unitSplit[0];
                            var ucn = unitSplit[1];

                            var ucnYear = int.Parse(ucn.Substring(0, 2));
                            var ucnMonth = int.Parse(ucn.Substring(2, 2));
                            var ucnDate = int.Parse(ucn.Substring(4, 2));

                            int birthDate = ucnDate;
                            int birthYear = 1900;
                            int birthMonth = ucnMonth;

                            if (ucnMonth > 40)
                            {
                                // born after 2000
                                birthYear += 100 + ucnYear;
                                birthMonth = ucnMonth - 40;
                            }

                            var birthDay = new BirthDay()
                            {
                                Name = name,
                                Date = new DateTime(birthYear, birthMonth, birthDate)
                            };

                            birthDays.Add(birthDay);
                        }
                        catch (FormatException)
                        {
                            // handle format exception
                        }
                        catch (ArgumentException)
                        {
                            // handle argument excepton
                        }
                    }

                    fileLine = UCNFile.ReadLine();
                }
            }

            var birhtDayEvents = new List<Event>();
            foreach (var birthDay in birthDays)
            {
                var eventDate = new DateTime(DateTime.Now.Year, birthDay.Date.Month, birthDay.Date.Day);
                var summery = string.Format("{0} has a BirthDay today. Going {1} !", birthDay.Name, DateTime.Now.Year - birthDay.Date.Year);

                var bdEvent = new Event()
                {
                    Summary = birthDay.Name + " has a BirthDay today.",
                    Start = new EventDateTime()
                    {
                        // check date.ToString()?!
                        Date = eventDate.ToString("yyyy-MM-dd")
                    },
                    End = new EventDateTime()
                    {
                        Date = eventDate.AddDays(1.0).ToString("yyyy-MM-dd")
                    },
                    Attendees = new List<EventAttendee>()
                    {
                        new EventAttendee() { Email = "dev.testing.ivo@gmail.com"}
                    }
                };

                birhtDayEvents.Add(bdEvent);
                var eventsAftercurrent = calendarService.Events.List(calendarId);
                eventsAftercurrent.TimeMax = eventDate.AddDays(1.0);
                eventsAftercurrent.TimeMin = eventDate.AddDays(-1.0);

                var eventsInTheSameInterval = eventsAftercurrent.Execute().Items;

                foreach (var item in eventsInTheSameInterval)
                {
                    if (item.Summary == summery)
                    {
                        continue;
                    }
                }
                
                calendarService.Events.Insert(bdEvent, calendarId).Execute();
            }

            //Event @event = new Event()
            //{
            //    Summary = "Appointment",
            //    Location = "Somewhere",
            //    Start = new EventDateTime()
            //    {
            //        DateTime = new DateTime(2014, 11, 27, 17, 00, 00),
            //        TimeZone = "Europe/Zurich"
            //    },
            //    End = new EventDateTime()
            //    {
            //        DateTime = new DateTime(2014, 11, 27, 18, 00, 00),
            //        TimeZone = "Europe/Zurich"
            //    },
            //    Attendees = new List<EventAttendee>()
            //    {
            //        new EventAttendee() { Email = "dev.testing.ivo@gmail.com"}
            //    }
            //};

            //var recurringEvent = calendarService.Events.Insert(@event, calendarId).Execute();

        }
    }
}