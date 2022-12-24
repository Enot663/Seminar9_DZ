// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите два неотрицательных числа M и N.");
int EnterNumber(string message) // Метод ввода данных 
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());    
}
int naturalNumbersM = EnterNumber("Введите число M: ");
int naturalNumbersN = EnterNumber("Введите число N: ");
Console.WriteLine($"m = ({naturalNumbersM}), n = ({naturalNumbersN}) -> A(m,n) = {AckermanFunc(naturalNumbersM, naturalNumbersN)}");

int AckermanFunc(int naturalNumbersM, int naturalNumbersN)
{
    if(naturalNumbersM == 0) return naturalNumbersN + 1;
    if(naturalNumbersM > 0 && naturalNumbersN == 0) return AckermanFunc(naturalNumbersM - 1, 1);
    else return AckermanFunc(naturalNumbersM - 1, AckermanFunc(naturalNumbersM, naturalNumbersN - 1));
}