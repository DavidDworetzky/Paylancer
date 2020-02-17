using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylancer.Models
{
    public class Invoice
    {
        public string Id { get; set; }

        public DateTime StartPeriod { get; set; }

        public DateTime EndPeriod { get; set; }

        public DateTime CreateDate { get; set; }

        public string Description { get; set; }

        public IList<WorkLineItem> LineItems { get; set; }
    }
}
