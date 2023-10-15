// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 

System.Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Convert.ToString(number).Length == 5)
{
    if ((number / 10000 == number % 10) && (number / 1000 % 10 == number % 100 / 10))
    {
        System.Console.WriteLine("True");
    }
    else
    {
        System.Console.WriteLine("False");
    }
}
else
{
    System.Console.WriteLine("Число не пятизначное");
    System.Console.WriteLine("False");
}
