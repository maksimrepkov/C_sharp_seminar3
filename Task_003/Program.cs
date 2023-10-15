// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

System.Console.WriteLine("Введите число: "); 
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for(int i = 1; i <= number; i++) 
System.Console.Write($"{Math.Pow(i, 3)} ");