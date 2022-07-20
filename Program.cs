int[,] CreateRandom2dArrey(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)

          newArray[i,j] = new Random(). Next(minValue, maxValue+1);
    return newArray;
} 

void Show2dArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

/*void DoubleShow2dArray (double [,] array) //Массив к задаче №47
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}
*/


/*double[,] Double2dArrey(int rows, int columns) //Массив к задаче №47
{
    double[,] newArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)

    for (int j = 0; j < columns; j++)
    {
    newArray[i,j] = new Random(). NextDouble();
    }
    return newArray;
} 
*/
/*void Array (int [,] AverageColumn) //Массив к задаче №52
{
        for (int i = 0; i < AverageColumn.GetLength(0); i++)
        {   
        for (int j = 0; j < AverageColumn.GetLength(1); j++)
        if (j==v) 
        x = x + AverageColumn[i,j];
        }
        x = x/n;
        Console.WriteLine($"Средняя {v+1} столбца {x}");
        x=0;  
        v++;
}
*/

/*
Console.Write("Input number of rows: "); //Задача №47
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n =  Convert.ToInt32(Console.ReadLine());
double [,] myArray = Double2dArrey (m, n);
DoubleShow2dArray(myArray);*/

/*Console.Write("Input number of rows: "); //Задача 50
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n =  Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: "); 
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max =  Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите строку числа в массиве? ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите столбец числа в массиве? ");
int j = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateRandom2dArrey(m, n, min, max);
Show2dArray(myArray); 
if (i > m || j > n) Console.Write($"Данного адреса в массиве нет {i},{j} ");
else
Console.Write($"Данное число {myArray[i-1,j-1]} ");*/

/* Console.Write("Input number of rows: "); //Задача 52
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n =  Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: "); 
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max =  Convert.ToInt32(Console.ReadLine());
int [,] AverageColumn = CreateRandom2dArrey(m, n, min, max);
Show2dArray(AverageColumn); 
double x = 0;
int v=0;
Array(AverageColumn);
while (v < n)
{
  Array(AverageColumn);

} */
