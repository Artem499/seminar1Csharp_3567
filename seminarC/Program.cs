// задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

Console.WriteLine("Input number1 = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2 = ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 < number2)
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine(number1);
}

