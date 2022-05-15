using Newtonsoft.Json;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Id = 1, Name = "murad", Surname = "aslanov", Age = 20 };
            Employee employee1 = new Employee { Id = 2, Name = "murad", Surname = "aslanov", Age = 20 };
            Employee employee2 = new Employee { Id = 3, Name = "murad", Surname = "aslanov", Age = 20 };

            Department department = new Department
            {
                Name = "kafedra",
                employees = new System.Collections.Generic.List<Employee>
                {
                    employee,
                    employee1,
                    employee2
                }
            };

            var empoyess = JsonConvert.SerializeObject(department);
           
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\tu71tfsws\Desktop\9\ConsoleApp1\ConsoleApp1\json1.json"))
            {
                streamWriter.WriteLine(empoyess);
            }

            string result;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\tu71tfsws\Desktop\9\ConsoleApp1\ConsoleApp1\json1.json"))
            {
               result = streamReader.ReadToEnd();
            }
            var empoyes = JsonConvert.DeserializeObject(result);

            Console.WriteLine(empoyes);


        }
    }
}
