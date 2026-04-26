using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
bool menu = true, validarOpcion;
do
{
    int opcion = Menu();
        Console.Clear();
        switch (opcion)
        {
            case 0:
                Console.WriteLine("Saliendo");
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.Write(".");
                menu = false;
                break;
            case 1:
                break;
            case 2: 
            case 3: 
            case 4:
            default:
                Console.WriteLine("Opcion no existente");
                Thread.Sleep(1000);
                break;
        }
} while(menu);

int CodigoPrestamo()
{
    do
    {
    } while ();
    return;
}
string NombreEstudiante;
int Carnet;
string Carrera;
string EquipoPrestado;
int Cantidad;
bool EstadoPrestamo;

int Menu()
{
    Console.Clear();
    Console.WriteLine("---Control de prestamos---");
    Console.WriteLine("1. Registrar préstamos");
    Console.WriteLine("2. Buscar préstamos");
    Console.WriteLine("3. Mostrar información");
    Console.WriteLine("4. Eliminar registros");
    Console.WriteLine("0. Salir");
    Console.Write("Elija una opcion:");
    validarOpcion = int.TryParse(Console.ReadLine(), out int opcion01);
    if (!validarOpcion)
    {
        Console.WriteLine("Caracter no valido");
        Thread.Sleep(500);
        Console.Write("-----> Intente otra ves;");
        Thread.Sleep(300);
        return 5;
    }
    else
    {
        return opcion01;
    }
}

class Control
{
    private int codigoPrestamo;
    private string nombreEstudiante;
    private int carnet;
    private string carrera;
    private string equipoPrestado;
    private int cantidad;
    private bool estadoPrestamo;

    public int CodigoPrestamo
    {
        get { return codigoPrestamo; }
        set { codigoPrestamo = value; }
    }
    public string NombreEstudiante
    {
        get { return nombreEstudiante; }
        set 
        {
            if (value.ToString().Length >= 3)
            {
                nombreEstudiante = value;
            }
        }
    }
    public int Carnet
    {
        get { return carnet; }
        set 
        {
            if (value.ToString().Length == 5)
            {
                carnet = value;
            }
        }
    }
    public string Carrera
    {
        get { return carrera; }
        set 
        {
            if (value.Length > 5)
            {
                carrera = value;
            }
        }
    }
    public string EquipoPrestado
    {
        get { return equipoPrestado; }
        set 
        {
            if (value.Length > 3)
            {
                equipoPrestado = value;
            }
        }
    }
    public int Cantidad
    {
        get { return cantidad; }
        set 
        {
            if (value > 0)
            {
                cantidad = value;
            }
        }
    }
    public bool EstadoPrestamo
        {
        get { return estadoPrestamo; }
        set 
        { estadoPrestamo = value; }
    }

    public Control(int CodigoPrestamo, string NombreEstudiante, int Carnet, string Carrera, string EquipoPrestado, int Cantidad, bool EstadoPrestamo)
    { 
        this.CodigoPrestamo = CodigoPrestamo;
        this.NombreEstudiante = NombreEstudiante;
        this.Carnet = Carnet;
        this.Carrera = Carrera;
        this.EquipoPrestado = EquipoPrestado;
        this.Cantidad = Cantidad;
        this.EstadoPrestamo = EstadoPrestamo;
    }

    public string ExtraerDatos()
    {
        return "Código del préstamo: " + codigoPrestamo + Environment.NewLine + "Nombre del estudiante: " + nombreEstudiante + Environment.NewLine +
               "Carnet: " + carnet + Environment.NewLine + "Carrera: " + carrera + Environment.NewLine + 
               "Equipo prestado: " + equipoPrestado + Environment.NewLine + "Cantidad: " + cantidad + Environment.NewLine +
               "Estado del préstamo: " + estadoPrestamo + Environment.NewLine + "---------------------------------" + Environment.NewLine;
    }

    public void GuardarDatos(string ruta)
    {
        File.AppendAllText(ruta, ExtraerDatos());
    }
}
