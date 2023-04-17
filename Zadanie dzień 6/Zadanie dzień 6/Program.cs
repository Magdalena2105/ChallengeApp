using Zadanie_dzień_6;

Employee employee1 = new Employee("Adam", "Adamski", 22);
Employee employee2 = new Employee("Bartek", "Baranowski", 33);
Employee employee3 = new Employee("Czarek", "Czarnecki", 44);

employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(1);

employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(7);
employee2.AddScore(9);

employee3.AddScore(4);
employee3.AddScore(1);
employee3.AddScore(7);
employee3.AddScore(9);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą punktów:");
Console.WriteLine(employeeWithMaxResult.Name + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek:" + employeeWithMaxResult.Age);
Console.WriteLine("Punkty:" + maxResult);
