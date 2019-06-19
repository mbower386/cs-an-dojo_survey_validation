using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models
{
    public class Survey
    {
        [Required]
        [MinLength (2, ErrorMessage = "Name must have at least 3 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose a location.")]
        [MinLength (2, ErrorMessage = "Are you trying to hack me, bro?")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please choose a language.")]
        [MinLength (2, ErrorMessage = "Are you trying to hack me, bro?")]
        public string Language { get; set; }

        [MaxLength (20, ErrorMessage = "Comment cannot be longer than 20 characters.")]
        public string Comment { get; set; }

    }
}