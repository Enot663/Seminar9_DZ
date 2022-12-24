// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
Console.Clear();
Console.WriteLine("Показать натуральные числа от N до 1.");
int EnterNumber(string message) // Метод ввода данных 
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());    
}
int endingNum = 1;
int initialVal = EnterNumber("Введите число N: "); 
FinalResult(initialVal, endingNum);
void FinalResult(int initialVal, int endingNum)
{
    if(initialVal >= endingNum)
    {
        Console.Write(initialVal + "; ");
        initialVal--;
        FinalResult(initialVal, endingNum);
    }
}


