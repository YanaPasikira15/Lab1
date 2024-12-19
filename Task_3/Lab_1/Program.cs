using System;

class Employee
{
    // Поля класу
    private string lastName;
    private string firstName;
    private string position;
    private int experience;
    private double salary;
    private double tax;
    // Конструктор класу
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }
    public void CalculateSalary(string position, int experience)
    {
        this.position = position;
        this.experience = experience;

        double baseSalary;

        switch (position.ToLower())
        {
            case "Менеджер":
                baseSalary = 20500;
                break;
            case "Розробник":
                baseSalary = 25000;
                break;
            case "Дизайнер":
                baseSalary = 18000;
                break;
            default:
                baseSalary = 15000;
                break;
        }

        // Додаємо бонуси за стаж (2% за кожен рік стажу)
        salary = baseSalary + (baseSalary * 0.02 * experience);

        // Розрахунок податкового збору (18% податок)
        tax = salary * 0.18;
    }
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {salary} UAH");
        Console.WriteLine($"Податковий збір: {tax} UAH");
    }
}

class Program
{
    static void Main()
    {
        // Введення даних про співробітника
        Console.WriteLine("Введіть прізвище:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введіть ім'я:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Введіть посаду (менеджер, розробник, дизайнер):");
        string position = Console.ReadLine();

        Console.WriteLine("Введіть стаж (в роках):");
        int experience = int.Parse(Console.ReadLine());

        Employee employee = new Employee(lastName, firstName);
        // Розрахунок окладу та податкового збору
        employee.CalculateSalary(position, experience);
        // Виведення інформації про співробітника
        employee.DisplayEmployeeInfo();
    }
}
