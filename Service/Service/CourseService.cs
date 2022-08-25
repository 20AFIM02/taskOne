namespace Service.Service;
using Domain.Models;

public class CourseService
{
    List<Course> list=new List<Course>();

    public List<Course> GetCourse(){
        return list;
    }

    public void Add(Course st){
        list.Add(st);
    }
    public void Update(Course st,int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
        list.Add(st);
    }
    public Course GetCourseById(int id){
        return list[list.FindIndex(item => item.id==id)];
    }
    public void Delete(int id){
        list.Remove(list[list.FindIndex(item => item.id==id)]);
    }
    public int Count(int id){
        return list.Count;
    }
}
