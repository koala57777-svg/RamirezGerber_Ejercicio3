Console.WriteLine("Seleccione el tipo de cliente (Número)");
Console.WriteLine("");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Admnistrativo");
Console.WriteLine("4. Externo");
Console.WriteLine("");
int tipoCliente = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el monto base (Q)");
Console.WriteLine("");
double montoBase = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el método de pago (Número): ");
Console.WriteLine("1. Efectivo");
Console.WriteLine("2. Tarjeta");
Console.WriteLine("3. Transferencia");
Console.WriteLine("");
int metodoPago = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("¿Tiene cupón? (S/N)");
Console.WriteLine("");
string tienecupon = Console.ReadLine();
string codigo = "";
if (tienecupon == "S")
{
    Console.WriteLine("Ingrese el cupón: ");
    codigo = Console.ReadLine();
}

Console.WriteLine("");
Console.WriteLine("Ingrese el reporte de intifraude (número): ");
Console.WriteLine("");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Cupón inválido repetido");
Console.WriteLine("3. Pagos rechazados múltiples");
Console.WriteLine("");
int reporteFraude = int.Parse(Console.ReadLine());
Console.WriteLine("");




