namespace MVC1.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int MyProperty { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; } //1 blogpost can have so many tags

    }
}
