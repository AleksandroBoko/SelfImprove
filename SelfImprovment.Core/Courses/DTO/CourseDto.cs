using Newtonsoft.Json;

namespace SelfImprovment.Core.Courses.DTO
{
    public class CourseDto
    {
        [JsonProperty(PropertyName = "courseId")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "courseName")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "courseDescription")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "categoryId")]
        public int CategoryId { get; set; }
    }
}
