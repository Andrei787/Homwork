// Задача №10
/*int CutNuber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Случайное трехзначное число"+" "+num);
    
    int des = num % 100; 
    int result = des / 10;

    return result;

}
int number = CutNuber();
Console.WriteLine("Вторая цифра"+" " + number);
*/

//Задача №13
/*void ThirdNumber (int num)
{
    if (num <=0)
    num = num * -1;
    if (num >= 100) 
    {int  quantity = 0;
    int x = num;
    while (x>0)
    {
    x = x/10;
    quantity++;
    }
    int b = Convert.ToInt32(Math.Pow (10,(quantity-3)));
    int number1 = num /b;
    int  c = number1 % 10;
    Console.WriteLine("Третий знак Вашего числа"+" " + c);
    }
    else
    {
         Console.WriteLine("Третьего знака нет");
    }
}
Console.Write("Введите любое число"+" ");
int num=Convert.ToInt32(Console.ReadLine());
ThirdNumber (num);
*/

// Задача №15
/*void WeekDay (int day)
{
    if(day >=1 && day<=7)
    {   if (day==1) Console.WriteLine("Данный день являетя рабочим");
        if (day==2) Console.WriteLine("Данный день являетя рабочим");
        if (day==3) Console.WriteLine("Данный день являетя рабочим");
        if (day==4) Console.WriteLine("Данный день являетя рабочим");
        if (day==5) Console.WriteLine("Данный день являетя рабочим");
        if (day==6) Console.WriteLine("Данный день являетя выходным");
        if (day==7) Console.WriteLine("Данный день являетя выходным");
    }
    else 
    Console.WriteLine("Ваше число НЕ коректно!!!");
}

Console.Write("Введите день недели"+" ");
int nam=Convert.ToInt32(Console.ReadLine());    

WeekDay(nam);
*/