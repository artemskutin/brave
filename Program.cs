// Напишите задачу каторая принимает на вход
// трёх значное число и удаляет вторую цифру этого числа

// int number = 256;
// int a = number / 100;
// int b = number % 10;
// int result = a * 10 + b;

// Console.WriteLine($"В числе {number} => {result}");


// Напишите програму которая выводит на вход трёх значное число 
// и возводит вторую цифру в степень равную третий цифре

// int number = 925;
// int a = number / 10 % 10;
// int b = number % 10;
// int result = (int)Math.Pow(a, b);

// Console.WriteLine($"{a} ^ {b} = {result}");

//  Напишите програму которая выводит третью
// цифру с конца, или сообщает что 3 цифры нет
// 456
// 1234
// 12 третий цифры нет

int number = 932654;
if (number >= 100)
{
    int a = (number / 100) % 10;
    Console.WriteLine($"Третья цифра с конца {a} ");
}
else
{
    Console.WriteLine("третий цифры нет");
}