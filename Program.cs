/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];

    for(int i=0; i < size; i++) 
     newArray[i] = new Random().Next(minValue, maxValue+1);

    return newArray;
}*/

/*int[] CreateArray (int size)
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

/*int GreaterZero (int [] array)  // Метод к задаче 41
{
    int sum = 0;
    for (int i=0; i < array.Length; i++)
    {
       if (array[i] > 0) sum++; 
    }
    return sum;
}*/

/*Console.Write("Input size of arrey:");  //Задача 41
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine("Количество элементов больше нуля"+ " "+ GreaterZero(array));*/

/*Console.Write("Введите элемент b1"+ " "); // Задача №43
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент b2"+ " ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент k1"+" ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент k2"+" ");
int k2 = Convert.ToInt32(Console.ReadLine());
if (k1==k2 && b1==b2) Console.Write("Прямые паралельны точек сопрекосновения нет");
else
{
double x = 0; 
double y = 0;
double k = k1 - k2;
double b = b2 - b1;
x = b / k;
y = x;
Console.WriteLine($"Точка пересечения прямых ({x};{y})");
}*/