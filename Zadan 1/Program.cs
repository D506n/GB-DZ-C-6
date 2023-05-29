//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
uint step = 0;
string temp = "";
int IntTemp = 0;
int[] array = new int[1];
Console.WriteLine("Введите числа, после ввода каждого числа нажмите Enter. После ввода всех необходимых чисел, нажмите Enter оставив поле ввода пустым: "); 
while (temp != ""){//меняю размер массива и записываю в него числа до тех пор, пока пользователь вводит числа с клавиатуры
  temp = Console.ReadLine();
  if (temp != ""){
    IntTemp = Int32.Parse($"{temp}");
    array[step] = IntTemp;
    step++;
    Array.Resize(ref array, array.Length + 1);
  }
}
IntTemp = 0;
int PositNum = 0;
while (IntTemp < step){ //выясняю сколько из введённых чисел больше 0
  if (array[IntTemp] > 0){
    PositNum++;
  }
  IntTemp++;
}
Console.WriteLine($"Количество чисел больше 0: {PositNum}");