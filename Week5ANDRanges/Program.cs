//temp <= 0 - freezing cold
//temp > AND temp <= - cold
//temp >10 AND temp <= 15 - chilly 10-15
//temp >15 AND <20 - warm 15-20
//temp >=20 AND temp <30 - hot 20-30
//temp >=30 - boiling hot


Console.WriteLine("Insert the temperature");
int temp = Int32.Parse(Console.ReadLine());

if(temp >= 30)
{
    Console.WriteLine("Boiling hot");
}
else if(temp <30 && temp >=20 )
{
    Console.WriteLine("Hot");
}
else if(temp <20 && temp >= 15)
{
    Console.WriteLine("warm");
}
else if (temp <15 && temp >= 10)
{
    Console.WriteLine("chilly");
}
else if (temp < 10)
{
    Console.WriteLine("freezing cold");
}