using Danea_Gabriel_Lab2_r.Models;
namespace Danea_Gabriel_Lab2_r.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
