namespace Domain.Models;

public class Post
{
    public string Id { get; set; }
    public  string Header { get; set; }
    public  string Body { get; set; }
   
    public  User WrittenBy { get; set; }
    public DateTime date_posted { get; set; }

    public Post()
    {
        Id = RandomIDGenerator.Generate(20);
        Header=String.Empty;
        Body=String.Empty;
        WrittenBy = new User();
        date_posted = new DateTime();
    }
}