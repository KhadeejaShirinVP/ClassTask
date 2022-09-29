using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyTask
{
    class Company
    {
        private int id;
        private string name;
        private string location;
        private int numberOfEmploy;
        private int numberOfManagers;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public int NumberOfEmploy
        {
            get { return numberOfEmploy; }
            set { numberOfEmploy = value; }
        }
        public int NumberOfManagers
        {
            get { return numberOfManagers; }
            set { numberOfManagers = value; }
        }

        public void TotalEmplyees()
        {
            Console.WriteLine("Total number of employees\t" + (numberOfEmploy + numberOfManagers));
        }

    }
}
