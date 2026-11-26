namespace Interface_Shapovalova.Models
{
    public class Messages
    {
        public string Message { get; set; }
        public System.DateTime Create { get; set; }
        public int IdUser { get; set; }
        public string ImagePath { get; set; }

        public Messages(string Message, System.DateTime Create, int IdUser, string ImagePath = null)
        {
            this.Message = Message;
            this.Create = Create;
            this.IdUser = IdUser;
            this.ImagePath = ImagePath;
        }
    }
}