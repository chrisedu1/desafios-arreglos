using System;

namespace ListadoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] compras = {
                {50, 3, 5, 2, 10},
                {100, 120, 950, 800, 110},
                {50, 70, 90, 12, 8},
                {300, 150, 18, 200, 22},
                {800, 9, 7, 60, 10}
            };

            CalcularDescuentosYTotal(compras);
        }

        static void CalcularDescuentosYTotal(int[,] compras)
        {
            int numClientes = compras.GetLength(0);
            int numCompras = compras.GetLength(1);

            for (int cliente = 0; cliente < numClientes; cliente++)
            {
                int totalCompra = 0;
                for (int compra = 0; compra < numCompras; compra++)
                {
                    totalCompra += compras[cliente, compra];
                }

                double descuento = 0;
                if (totalCompra >= 100 && totalCompra <= 1000)
                {
                    descuento = totalCompra * 0.1;
                }
                else if (totalCompra > 1000)
                {
                    descuento = totalCompra * 0.2;
                }

                double totalConDescuento = totalCompra - descuento;

                Console.WriteLine($"Cliente {cliente + 1}: Total compra: {totalCompra}, Descuento: {descuento}, Total con descuento: {totalConDescuento}");
            }
        }
    }
}