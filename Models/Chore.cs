using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models;



public class Chore
{
    public Chore(int id, string name, bool? isComplete)
    {
        Id = id;
        Name = name;
        IsComplete = isComplete;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public bool? IsComplete { get; set; }



}



