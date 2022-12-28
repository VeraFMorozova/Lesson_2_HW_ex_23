// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int userN = getUserValue("Введите число N");

void Stepen3(int userN)
{
    for (int i = 1; i < userN + 1; i = i+1)
    {
        int temp = i * i * i;
        if (i < userN)
        {
            Console.Write($" {temp},");
        }
        else 
        {
            Console.Write($" {temp}");
        }
    }
}
Stepen3(userN);
