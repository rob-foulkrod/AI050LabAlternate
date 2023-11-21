using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;


namespace AI050LabAlternate.Labs.Lab02
{
    public class Lab02Model
    {
        [Required]
        [StringLength(5000, ErrorMessage = "System Message Cannot Exceed 5000 characters")]
        public string SystemMessage { get; set; }


        [StringLength(5000, ErrorMessage = "User Message Cannot Exceed 5000 characters")]
        public string UserMessage { get; set; }

        [StringLength(5000, ErrorMessage = "Assistant Message Cannot Exceed 5000 characters")]
        public string AssistantMessage { get; set; }


        [Required]
        [StringLength(5000, ErrorMessage = "Query Message Cannot Exceed 5000 characters")]
        public string QueryMessage { get; set; }


        [Required]
        [Range(0, 1, ErrorMessage = "Temperature must be a decimal between 0 and 1")]
        public float? Temperature { get; set; } = 0.7f;
        [Required]
        [Range(0, 1000, ErrorMessage = "MaxResponses must be a decimal between 0 and 1000")]
        public int MaxResponses { get; set; } = 800;

        public string AssistantSetup { get; set; }

        public bool IsAssistantHidden
        {
            get { return AssistantSetup != "fewShot"; }
        }

        public string ResponseMessage { get; set; }

    }
}
