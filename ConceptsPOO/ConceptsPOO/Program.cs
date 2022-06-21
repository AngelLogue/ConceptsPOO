using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");


Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Luis",
    LastName = "Hernandez",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 320000000M,
    CommisionPercentaje = 0.03F

};

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Alan",
    LastName = "Gonzales",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F

};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Angela",
    LastName = "Rodriguez",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommisionPercentaje = 0.015F

};

//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                               =================");
Console.WriteLine($"TOTAL                           {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "IPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
