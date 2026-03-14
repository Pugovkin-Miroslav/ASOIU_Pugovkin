using System.Globalization;

static int min(int n1, int n2, int n3)
{
    if (n3 < n2 && n3 < n2)
    {
        return n3;
    }
    else if (n2 < n1 && n2 < n3)
    {
        return n2;
    }
    return n1;
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
    Console.WriteLine($"{i} {j}");
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
    return min((D(i - 1, j, s1, s2) + 1), (D(i, j - 1, s1, s2) + 1), (D(i - 1, j - 1, s1, s2) + m(i, j, s1, s2)));
}



while (true)
{
    Console.WriteLine(min(1, 2, 3));
    string s1 = Console.ReadLine();
    if (s1 == "exit")
    {
        break;
    }
    string s2 = Console.ReadLine();

    Console.WriteLine($"first string: {s1}, second string: {s2}");
    Console.WriteLine($"Расстояние Левенштейна: {D(s1.Length, s2.Length, s1, s2)}");
}