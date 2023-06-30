using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Repositories;

public class TodosRepository
{
    private List<Chore> dbChores;

    public TodosRepository()
    {
        this.dbChores = new List<Chore> { };
        dbChores.Add(new Chore(1, "Cook Dinner", false));
        dbChores.Add(new Chore(2, "Wash Dishes", true));
        dbChores.Add(new Chore(3, "wash dog", false));
    }


    internal List<Chore> GetAllTodos()
    {
        return dbChores;
    }

    internal Chore CreateTodo(Chore choreData)
    {
        int lastId = dbChores[dbChores.Count - 1].Id;
        choreData.Id = lastId + 1;

        dbChores.Add(choreData);
        return choreData;
    }
    internal Chore GetById(int choreId)
    {
        Chore chore = dbChores.Find(c => c.Id == choreId);
        return chore;
    }
    internal void UpdateTodo(Chore updateData)
    {
        Chore chore = GetById(updateData.Id);
        chore = updateData;
    }

    internal void RemoveTodo(int choreId)
    {
        Chore chore = dbChores.Find(c => c.Id == choreId);
        dbChores.Remove(chore);
    }
}
