using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WrestlingResultsAPI.Controllers
{
    public class Person
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default;
        public Guid PublicId { get; set; } = new Guid();
        public string Firstnames { get; set; } = "";
        public string Surname { get; set; } = "";
        public DateTime? DateOfBirth { get; set; }
        public bool Gender { get; set; } = true; 
        public Nation? Nationality { get; set; }
        public string? Notes { get; set; }
 }
}