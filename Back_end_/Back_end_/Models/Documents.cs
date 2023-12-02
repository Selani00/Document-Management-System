using System.ComponentModel.DataAnnotations;

namespace Back_end_.Models
{
    public class Documents
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string DocType { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public DateTime Date { get; set; }
        public string Sender { get; set; }
        public string Reciver { get; set; }
        public string State { get; set; }
        public string Discription { get; set; }

    }
}
