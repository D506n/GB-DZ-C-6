//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double Promt(string text){//метод который запрашивает у пользователя данные точек и возвращает их в переменную, при этом выводя пользователю сообщение с указанием какие данные от него ожидаются
    Console.WriteLine(text);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}
Console.WriteLine("Введите параметры точек");
double b1 = Promt("b1:");
double k1 = Promt("k1:");
double b2 = Promt("b2:");
double k2 = Promt("k2:");
if (k1 == k2){//проверка на пересечение прямых
  Console.WriteLine("Прямые не пересекаются.");
}
else{//если прямые пересекаются, то начинает решаться уравнение по поиску точки пересечения
  double x = k1 - k2;
  double y = b1 - b2;
  x = x * (-1);
  x = y / x;
  y = k2 * x;
  y = y + b2;
  Console.WriteLine($"Прямые пересекаются в точке {x}, {y}");
}