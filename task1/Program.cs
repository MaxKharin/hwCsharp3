// Задача 1: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
Console.WriteLine("Enter a 5 digit number: ");
string Pal = Console.ReadLine();
int length = Pal.Length;
bool isPal = true;
for (int i = 0; i <= length / 2; i++)
{
    if (Pal[i] != Pal[length - 1 - i])
    {
        Console.WriteLine($"{Pal} is not a palindrome");
        isPal = false;
        break;
    }
}
if (isPal == true)
{
    Console.WriteLine($"{Pal} is a palondrome");
}