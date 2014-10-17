using Application.Data.Repositories;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Application.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlertsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlertsService.svc or AlertsService.svc.cs at the Solution Explorer and start debugging.
    public class AlertsService : IAlertsService
    {
        private IApplicationData data;


        public AlertsService()
            :this(new ApplicationData())
        {
        }

        public AlertsService(IApplicationData data)
        {
            this.data = data;
        }

        public ICollection<Alert> GetAlerts()
        {
            return this.data.Alerts.All().ToArray();
        }
    }
}
