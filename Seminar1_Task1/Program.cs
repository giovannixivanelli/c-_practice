int a = 144;
int b = 12;

if(a * a == b)
{
    Console.WriteLine($"{a} is a quarter of {b}");
} else if (b * b == a) 
{
    Console.WriteLine($"{b} is a quarter of {a}");
} else
{
    Console.WriteLine($"{b} is not a quarter of {a}");
}