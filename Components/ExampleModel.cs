using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace AI050LabAlternate.Components
{
    public class ExampleModel
    {
        [Required]
        [StringLength(5000, ErrorMessage = "User Message Cannot Exceed 5000 characters")]
        [Parameter]
        public string UserMessage { get; set; } = "";

        [Required]
        [StringLength(5000, ErrorMessage = "Assistant Message Cannot Exceed 5000 characters")]
        [Parameter]
        public string AssistantMessage { get; set; } = "";
    }
}
