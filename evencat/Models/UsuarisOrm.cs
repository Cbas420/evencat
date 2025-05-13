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

        public static List<Usuaris> searchSpecificUsers(string name, string role, string selectedOrder)
        {
            var query = Orm.bd.Usuaris.AsQueryable();

            //Filtrar por nombre si tiene un valor válido y no es el texto predeterminado
            if (!string.IsNullOrWhiteSpace(name) && name != "Space name")
            {
                query = query.Where(u => u.nom.Contains(name));
            }

            //Filtrar por rol (si no es "Todos")
            if (!string.IsNullOrWhiteSpace(role) && role != "Todos")
            {
                query = query.Where(u => u.rol == role);
            }

            //Aplicar el orden seleccionado
            switch (selectedOrder)
            {
                case "ID":
                    query = query.OrderBy(u => u.usuari_id);
                    break;
                case "Name":
                    query = query.OrderBy(u => u.nom);
                    break;
                case "Role":
                    query = query.OrderBy(u => u.rol);
                    break;
                case "Email":
                    query = query.OrderBy(u => u.email);
                    break;
                default:
                    query = query.OrderBy(u => u.usuari_id);
                    break;
            }

            //Finalmente, devolvemos la lista completa
            return query.ToList();
        }



    }
}
