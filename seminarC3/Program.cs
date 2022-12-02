// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет

Console.WriteLine("input number : ");
int intNumber= Convert.ToInt32(Console.ReadLine());

if(intNumber / 2)
{
    Console.WriteLine("the number is divided by two : ");
    Console.WriteLine(intNumber);
}
else
{
    Console.WriteLine("Error! the number is not divided by two")
}
