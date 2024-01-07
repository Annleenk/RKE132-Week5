// range math >= 90, biology >=90, chemistry >=90

using System.ComponentModel.Design;

int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter yoru chemistry result.");
chemistry = Int32.Parse(Console.ReadLine());


if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congrats, you've been accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved");
}