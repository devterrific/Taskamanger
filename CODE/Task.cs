
public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }

   
    public Task(int id, string description)
    {
        Id = id;
        Description = description;
        Completed = false; 
    }
}
