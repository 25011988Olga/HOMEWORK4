Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int s =0;
while(n>0)
{
    s = s+n%10;
    n = n/10;
}
Console.WriteLine(s);
