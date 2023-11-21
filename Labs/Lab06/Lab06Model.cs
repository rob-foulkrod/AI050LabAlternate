﻿using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;


namespace AI050LabAlternate.Labs.Lab06
{
    public class Lab06Model
    {
        [StringLength(5000, ErrorMessage = "System Message Cannot Exceed 5000 characters")]
        public string SystemMessage { get; set; }


        [StringLength(5000, ErrorMessage = "User Message Cannot Exceed 5000 characters")]
        public string UserMessage { get; set; }



        [Required]
        [StringLength(5000, ErrorMessage = "Query Message Cannot Exceed 5000 characters")]
        public string QueryMessage { get; set; }


        [Required]
        [Range(0, 1, ErrorMessage = "Temperature must be a decimal between 0 and 1")]
        public float? Temperature { get; set; } = 0.7f;
        [Required]
        [Range(0, 1000, ErrorMessage = "MaxResponses must be a decimal between 0 and 1000")]
        public int MaxResponses { get; set; } = 800;

        public bool UseCustomDataSource { get; set; }

        public string ResponseMessage { get; set; }

    }
}
