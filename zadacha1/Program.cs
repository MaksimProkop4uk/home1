Console.WriteLine("Введите число");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число");
int numB = int.Parse(Console.ReadLine()!);
 int max = numA;
 
 if (numA>max) max = numA;
if (numB>max) max = numB;
Console.Write("max=");
Console.WriteLine(max);
