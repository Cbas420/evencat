using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evencat.Models
{
    public static class EspaisOrm
    {

        public static List<Espais> Select()
        {
            List<Espais> _espais = (
                from u in Orm.bd.Espais
                select u
                ).ToList();
            return _espais;

        }

    }
}
