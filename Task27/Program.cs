int Sum(int n)
{
    string b = Convert.ToString(n);
    int result = 0;
      for(int i = 0; i <= b.Length; i++)
    {
        int n1 = n % 10;
        n /= 10;
        result = result + n1;
    }
    return result;
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("The sum of number is: " + Sum(n));