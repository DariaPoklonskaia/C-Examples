string CheckPalindrom(int num)
{
    if(num / 10000 == num % 10 && num/1000 == num%100)
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

Console.WriteLine("input 5-digital number");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckPalindrom(userNum));