// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] A = new int[3];
Console.Write("Введите корд Х точки А: ");
A[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корд Y точки А: ");
A[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корд Z точки А: ");
A[2] = Convert.ToInt32(Console.ReadLine());

int[] B = new int[3];
Console.Write("Введите корд Х точки B: ");
B[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корд Y точки B: ");
B[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корд Z точки B: ");
A[2] = Convert.ToInt32(Console.ReadLine());

int res1 = (int)Math.Pow(A[0] - B[0], 2);
int res2 = (int)Math.Pow(A[1] - B[1], 2);
int res3 = (int)Math.Pow(A[2] - B[2], 2);
double dist = Math.Sqrt(res1 + res2 + res3);
Console.WriteLine(Math.Round(dist, 3));