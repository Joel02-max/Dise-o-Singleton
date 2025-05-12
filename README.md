# Diseño Singleton

# Patrón Singleton en C#

Este proyecto implementa el patrón de diseño Singleton en C#. El patrón Singleton asegura que una clase tenga una única instancia y proporciona un punto de acceso global a ella.

## Descripción

La clase `Configuracion` es un ejemplo de implementación del patrón Singleton. Esta clase contiene propiedades de configuración que pueden ser accedidas y modificadas a través de una única instancia. El constructor es privado para evitar la creación de instancias externas.

### Propiedades

- `Parametro1`: Una cadena que representa un parámetro de configuración.
- `Parametro2`: Un entero que representa otro parámetro de configuración.

## Uso

Para utilizar la clase `Configuracion`, simplemente llama al método estático `ObtenerInstancia()` para obtener la instancia única de la clase. Puedes modificar las propiedades de configuración como se muestra en el siguiente ejemplo:

```csharp
public class Program
{
    public static void Main()
    {
        // Acceder a la instancia única de Configuracion
        Configuracion config1 = Configuracion.ObtenerInstancia();
        config1.Parametro1 = "Nuevo Dato";

        // Obtener la misma instancia en otro lugar
        Configuracion config2 = Configuracion.ObtenerInstancia();
        Console.WriteLine(config2.Parametro1);  // Imprime "Nuevo Dato"
    }
}
```

## Instalación
Clona el repositorio:
bash
Run
Copy code
git clone https://github.com/tu_usuario/nombre_del_repositorio.git
Abre el proyecto en tu IDE favorito (por ejemplo, Visual Studio).
Compila y ejecuta el proyecto.


Contribuciones
Las contribuciones son bienvenidas. Si deseas contribuir, por favor sigue estos pasos:

Haz un fork del repositorio.
Crea una nueva rama (git checkout -b feature/nueva-caracteristica).
Realiza tus cambios y haz un commit (git commit -m 'Añadir nueva característica').
Haz push a la rama (git push origin feature/nueva-caracteristica).
Abre un Pull Request.
