//temp >= o - väga külm
//temp >0 AND temp <= 10 - külm
//temp >=10 AND <15 Okei
//temp >=15 and <20 Soe
// >=20 <30 Kuum
// >=30 Väga kuum

Console.WriteLine("Sisesta temperatuur: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Väga kuum");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Kuum");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Soe");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Jahe");
}
else if (temp < 10 && temp > 0)
{
    Console.WriteLine("Külm");
}
else
{
    Console.WriteLine("Väga külm");
}
