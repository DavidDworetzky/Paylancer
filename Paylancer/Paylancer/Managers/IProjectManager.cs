using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylancer.Managers
{
    interface IProjectManager
    {
        void CreateCustomer(Models.Customer customer);
        void CreateProject(Models.Project project);

        void AddWorkLineItem(Models.WorkLineItem lineItem);

        void CreateInvoice(Models.Invoice invoice);

        void GetInvoicesForProject(int projectId);

        void GetWorkLineItemsForProject(int projectId);

        
    }
}
