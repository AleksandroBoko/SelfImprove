using SelfImprovment.Core.Courses.DTO;
using System.Collections.Generic;

namespace SelfImprovment.Core.Courses.Interfaces
{
    public interface ICoursesRepository
    {
        CourseDto GetCourseById(int id);
        IEnumerable<CourseDto> GetCourses();
    }
}
