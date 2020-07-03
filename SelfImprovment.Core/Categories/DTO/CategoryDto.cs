using Newtonsoft.Json;

namespace SelfImprovment.Core.Categories.DTO
{
    public class CategoryDto
    {
        [JsonProperty(PropertyName = "categoryId")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "categoryName")]
        public int Name { get; set; }
    }
}
