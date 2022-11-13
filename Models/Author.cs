using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace Danea_Gabriel_Lab2_r.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
