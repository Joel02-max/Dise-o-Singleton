using System;
public class Configuracion
{
    // Instancia privada estática de la clase
    private static Configuracion _instancia;

    // Propiedades de configuración
    public string Parametro1 { get; set; }
    public int Parametro2 { get; set; }

    // Constructor privado para evitar la creación de instancias externas
    private Configuracion()
    {
        // Inicialización de parámetros
        Parametro1 = "Valor predeterminado";
        Parametro2 = 10;
    }

    // Método público estático para obtener la instancia única
    public static Configuracion ObtenerInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new Configuracion();
        }
        return _instancia;
    }
}

public class Program
{
    public static void Main()
    {
        // Acceder a la instancia única de Configuracion
        Configuracion config1 = Configuracion.ObtenerInstancia();
        config1.Parametro1 = "Nuevo Dato";

        // Obtener la misma instancia en otro lugar
        Configuracion config2 = Configuracion.ObtenerInstancia();
        Console.WriteLine(config2.Parametro1);  // Imprime "Nuevo valor"
    }
}
