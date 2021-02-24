using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ErUserType
    {
        public Guid Id { get; set; }

        [MaxLength(32)] 
        public string UserType { get; set; } = default!;

        public ICollection<ErUser>? ErUsers { get; set; }
    }
}