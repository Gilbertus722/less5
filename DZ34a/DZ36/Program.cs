//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Write($"Количество элементов: ");
int numElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numElements, int min, int max)
  {
  int[] randomNumbers = new int[numElements];
  int sumElements = 0;
  Console.Write("Массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numElements, 1, 10);

Console.WriteLine($"Сумма эллементов стоящих на четных позициях: {randomNumbers}");