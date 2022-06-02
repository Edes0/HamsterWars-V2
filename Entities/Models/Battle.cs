
namespace Entities.Models
{
    public class Battle
    {
        public Battle()
        {
            Date = DateTime.Now;
        }

        public Guid Id { get; set; }

        public Guid Winner_ID { get; set; }

        public Guid Loser_ID { get; set; }

        public DateTime Date { get; set; }
    }
}
