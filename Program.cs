// Задача №19
/*void Palindrome ( int number)
{   
    int number1 = number / 10000;
    int number4  = number % 10;
    int number2 = (number / 1000) % 10;
    int number3 = number % 100 / 10;
    
    if (number1==number4 && number2==number3)
    Console.WriteLine (number +  " " + "Данное число является палиндромом");
    else
    Console.WriteLine (number + " " +  "Данное число не является пландромом");
    
}
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999) 
    Console.WriteLine (number +  " " + "Данное число не является пятизначным");
else
Palindrome (number);*/

// Задача №23
/*void  TableСubes ( int number)
{   
    int counter = 1; 
    while (counter <= number)
    {
        int cubes = Convert.ToInt32(Math.Pow (counter,3));
        Console.Write(cubes + " ");
        counter++;
    }
    
}
Console.Write("Введите Ваше положительное число"+ " ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <=0)
    Console.WriteLine (number +  " " + "Данное число не является положительным");
else    
TableСubes (number);*/
