// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine("Сумма натуральных чисел от M до N.");
int EnterNumber(string message) // Метод ввода данных 
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());    
}
int naturalNumbersM = EnterNumber("Введите число M: ");
int naturalNumbersN = EnterNumber("Введите число N: ");

int SumNumbers(int naturalNumbersM, int naturalNumbersN)
{
    if(naturalNumbersN == naturalNumbersM) return naturalNumbersN;
    return naturalNumbersM + SumNumbers(naturalNumbersM + 1, naturalNumbersN);
}
Console.WriteLine($"Сумма натуральных чисел в промежутке от {naturalNumbersM} до {naturalNumbersN} равна {SumNumbers(naturalNumbersM, naturalNumbersN)}");
