namespace Service.Service;
using Domain.Models;

public class StudentService
{
    private List<Student> list=new List<Student>();

    public List<Student> GetStudent(){
        return list;
    }
    public void Add(Student st){
        list.Add(st);
    }
    public void Update(Student st,int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
        list.Add(st);
    }
    public Student GetStudentById(int id){
        return list[list.FindIndex(item => item.id==id)];
    }
    public void Delete(int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
    }
    public int Count(int id){
        return list.Count;
    }
}
