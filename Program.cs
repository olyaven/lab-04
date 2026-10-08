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