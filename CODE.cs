
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01 {
  internal class Program {
    static void Main(string[] args) {
      int a, n1, inputResult;
      int degreeResult = 1;
      string x;

      Console.WriteLine("Какое задание вы хотите выполнить? (введите только цифру)");
      Console.WriteLine("1. Возведение числа a в степень n");
      Console.WriteLine("2. Изменить число x");

      inputResult = Convert.ToInt32(Console.ReadLine());

      if (inputResult == 1) {
        Console.WriteLine("Введите число a = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число n = ");
        n1 = Convert.ToInt32(Console.ReadLine());

        for (int indexDegree = 0; indexDegree < n1; ++indexDegree)
        {
          degreeResult *= a;
        }
        Console.WriteLine("Результат возведения в степень: ");
        Console.WriteLine(degreeResult);
      } else if (inputResult == 2) {
        Console.WriteLine("Введите число x = ");
        x = Console.ReadLine();

        x += x[1];

        Console.WriteLine(x.Remove(1, 1));
      } else {
        Console.WriteLine("Вы выбрали неверное задание");
      }
    }
  }
}
