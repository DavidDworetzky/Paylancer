using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Paylancer.Tests
{
    [TestClass]
    public class ProjectTests
    {
        private Paylancer.Models.Project dailyProjectFixture;
        private Paylancer.Models.Project weeklyProjectFixture;
        private Paylancer.Models.Project biweeklyProjectFixture;
        private Paylancer.Models.Project monthlyProjectFixture;

        private DateTime FirstOfYearFixture
        {
            get
            {
                return new DateTime(2020, 1, 1);
            }
        }

        private ProjectTests()
        {
            dailyProjectFixture = new Models.Project() { Id = 0, InvoiceScheduleType = (int)Models.InvoiceScheduleType.Daily, Name = "Daily Billing Project" };
            weeklyProjectFixture = new Models.Project() { Id = 1, InvoiceScheduleType = (int)Models.InvoiceScheduleType.Weekly, Name = "Weekly Billing Project" };
            biweeklyProjectFixture = new Models.Project() { Id = 2, InvoiceScheduleType = (int)Models.InvoiceScheduleType.Weekly, Name = "BiWeekly Billing Project" };
            monthlyProjectFixture = new Models.Project() { Id = 3, InvoiceScheduleType = (int)Models.InvoiceScheduleType.Weekly, Name = "Monthly Billing Project" };
        }

        private void GetNextInvoiceDateAndTestIterate(DateTime initial, int iterations, Models.Project project, Func<DateTime, bool> condition)
        {
            var date = initial;
            for(int i = 0; i < iterations; i++)
            {
                date = project.GetNextInvoiceDate(date);
                Assert.IsTrue(condition(date));
            }
        }

        [TestMethod]
        public void WeeklyProjectBillsFourTimesInJanuary()
        {
            GetNextInvoiceDateAndTestIterate(FirstOfYearFixture, 4, weeklyProjectFixture, (date) => { return date.Month == 1; });
        }

        [TestMethod]
        public void DailyProjectBills31TimesInJanuary()
        {
            GetNextInvoiceDateAndTestIterate(FirstOfYearFixture, 31, dailyProjectFixture, (date) => { return date.Month == 1; });
        }

        [TestMethod]
        public void MonthlyProjectBillsOnceInJanuary()
        {
            GetNextInvoiceDateAndTestIterate(FirstOfYearFixture, 1, monthlyProjectFixture, (date) => { return date.Month == 1; });
        }

        [TestMethod]
        public void BiWeeklyProjectBillsTwiceInJanuary()
        {
            GetNextInvoiceDateAndTestIterate(FirstOfYearFixture, 2, biweeklyProjectFixture, (date) => { return date.Month == 1; });
        }
    }
}
