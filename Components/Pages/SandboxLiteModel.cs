using AI050LabAlternate.Components;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;


namespace AI050LabAlternate.Components.Pages
{
    public class SandboxLiteModel
    {

        public SandboxLiteModel()
        {
            SystemMessage = "";
            QueryMessage = "";
            Temperature = 0.7f;
            MaxResponses = 800;
            ResponseMessage = "";
            Examples = new List<ExampleModel>();
        }


        [Required]
        [StringLength(5000, ErrorMessage = "System Message Cannot Exceed 5000 characters")]
        public string SystemMessage { get; set; }

        public bool HasExamples { get { return Examples.Count > 0; } }

        public List<ExampleModel> Examples { get; set; }


        [Required]
        [StringLength(5000, ErrorMessage = "Query Message Cannot Exceed 5000 characters")]
        public string QueryMessage { get; set; }


        [Required]
        [Range(0, 1, ErrorMessage = "Temperature must be a decimal between 0 and 1")]
        public float? Temperature { get; set; } = 0.7f;
        [Required]
        [Range(0, 1000, ErrorMessage = "MaxResponses must be a decimal between 0 and 1000")]
        public int MaxResponses { get; set; } = 800;


        public void AddExample()
        {
            Examples.Add(new ExampleModel());
        }

        public void RemoveExample()
        {
            if (Examples.Count > 0)
            {
                Examples.RemoveAt(Examples.Count - 1);
            }
        }

        public bool CustomDataSourceConfigured { get; set; }

        public bool UseCustomDataSource { get; set; }

        public string ResponseMessage { get; set; }

    }
}
