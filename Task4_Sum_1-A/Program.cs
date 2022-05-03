// Найти сумму чисел от 1 до А

 Console.Clear();

int GetValue(string text)
{
    Console.Write($"{text} ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}
int A=GetValue("A= ");

double Sum_1_A(int a)
{ 
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum = sum+i;
    }
    return sum;
}




double result= Sum_1_A(A);
Console.WriteLine(result);
