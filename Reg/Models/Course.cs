using System.Collections.Generic;

namespace Reg.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int CourseId {get; set;}

    public string Description {get; set;}

    public string Title {get; set;}

    public virtual ICollection<CourseStudent> JoinEntities {get; set;}
  }
}