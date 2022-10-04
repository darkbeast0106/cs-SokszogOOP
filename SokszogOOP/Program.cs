using SokszogOOP;

Random rnd = new Random();
for (int i = 0; i < 5; i++)
{
    double a = rnd.NextDouble() * 10 + 5;
    double b = rnd.NextDouble() * 10 + 5;
    Console.WriteLine(new Teglalap(a, b));
}

for (int i = 0; i < 5; i++)
{
    Haromszog haromszogObjektum = new Haromszog();
    Console.WriteLine(haromszogObjektum);
    Console.WriteLine(haromszogObjektum.A);
}