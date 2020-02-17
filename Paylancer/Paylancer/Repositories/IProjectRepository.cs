using Paylancer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylancer.Repositories
{
    public interface IProjectRepository
    {
        /// <summary>
        /// Add Customer
        /// </summary>
        /// <param name="customer"></param>
        void AddCustomer(Customer customer);
        /// <summary>
        /// Add Project
        /// </summary>
        /// <param name="project"></param>
        void AddProject(Project project);

        /// <summary>
        /// Update Project
        /// </summary>
        /// <param name="project"></param>
        void UpdateProject(Project project);

        /// <summary>
        /// Get Project
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Project GetProject(int id);

        /// <summary>
        /// Work Line Item, Add
        /// </summary>
        /// <param name="lineItem"></param>
        void AddWorkLineItem(WorkLineItem lineItem);

        /// <summary>
        /// Get Range of Work Line Items
        /// </summary>
        /// <param name="startRange"></param>
        /// <param name="endRange"></param>
        /// <returns></returns>
        IList<WorkLineItem> GetWorkLineItemsInDays(DateTime startRange, DateTime endRange);

        /// <summary>
        /// Add Invoice
        /// </summary>
        /// <param name="invoice"></param>
        void AddInvoice(Invoice invoice);

        /// <summary>
        /// Get invoice
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Invoice GetInvoice(int id);


    }
}
