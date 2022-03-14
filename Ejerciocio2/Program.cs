// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

ControlProductos controlProductos = new ControlProductos();
controlProductos.agregarProducto(new Producto("Foco", 100, "Electronica", 1, 150, 50));
controlProductos.agregarProducto(new Producto("Trapeador", 15, "Limpieza", 2, 300, 15));
controlProductos.agregarProducto(new Producto("Paleta payaso", 8, "Dulces", 3, 400, 100));
controlProductos.agregarProducto(new Producto("Microondas", 1500, "Electrodomesticos", 4, 30, 10));

MenuVentas menu = new MenuVentas(controlProductos);
menu.manejarMenu();