using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First  compnay details");
            Company company1 = new Company();
            company1.Id = 1;
            company1.Name = "moback";
            company1.Location = "banglure";
            company1.NumberOfEmploy = 210;
            company1.NumberOfManagers = 12;
            company1.TotalEmplyees();

            Console.WriteLine("Company id-\t" + company1.Id);
            Console.WriteLine("Company name-\t" + company1.Name);
            Console.WriteLine("Copmany location-\t" + company1.Location);
            Console.WriteLine("number of employees-\t" + company1.NumberOfEmploy);
            Console.WriteLine("number of managers-\t" + company1.NumberOfManagers);
            

            Console.WriteLine("Second company details");
            Company company2= new Company();
            company2.Id=2;
            company2.Name = "uber";
            company2.Location = "kochi";
            company2.NumberOfEmploy = 500;
            company2.NumberOfManagers = 87;
            company2.TotalEmplyees();

            Console.WriteLine("Company id-\t" + company2.Id);
            Console.WriteLine("Company name-\t" + company2.Name);
            Console.WriteLine("Company location-\t"+ company2.Location);
            Console.WriteLine("Company employees-\t" + company2.NumberOfEmploy);
            Console.WriteLine("Company managers-\t"+ company2.NumberOfManagers);

            Console.ReadKey();
          
        }
    }
}
