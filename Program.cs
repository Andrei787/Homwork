/*int num1, num2;
Console.Write("Введите для сравнения свое первое число: ");
num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для сравнения свое второе число: ");
num2=Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.Write (num1 +" Больше числа " +num2);
}
if (num2>num1)
{
    Console.Write (num2 +" Больше числа " +num1);
}
 if (num1==num2)
{
     Console.Write ("Вам точно нужна моя помощь?");
}*/

/*int num1, num2, num3;
Console.Write("Введите для сравнения свое первое число: ");
num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для сравнения свое второе число: ");
num2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для сравнения свое третье число: ");
num3=Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > num1) max=num2;
if (num3 > num2) max=num3;
Console.WriteLine ("Максимальное число=" +max);
*/

/*int num, a;
Console.Write("Введите для сравнения число: ");
num=Convert.ToInt32(Console.ReadLine());
a=num/2;
if (a+a==num)
{
    Console.WriteLine(num+" "+"является четным числом");
}
if (a+a<num)
{
    Console.WriteLine(num+" "+"Не является четным числом");
}*/

int n, carrent;
Console.Write("Введите число для разбивки на четные числа: ");
n=Convert.ToInt32(Console.ReadLine());
carrent = 2;

while (carrent<=n)
{
    Console.Write(carrent+" ");
    carrent = carrent + 2;
}