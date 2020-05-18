using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreMVCCRUD.Models;

namespace Asp.NetCoreMVCCRUD.Data
{
    public class DbInicializador
    {
        public static void Initialize(AspNetCoreMVCCRUDContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si existen registros en la tabla categoría
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre= "Programación", Descripcion= "Curso de programación", Estado= true},
                new Categoria{Nombre= "Diseño Grafico", Descripcion= "Curso de Diseño Grafico", Estado= true}
            };

            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
