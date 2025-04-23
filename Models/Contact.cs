using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        public DateTime DateAdded { get; set; }
        public string Slug => Firstname?.Replace(' ', '-').ToLower()+ "-" + Lastname?.Replace(' ', '-').ToLower();
    }
}
