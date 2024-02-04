// Напишите задачу каторая принимает на вход
// трёх значное число и удаляет вторую цифру этого числа

int number = 256;
int a = number / 100;
int b = number % 10;
int result = a * 10 + b;

Console.WriteLine($"В числе {number} => {result}");