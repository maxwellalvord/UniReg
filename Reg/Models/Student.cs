using System.Collections.Generic;

namespace Reg.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }
    public string Name {get; set;}
    public int StudentId {get; set;}
  
    public virtual ICollection<CourseStudent> JoinEntities {get; set;}
  }
}