// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет

Console.WriteLine("Проверка числа на четность");
Console.WriteLine("input number : ");
int figure = Convert.ToInt32(Console.ReadLine());

if(figure % 2 == 0)
{
    Console.WriteLine("the number is divided by two : ");
    Console.WriteLine(figure);
}
else
{
    Console.WriteLine("Error! the number is not divided by two");
}

