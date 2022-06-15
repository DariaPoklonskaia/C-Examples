//Ex1 CheckPalindrom
/*
string CheckPalindrom(int num)
{
    if (Math.Abs(num) > 9999 && Math.Abs(num) < 100000)
        { 
             if(num / 10000 == num % 10 && ((num/1000)%10) == (num%100)/10)
                 {
                    string yes = "yes";
                    return yes;
                 }
            else
                {
                    string no = "no";
                    return no;
                }
        }
    else
        {
            string NotValid = "Your number is not 5-digital";
            return NotValid;
        }
}

Console.WriteLine("input 5-digital number");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckPalindrom(userNum));

*/

// Ex3 -input N and output from 1 to N^3
/*
void NNN (int num)
{
    if (num > 0)
    {
        int count = 1;
        while (count <= num)
            {
                Console.Write(Math.Pow(count, 3) + " ");
                count++; 
            }
    }
    else Console.WriteLine("This method doesn't work with negative numbers");
}

Console.WriteLine("Input natural number");
int userNum = Convert.ToInt32(Console.ReadLine());

NNN(userNum);

*/

//Ex2 Find lenght b/w points in 3D space

double FindLenght (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)); 
}

Console.WriteLine("Input x coordinate first point");
double userX1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y coordinate first point");
double userY1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z coordinate first point");
double userZ1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x coordinate second point");
double userX2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y coordinate second point");
double userY2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z coordinate second point");
double userZ2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(FindLenght(userX1, userY1, userZ1, userX2, userY2, userZ2));

