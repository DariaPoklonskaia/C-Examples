// Ex1 на вход дается число. Надо выдать сумму цифр
/*
int FindSumOfDigits (int num)
{
    int sum = 0; 
    while (num > 0)
        {
            sum = sum + num % 10; // short form sum += num%10 (+= увеличить, -= уменьшить, *= увеличить в несколько раз, /= сократить в несколько раз)
            num = num/10; 
        }
        return sum;
}

Console.WriteLine("Input number");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindSumOfDigits(userNum));

*/

// Ex2 принимает на вход число и возращает сумму чисел от 1 до этого числа.
/*
int FindSumOfDigits (int num)
{
    int sum = 0; 
    int count = 1;
    while (count <= Math.Abs(num))
        {
            sum = sum + count; 
            count++; 
        }
    if (num < 0) return sum = sum * -1;
    else return sum;
}

Console.WriteLine("Input number");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindSumOfDigits(userNum));
*/
// Ex3 принимает на вход число и возращает произведение чисел от 1 до этого числа.
/*
int Find(int num)
{
    int prod = 1; 
    int count = 1;
    while (count <= Math.Abs(num))
        {
            prod = prod*count; 
            count++; 
        }
    if (num < 0 && num%2 ==1) return prod = prod * -1;
    else return prod;
}

Console.WriteLine("Input number");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Find(userNum));
*/
// Ex4 принимает число и возвращает количество цифр в этом числе. 

int FindNofDigits (int num)
{
    int count = 0; 
    num = Math.Abs(num);
    while (num > 0)
        {
            num = num/10; 
            count++;
        }
        return count;
}

Console.WriteLine("Input number");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNofDigits(userNum));