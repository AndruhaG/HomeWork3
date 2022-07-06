/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


/*Console.WriteLine();
Console.WriteLine("Введите координаты точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите координаты точки В: ");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());
double Length = 0;
Length = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
Console.WriteLine(Length);
*/



/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*Console.WriteLine();
Console.WriteLine("Введите число ");
int Length = Convert.ToInt32(Console.ReadLine());
int numb = 3;

for (int count=1; count <= Length; count++)
{
    
    Console.WriteLine($"{count}^3 = " + Math.Pow(count, numb)); 
}
*/


/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();


if (number[0]==number[4] || number[1]==number[3])
{
    Console.WriteLine($"Число: {number} - палиндром.");
}
 else if (number.Length > 5)
{
    Console.WriteLine("Введите правильное число");
}
else
Console.WriteLine($"Число: {number} - НЕ палиндром.");


