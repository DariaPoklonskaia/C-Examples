
// Ex1

int CutNumber(int number)
{
    if (Math.Abs(number) > 99 && Math.Abs(number) < 1000)
    {
        int result = ((number%100) - (number%10))/10;
        return Math.Abs(result);
    }
        else
        {
            return -1;
        }

}

Console.WriteLine("Inter 3-digital number ");
int usernum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CutNumber(usernum));




//Ex 2
/*
string CutNumber(int number)
{
    if (Math.Abs(number) > 99)
    {
        int result = (number/100) - (10*(number/1000));
        string printResult = Math.Abs(result).ToString();
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

*/

// Ex 3 (var1)

/*
string CheckWeekends(int day)
{
    if (day >5 && day<8)
        {
            string yes = "Yes";
            return yes;
        }
    if (day > 0 && day < 6)
        {
            string no = "NO";
            return no;
        }
    else 
        {
            string notAweekand = "There are only 7 days in a week, enter number from 1 to 7";
            return notAweekand;
        }
}

Console.WriteLine("Inter day of the week from 1 to 7, where 1 - Monday and 7 - Sunday");
int userDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckWeekends(userDay));

*/ 

//Ex3 (var2)
/*
bool CheckWeekends(int day)
{
    return (day >5 && day<8);
}

Console.WriteLine("Inter day of the week from 1 to 7, where 1 - Monday and 7 - Sunday");
int userDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckWeekends(userDay));
*/
