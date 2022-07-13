/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];

    for(int i=0; i < size; i++) 
     newArray[i] = new Random().Next(minValue, maxValue+1);

    return newArray;
}*/

/* int[] CreateArray (int size)
{
    int[] newArray = new int [size];
    Console.WriteLine("Creating array here:");
    for(int i=0; i < size; i++) 
    {
      Console.Write($"Input {i+1} element:");
      newArray[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    return newArray;

} */

/*void ShowArray (int[] array)
{
  for(int i=0; i < array.Length; i++)
  Console.Write(array[i] + " ");

  Console.WriteLine();
}*/


/*int EvenNumbers(int[] array) // Метод к задаче №34
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
      if (array[i] % 2==0) count ++;
    return count; 
}  */

/*int OddNumbers(int[] array)   //Метод к задаче №36
{     
    int sum = 0;
    for( int i = 1; i < array.Length; i=i+2)
    sum = sum + array[i];
    return sum;
} /*

/*Console.Write("Input size of arrey:");  //Задача №34
int size = Convert.ToInt32(Console.ReadLine());
int min = 100; 
int max = 999; 
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Количество четных чисел в массиве" + " " + EvenNumbers(array));*/


/*Console.Write("Input size of arrey:");    //Задача №36
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements:");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Сумма элементов стоящие на нечетных позициях" + " " + OddNumbers(array));*/

/* Console.Write("Input size of arrey:");   // Задача №38
int size = Convert.ToInt32(Console.ReadLine());
double[] DoubleArrey = new double[size];
Random random = new Random();
for (int i = 0; i < DoubleArrey.Length; i++)
{
    
        DoubleArrey[i] = random.NextDouble(); 
    Console.WriteLine(DoubleArrey[i]);
}
double max = 0;
double min = 0; 
if (DoubleArrey[0] > DoubleArrey[1])
{
  max = DoubleArrey[0]; 
  min = DoubleArrey[1];
}
if (DoubleArrey[0] < DoubleArrey[1])
{
  min = DoubleArrey[0];
  max = DoubleArrey[1];
}
for( int i = 2; i < DoubleArrey.Length; i++)
{
if (DoubleArrey[i] > max) DoubleArrey[i] = max;
if (DoubleArrey[i] < min) DoubleArrey[i] = min;
}
double s =  max -  min;

Console.WriteLine("Разница между максимальным и минимальным значением" +  " "+ s);*/