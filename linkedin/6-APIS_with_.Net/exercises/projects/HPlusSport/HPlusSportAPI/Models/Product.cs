﻿using System.Text.Json.Serialization;

namespace HPlusSportAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool isAvailable { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }

    }
}
