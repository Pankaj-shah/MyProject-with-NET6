// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
String firstName = "Radha";
String lastName = "Shrestha";


//concatenation
Console.WriteLine(firstName + " " + lastName);

//print length of string
int length = firstName.Length;
Console.WriteLine($"your name is {length} meters long.");

//Replace string parts
String newName = firstName.Replace('R', 'P');
Console.WriteLine(newName);

//Append to other string varibles
String fullName = firstName + " " + lastName;
Console.WriteLine(fullName);
//split string

string[] splitName = fullName.Split('d');
for (int i = 0; i < splitName.Length; i++)
{


    Console.WriteLine(splitName[i]);
}
//compare string
string nullString = null;
string emptyString = " ";
string whitespaceString = " ";

if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("names are equal");
}

if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}