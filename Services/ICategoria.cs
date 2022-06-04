using WebApi.Models;

namespace WebApi.Services
{
    public interface ICategoria
    {
         IEnumerable<Categoria> Get();
         Task Save(Categoria categoria);
         Task Update(Guid id,Categoria categoria);
         Task Delete(Guid id);
    }
}