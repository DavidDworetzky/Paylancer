using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylancer.Models
{
    /// <summary>
    /// Paylancer project
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Project Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The schedule at which we should create invoices for this project
        /// </summary>
        public int InvoiceScheduleType { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        public string Name { get; set; }

        public DateTime GetNextInvoiceDate(DateTime previousStartDate)
        {
            //convert InvoiceScheduleType to InvoiceScheduleType
            object? scheduleType;
            if(!Enum.TryParse(typeof(InvoiceScheduleType), InvoiceScheduleType.ToString(), out scheduleType))
            {
                throw new System.ArgumentOutOfRangeException($"Invoice schedule type does not match enumeration type: {InvoiceScheduleType}");
            }
            var type = (InvoiceScheduleType)scheduleType;
            var date = previousStartDate;

            switch(type)
            {
                case Models.InvoiceScheduleType.Daily:
                    date = date.AddDays(1);
                break;
                case Models.InvoiceScheduleType.Weekly:
                    date = date.AddDays(7);
                break;
                case Models.InvoiceScheduleType.Monthly:
                    date = date.AddMonths(1);
                break;
                default:
                break;
            }
            return date;
        }
    }

    public enum InvoiceScheduleType
    {
        Daily = 0,
        Weekly = 2,
        Monthly = 3,
        Manual = 4
    }
}
