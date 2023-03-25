// See https://aka.ms/new-console-template for more information
using ByteBank.GeneradorLlaves;

Console.WriteLine("Aplicación de llaves");

Console.WriteLine(GeneradorLlaves.GeneraLlaveUnica());
var llaves = GeneradorLlaves.GeneraLlavesUnicas(5);

for(int i=0;i < llaves.Count();i++)
{
    Console.WriteLine(llaves[i]);
}
Console.ReadLine();
