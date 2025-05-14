// Задача 4
Console.WriteLine("Введите  целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int cnt = 1;
if (number>0)
{
    while (cnt <= number)
{
     if (cnt % 2 == 0)
     {
         Console.Write(cnt);
         Console.Write(",");
     }
  cnt++;   
}
    
}
else
{
    Console.WriteLine("Ошибка ввода!!!");
}
