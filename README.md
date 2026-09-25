# Лабораторная работа №4
Дудаков Иван\
ИСП-241\
20.09.2026

---

## Описание проекта
В проекте были показаны преобретенные навыки, такие как создание папок и файлов через терминал, редактирование HTML, Markdown-файлов, создание консольного приложения на C#,
работа с Git-инструментарием.

---

## Содержание
[Лабораторная работа №4](#лабораторная-работа-4)\
[Описание проекта](#описание-проекта)\
[Структура проекта](#структура-проекта)\
[Примеры Markdown](#примеры-markdown)\
[Примеры LaTeX](#примеры-latex)\
[Ссылка на репозиторий](#ссылка-на-репозиторий)\
[Скриншоты](#скриншоты)\
[Заключение](#заключение)

---
## Структура проекта
* client/
    * index.html
    * about.html
* docs/
    * markdown_examples.md
* repo/
    * browser_Dudakov.png
    * backend_Dudakov.png
    * terminal_Dudakov.png
    * git_Dudakov.png
* server/
    * Program.cs
    * server.csproj
    * .gitignore
* terminal_practice/
    * data/
        * text.txt
    * logs/
        * app.log
* README.md

---

## Примеры Markdown
### Загловок

1. Пункт 1
2. Пункт 2
3. Пункт 3

![Browser Screenshot](/repo/browser_Dudakov.png)

```csharp

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

```

---

## Примеры LaTeX
inline $a^2 + b^2 = c^2$
block
$$
\sum_{i=1} i = \frac{n(n+1)}{2}
$$

---

## Ссылка на репозиторий
[Lab4_ISPRO_Dudakov](https://github.com/mirror344/Lab4_ISRPO_Dudakov)

---

## Скриншоты
![Browser](/repo/browser_Dudakov.png)
![Backend](/repo/backend_Dudakov.png)
![Terminal](/repo/terminal_Dudakov.png)
![Git](/repo/git_Dudakov.png)

---

## Заключение
В ходе лабораторный работы были закрепленны навыки использования Git, синтаксис Markdown, работа с терминалом, создание консольного приложения на C# и оформления README.md.