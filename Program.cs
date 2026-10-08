int ageStep1 = 20;

if (ageStep1 >= 21)
{
    Console.WriteLine("Доступ разрешён");
}

Console.WriteLine("Программа продолжает работу");

//---

int ageStep2 = 15;

if (ageStep2 >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия осталось {18 - ageStep2} лет");
}

//---

int ageStep3 = 14;

if (ageStep3 < 13)
{
    Console.WriteLine("Ребёнок");
}
else if (ageStep3 < 18)
{
    Console.WriteLine("Подросток");
}
else if (ageStep3 >= 60)
{
    Console.WriteLine("Пенсионер");
}
else
{
    Console.WriteLine("Взрослый");
}

//---

int ageStep4 = 16;
double heightStep4 = 1.55;
bool hasAdult = false;

if ((ageStep4 >= 14 && heightStep4 >= 1.5) || hasAdult)
{
    Console.WriteLine("Можно кататься");
}
else
{
    Console.WriteLine("Пока нельзя");
}

// Задача А. Чётное или нечётное

Console.WriteLine();

Console.WriteLine("Задача А. Чётное или нечётное");

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}


// Задача Б. Оценка

Console.WriteLine();

Console.WriteLine("Задача Б. Оценка");

Console.Write("Введите оценку: ");
int gradeB = int.Parse(Console.ReadLine());

if (gradeB == 5)
{
    Console.WriteLine("Отлично");
}
else if (gradeB == 4)
{
    Console.WriteLine("Хорошо");
}
else if (gradeB == 3)
{
    Console.WriteLine("Удовлетворительно");
}
else if (gradeB == 2)
{
    Console.WriteLine("Неудовлетворительно");
}
else
{
    Console.WriteLine("Неверная оценка");
}


// Задача В. Наибольшее из трёх чисел

Console.WriteLine();

Console.WriteLine("Задача В. Наибольшее число");

Console.Write("Введите первое число: ");
double numberB1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double numberB2 = double.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
double numberB3 = double.Parse(Console.ReadLine());

if (numberB1 >= numberB2 && numberB1 >= numberB3)
{
    Console.WriteLine($"Наибольшее число: {numberB1}");
}
else if (numberB2 >= numberB1 && numberB2 >= numberB3)
{
    Console.WriteLine($"Наибольшее число: {numberB2}");
}
else
{
    Console.WriteLine($"Наибольшее число: {numberB3}");
}


// Задача Г. Високосный год

Console.WriteLine();

Console.WriteLine("Задача Г. Високосный год");

Console.Write("Введите год: ");
int yearG = int.Parse(Console.ReadLine());

if ((yearG % 4 == 0 && yearG % 100 != 0) || yearG % 400 == 0)
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}


// Индивидуальный вариант 2. Проверка возраста для доступа

Console.WriteLine();

Console.WriteLine("Вариант 2. Проверка возраста");

Console.Write("Введите возраст: ");
int ageVariant2 = int.Parse(Console.ReadLine());

if (ageVariant2 >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}


// Индивидуальный вариант 7. Существование и тип треугольника

Console.WriteLine();

Console.WriteLine("Вариант 7. Тип треугольника");

Console.Write("Введите первую сторону: ");
double side1 = double.Parse(Console.ReadLine());

Console.Write("Введите вторую сторону: ");
double side2 = double.Parse(Console.ReadLine());

Console.Write("Введите третью сторону: ");
double side3 = double.Parse(Console.ReadLine());

if (side1 + side2 > side3 &&
    side1 + side3 > side2 &&
    side2 + side3 > side1)
{
    if (side1 == side2 && side2 == side3)
    {
        Console.WriteLine("Равносторонний треугольник");
    }
    else if (side1 == side2 || side1 == side3 || side2 == side3)
    {
        Console.WriteLine("Равнобедренный треугольник");
    }
    else
    {
        Console.WriteLine("Разносторонний треугольник");
    }
}
else
{
    Console.WriteLine("Треугольник не существует");
}