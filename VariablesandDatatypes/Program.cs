// See https://aka.ms/new-console-template for more information

//variables declaration and Datatypes
string fullName = string.Empty;
int age ;
double salary;
char gender = char.MinValue;
bool working=false;

Console.WriteLine("enter your name");
fullName=Console.ReadLine();

Console.Write("Please enter your age");
age=Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter ur salary");
salary=Convert.ToDouble(Console.ReadLine());

Console.Write(" Please Enter ur Gender");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working true or false");
    working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("your name is :" + fullName);
Console.WriteLine("your age is :" + age);
Console.WriteLine("your salary is: "+salary);
Console.WriteLine("your Gender is :{gender}");  





