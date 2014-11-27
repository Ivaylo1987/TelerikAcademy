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

            //calendarService.CalendarList.Delete("qlgi89v6igg9ui8fccrtg6jnl8@group.calendar.google.com").Execute();
            calendarService.Calendars.Delete("qlgi89v6igg9ui8fccrtg6jnl8@group.calendar.google.com").Execute();
            var aclList = calendarService.Acl.List("dc37sl7l13vfp2pobmkdoqnnq0@group.calendar.google.com").Execute().Items;

            if (aclList.Count <= 0 )
            {
                AclRule rule = new AclRule();
                rule.Role = "owner";
                rule.Scope = new AclRule.ScopeData();
                rule.Scope.Type = "user";
                rule.Scope.Value = "dev.testing.ivo@gmail.com";

                calendarService.Acl.Insert(rule, "dc37sl7l13vfp2pobmkdoqnnq0@group.calendar.google.com").Execute();
            }

            Event @event = new Event()
            {
                Summary = "Appointment",
                Location = "Somewhere",
                Start = new EventDateTime()
                {
                    DateTime = new DateTime(2014, 11, 27, 16, 00, 00),
                    TimeZone = "Europe/Zurich"
                },
                End = new EventDateTime()
                {
                    DateTime = new DateTime(2014, 11, 27, 17, 00, 00),
                    TimeZone = "Europe/Zurich"
                },
                Attendees = new List<EventAttendee>()
                {
                    new EventAttendee() { Email = "dev.testing.ivo@gmail.com"}
                }
            };

            var recurringEvent = calendarService.Events.Insert(@event, "dc37sl7l13vfp2pobmkdoqnnq0@group.calendar.google.com").Execute();

        }
    }
}