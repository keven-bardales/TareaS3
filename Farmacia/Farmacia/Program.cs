using Farmacia.Modelos;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Medicina> medicinas = new List<Medicina>();

List<string> ingredientesList = new List<string> { "Ingrediente 1", "Ingrediente 2", "Ingrediente 3" };


ProductoPastilla p1 = new ProductoPastilla() {
    nombre = "Acetaminomen",
    precio = 100,
    fechaVencimiento = new DateTime(2023, 08, 26),
     ingredientes = ingredientesList,
     Gramos = 100,
     Color = "Azul",
     Presentacion = "Caja"
    };

medicinas.Add(p1);



List<string> ingredientesList2 = new List<string> { "Ingrediente 4", "Ingrediente 5", "Ingrediente 6" };

ProductoInyectado p2 = new ProductoInyectado()
{
    nombre = "Producto Inyectado",
    precio = 500,
    fechaVencimiento = new DateTime(2023, 05, 02),
    ingredientes = ingredientesList2,
    mlProducto = 50
};

medicinas.Add(p2);

List<string> ingredientesList3 = new List<string> { "Ingrediente 7", "Ingrediente 8", "Ingrediente 9" };

ProductoTomado p3 = new ProductoTomado()
{
    nombre = "Produto Tomado",
    precio = 800,
    fechaVencimiento = new DateTime(2024, 06, 20),
    ingredientes = ingredientesList3,
    nombreEnvase = "Nombre de envase",
    Flagcuchara = true
};

medicinas.Add(p3);

List<string> ingredientesList4 = new List<string> { "Ingrediente 10", "Ingrediente 11", "Ingrediente 12" };

ProductoTomado p4 = new ProductoTomado()
{
    nombre = "Produto Tomado Numero 2",
    precio = 800,
    fechaVencimiento = new DateTime(2024, 06, 20),
    ingredientes = ingredientesList4,
    nombreEnvase = "Nombre de envase",
    Flagcuchara = false
};

medicinas.Add(p4);


foreach (Medicina medicina in medicinas)
{
    Console.WriteLine(medicina.ToString());
}




