/* Финальная контрольная работа
Задание
Написать программу, которая из имеющегося массива строк формирует массив строк, 
длинна которых меньше либо равна 3 символам.
*/


Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 0;
string[] array = new string[n];
string[] arrayX = new string[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите значение массива: ");
    var m = Console.ReadLine();
    array[i] = m;
    if (array[i].Length <= 3)
    {
        arrayX[x] = m;
        x++;
    }
}
arrayX = arrayX.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("[" + string.Join(", ", arrayX) + "]");