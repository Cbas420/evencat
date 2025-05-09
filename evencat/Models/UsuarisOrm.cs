using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evencat.Models
{
    public static class UsuarisOrm
    {

        public static List<Usuaris> Select() 
        {  
            List<Usuaris> _usuaris = (
                from u in Orm.bd.Usuaris
                select u
                ).ToList();
            return _usuaris;
        }

        public static void Insert(Usuaris user) {

            Orm.bd.Usuaris.Add(user);

            Orm.bd.SaveChanges();
        
        }



    }
}
