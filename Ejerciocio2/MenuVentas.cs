namespace ConsoleApp1;

public class MenuVentas
{
    private ControlProductos controlProductos;

    public MenuVentas(ControlProductos controlProductos)
    {
        this.controlProductos = controlProductos;
    }

    private void imprimirMenu()
    {
        Console.WriteLine("Bienvenido, ingresa la opcion que desees \n" +
                          "1. Agregar Producto \n" +
                          "2. Quitar Productos \n" +
                          "3. Listar productos \n" +
                          "4. Productos mas vendidos \n" +
                          "5. Productos menos vendidos \n" +
                          "6. Salir");
    }

    public void manejarMenu()
    {
        int opcion = 0;
        do
        {
            imprimirMenu();
        } while (!validarMenu(6,ref opcion));

        switch (opcion)
        {
            case 1:
                agregarProducto();
                break;
            case 2:
                quitarPorducto();
                break;
            case 3:
                listarProductos();
                break;
            case 4:
                listarProductosMasVendidos();
                break;
            case 5:
                listarProductosMenosVendidos();
                break;
            case 6:
                break;
        }
    }

    private void agregarProducto()
    {
        Console.WriteLine("Ingresa el nombre");
        String nombre = Console.ReadLine();
        Console.WriteLine("Ingresa el precio(numero mayor a 0)");
        int precio = 0;
        validarNumero(ref precio,1);
        Console.WriteLine("Ingresa la categoria");
        String categoria = Console.ReadLine();
        Console.WriteLine("Ingresa el id(numero mayor a 0)");
        int id = 0;
        validarNumero(ref id,1);
        Console.WriteLine("Ingresa el numero de ventas (numero mayor o igual a 0)");
        int ventas = 0;
        validarNumero(ref ventas,0);
        Console.WriteLine("Ingresa la cantidad disponible (numero mayor o igual a 0)");
        int cantidad = 0;
        validarNumero(ref cantidad,0);
        Producto producto = new Producto(nombre, precio, categoria, id, ventas, cantidad);
        if (controlProductos.agregarProducto(producto))
        {
            Console.WriteLine("El producto se agrego correctamente\n" +
                              "Presiona enter para continuar");
            Console.ReadLine();
            Console.Clear();
            manejarMenu();
        }
        else
        {
            Console.WriteLine("El producto no se agrego (id repetido)\n" +
                              "Presiona enter para continuar");
            Console.ReadLine();
            Console.Clear();
            manejarMenu();

        }
    }

    private void quitarPorducto()
    {
        Console.WriteLine("Ingresa el id(numero mayor a 0)");
        int id = 0;
        validarNumero(ref id,1);
        if (controlProductos.quitarProducto(id))
        {
            Console.WriteLine("Se quito el producto correctamente\n" + 
                "Presiona enter para continuar");
            Console.ReadLine();
            Console.Clear();
            manejarMenu();
        }
        else
        {
            Console.WriteLine("No se encontro el producto\n" +
                              "Presiona enter para continuar");
            Console.ReadLine();
            Console.Clear();
            manejarMenu();
        }
    }
    private  bool validarMenu(int opciones, ref int opcionSeleccionada)
    {
        int n;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            if (n <= opciones && n > 0)
            {
                opcionSeleccionada = n;
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opcion invalida");
                return false;
            }
                
        }
        Console.Clear();
        Console.WriteLine("Opcion invalida");
        return false;
    }
    
    private void validarNumero(ref int numero, int minimo)
    {
        while(!int.TryParse(Console.ReadLine(), out numero) && numero >= minimo) 
        { 
            Console.WriteLine("Elemento invalido");
        }
    }

    private void listarProductos()
    {
        controlProductos.imprimirProductos();
        Console.WriteLine("Presione enter para coninuar");
        Console.ReadLine();
        Console.Clear();
        manejarMenu();
    }

    private void listarProductosMasVendidos()
    {
        controlProductos.imprimirProductosMasVendidos();
        Console.WriteLine("Presione enter para coninuar");
        Console.ReadLine();
        Console.Clear();
        manejarMenu();
    }
    
    private void listarProductosMenosVendidos()
    {
        controlProductos.imprimirProductosMenosVendidos();
        Console.WriteLine("Presione enter para coninuar");
        Console.ReadLine();
        Console.Clear();
        manejarMenu();
    }
    
    
}
