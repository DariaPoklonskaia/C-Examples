//Ex 1 Функция, которая возводит в степень
/*
double PowAB(int a, int b)
{
    return Math.Pow(a, b);
}

Console.WriteLine("inter base of power number");
int userA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("inter  power number");
int userB = Convert.ToInt32(Console.ReadLine());

double result = PowAB(userA, userB);
Console.WriteLine(result);
*/

// Ex2 вывод массива

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-1000, 1000); 
    }

for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] +" ");
    }



