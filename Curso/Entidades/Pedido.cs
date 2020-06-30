using System;
using Curso.Entidades.Enumerados;

namespace Curso.Entidades
{
    class Pedido
    {
        public int Identicicador { get; set; }
        public DateTime Momento { get; set; }
        public StatusDoPedido Status { get; set; }

        public override string ToString()
        {
            return Identicicador + ", " + Momento + ", " + Status;
        }
    }
}
