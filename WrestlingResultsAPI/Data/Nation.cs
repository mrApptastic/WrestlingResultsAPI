using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WrestlingResultsAPI.Controllers
{
    public class Nation
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default;
        public Guid PublicId { get; set; } = new Guid();
        public string Name { get; set; } = "";
     }
}