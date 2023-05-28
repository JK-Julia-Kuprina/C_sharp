// Вид 1
//
// Method1();










// Вид 2
//
//Method2("Текст  сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "Новый текст");








// Вид 3
// int Method3()
// {
//     return DataTime.Now.Year;
// }
// int yaer = Method3();
//System.Console.WriteLine(year);












// Вид 4
// string Method4(int count, string text);
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string Method4(int count, string text)
// {

//     string result = String.Empty;
//     for (int i = 0; i < count; i++)

//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// System.Console.WriteLine(res);


// цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}");
    }
    System.Console.WriteLine();
}
