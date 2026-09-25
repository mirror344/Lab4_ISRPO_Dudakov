string name = "Иван";
string surname = "Дудаков"; 
string group = "ИСП-241"; 
string data = "25.09.2026";
string time = "21:31";
bool flag = true;


System.Console.WriteLine("Здравствуйте, это консольное приложение созданное в рамках лабораторной работы №4");
while (flag)
{
    System.Console.WriteLine("Меню: \n 1 - Показать ФИО \n 2 - Показать группу \n 3 - Показать дату \n 4 - Выход");
    int choice = int.Parse(Console.ReadLine());
    
    switch (choice) 
    {
        case 1:
            System.Console.WriteLine($"ФИО: {name} {surname}");
            Console.ReadKey();
            break;
        case 2:
            System.Console.WriteLine($"Группа: {group}");
            Console.ReadKey();
            break;
        case 3:
            System.Console.WriteLine($"Дата и время: {data}, {time}");
            Console.ReadKey();
            break;
        case 4:
            System.Console.WriteLine($"Вы вышли из программы");
            flag = false;
            break;
        default:
            System.Console.WriteLine("Такой команды нет");
            Console.ReadKey();
            break;
    }
}