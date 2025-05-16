using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace evencat.Models
{
    public static class EsdevenimentsOrm
    {

        public static List<Esdeveniments> select()
        {
            List<Esdeveniments> _esdeveniments = (
                from e in Orm.bd.Esdeveniments
                select e
                ).ToList();
            return _esdeveniments;
        }

        public static List<Esdeveniments> searchSpecificEvents(string name, string status, string selectedOrder)
        {
            var query = Orm.bd.Esdeveniments.AsQueryable();

            // Filtrar por nombre
            if (!string.IsNullOrWhiteSpace(name) && name != "Event name")
            {
                query = query.Where(e => e.nom.Contains(name));
            }

            // Filtrar por estado (si no es "Todos")
            if (!string.IsNullOrWhiteSpace(status) && status != "Todos")
            {
                query = query.Where(e => e.estat == status);
            }

            // Ordenar por
            switch (selectedOrder)
            {
                case "ID":
                    query = query.OrderBy(e => e.event_id);
                    break;
                case "Name":
                    query = query.OrderBy(e => e.nom);
                    break;
                default:
                    query = query.OrderBy(e => e.event_id);
                    break;
            }

            return query.ToList();
        }

        public static void update(Esdeveniments updatedEvent)
        {
            Esdeveniments existingEvent = Orm.bd.Esdeveniments.Find(updatedEvent.event_id);

            if (existingEvent != null)
            {
                existingEvent.nom = updatedEvent.nom;
                existingEvent.descripcio = updatedEvent.descripcio;
                existingEvent.imatge_promocional_url = updatedEvent.imatge_promocional_url;
                existingEvent.estat = updatedEvent.estat;

                Orm.bd.SaveChanges();
            }
        }

        public static void insert(Esdeveniments e)
        {
            Orm.bd.Esdeveniments.Add(e);
            Orm.bd.SaveChanges();
        }

    }
}
