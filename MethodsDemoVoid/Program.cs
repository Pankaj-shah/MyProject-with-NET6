// See https://aka.ms/new-console-template for more information
void PrintName()
{
    Console.WriteLine("My Name");
}

void Addition(int a, int b)
{
    Console.WriteLine($"This is the reslult {a + b}");
}

void Subtraction(float f,float p)
{
    Console.WriteLine($"Tis is the float value {f - p} ");
}
int LargestNumber(int a, int b, int c)
{
    if(a < b &&  a< c)
    {
        return a;
    }
    else if(b < c)
    {
        return b;
    }
    else
    {
        return c;
    }
}

Subtraction(45.99f, 12.34f);
Console.WriteLine("Enter the number 1=");
int a=Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Enter number 2");
int b=Convert.ToInt32(Console.ReadLine());
Addition(a, b);
PrintName();
Console.WriteLine("Enter third Number");
int c=Convert.ToInt32(Console.ReadLine());  

int result=LargestNumber(a, b, c);
Console.WriteLine("The largest value="+result);
