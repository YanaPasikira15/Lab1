using System;

class User
{
    // Поля класу
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime dateOfFillingForm;
    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.dateOfFillingForm = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Логін: {login}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Дата заповнення анкети: {dateOfFillingForm.ToString("dd.MM.yyyy")}");
    }
}

class Program
{
    static void Main()
    {
        // Введення даних про користувача
        Console.WriteLine("Введіть логін:");
        string login = Console.ReadLine();

        Console.WriteLine("Введіть ім'я:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Введіть прізвище:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введіть вік:");
        int age = int.Parse(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);

        // Виведення інформації про користувача
        user.DisplayUserInfo();
    }
}
