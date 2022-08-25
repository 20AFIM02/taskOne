namespace Service.Service;
using Domain.Models;

public class PostService
{
    List<Post> list=new List<Post>();

    public List<Post> GetPost(){
        return list;
    }

    public void Add(Post st){
        list.Add(st);
    }
    public void Update(Post st,int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
        list.Add(st);
    }
    public Post GetPostById(int id){
        return list[list.FindIndex(item => item.id==id)];
    }
    public void Delete(int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
    }
    public int Count(int id){
        return list.Count;
    }
}
