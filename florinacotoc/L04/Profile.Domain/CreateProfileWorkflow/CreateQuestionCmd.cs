using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Question.Domain.CreateProfileWorkflow
{
    public struct CreateQuestionCmd
    {
        [Required]
        public string Title { get; private set; }
        public string Description { get; set; }
        [Required]
        public string Tag { get; private set; }

        public CreateQuestionCmd(string title, string description, string tag)
        {
            Title = title;
            Description = description;
            Tag = tag;
        }
    }
}
