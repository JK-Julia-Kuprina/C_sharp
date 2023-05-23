// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да
// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1 % 7 == 0 && num1 % 23 == 0){
//     System.Console.WriteLine("yes");
// }
// else{
//     System.Console.WriteLine("no");
// }

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 * num1 == num2 || num2 * num2 == num1){
    System.Console.WriteLine("yes");
}
else{
    System.Console.WriteLine("no");
}

