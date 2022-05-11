using Faturador.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faturador.Services
{
    public class FaturadorService
    {
        public void Faturar(FiltroFaturamento filtro)
        {
            Console.WriteLine($"Fatura: {filtro.Id} | Cliente: {filtro.CodigoCliente} | GERADA COM SUCESSO | Data Inicio Apuração: {filtro.DataInicioApuracao} - Data Fim Apuração: {filtro.DataFimApuracao}");
            
        }
    }
}
