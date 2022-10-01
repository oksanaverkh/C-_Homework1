//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter the 1st number: ");
int Number1 = int.Parse(Console.ReadLine());
Console.Write("Enter the 2nd number: ");
int Number2 = int.Parse(Console.ReadLine());

if (Number1 > Number2)
{
    Console.WriteLine("Max = " + Number1);
}
else
{
    Console.WriteLine("Max = " + Number2);
}