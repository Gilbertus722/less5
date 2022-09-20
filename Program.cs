Console.WriteLine($"Поехали");

double[] arrayRealNum = new double[100];
  for (int i = 0; i < arrayRealNum.Length; i++ )
  {
    arrayRealNum[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNum[i] + " ");
  }

double maxNum = arrayRealNum[0];
double minNum = arrayRealNum[0];

  for (int i = 1; i < arrayRealNum.Length; i++)
  {
    if (maxNum < arrayRealNum[i])
    {
      maxNum = arrayRealNum[i];
    }
        if (minNum > arrayRealNum[i])
    {
      minNum = arrayRealNum[i];
    }
  }

  double decision = maxNum - minNum;

  Console.WriteLine($"nразница между между максимальным ({maxNum}) и минимальным({minNum}) элементами: {decision}"); 
