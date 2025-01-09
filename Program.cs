using PooServiteca.Classes;
using System.Linq.Expressions;

//Creación de mantenimientos

//Mantenimiento Correctivo Mayor
Mantenimientos RepararMotor = new Mantenimientos("Reparar el motor", 3500000f);
Mantenimientos ReparaCajaCambios = new Mantenimientos("Reparar la caja de cambios", 2250000f);
Mantenimientos ReparaCajaDireccion = new Mantenimientos("Reparar la caja de Dirección", 1250000f);
//Mantenimiento Correctivo Menor
Mantenimientos Arreglarfugas = new Mantenimientos("Arreglar las fugas", 300000f);
Mantenimientos CambiarPastillaFreno = new Mantenimientos("Cambiar las pastillas del freno", 900000f);
Mantenimientos CambiarAmortiguador = new Mantenimientos("Cambiar el amortiguador", 300000f);
Mantenimientos RectificarRines = new Mantenimientos("Rectificar los rines", 200000f);
//Mantenimiento Preventivo Mayor
Mantenimientos RevisarFrenos = new Mantenimientos("Revisar los frenos", 350000f);
Mantenimientos RevisarSuspension = new Mantenimientos("Revisar la suspension", 500000f);
Mantenimientos RevisarLuces = new Mantenimientos("Revisar las luces", 150000f);
Mantenimientos CambiarAceite = new Mantenimientos("Cambiar aceite", 150000f);
Mantenimientos Sincronizar = new Mantenimientos("Sincronizar", 400000f);
Mantenimientos AlinearYBalancear = new Mantenimientos("AlinearYBalancear", 200000f);
Mantenimientos ReemplazarBateria = new Mantenimientos("Cambiar la bateria", 350000f);

//crear los tipos de mantenimientos

Serviteca MantenimientoPreventivo = new Serviteca();
Serviteca MantenimientoCorrectivoMayor = new Serviteca();
Serviteca MantenimientoCorrectivoMenor = new Serviteca();

//Asignar los nombres

MantenimientoPreventivo.NombreMantenimiento = "Mantenimiento Preventivo";
MantenimientoCorrectivoMayor.NombreMantenimiento = "Mantenimiento correctivo Especilizado";
MantenimientoCorrectivoMayor.NombreMantenimiento = "Mantenimiento Correctivo Menor";

//añadir las actividades a cada tipo de mantenimiento

MantenimientoPreventivo.TipoMantenimiento.AddRange(new[] { 
    RevisarFrenos, 
    RevisarSuspension, 
    RevisarLuces,
    CambiarAceite,
    Sincronizar,
    AlinearYBalancear,
    ReemplazarBateria
});
MantenimientoCorrectivoMenor.TipoMantenimiento.AddRange(new[]
{
    Arreglarfugas,
    CambiarPastillaFreno,
    CambiarAmortiguador,
    RectificarRines
});
MantenimientoCorrectivoMayor.TipoMantenimiento.AddRange(new[]
{
    RepararMotor,
    ReparaCajaCambios,
    ReparaCajaDireccion,
});


//creación de los tipos de carro

TipoCarro TipoMicro = new TipoCarro("MICRO", 2.5f, 3f, 2, 4, 0.1f);
TipoCarro TipoA = new TipoCarro("A", 3f, 3.5f, 4, 5, 0.2f);
TipoCarro TipoB = new TipoCarro("B", 3.5f, 4f, 4, 5, 0.3f);
TipoCarro TipoC = new TipoCarro("C", 4f, 4.5f, 5, 5, 0.4f);
TipoCarro TipoD = new TipoCarro("D", 4.5f, 5f, 5, 5, 0.5f);
TipoCarro TipoE = new TipoCarro("E", 5f, 5.5f, 5, 5, 0.6f);
TipoCarro TipoF = new TipoCarro("F", 5f, 5.3f, 5, 7, 0.7f);


//Creación del usuario y su carro

Usuario usuario = new Usuario("Pepe", 12345678);
Carro CarroUsuario = new Carro(usuario.nombre, 123456, TipoA, "AAA123", "blanco", "amarillo", false);

 Console.WriteLine("""
***********************
*--Sistema Serviteca--*
**********************+

""");
Console.WriteLine("""
Ingrese un número según lo que desee 
- Tipo Micro (M)
- Tipo A
- Tipo B
- Tipo C 
- Tipo D
- Tipo E
- Tipo F
    
(ingrese solo la letra del tipo de carro )
""");
char Opcion = Console.ReadLine()[0];
Opcion = char.ToUpper(Opcion);
switch (Opcion)
{
    case 'M':
        CarroUsuario.tipocarro = TipoMicro;
        break;
    case 'A':
        CarroUsuario.tipocarro = TipoA;
        break;
    case 'B':
        CarroUsuario.tipocarro = TipoB;
        break;
    case 'C':
        CarroUsuario.tipocarro = TipoC;
        break;
    case 'D':
        CarroUsuario.tipocarro = TipoD;
        break;
    case 'E':
        CarroUsuario.tipocarro = TipoE;
        break;
    case 'F':
        CarroUsuario.tipocarro = TipoF;
        break;
    default:
        Console.WriteLine($"el caracter {Opcion} no es valido");
        break;
}

Console.WriteLine("ingrese la placa: ");
CarroUsuario.placa = Console.ReadLine();
Console.WriteLine("ingrese el color de la placa: ");
CarroUsuario.colorplaca = Console.ReadLine();
Console.WriteLine("ingrese el color de la carroceria: ");
CarroUsuario.colorcarroceria = Console.ReadLine();

Console.WriteLine("""
    Ingrese un numero para seleccionar mantenimiento
    1 - Mantenimiento preventivo
    2 - Mantenimiento correctivo Especializado
    3 - Mantenimiento Correctivo Menor
    """);

int Tipo_mantenimiento = int.Parse(Console.ReadLine());

switch (Tipo_mantenimiento)
{
    case 1:
        Serviteca.MantenimientoARealizar(CarroUsuario, MantenimientoPreventivo);
        break;
    case 2:
        Serviteca.MantenimientoARealizar(CarroUsuario, MantenimientoCorrectivoMayor);
        break;
    case 3:
        Serviteca.MantenimientoARealizar(CarroUsuario,MantenimientoCorrectivoMenor);
        break;
    default:
        Console.WriteLine("ERROR!!!!");
        Environment.Exit(0);
        break;
}



