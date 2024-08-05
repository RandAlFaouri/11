using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADelegate
{
    internal class Report
    {
        public void ProcessEmployeeWith60000PlusSales(Employee[] employees)
        {
            Console.WriteLine("Employees With $60,000+Sales");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var e in employees) {
                if (e.TotalSales >= 60000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");

        }
        public void ProcessEmployeeWithSalesBetween300000And59999(Employee[] employees)
        {
            Console.WriteLine("Employees With sales between $30,0000 And $59,999 Sales");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var e in employees)
            {
                if (e.TotalSales < 60000m && e.TotalSales >= 300000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");

        }
        public void ProcessEmployeeWithSalesLessThan300000And59999(Employee[] employees)
        {
            Console.WriteLine("Employees Less than sales between $30,0000 And $59,999 Sales");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var e in employees)
            {
                if (e.TotalSales < 30000m )
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");

        }
    } }
