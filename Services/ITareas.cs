using WebApi.Models;
namespace WebApi.Services
{
    public interface ITareas
    {
         IEnumerable<Tarea> Get();
         Task Save(Tarea tarea);
         Task Update(Guid id,Tarea tarea);
         Task Delete(Guid id);
    }
}