using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\francisco.holiveira3\source\repos\Agenda\Agenda\BancoDeDados\AgendaFinal.mdf;Integrated Security=True";
        }
    }
}
