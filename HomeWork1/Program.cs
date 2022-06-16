// Ex1
/*
int num1, num2;

Console.WriteLine("Inter first integer number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter second integer number ");
num2 = Convert.ToInt32(Console.ReadLine());


if (num1 >= num2)
{
    Console.WriteLine("max is " + num1);
}
else 
{
    Console.WriteLine("max is " + num2);
}
*/

//Ex 2
/*
int num1, num2, num3;

Console.WriteLine("Inter first integer number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter second integer number ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter third integer number ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) 
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.WriteLine("max is " + max);
*/ 

// Ex 3
/*
int num;

Console.WriteLine("Inter integer number ");
num = Convert.ToInt32(Console.ReadLine());

int residual = num % 2;

if(residual == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

//Ex 4

int num;

Console.WriteLine("Inter integer number ");
num = Convert.ToInt32(Console.ReadLine());

int count = 2;

if (num < count)
{
    Console.Write("No even number before " + num);
}
while (num >= count)

    Console.Write(count + " ");
    count = count +2;
}

