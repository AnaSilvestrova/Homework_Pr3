/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Расстояние между точками — это число, равное корню из суммы квадратов разностей координат точек или длине разности радиус-векторов точек.

Формула: d=sqrt(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)
*/

void Print(string text) // Метод для вывода на печать.
{
    Console.WriteLine(text);
}

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine()); // Вовращает число.
    return number;
}

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
        double result = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
        return result;
}

Print("Insert one by one 3 coordinates for point A --> "); 
int x1 = GetIntNumber(); 
int y1 = GetIntNumber(); 
int z1 = GetIntNumber();

Print("Insert one by one 3 coordinates for point A --> ");
int x2 = GetIntNumber();
int y2 = GetIntNumber(); 
int z2 = GetIntNumber();

Print($"Coordinates for point A are --> {x1}, {y1}, {z1}.");
Print($"Coordinates for point B are --> {x2}, {y2}, {z2}.");

double result = FindDistance(x1, y1, z1, x2, y2, z2);
Print($"Distance between points A and B in 3D space is {result}.");