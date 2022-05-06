using System;
using System.Collections.Generic;

namespace DevCandidateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Item item = new Item();
            var listacompra = new List<Item>();
            var shopping = new ShoppingCart();
            //Agregar Items
            for (var i = 1; i < 4; i++)
            {
                item.Nombre = "Masa";
                item.Cantidad = 2;
                item.Precio = 55;

                listacompra.Add(item);
            }
            shopping.ListaItems = listacompra;
            var TotaldeCompra = shopping.TotalCompra(listacompra);
            var CantidadItems = listacompra.Count;
            Console.WriteLine("Cantidad de Items: " + CantidadItems);
            foreach (var x in listacompra)
            {
                Console.WriteLine("Nombre de Item: " + x.Nombre + ". Cantidad: " + x.Cantidad + ". Precio: " + x.Precio);
            }

            Console.WriteLine("Total de Compra:" + TotaldeCompra);

        }
    }
}
public class Item
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public float Precio { get; set; }

}
public class ShoppingCart
{
    public string FechaCompra { get; set; }
    public List<Item> ListaItems { get; set; }
    public float TotalCompra(List<Item> lstitem)
    {
        float total = 0;
        foreach (var item in lstitem)
        {
            total += item.Precio * item.Cantidad;
        }
        return total;

    }
}
