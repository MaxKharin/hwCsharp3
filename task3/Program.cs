//Задача 3: Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27. 
//5 -> 1, 8, 27, 64, 125
int num = prompt("Enter a number, please: ");
for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i * i * i}");
}

int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}