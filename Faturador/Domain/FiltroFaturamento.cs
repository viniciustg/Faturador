using System;
using System.Collections.Generic;

namespace Faturador.Domain
{
    public class FiltroFaturamento
    {
        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public DateTime DataInicioApuracao { get; set; }
        public DateTime DataFimApuracao { get; set; }
        public int TipoApuracao { get; set; }
        public int GerenciadoraId { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
