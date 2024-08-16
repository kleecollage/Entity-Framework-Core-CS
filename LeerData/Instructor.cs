using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Grado { get; set; }
        public byte[]? FotoPerfil { get; set; }
        
        // la siguiente relacion se forma como consecuencia de una relacion n:n
        public ICollection<CursoInstructor>? CursoLink { get; set; } // RELACION 1:N
    }
}