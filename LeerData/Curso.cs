using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Precio? PrecioPromocion { get; set; } // RELACION 1:1
        public ICollection<Comentario>? ComentarioLista { get; set; } // RELACION 1:n
        
        // la siguiente relacion se forma como consecuencia de una relacion n:n
        public ICollection<CursoInstructor>? InstructorLink { get; set; } // RELACION 1:N
    }
}