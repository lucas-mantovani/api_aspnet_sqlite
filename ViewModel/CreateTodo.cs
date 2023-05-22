using System.ComponentModel.DataAnnotations;

namespace api_aspnet.ViewModel
{
    public class CreateTarefa
    {
        [Required]
        public string Title { get; set; }
    }
}