using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Employee {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int ID, string name, decimal salary) {
            EmployeeID = ID;
            Name = name;
            Salary = salary;
}
    }

    class Program1
    {
        static void Main() {
            List<Employee> employee = new List<Employee> {
                new Employee(1,"steve",1000),
                new Employee(2,"smith",2000),
                new Employee(3,"sai",3000),
                new Employee(4,"dhoni",4000),
                new Employee(5,"virat", 5000)
                };

         Employee high = employee.OrderByDescending(e => e.Salary).First();
            Console.WriteLine("highest salary employee ");
            Console.WriteLine($"Name: {high.Name}, Salary: {high.Salary}");

        Dictionary<int,string> dic = new Dictionary<int,string>();
            foreach (var e in employee) {
                dic[e.EmployeeID] = e.Name;
            }

            foreach (var f in dic) {
                Console.WriteLine($"EmployeeID: {f.Key}, EmployeeName: {f.Value}");
            }

            if (dic.ContainsKey(3))
            {
                Console.WriteLine($"found, Name: {dic[3]}");
            }
            else {
                Console.WriteLine("not found");
            }
        }
    }
}