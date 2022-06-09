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