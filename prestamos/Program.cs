using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        set { nombreEstudiante = value; }
    }
    public int Carnet
    {
        get { return carnet; }
        set { carnet = value; }
    }
    public string Carrera
    {
        get { return carrera; }
        set { carrera = value; }
    }
    public string EquipoPrestado
    {
        get { return equipoPrestado; }
        set { equipoPrestado = value; }
    }
    public int Cantidad
    {
        get { return cantidad; }
        set { cantidad = value; }
    }
    public bool EstadoPrestamo
        {
        get { return estadoPrestamo; }
        set { estadoPrestamo = value; }
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
