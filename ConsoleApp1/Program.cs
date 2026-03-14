using System.Diagnostics.CodeAnalysis;
using System.Globalization;

static int min(int n1, int n2, int n3)
{
    int m = n1;
    if (n2 < m) m = n2;
    if (n3 < m) m = n3;
    return m;
}

static int m(int i, int j, string s1, string s2)
{
    if (s1[i] == s2[j])
    {
        return 0;
    }
    return 1;
}

static int D(int i, int j, string s1, string s2)
{
    if (i == 0 && j == 0)
    {
        return 0;
    }
    else if (i > 0 && j == 0)
    {
        return i;
    }
    else if (i == 0 && j > 0)
    {
        return j;
    }
    return min((D(i - 1, j, s1, s2) + 1), (D(i, j - 1, s1, s2) + 1), (D(i - 1, j - 1, s1, s2) + m(i-1, j-1, s1, s2)));
}

static int DT(int i, int j, string s1, string s2)
{
    if (i == 0 && j == 0)
    {
        return 0;
    }
    else if (i > 0 && j == 0)
    {
        return i;
    }
    else if (i == 0 && j > 0)
    {
        return j;
    }


    int d0 = min((DT(i - 1, j, s1, s2) + 1), (DT(i, j - 1, s1, s2) + 1), (DT(i - 1, j - 1, s1, s2) + m(i - 1, j - 1, s1, s2)));

    if (i > 1 && j > 1 && s1[i - 1] == s2[j - 2] && s1[i - 2] == s2[j - 1])
    {
        int transposition = DT(i - 2, j - 2, s1, s2) + 1;
        if (transposition < d0)
            return transposition;
    }
    return d0;
}


while (true)
{
    string s1 = Console.ReadLine();
    if (s1 == "exit")
    {
        break;
    }
    string s2 = Console.ReadLine();

    Console.WriteLine($"Первая строка: {s1}, вторая строка: {s2}");
    Console.WriteLine($"Расстояние Левенштейна: {D(s1.Length, s2.Length, s1, s2)}");
    Console.WriteLine($"Расстояние Дамерау-Левенштейна: {DT(s1.Length, s2.Length, s1, s2)}");
}