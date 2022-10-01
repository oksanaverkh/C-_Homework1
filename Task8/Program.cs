// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number: ");
int Number = int.Parse(Console.ReadLine());

if (Number > 0)
{int i = 2;
    while (i <= Number)
    {
        if (i % 2 == 0)
        {
            if ((Number % 2 == 0 && i == Number) || (Number % 2 == 1 && i == Number - 1))
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + ", ");
            }
        }
        i = i + 2;
    }
}
if (Number == 0)
{
    Console.Write("ERROR!");
}
if (Number < 0)
{int i = -2;
    while (i >= Number)
    {
        if (i % 2 == 0)
        {
            if ((Number % 2 == 0 && i == Number) || (Number % 2 == -1 && i == Number + 1))
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + ", ");
            }
        }
        i = i - 2;
    }
}

