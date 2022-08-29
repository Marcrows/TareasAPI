using webapi.Models;

namespace webapi.Services; 
public class CategoriaService : ICategoriaService
{
    TareasContext context;

    public CategoriaService(TareasContext dbcontext)
    {
        context = dbcontext;
    }

    public IEnumerable<Categoria> Get()
    {
        return context.Categorias;
    }

    public async Task Save(Categoria CategoriaObject)
    {
        context.Add(CategoriaObject);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid Id, Categoria CategoriaObject)
    {
        var CategoriaActual = context.Categorias.Find(Id);

        if (CategoriaActual != null)
        {
            CategoriaActual.Nombre = CategoriaObject.Nombre;
            CategoriaActual.Descripcion = CategoriaObject.Descripcion;
            CategoriaActual.Peso = CategoriaObject.Peso;

            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid Id)
    {
        var CategoriaActual = context.Categorias.Find(Id);

        if (CategoriaActual != null)
        {
            context.Remove(CategoriaActual);

            await context.SaveChangesAsync();
        }
    }
}

public interface ICategoriaService
{
    IEnumerable<Categoria> Get();
    Task Save(Categoria CategoriaObject);
    Task Update(Guid Id, Categoria CategoriaObject);
    Task Delete(Guid Id);
}