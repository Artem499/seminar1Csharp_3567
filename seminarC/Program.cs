﻿// задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

Console.WriteLine("Сравни два числа, какое из них больше.");
Console.WriteLine("Input number1 = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2 = ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 < number2)

{
    Console.WriteLine("Число 2 больше, чем число 1 :");
    Console.WriteLine(number2);
}

else

{
    Console.WriteLine("Число 1 больше, чем число 2 :");
    Console.WriteLine(number1);
}


