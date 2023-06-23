/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void Print(string text) // Метод для вывода числа на печать.
{
    Console.WriteLine(text);
}

int GetNumber()
{
        int number = Convert.ToInt32(Console.ReadLine()); // Вовращает число, которое пользователь вводит в консоль.
        return number;
}


Print("Insert 5-digit number --> .");

int number = GetNumberNumber(); // Вывели число в консоль.
