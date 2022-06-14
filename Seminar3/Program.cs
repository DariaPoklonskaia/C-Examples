// Ex 1 Принимает на вход координаты точки [X, y]; нераные нулю. Выдаем четверть в которой находится эта  точка.

int FindQuart (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return -1; 
}

Console.WriteLine("Input non-zero x coordinate");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input non-zero y coordinate");
int y1 = Convert.ToInt32(Console.ReadLine());

int result = FindQuart(x1, y1);

if (result == -1) Console.WriteLine("This point belong to one of the axis");
else Console.WriteLine($"Point related to {result} quard");
    

