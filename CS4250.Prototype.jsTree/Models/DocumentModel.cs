namespace CS4250.Prototype.jsTree.Models
{
    public class DocumentModel
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Action { get; set; }

        public string Controller { get; set; }

        public string DisplayName { get; set; }
        
        public bool Expand { get; set; }

        public string Image { get; set; }
        
        public string ToolTip { get; set; }
    }
}

// Id | ParentId | DisplayName | Expand | Image 