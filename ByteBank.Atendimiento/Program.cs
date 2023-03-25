// See https://aka.ms/new-console-template for more information

using ByteBank.Atendimiento.ByteBank.Atendimiento;

#region Manipulación de arreglos
/*
int edad1 = 18;
int edad2 = 25;
int edad3 = 29;
int edad4 = 38;
int edad5 = 19;
int edad6 = 62;

int mediaEdades = (edad1 + edad2 + edad3 + edad4 + edad5 + edad6) / 6;

Console.WriteLine("La media de las edades es: " + mediaEdades);
*/
void TestEnteros()
{

    int[] edades = new int[6];
    edades[0] = 18;
    edades[1] = 25;
    edades[2] = 29;
    edades[3] = 38;
    edades[4] = 19;
    edades[5] = 62;

    int totalEdades = 0;
    for (int i = 0; i < edades.Length; i++)
    {
        //totalEdades = totalEdades + edades[i];
        totalEdades += edades[i];
    }

    int mediaEdades = totalEdades / edades.Length;


    Console.WriteLine("La media de las edades es: " + mediaEdades);
}

void TestCadenas()
{
    string[] listaNombres = new string[5];

    for(int i = 0;i < listaNombres.Length;i++)
    {
        Console.Write($"Nombre {i+1}:");
        listaNombres[i] = Console.ReadLine();
    }

    Console.Write("Nombre a buscar: ");
    string nombreABuscar = Console.ReadLine();

    foreach(string nombre in listaNombres)
    {
        if (nombre.Equals(nombreABuscar))
        {
            Console.WriteLine($"La persona con nombre {nombreABuscar} fue encontrada");
            break;
        } 
    }

}

void TestClaseArray()
{
    Array lista = Array.CreateInstance(typeof(double), 7);

    lista.SetValue(1.8, 0);
    lista.SetValue(7.4, 1);
    lista.SetValue(3.4, 2);
    lista.SetValue(2.8, 3);
    lista.SetValue(5.7, 4);
    lista.SetValue(6.8, 5);
    lista.SetValue(4.9, 6);

    double[] listaOrdenada = (double[])lista.Clone();

    Array.Sort(listaOrdenada);

    int elementoMedio = listaOrdenada.Length / 2;

    double mediana = (listaOrdenada.Length % 2 != 0) ? listaOrdenada[elementoMedio] : (listaOrdenada[elementoMedio-1] + listaOrdenada[elementoMedio]) / 2;

    Console.WriteLine($"La mediana del conjunto es: {mediana}");

}

/*
int[] valores = { 4, 5, 6, 8, 9 };

for(int i = 0;i < 10;i++)
{
    Console.WriteLine($"{valores[i]}");
}
*/

/*
void TestArregloCuentasBancarias()
{
    CuentaBancaria[] listaCuentasBancarias = new CuentaBancaria[]
    {
        new CuentaBancaria("123232","213434"),
        new CuentaBancaria("454532","345344"),
        new CuentaBancaria("343433","576788"),
        new CuentaBancaria("989895","232323"),
    };

    for(int i = 0;i < listaCuentasBancarias.Length;i++)
    {
        Console.WriteLine($"Cuenta {i} - Nro. {listaCuentasBancarias[i].NumeroCuenta} - Agencia {listaCuentasBancarias[i].NumeroAgencia}");
    }
}


void TestArregloListaCuentasBancarias()
{
    ListaCuentasBancarias listaCuentasBancarias = new ListaCuentasBancarias();

    CuentaBancaria cuenta1 = new CuentaBancaria("454532", "345344");
    //0
    listaCuentasBancarias.agregar(new CuentaBancaria("123232", "213434"));
    //1
    listaCuentasBancarias.agregar(cuenta1);
    listaCuentasBancarias.agregar(new CuentaBancaria("343433", "576788"));
    listaCuentasBancarias.agregar(new CuentaBancaria("989895", "232323"));
    listaCuentasBancarias.agregar(new CuentaBancaria("665654", "696556"));
    listaCuentasBancarias.agregar(new CuentaBancaria("666524", "979841"));
    //Mostra Lista
    Console.WriteLine("Cuentas agregadas ***********");
    listaCuentasBancarias.mostrarLista();

    Console.WriteLine("Eliminando 1 cuenta ***********");
    listaCuentasBancarias.remover(cuenta1);
    //Mostra lista
    //listaCuentasBancarias.mostrarLista();
    Console.WriteLine("Iterando la listaCuentasBancarias como arreglo  ***********");
    for (int i = 0;i < listaCuentasBancarias.Tamano;i++)
    {
        CuentaBancaria obj = listaCuentasBancarias[i];

        Console.WriteLine($"Cuenta {i} - Nro. {obj.NumeroCuenta} - Agencia {obj.NumeroAgencia}");
    }


}

//TestArregloListaCuentasBancarias();
*/
#endregion

#region métodos de List
/*
//Colección


List<CuentaBancaria> lstCuentasBancarias2 = new List<CuentaBancaria>()
{
    new CuentaBancaria("123232-B","21343422"),
    new CuentaBancaria("454532-B","34534422"),
    new CuentaBancaria("343433-B","57678822"),
};

List<CuentaBancaria> lstCuentasBancarias3 = new List<CuentaBancaria>()
{
    new CuentaBancaria("123232-C","21343433"),
    new CuentaBancaria("454532-C","34534433"),
    new CuentaBancaria("343433-C","57678833"),
};

var rango = lstCuentasBancarias3.GetRange(0,1);

lstCuentasBancarias2.AddRange(rango);

for (int i = 0; i < lstCuentasBancarias2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Cuenta [{lstCuentasBancarias2[i].NumeroCuenta}]");
}

//Modo reverso
lstCuentasBancarias2.Reverse();
Console.WriteLine("Modo reverso:");
for (int i = 0; i < lstCuentasBancarias2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Cuenta [{lstCuentasBancarias2[i].NumeroCuenta}]");
}

//Limpiar lista
lstCuentasBancarias2.Clear();
Console.WriteLine("Limpiamos:");
for (int i = 0; i < lstCuentasBancarias2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Cuenta [{lstCuentasBancarias2[i].NumeroCuenta}]");
}
*/
#endregion

#region clase genérica
/*
Generica<int> obj = new Generica<int>();

obj.mostrarMensaje(3);

Generica<string> objS = new Generica<string>();

objS.mostrarMensaje("Este es un texto");

public class Generica<T>
{
    public void mostrarMensaje(T t)
    {
        Console.WriteLine($"Mostrando {t}");
    }
}
*/
#endregion


new ByteBankAtendimiento().menuAtendimiento();


