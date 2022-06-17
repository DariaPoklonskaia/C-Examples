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
            sum = sum + count; // short form sum += num%10 (+= увеличить, -= уменьшить, *= увеличить в несколько раз, /= сократить в несколько раз)
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

// Ex4 принимает число и возвращает количество цифр в этом числе. 