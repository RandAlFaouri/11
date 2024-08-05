using CADelegate;
using System.ComponentModel.Design;

internal class Program
{
     static void Main(string[] args)
    {
        var emps = new Employee[]
        {
            new Employee {Id = 1 , Name = "Issam A",Gender="M",TotalSales=65000m},
            new Employee {Id = 2 , Name = "Reem S",Gender="F",TotalSales=50000m},
            new Employee {Id = 3 , Name = "Suzan B",Gender="F",TotalSales=65000m},
            new Employee {Id = 4 , Name = "Sara A",Gender="F",TotalSales=400000m},
            new Employee {Id = 5 , Name = "Salah C ",Gender="M",TotalSales=42000m},
            new Employee {Id = 6 , Name = "Rateb A",Gender="M",TotalSales=30000m},
            new Employee {Id = 7 , Name = "Abeer C ",Gender="F",TotalSales=16000m},
            new Employee {Id = 8 , Name = "Marwan M",Gender="M",TotalSales=15000m}
        };
        var report = new Report();

        report.ProcessEmployeeWith60000PlusSales(emps);
        report.ProcessEmployeeWithSalesBetween300000And59999(emps);
        report.ProcessEmployeeWithSalesLessThan300000And59999(emps);
        }
    }
