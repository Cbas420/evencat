using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evencat.Models
{
    public static class ReservesOrm
    {
        public static List<Reserves> select()
        {
            var _reserves = (
                from r in Orm.bd.Reserves
                select r
            ).ToList();

            return _reserves;
        }

        public static void delete(Reserves reserva)
        {
            Orm.bd.Reserves.Remove(reserva);
            Orm.bd.SaveChanges();
        }

        public static List<Reserves> searchByUserName(string name)
        {
            var reserves = (
                from r in Orm.bd.Reserves
                join u in Orm.bd.Usuaris on r.usuari_id equals u.usuari_id
                where u.nom.Contains(name)
                select r
            ).ToList();

            return reserves;
        }

        public static List<Reserves> selectForOrganitzador(int organitzadorId)
        {
            return (
                from r in Orm.bd.Reserves
                join e in Orm.bd.Esdeveniments on r.event_id equals e.event_id
                where e.organitzador_id == organitzadorId
                select r
            ).ToList();
        }
    }
}