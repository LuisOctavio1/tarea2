namespace ConsoleApp1;

public class ControlProductos
{
    private List<Producto> productos;

    public ControlProductos()
    {
        productos = new List<Producto>();
    }

    public bool agregarProducto(Producto producto)
    {
        if (productos.FirstOrDefault(u => u.Id == producto.Id) == null)
        {
            productos.Add(producto);
            productos = productos.OrderBy(u => u.Ventas).ToList();
            return true;
        }

        return false;

    }

    public bool quitarProducto(int id)
    {
        Producto? producto = productos.FirstOrDefault(u => u.Id == id);
        if ( producto!= null)
        {
            productos.Remove(producto);
            return true;
        }

        return false;
    }

    public void imprimirProductos()
    {
        foreach (Producto producto in productos)
        {
            Console.WriteLine("------------------");
            Console.WriteLine(producto.ToString());
        }
    }

    public void imprimirProductosMasVendidos()
    {
        int numero = productos.Count/4;
        int cuenta = 0;
        foreach (Producto producto in productos)
        {
            if (cuenta <= numero)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(producto.ToString());
            }
            else
            {
                break;
            }
            cuenta++;
        }
    }
    
    public void imprimirProductosMenosVendidos()
    {
        int numero = productos.Count - productos.Count/4;
        Console.WriteLine(numero);
        int cuenta = 0;
        foreach (Producto producto in productos)
        {
            cuenta++;
            if (cuenta >= numero)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(producto.ToString());
            }
            
        }
    }

}