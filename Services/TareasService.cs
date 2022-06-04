using WebApi.Models;

namespace WebApi.Services
{
    public class TareasService:ITareas
    {
        TareasContext context;

        public TareasService(TareasContext dbcontext)
        {
            context=dbcontext;
        }

        public async Task Delete(Guid id)
        {
            var tareaActual=context.Tareas.Find(id);
            if(tareaActual!=null)
            {
                context.Remove(tareaActual);
                await context.SaveChangesAsync();
            }
        }

        public IEnumerable<Tarea> Get()
        {
            return context.Tareas;
        }

        public async Task Save(Tarea tarea)
        {
            context.Add(tarea);
            await context.SaveChangesAsync();
        }

        public async Task Update(Guid id, Tarea tarea)
        {
            var tareaActual=context.Tareas.Find(id);
            if(tareaActual!=null)
            {
                //tareaActual.Categoria=tarea.Categoria;
                tareaActual.CategoriaId=tarea.CategoriaId;
                tareaActual.Descripcion=tarea.Descripcion;
                tareaActual.PrioridadTarea=tarea.PrioridadTarea;
                tareaActual.Resumen=tarea.Resumen;
                tareaActual.Titulo=tarea.Titulo;

                await context.SaveChangesAsync();
            }
        }
    }
}