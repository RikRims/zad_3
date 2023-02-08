// подробнее в readme хз как это коротко написать
string VPadezch (int a)
{
    string str = "";
    string b = "компьют";
    int ostatok = a % 10;

    switch (ostatok)

    {
        case 1:
            str = $"{a} {b}ер";
            break;
        case 2 or 3 or 4:
            str = $"{a} {b}ера";
            break;
        default:
            str = $"{a} {b}еров";
            break;
    }
    return (str);
}

//вымогаем число у пользователя с проверкой 
Console.WriteLine("Дай число: ");
int chislo;
while (!int.TryParse(Console.ReadLine(), out chislo))
{
    Console.WriteLine("Ошибка ввода. Дай число: ");
}

//вызов функции
Console.WriteLine(VPadezch(chislo));    