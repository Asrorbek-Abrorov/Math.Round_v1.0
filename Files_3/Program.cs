// See https://aka.ms/new-console-template for more information

using System.Numerics;

string Round(string x, int a)
{
    if (a <= 15)
    {
        return "Math.Round(x, a).ToString()";
    }
    else
    {
        var lst = x.ToString().Split('.');
        var chars = lst[1].ToCharArray();
        string result = $"{lst[0]}.";
        if (chars[a] >= 5)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == a - 1)
                {
                    chars[i] = (char)(chars[i] + 1);
                    result += chars[i].ToString();
                }
                else if(i == a)
                {
                    result += 0;
                }
                else
                {
                    result += chars[i].ToString();
                }
            }
            return (result);
        }
        else
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if(i == a)
                {
                    result += 0;
                }
                else
                {
                    result += chars[i].ToString();
                }
            }
            return (result);
        }
    }
}

Console.WriteLine(Round("1.1111111111111117889777777", 20));
