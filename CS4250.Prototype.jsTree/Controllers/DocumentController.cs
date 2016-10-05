using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS4250.Prototype.jsTree.Controllers
{
    using CS4250.FileService;
    using CS4250.Prototype.jsTree.Models;

    public class DocumentController : Controller
    {
        private readonly IFileService fileService;

        private IList<DocumentModel> model;

        public DocumentController()
        {
            this.fileService = new FileService();
            this.model = this.GetDocumentModel();
        }

        public ActionResult Index(int? documentId)
        {
            return View(this.model);
        }

        private IList<DocumentModel> GetDocumentModel()
        {
            var documentData = this.fileService.GetDocuments();

            this.model = new List<DocumentModel>();

            foreach (var line in documentData)
            {
                // Skip empty or comment lines.
                if (line.StartsWith("#") || string.IsNullOrEmpty(line))
                    continue;

                var data = line.Split('|');

                if (data.Length != 5) throw new Exception("Invalid data!");

                this.model.Add(new DocumentModel
                {
                    Action = "Index",
                    Controller = "Document",
                    DisplayName = data[2].Trim(),
                    Expand = bool.Parse(data[3]),
                    Id = int.Parse(data[0]),
                    Image = data[4],
                    ParentId = int.Parse(data[1]),
                    ToolTip = "test tooltip"
                });
            }
            
            return this.model;
        }
    }
}