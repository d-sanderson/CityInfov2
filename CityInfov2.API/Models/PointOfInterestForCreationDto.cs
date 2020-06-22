using System.ComponentModel.DataAnnotations;

namespace CityInfov2.API.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "You must provide a name value")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The field Description must be a string or array type with a max length of 200")]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
