namespace CarWorkshop.MVC.Models
{
    public class About
    {
        private string title;
        private string description;
        private List<string> tags;

        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }

        public List<string> Tags { get {  return tags; } set { tags = value; } }
    }
}
