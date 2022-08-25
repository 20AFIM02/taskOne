namespace Domain.Models;

class Course{
    public int id {get;set}
    public string Title {get;set}
    public string Description {get;set}
    public decimal Free {get;set}
    public bool HasDiscount {get;set}
}