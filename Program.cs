
// // Задача вывести вторую цифру

// Console.WriteLine("Введите 1 число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// if (n1 > 99) Console.WriteLine(((n1 % 100)-(n1 % 10))/10);

// Console.WriteLine("Введите 2 число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n2 > 99) Console.WriteLine(((n2 % 100)-(n2 % 10))/10);

// Console.WriteLine("Введите число: ");
// int n3 = Convert.ToInt32(Console.ReadLine());

// if (n3 > 99) Console.WriteLine(((n3 % 100)-(n3 % 10))/10);


//Найти 3ю цифру, если нет, вывести цифры нет
int number = new Random().Next(1,10000000);
Console.WriteLine(number);
string str = number.ToString();
if (str.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int a = (int)Char.GetNumericValue(str[2]);
    Console.WriteLine($"{a}");
}




// задача цифра = дате недели и проверяет является она выходном
// Console.WriteLine("Введите день ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n == 6 || n == 7)
// {
//     Console.WriteLine($"Да, {n} является выходным");
// }
// else
// {
//     Console.WriteLine($"Нет, {n} не выходной");
// }