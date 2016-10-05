namespace CS4250.Domain
{
    using System.Security.Permissions;

    public class Document
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string FileName { get; set; }


    }
}
