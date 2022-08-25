namespace Domain.Models;

class Post{
    public int id {get;set}
    public string Title {get;set}
    public string Description {get;set}
    public int Vote {get;set}
    public DateTime CreatedAt {get;set}
}