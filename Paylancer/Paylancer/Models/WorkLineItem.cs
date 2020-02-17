using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylancer.Models
{
    public class WorkLineItem
    {
        public DateTime Date { get; set; }

        public string Notes { get; set; }

        public Decimal Amount { get; set; }

        public int Type { get; set; }

        /// <summary>
        /// Project Associated with Work Line Item
        /// </summary>
        public Project Project { get; set; }
    }

    public enum WorkLineItemType
    {
        Material,
        Labor
    }
}
