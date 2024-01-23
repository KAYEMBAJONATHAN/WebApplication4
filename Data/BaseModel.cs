namespace WebApplication4.Data
{
    public class BaseModel
    {
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;
        public int Id { get; set; }

    }
}
