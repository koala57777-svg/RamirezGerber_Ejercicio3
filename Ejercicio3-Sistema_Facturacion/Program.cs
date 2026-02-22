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
bool cuponvalido = false;
if (tienecupon == "S")
{
    Console.WriteLine("Ingrese la primera letra de su cupón: ");
    string primeraLetra = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Ingrese el último dígito de su cupón");
    int ultimoDigito = int.Parse(Console.ReadLine());
    if (primeraLetra == "U" && (ultimoDigito%2 == 0))
    {
        cuponvalido=true;
    }
    else
    {
        cuponvalido = false;
    }
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

if (montoBase >= 0 && (tienecupon=="S" || tienecupon=="N"))
{
    switch (tipoCliente)
    {
        case 1:
            switch(metodoPago)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    return;
            }
            break;
        case 2:
            switch (metodoPago)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    return;
            }
            break;
        case 3:
            switch (metodoPago)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    return;
            }
            break;
        case 4:
            switch (metodoPago)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    return;
            }
            break;
        default:
            Console.WriteLine("Tipo de cliente inválido.");
            return;
    }
}
else
{
    Console.WriteLine("Datos inválidos. Por favor ingrese datos válidos.");
}





