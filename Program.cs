// Задача №27
/*int SummaNumbers (int a)
  { 
    if (a < 0) a = a * -1;
    int result = 0;
    int number1 = 0;
    while (a>0)
    {
        number1= a % 10;
        result = number1 + result;
        a = a / 10;
    }
    return result;
  }
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {SummaNumbers(num)}");*/

// Задача №29
/*void ArrayNumbers (int a)
{
    for(int carent = 1; carent<=a; carent++)
    Console.Write(new Random().Next(0,1000)+" ");
}
Console.WriteLine("Введите положительное число которое задаст Ваш массив");
int num = Convert.ToInt32(Console.ReadLine());
if (num <=0 )
  Console.WriteLine ($"{num} это число не является положительным");
else  
ArrayNumbers(num);*/

