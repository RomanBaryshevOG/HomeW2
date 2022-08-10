// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int num1 = Convert.ToInt32(Console.ReadLine ());
if ( num1 == 1)  Console.Write("Понедельник");
else if ( num1 == 2 ) Console.Write("Вторник");
else if ( num1 == 3 ) Console.Write("Среда");
else if ( num1 == 4 ) Console.Write("Четверг");
else if ( num1 == 5 ) Console.Write("Пятница");
else if ( num1 == 6 ) Console.Write("Выходной - Суббота");
else if ( num1 == 7 ) Console.Write("Выходной - Воскресенье");
else Console.WriteLine("Число не в дипазоне 1 - 7");
 