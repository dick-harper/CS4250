using System.IO;
using System.Linq;

namespace CS4250.FileService
{
    using System.Collections.Generic;

    using CS4250.Domain;

    public class FileService : IFileService
    {
        private const string DocumentsFileName = "documents.txt";

        private IList<string> documents;

        public FileService()
        {
            this.documents = this.GetDocuments();
        }

        private IList<string> GetDocuments()
        {
            return File.ReadAllLines(DocumentsFileName).ToList();
        }

        public Document Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Document> GetByCategory(string category)
        {
            throw new System.NotImplementedException();
        }
    }
}