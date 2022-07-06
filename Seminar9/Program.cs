// ввывести все натуральные числа от единицы до n
/*
void ShowNums(int n)
{
    if(n != 1)
    {
        Console.Write(n + " "); // так выведет числа от 5 до 2
        ShowNums(n-1);
    }   

    Console.Write(n + " "); // выдаст числа от 1 до 5 при схлопывании всех методов.
    
}

Console.WriteLine("Input number");
int userN = Convert.ToInt32(Console.ReadLine());

ShowNums(userN);

//любая память в битах и байтах. переменная инт32 - 32 бита = 4 байта, это значит есть 32 позиции для 0 и 1. Под одну переменную.
// то есть выделяется 32 символа, и вес не меняется в зависимости от того записано ли 32 млн или цифра 4.
// здесь под каждый вызов метода выделяется память 4 байта (одна инт переменная). если сделать много-много вызовов метода,
// то каждый раз будет заниматься 4 байта, и высвобождаться эта память будет только в момент завершения метода. 
// если речь идет о больших и неконтролируемых объемах информации, то рекурсивные методы не используются. Поэтому вначале 
// должна быть проверка числа, подходит ли оно для рекурсии.
// Рекурсия полезна если н-р надо сделать обход дерева папок. 

*/
//Ex2 вывести числа от m до n ; m < n от меньшего к большего
/*
void ShowNums(int n, int m)
{
       if(n != m)
            ShowNums(n-1, m);
       
        Console.Write(n + " ");
}

Console.WriteLine("Input first number");
int userN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int userM = Convert.ToInt32(Console.ReadLine());

ShowNums(userN, userM);
*/

//Ex3 принимать на вход число, и возвращать сумму цифр. 

/*
int SumOfDigits(int num)
{
    if(num / 10 == 0) return num%10;
    else return num%10 + SumOfDigits(num/10);
}

Console.WriteLine(SumOfDigits(1123));
*/

//Ex4 а возвести в степень б (b > 0)
/*
int PowAB(int a, int b)
{
    if (b == 1) return a;
    else return a*PowAB(a, b-1);
}

Console.WriteLine(PowAB(2, 5));
*/

//Ex5 а возвести в степень б (b > < 0)

double PowAB(int a, int b)
{
    if (b == 1) return a;
    if (b > 0) return a*PowAB(a, b-1);
    else return 1/(a*PowAB(a, -b-1));
}

Console.WriteLine(PowAB(2, -2));