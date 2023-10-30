// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Input B");
int B = int.Parse(Console.ReadLine());
for (int i = A; i > B-1; i--)    Console.WriteLine(i);
Console.ReadLine();