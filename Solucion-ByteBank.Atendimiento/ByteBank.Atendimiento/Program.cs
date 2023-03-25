// See https://aka.ms/new-console-template for more information

using ByteBank.Atendimiento.ByteBank.Atendimiento;
using ByteBank.GeneradorLlaves;
using ByteBank.Modelos;

/*new ByteBankAtendimiento().menuAtendimiento();

class Temporario : Empleado
{
    public Temporario(string _Dni, double _Salario) : base(_Dni, _Salario)
    {
    }

    protected override double obtenerBonificacion()
    {
        throw new NotImplementedException();
    }
}*/

Console.WriteLine("Probando componentes externos (DLLs)");
// Creando una llave única
Console.WriteLine("Llave: ");
Console.WriteLine(GeneradorLlaves.GeneraLlaveUnica());
// Creando múltiples llaves
Console.WriteLine("Generando 5 Llaves: ");
var llaves = GeneradorLlaves.GeneraLlavesUnicas(5);
for(int i = 0;i < llaves.Count;i++)
{
    Console.WriteLine(llaves[i]);
}

