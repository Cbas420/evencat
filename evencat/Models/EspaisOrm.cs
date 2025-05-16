using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace evencat.Models
{
    public static class EspaisOrm
    {

        public static List<Espais> select()
        {
            List<Espais> _espais = (
                from u in Orm.bd.Espais
                select u
                ).ToList();
            return _espais;

        }

        public static List<Espais> searchSpecificSpaces(string nom, string cadiraFilter, string orderBy)
        {
            var query = Orm.bd.Espais.AsQueryable();

            if (!string.IsNullOrWhiteSpace(nom) && nom != "Space name")
            {
                query = query.Where(e => e.nom.Contains(nom));
            }

            switch (cadiraFilter)
            {
                case "Assigned seats":
                    query = query.Where(e => e.cadires_fixes != null);
                    break;
                case "Unassigned seats":
                    query = query.Where(e => e.cadires_fixes == null);
                    break;
                case "All":
                default:
                    // No filtro
                    break;
            }

            switch (orderBy)
            {
                case "ID":
                    query = query.OrderBy(e => e.espai_id);
                    break;
                case "Space name":
                    query = query.OrderBy(e => e.nom);
                    break;
                case "Location":
                    query = query.OrderBy(e => e.ubicacio);
                    break;
                case "Square meters":
                    query = query.OrderBy(e => e.metres_quadrats);
                    break;
                case "Assigned seats":
                    query = query.OrderBy(e => e.cadires_fixes);
                    break;
            }

            return query.ToList();
        }

        public static void insert(Espais espai)
        {

            Orm.bd.Espais.Add(espai);

            Orm.bd.SaveChanges();

        }

        public static void delete(Espais space)
        {
            Orm.bd.Espais.Remove(space);
            Orm.bd.SaveChanges();
        }

        public static void update(Espais updatedSpace)
        {
            var existingSpace = Orm.bd.Espais.Find(updatedSpace.espai_id);

            if (existingSpace != null)
            {
                existingSpace.nom = updatedSpace.nom;
                existingSpace.ubicacio = updatedSpace.ubicacio;
                existingSpace.metres_quadrats = updatedSpace.metres_quadrats;
                existingSpace.cadires_fixes = updatedSpace.cadires_fixes;

                Orm.bd.SaveChanges();
            }
        }

        public static List<Usuaris> searchSpecificUsers(string name, string role, string selectedOrder)
        {
            var query = Orm.bd.Usuaris.AsQueryable();

            if (!string.IsNullOrWhiteSpace(name) && name != "Space name")
            {
                query = query.Where(u => u.nom.Contains(name));
            }

            //Filtrar por rol (si no es "Todos")
            if (!string.IsNullOrWhiteSpace(role) && role != "Todos")
            {
                query = query.Where(u => u.rol == role);
            }

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
