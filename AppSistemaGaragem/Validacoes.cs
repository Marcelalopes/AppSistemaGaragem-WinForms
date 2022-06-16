using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaGaragem
{
    class Validacoes
    {
        public static bool garagemFechada()
        {            
            return DateTime.Now.Hour < 7 || DateTime.Now.Hour > 20;
        }        

        public static bool temVaga(List<Veiculo> lista)
        {
            return lista.Count <= 50;
        }
    }
}
