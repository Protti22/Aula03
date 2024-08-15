int x;
int v;
Console.WriteLine("Digite dois numeros.");

x = Convert.ToInt32(Console.ReadLine());
v = Convert.ToInt32(Console.ReadLine());

int resultado1 = x + v;
int resultado2 = x - v;
int resultado3 = x * v;
int resultado4 = x / v;

Console.WriteLine($"Seu resultado somado foi {0}", resultado1);
Console.WriteLine("Seu resultado subtraindo foi " + resultado2 + "");
Console.WriteLine("Seu resultado multiplicando foi {0}", resultado3);
Console.WriteLine($"Seu resultado dividindo foi {resultado4}");