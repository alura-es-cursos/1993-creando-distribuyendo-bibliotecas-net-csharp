// See https://aka.ms/new-console-template for more information

using ByteBank.Atendimiento.ByteBank.Atendimiento;
using ByteBank.Modelos;

new ByteBankAtendimiento().menuAtendimiento();

class Temporario : Empleado
{
    public Temporario(string _Dni, double _Salario) : base(_Dni, _Salario)
    {
    }

    protected override double obtenerBonificacion()
    {
        throw new NotImplementedException();
    }
}