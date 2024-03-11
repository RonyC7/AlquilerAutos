using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    public static class RepositorioDatos
    {
        public static Dictionary<string, List<string>> ClientesVehiculosAlquilados { get; } = new Dictionary<string, List<string>>();
    }

}
