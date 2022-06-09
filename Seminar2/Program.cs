/*
int FindMaxPart(int num)
{
    if (num > 9 && num < 100) //&& - logical 'and'
    {
        int dec = num / 10;
        int ed = num % 10; // c = a % b - остаток от деления; 5%2 = 1

        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else 
    {
    return -1;
    }
}

Console.Write("input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a); 
if (result == -1)
{
    Console.WriteLine("your number is not a two-digital");
}
else
{
    Console.WriteLine($"Bigger number of {a} is {result}"); //different way to write variables and text together
}

*/

//Ex Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 123 -> 13
/*
int CutNumber()
{
int number = new Random ().Next (100, 1000);
int result = (number/100)*10 + number%10;
Console.WriteLine(number);
return result;
}

Console.WriteLine(CutNumber());
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления

/*
string IsKratno(int arg1, int arg2)
{
    if(arg1 % arg2 == 0)
         return "True";
    else
        return ("False, residual is " + (arg1%arg2));
}

Console.WriteLine("Input first integer number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsKratno(a, b));
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23


bool IsKratno2(int arg1)
{
   //  if (arg1 % 7 == 0 && arg1 % 23 == 0) return true; // result is in () is a boll type, so it can be returned itself
   //  else return false;
  
    return (arg1 % 7 == 0 && arg1 % 23 == 0);
}

Console.WriteLine("Input integer number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsKratno2(a)); 

