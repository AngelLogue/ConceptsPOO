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

Console.WriteLine(employee1);
Console.WriteLine(employee2);