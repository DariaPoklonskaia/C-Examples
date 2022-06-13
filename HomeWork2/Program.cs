
// Ex1
/*
int CutNumber(int number)
{
    if (number>99 && number<1000)
    {
        int result = (number/10) - (10*(number/100));
        return result;
    }
        else
        {
            return -1;
        }

}

Console.WriteLine("Inter 3-digital number ");
int usernum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CutNumber(usernum));

*/


//Ex 2

string CutNumber(int number)
{
    if (number>99)
    {
        int result = (number/100) - (10*(number/1000));
        string printResult = result.ToString();
        return printResult;
    }
        else
        {
            string noThirdSign = "Третьей цифры нет";
            return noThirdSign;
        }

}

Console.WriteLine("Input number ");
int usernum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CutNumber(usernum));