// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter the 1st number: ");
int Number1 = int.Parse(Console.ReadLine());
Console.Write("Enter the 2nd number: ");
int Number2 = int.Parse(Console.ReadLine());
Console.Write("Enter the 3rd number: ");
int Number3 = int.Parse(Console.ReadLine());

if (Number1 > Number2)
{
    Console.WriteLine("Max = " + Number1);
}
else
{   if (Number2 > Number3)
    {
        Console.WriteLine("Max = " + Number2);
    }
    else
    {
    Console.WriteLine("Max = " + Number3);
    }}