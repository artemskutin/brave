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

// int number = 932654;
// if (number >= 100)
// {
//     int a = (number / 100) % 10;
//     Console.WriteLine($"Третья цифра с конца {a} ");
// }
// else
// {
//     Console.WriteLine("третий цифры нет");
// }


//  Запишите програму которая будет принимать на вход два числа 
//  и выводить является ли второе число кратным первому
//  если нет то выводит остаток от деления 

// int a = 6;
// int b = 3;

// if (a % b == 0)
// {
//     Console.WriteLine($"{a} кратно (делится без остатка)");
// }
// else
// {
//     Console.WriteLine($"остаток от {a} / {b} = {a % b}");
// }

// //  Проверка на четность 
// int number = 6;
//         if ((number % 2) == 0)
//         {
//             Console.WriteLine($"четное");
//         }
//         else
//         {
//             Console.WriteLine($"нечетное");
//         }


// int number = 6;
// int a = 1;
// while (a <= number)
// {
// if (a % 2 == 0)
// {
//     Console.Write(a + " ");
// }
//     a++;
// }



double CalculateFormula (int b, int c, int d, int g)
{
    double  numenator = b * c;
    int  deminator = d + g;
    double result = numenator / deminator;
    return  result;
}
double result = CalculateFormula (1, 2, 3, 4);

Console.WriteLine(result);