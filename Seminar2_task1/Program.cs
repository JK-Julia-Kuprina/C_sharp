﻿// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

// int num = new Random().Next(100,999);
// System.Console.WriteLine($"Было сгенерировано случайное число {num}");

// int x1 = num/100;  // 799 / 10 = 7.9    то это целочисленное деление 79 // 10 = 7 
// int x2 = num % 10; // остаток от деления
// System.Console.WriteLine($"{x1}{x2}");

// /
// }

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (num >= 100) 
{ 
    num = num / 10; 
    Console.Write(num % 10);
    count++; 
}


