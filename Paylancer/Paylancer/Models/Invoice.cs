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

        /// <summary>
        /// Work Line Items Associated with this invoice
        /// </summary>
        public IList<WorkLineItem> LineItems { get; set; }

        /// <summary>
        /// Project Associated with this Invoice
        /// </summary>
        public Models.Project Project { get; set; }
    }
}
