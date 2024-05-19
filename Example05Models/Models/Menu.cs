namespace Example05Models.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public override string ToString() //url oluşturucu
        {
            return "/" + this.Controller + "/" + this.Action;
        }
    }
}
