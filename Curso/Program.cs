using System;
using Curso.Entidades;
using Curso.Entidades.Enumerados;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Identicicador = 1290,
                Momento = DateTime.Now,
                Status = StatusDoPedido.PagamentoPendente
            };
            
            Console.WriteLine(pedido);

            //Convertendo tipo enumerados para string
            string texto = StatusDoPedido.PagamentoPendente.ToString();

            //Convertendo string para enumerados

            StatusDoPedido informa = Enum.Parse<StatusDoPedido>("Entregue");

            Console.WriteLine(texto);
            Console.WriteLine(informa);

        }
    }
}
