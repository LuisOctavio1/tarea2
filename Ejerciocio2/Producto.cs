namespace ConsoleApp1;

public class Producto
{
    private String nombre;
    private int precio;
    private String categoria;
    private double id;
    private int ventas;
    private int cantidadDisponible;

    public Producto(string nombre, int precio, string categoria, int id, int ventas, int cantidadDisponible)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.categoria = categoria;
        this.id = id;
        this.ventas = ventas;
        this.cantidadDisponible = cantidadDisponible;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Precio
    {
        get => precio;
        set => precio = value;
    }

    public string Categoria
    {
        get => categoria;
        set => categoria = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Id
    {
        get => id;
        set => id = value;
    }

    public int Ventas
    {
        get => ventas;
        set => ventas = value;
    }

    public int CantidadDisponible
    {
        get => cantidadDisponible;
        set => cantidadDisponible = value;
    }

    public String ToString()
    {
        String cadena = "Nombre: " + nombre + "\n" +
                        "Precio: " + precio + "\n" +
                        "Categoria: " + categoria + "\n" +
                        "Id: " + id + "\n" +
                        "Ventas: " + ventas + "\n" +
                        "Cantidad disponible: " + cantidadDisponible;
        return cadena;
    }
}