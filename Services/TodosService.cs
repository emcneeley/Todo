using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Services;

public class TodosService
{

    private readonly TodosRepository _repo;
    public TodosService(TodosRepository repo)
    {
        _repo = repo;
    }

    public List<Chore> GetAllTodos()
    {
        List<Chore> chores = _repo.GetAllTodos();
        return chores;
    }

    internal Chore CreateTodo(Chore choreData)
    {
        Chore chore = _repo.CreateTodo(choreData);
        return chore;
    }


    internal Chore Updatetodo(Chore updateData)
    {
        Chore original = _repo.GetById(updateData.Id);
        if (original == null) throw new Exception($"No Chore at Id: {updateData.Id}");
        original.Name = updateData.Name != null ? updateData.Name : original.Name;
        _repo.UpdateTodo(updateData);
        return updateData;
    }
    internal string RemoveTodo(int choreId)
    {
        Chore chore = _repo.GetById(choreId);
        if (chore == null) throw new Exception($"No chore at id:{choreId}");
        _repo.RemoveTodo(choreId);
        return $"chore was depleted";
    }
}
