using webapi.Models;

namespace webapi.Services; 

public class TareasService : ITareasService
{
    TareasContext context;

    public TareasService(TareasContext dbcontext)
    {
        context = dbcontext;
    }

    public IEnumerable<Tarea> Get()
    {
        return context.Tareas;
    }

    public async Task Save(Tarea TareaObject)
    {
        context.Add(TareaObject);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid Id, Tarea TareaObject)
    {
        var TareaActualizar = context.Tareas.Find(Id);

        if (TareaActualizar != null)
        {
            TareaActualizar.Titulo = TareaObject.Titulo;
            TareaActualizar.Descripcion = TareaObject.Descripcion;
            TareaActualizar.PrioridadTarea = TareaObject.PrioridadTarea;
            TareaActualizar.Categoria = TareaObject.Categoria;

            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid Id)
    {
        var TareaActualizar = context.Tareas.Find(Id);

        if (TareaActualizar != null)
        {
            context.Remove(TareaActualizar);

            await context.SaveChangesAsync();
        }
    }
}

public interface ITareasService
{
    IEnumerable<Tarea> Get();
    Task Save(Tarea TareaObject);
    Task Update(Guid Id, Tarea TareaObject);
    Task Delete(Guid Id);
}