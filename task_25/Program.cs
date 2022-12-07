//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int expfunction(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A:");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B:");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponent = expfunction(numberA, numberB);
  Console.WriteLine($"Число " + numberA + " в степени " + numberB + " равно: "  + exponent);
