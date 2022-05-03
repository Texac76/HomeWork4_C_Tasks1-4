// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 Console.Clear();

int GetValue(string text)
{
    Console.Write($"{text} ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}

double SumNum(int a)
{ 
    int sum = 0;
    while (a>0)
    {
        sum = sum+a % 10;
        a = a / 10;
    }
    return sum;
}


int A=GetValue("A= ");

double result= SumNum(A);
Console.WriteLine(result);