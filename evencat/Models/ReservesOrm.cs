using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evencat.Models
{
    public static class ReservesOrm
    {
        public static List<Reserves> Select()
        {
            var _reserves = (
                from r in Orm.bd.Reserves
                select r
            ).ToList();

            return _reserves;
        }

        public static void Insert(Reserves reserva)
        {
            Orm.bd.Reserves.Add(reserva);
            Orm.bd.SaveChanges();
        }

        public static void Delete(Reserves reserva)
        {
            Orm.bd.Reserves.Remove(reserva);
            Orm.bd.SaveChanges();
        }
    }
}