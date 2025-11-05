using System;
using System.Collections.Generic;




namespace LeerData
{
    public class Libro
    {
        public int LibroId {get;set;}

        public string Titulo {get;set;}

        public string Descripcion {get;set;}

        public System.DateTime FechaDePublicacion {get;set;}

        public Precio PrecioPromocion {get;set;}

        public ICollection<Comentario> ComentarioLista {get;set;}

        public ICollection<LibroAutor> AutorLink {get;set;}

    }
}