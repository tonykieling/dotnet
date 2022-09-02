using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HPlusSport.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        // it checks whether the string received is empty (""), if so it retunw a string ---, or the original string
        private string CheckString(string str) => string.IsNullOrEmpty(str) ? "---" : str;

        public override string ToString()
        {
            //return ($"Id: {Id}, Sku: {Sku}, Name: {Name}, Desc: {(string.IsNullOrEmpty(Description) ? "-" : Description)}, $: {Price}, Avail: {IsAvailable}");
            return ($"Id: {Id}, Sku: {Sku}, Name: {Name}, Desc: {(CheckString(Description))}, $: {Price}, Avail: {IsAvailable}");
        }

        [Required]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }

    }
}
