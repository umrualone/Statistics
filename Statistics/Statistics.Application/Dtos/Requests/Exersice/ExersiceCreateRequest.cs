using System.ComponentModel.DataAnnotations;

namespace Statistics.Application.Dtos.Requests.Exersice
{
    public class ExersiceCreateRequest
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Sd")]
        public string Title { get; set; }

        [Required]
        public int Count { get; set; }
    }
}
