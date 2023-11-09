//24var
Console.WriteLine("|    x   |   y    |");
for(double x = -Math.PI / 2; x <= Math.PI; x+=0.2)
{
    double y;
    if (x < 0) y = Math.Exp(-x);
    else if (x >= 0 && x <= 2) y = -2 * Math.Pow(x, 3) + 2;
    else y = Math.Sqrt(2*x+Math.Log(x-1));
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
    x += 0.2;
}