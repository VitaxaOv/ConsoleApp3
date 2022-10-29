// See https://aka.ms/new-console-template for more information

using ConsoleApp3;


/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
a = 1 b = 1 -> числа равны./*


Console.Clear();
bool isParsed = false;
while (!isParsed)
{
    double number2 = Convert.ToDouble(Console.ReadLine());
    isParsed = double.TryParse(Console.ReadLine(), out double number);

    Console.WriteLine(isParsed);
    Console.WriteLine(number);
    Console.WriteLine("Я работаю");
   
    Console.WriteLine("Я работаю");
}
//double number = 2;
/*Console.WriteLine(number);
TryNumber(out number);
Console.WriteLine(number);

Number(number);
Console.WriteLine(number);



void TryNumber(out double number)
{
    number = 5;
}

void Number(double number)
{
    number = 532131;
}*/






/*int[] array1 = new[] { 1 };
int[] array2 = new[] { 1 , 3 };


int number = Convert.ToInt32(Console.ReadLine());

if (CheckPalindrome(number))
{
    Console.WriteLine("Da");
}
else
{
    Console.WriteLine("нет");
}


bool CheckPalindrome(int number)
{
    int[] array = UsefulMethods.ToArray(number);

    int[] reverseArray = UsefulMethods.GetReverseArray(array);

    return UsefulMethods.CompareArrays(array, reverseArray);
}


/*int i = 5;

int b = i;
b++;*/
/*
Console.WriteLine($"i = {i}");
Console.WriteLine($"b = {b}");*/

decimal f = Convert.ToDecimal("123213");
short iMax = Int16.MaxValue;
short iMin = Int16.MinValue;

int i = Int32.MaxValue;

long k = Int64.MaxValue;

Decimal a = Decimal.MaxValue;

/*string c = "123";

string g = "312";

g = c;

g += "1";

while (true)
{
    g += "1";
}

Console.WriteLine(c);
Console.WriteLine(g);
*/
/*
Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

CompareArrays(input);

int GetLengthNumber(int number)
{
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}


void CompareArrays(int number)
{
    int length1 = GetLengthNumber(number);
    int number2 = number;
    
    int[] array1 = new int[length1];
    int[] array2 = new int[length2];
    int count = length1;

    for(int i = 0; i < length1; i++)
    {
        array1[i] = number1 % 10;
        number1 /= 10;
    }
    for (int i = 0; i < length1; i++)
    {
        Console.Write(array1[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
    for(int i = length2 - 1; i >= 0; i--)
    {
        array2[i] = number2 % 10;
        number2 /= 10;
    }
    for (int i = 0; i < length2; i++)
    {
        Console.Write(array2[i]);
        Console.Write(" ");
    }
    int y = 0;
    for(int i = 0; i < count; i++)
    {
        if(array1[i] == array2[i])
        {
            y++;
            continue;
        }
        else
        {
            Console.WriteLine("");
            Console.Write("Число не является полиндромом");
            break;
        }
    }
    if (array1.Length == y)
    {
        Console.WriteLine("");
        Console.WriteLine("Число является полиндромом");
    }
}*/








