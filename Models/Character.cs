namespace AvatarApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Element { get; set; }
        public required string Nation { get; set; }
        public required string ImageUrl { get; set; }
    }
}