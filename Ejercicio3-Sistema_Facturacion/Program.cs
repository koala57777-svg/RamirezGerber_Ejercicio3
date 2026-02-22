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
double descuento = 0.1;
double recargo = 0.05;
Console.WriteLine("");

if (montoBase >= 0 && (tienecupon=="S" || tienecupon=="N") && reporteFraude>=1 && reporteFraude<=3)
{
    switch (tipoCliente)
    {
        case 1:
            switch(metodoPago)
            {
                case 1:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo*100}%");
                        Console.WriteLine($"Total final: {montoBase+(montoBase*recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento*100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento))-(0.1*(montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.1 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.1)}");
                    }
                    break;
                case 2:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento)) - (0.07 * (montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.07)}");
                    }
                    break;
                case 3:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * descuento)}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 0}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    break;
            }
            break;
        case 2:
            switch (metodoPago)
            {
                case 1:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento)) - (0.1 * (montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.1 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.1)}");
                    }
                    break;
                case 2:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento)) - (0.07 * (montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.07)}");
                    }
                    break;
                case 3:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * descuento)}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 0}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    break;
            }
            break;
        case 3:
            switch (metodoPago)
            {
                case 1:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento)) - (0.1 * (montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.1 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.1)}");
                    }
                    break;
                case 2:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento)) - (0.07 * (montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.07)}");
                    }
                    break;
                case 3:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * descuento)}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 0}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    break;
            }
            break;
        case 4:
            switch (metodoPago)
            {
                case 1:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento)) - (0.1 * (montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.1 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.1)}");
                    }
                    break;
                case 2:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {(montoBase - (montoBase * descuento)) - (0.07 * (montoBase - (montoBase * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * 0.07)}");
                    }
                    break;
                case 3:
                    if (reporteFraude == 2 || reporteFraude == 3)
                    {
                        Console.WriteLine("Descuento aplicado: Ninguno");
                        Console.WriteLine($"Recargo:{recargo * 100}%");
                        Console.WriteLine($"Total final: {montoBase + (montoBase * recargo)}");
                    }
                    else if (cuponvalido)
                    {
                        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase - (montoBase * descuento)}");
                    }
                    else
                    {
                        Console.WriteLine($"Descuento aplicado: {0.07 * 0}%");
                        Console.WriteLine($"Recargo:{recargo * 0}%");
                        Console.WriteLine($"Total final: {montoBase}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago inválido.");
                    break;
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





