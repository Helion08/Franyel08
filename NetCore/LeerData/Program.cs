using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Linq;

using System;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaLibrosContext())
            {
                
                var autorDEL = db.Autor.Single(x => x.AutorId == 7);

                if (autorDEL != null)
                {
                    db.Remove(autorDEL);
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine($"El estado de transaccion es ===> {estadoTransaccion}");
                }

                var autoresLeer = db.Autor;
                foreach (var item in autoresLeer)
                {
                    Console.WriteLine($"El autor es {item.Nombre}");
                }
                
                
            }
        }
    }
}
