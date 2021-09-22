using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Domain.Models
{
    public abstract class BaseModel
    {

        protected BaseModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}
