namespace Service.Service;
using Domain.Models;

public class TeacherService
{
    List<Teacher> list=new List<Teacher>;

    public List<Teacher> GetTeacher(){
        return list;
    }

    public void Add(Teacher st){
        list.Add(st);
    }
    public void Update(Teacher st,int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
        list.Add(st);
    }
    public Teacher GetTeacherById(int id){
        return list[list.FindIndex(item => item.id==id)];
    }
    public void Delete(int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
    }
    public int Count(int id){
        return list.Count;
    }
}
