static int Ebob(int x, int y)
{
    // Özyinelemeli Euclid yöntemi
    if (y == 0)
        return x;
    else
        return Ebob(y, x % y);
}

// Kullanım:
int e = Ebob(48, 18); // 6
Console.WriteLine($"EBOB = {e}");
