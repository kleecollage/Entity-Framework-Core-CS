using System;
using Microsoft.EntityFrameworkCore;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            // LLAMADA A DATOS DE DB LOCAL
            // using (var db = new AppVentaCursosContext()){
            //     var cursos = db.Curso!.AsNoTracking();
            //     foreach(var curso in cursos) {
            //         Console.WriteLine(curso.Titulo + "-------" + curso.Descripcion);
            //     }
            // }

            // LLAMADA A DB CON RELACION 1:1
            // using (var db = new AppVentaCursosContext()) {
            //     var cursos = db.Curso!.Include(p => p.PrecioPromocion).AsNoTracking();
            //     foreach(var curso in cursos) {
            //         Console.WriteLine(curso.Titulo + "*******" + curso.PrecioPromocion?.PrecioActual);
            //     }
            // }

            // LLAMADA A DB CON RELACION 1:N
            // using (var db = new AppVentaCursosContext()) {
            //     var cursos = db.Curso!.Include(c => c.ComentarioLista).AsNoTracking();
            //     foreach(var curso in cursos) {
            //         Console.WriteLine(curso.Titulo);
            //         foreach(var comentario in curso.ComentarioLista) {
            //             Console.WriteLine(" ******* " + comentario.ComentarioTexto);
            //         }
            //     }
            // }

            // LLAMADA A DB CON RELACION N:N
            using (var db = new AppVentaCursosContext()) 
            {
                var cursos = db.Curso.Include(c => c.InstructorLink).ThenInclude(ci => ci.Instructor);
                foreach(var curso in cursos) {
                    Console.WriteLine(curso.Titulo);
                    foreach(var insLink in curso.InstructorLink) {
                        Console.WriteLine(" ******* " + insLink.Instructor.Nombre);
                    }
                }
            }
            
        }
    }
}
