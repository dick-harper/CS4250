namespace CS4250.Domain
{
    using System.Security.Permissions;

    public class Document
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string Path { get; set; }

        public string FileName { get; set; }
    }
}