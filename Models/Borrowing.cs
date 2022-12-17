using System.ComponentModel.DataAnnotations;

namespace Danea_Gabriel_Lab2_r.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        public int? BookID { get; set; }
        public Book? Book { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        public static implicit operator Borrowing(List<Borrowing> v)
        {
            throw new NotImplementedException();
        }
    }
}
