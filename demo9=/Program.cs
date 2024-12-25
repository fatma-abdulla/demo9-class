
//object class 

using demo9_.models;
//task3
Employee emp =new Employee();
Console.WriteLine("Enter Email address");
emp.EmailAddress = Console.ReadLine();





//demo d1 =new demo();
//Console.WriteLine("Enter your Name");
//d1.SetName(Console.ReadLine());
//Console.WriteLine("Welcome"+d1.GetName());


//class Employee 
//object class
//add new employee
//getEmloyee 

int count = Convert.ToInt32(Console.ReadLine());
Employee emp = new Employee();

for (int i = 1; i <= count; i++)
{
    Console.WriteLine("Enter your Id  ");
    int EmployeeId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your name ");
    string EmployeeName = Console.ReadLine();
    Console.WriteLine("Enter your email  ");
    string EmployeeEmail = Console.ReadLine();
    Console.WriteLine("Enter your age  ");
    int EmployeeAge = Convert.ToInt32(Console.ReadLine());
emp.AddEmployee(EmployeeId ,EmployeeName,EmployeeEmail,EmployeeAge);

}
//add emplpyee


//Getemployee
emp.GetEmployee();

//task3
