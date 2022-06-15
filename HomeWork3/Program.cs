
string CheckPalindrom (int num)
{
    if (num > 9999 && num < 10^5)
        {
            if (num/10^4 == num%10 && num/10^3 == num % 100)
            return yes = "Yes";
            else return no = "No";
        }
    else return NotValid = "You bumber is not 5-digital";
}

Console.WriteLine("Inter 5-digital number"); 
int userNum = Convert.ToInt32(read)