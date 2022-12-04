// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// задал максимальное целое число, с которым будут сравниваться другие числа

Console.WriteLine("Сравнение, какое из треёх чисел больше");

int numberMax = 1;

// пользователь вводит числа, которые будут сравниваться

Console.WriteLine("Input number 1 : ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2 : ");
int numberb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3 : ");
int numberc = Convert.ToInt32(Console.ReadLine());

if(numbera > numberMax) numberMax = numbera;
if(numberb > numberMax) numberMax = numberb;
if(numberc > numberMax) numberMax = numberc;

Console.WriteLine("Max number : ");
Console.WriteLine(numberMax);
