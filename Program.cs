/*int[,] CreateRandom2dArrey(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)

          newArray[i,j] = new Random(). Next(minValue, maxValue+1);
    return newArray;
} 
*/

void Show2dArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}



/*Console.Write("Input number of rows: "); //Задача 54
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n =  Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: "); 
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max =  Convert.ToInt32(Console.ReadLine());
int [,] Array = CreateRandom2dArrey(m, n, min, max);
int i=0, imin=0,  jmin=0;
Show2dArray (Array); 
while (jmin <= n) MinArray(Array);
for (int v =1; v < n; v++)    
    {i++;
    imin++;
    jmin=0;
    while(jmin <=n) MinArray(Array);
    }
Console.WriteLine();
Show2dArray (Array);

void MinArray(int[,] myArray)  //Метод к задаче 54
{    
    
    for(int j = jmin+1; j < myArray.GetLength(1); j++)
    {
        if (myArray[imin,jmin] <  myArray[i,j])
        {
            int temp = myArray[imin,jmin];
            myArray[imin,jmin] = myArray[i,j];  
            myArray[i,j] = temp;
        } 
        
    }
    jmin++;
    return; 
}  
*/

/*Console.Write("Input number of rows: "); //Задача 56
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n =  Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: "); 
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max =  Convert.ToInt32(Console.ReadLine());
int [,] Array = CreateRandom2dArrey(m, n, min, max);
if (n >= m) Console.WriteLine("Данный массив не является прямоугольным");
else
{
    Show2dArray (Array); 

int summa = 0, summamin = 0, stroka = 0;
for (int i=0; i < Array.GetLength(0); i++)
{      summa = 0;  
    for (int j=0; j < Array.GetLength(1); j++)
    {
        summa = summa+Array[i,j];
        if (i==0) summamin = summa;
        
    }
    if (summamin > summa) 
    {
        summamin = summa;
        stroka = i+1;
    }
}
Console.Write($" Минимальная сумма {summamin} в {stroka} строке");
}
*/
 
//Задача 62
int [,] Array = CreateRandom2dArrey4();

int[,] CreateRandom2dArrey4()
{   
    int n = 1;
    int[,] newArray = new  int[4, 4];
    for(int i = 0; i < 4;i= i+4)
      for (int j = 0; j < 4; j=j+1)
         newArray[i,j] = n++; 
    for(int i = 1;  i < 4; i++)
       for (int j=3; j<4; j++)
        newArray[i,j] = n++;
     for(int i = 3;  i < 4; i++)
       for (int j=2; j>-1; j=j-1)
        newArray[i,j] = n++;     
    for(int i = 2;  i >0; i=i-1)
       for (int j=0; j>-1; j=j-1)
        newArray[i,j] = n++;    
     for(int i = 1;  i < 2; i++)
       for (int j=1; j<3; j++)
        newArray[i,j] = n++;   
    for(int i = 2;  i < 3; i++)
       for (int j=2; j>0; j=j-1)
        newArray[i,j] = n++;
    return newArray;
} 
Show2dArray(Array);



