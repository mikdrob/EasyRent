using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace Domain
{
    public class Property : BaseEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = default!;
        
        public int Price { get; set; } = default!;
        
        public string? Description { get; set; }

        public int BedroomCount { get; set; } = default!;

        public int? TenantsCount { get; set; }
        
        
        public ICollection<PropertyReview>? PropertyReviews { get; set; }
        public ICollection<PropertyPicture>? PropertyPictures { get; set; }
        public ICollection<ErApplication>? ErApplications { get; set; }
        
        public Guid ErUserId { get; set; }
        public ErUser? ErUser { get; set; }

        public Guid PropertyTypeId { get; set; }
        public PropertyType? PropertyType { get; set; }


    }
}