using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo9_.models
{
    public class Employee
    {
        //task3 
        private string emilAddress;
        //prop
        public string EmailAddress {
            get { return emilAddress; }
            set {
                if (value.Contains("0"))
                {
                    emilAddress = value;
                }
                else {
                    Console.WriteLine("Invalid Email Address");
                } } }

        public void GetEmailAddress()
        {
            Console.WriteLine("My Email is " + emilAddress);

        }


        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }

        List<Employee> employeeslist = new List<Employee>();
        //add Employee 
        public void AddEmployee(int id, string name, string email, int age)
        {
            employeeslist.Add(new Employee { Id=id , Name = name, Email = email, Age = age });

        }

        //GetEmployee
        public void GetEmployee()
        {

            foreach (var emp in employeeslist) {
                Console.WriteLine("Id "+emp.Id+ "\nName "+emp.Name + "\nEmail " + emp.Email + "Age " + emp.Age);
        }
        } }
}


