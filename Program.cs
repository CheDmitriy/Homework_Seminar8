/*Console.WriteLine($"\nEnter the size of the array m x n:");  // Задача 54
int m = InputNumbers("Input m: ");
int n = InputNumbers("Input n: ");
int range = InputNumbers("Enter a range: from 1 to ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nSorted array: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}


Console.WriteLine($"\nEnter the size of the array m x n and a range of random values:"); // Задача 56
int m = InputNumbers("Input m: ");
int n = InputNumbers("Input n: ");
int range = InputNumbers("Enter a range: from 1 to ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumRows = 0;
int sumRows = SumRowsElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRows = SumRowsElements(array, i);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minSumRows = i;
  }
}

Console.WriteLine($"\n{minSumRows+1} - the row with the smallest amount ({sumRows}) elements ");


int SumRowsElements(int[,] array, int i)
{
  int sumRows = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRows += array[i,j];
  }
  return sumRows;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
*/

int n = 4;                            // Задача 62
int[,] spiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}