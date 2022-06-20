// Задача 2: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
int x1 = prompt("Enter x1, please: ");
int y1 = prompt("Enter y1, please: ");
int z1 = prompt("Enter z1, please: ");
int x2 = prompt("Enter x2, please: ");
int y2 = prompt("Enter y2, please: ");
int z2 = prompt("Enter z2, please: ");
Console.WriteLine($"The distance between dots is {distance(x1,y1,z1,x2,y2,z2)}");

int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

double sqr(double num)
{
    return num * num;
}

double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double s = sqr(x2 - x1) + sqr(y2 - y1) + sqr(z2 - z1);
    double result = Math.Sqrt(s);
    return result;
}