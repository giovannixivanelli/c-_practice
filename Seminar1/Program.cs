int first = 12;
int second = new Random().Next(1,100);
if (first > second)
{
    Console.WriteLine($"{first} greater than {second}");
}
else 
{
    Console.WriteLine($"{second} greater than {first}");
}