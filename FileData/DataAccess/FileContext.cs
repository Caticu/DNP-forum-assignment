using System.Text.Json;
using Domain.Models;

namespace FileData.DataAccess;

public class FileContext
{
    private string forumFilePath = "forum.json";

    private Forum? forum;

    public Forum Forum
    {
        get
        {
            if (forum == null)
            {
                LoadData();
            }

            return forum!;
        }
    }

    public FileContext()
    {
        if (!File.Exists(forumFilePath))
        {
            Seed();
        }
    }

    private void Seed()
    {
        forum = new Forum();
        User[] users =
        {
            
            new User{
                UserName = "user", Password = "marian1234", City = "Horning", BirthDate = new DateTime(1997,07,25),Role = "User"
            },
           
        };
            /*Forum[] ts =
        {
            new Forum()
            {
                Description = "Testing something about subForum", Title = "Gaming"
            },
            new SubForum()
            {
                Description = "Gaming dot this", Title = "Testing second"
            }
        };*/


            forum.Users = users.ToList();
            //forum.SubForums = ts.ToList();
        SaveChanges();
    }

    public void SaveChanges()
    {
        string serialize = JsonSerializer.Serialize(Forum);
        File.WriteAllText(forumFilePath, serialize);
        forum = null;
    }

    private void LoadData()
    {
        string content = File.ReadAllText(forumFilePath);
        forum = JsonSerializer.Deserialize<Forum>(content);
    }
}