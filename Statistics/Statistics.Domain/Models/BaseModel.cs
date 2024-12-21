namespace Statistics.Domain.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
