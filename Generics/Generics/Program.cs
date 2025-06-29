// See https://aka.ms/new-console-template for more information
bool IsPalindrome(int x)
{
    string number = x.ToString();
    int SumOfDigits = number.Length;
    int length = number.Length / 2;
    for (int i = 0; i <= length; i++)
    {
        SumOfDigits -= 1;
        if (number[i] != number[SumOfDigits])
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(IsPalindrome(121));