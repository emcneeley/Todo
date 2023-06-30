namespace Todo.Controllers;

[ApiController]
[Route("api/todos")]
public class TodosController : ControllerBase
{
    private readonly TodosService _todosService;

    public TodosController(TodosService todosService)
    {
        _todosService = todosService;
    }

    [HttpGet("test")]

    public ActionResult<string> Test()
    {
        try
        {
            return Ok("Hey");
        }
        catch (SystemException error)
        {
            return BadRequest("I cant do that." + error.Message);
        }
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetAllTodos()
    {
        try
        {
            List<Chore> todos = _todosService.GetAllTodos();
            return Ok(todos);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> CreateTodo([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _todosService.CreateTodo(choreData);
            return Ok(chore);

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{choreId}")]
    public ActionResult<Chore> UpdateTodo(int choreId, [FromBody] Chore updateData)
    {
        try
        {
            updateData.Id = choreId;
            Chore chore = _todosService.Updatetodo(updateData);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{choreId}")]
    public ActionResult<string> RemoveTodo(int choreId)
    {
        try
        {
            string message = _todosService.RemoveTodo(choreId);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


}


