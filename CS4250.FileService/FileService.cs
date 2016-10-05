using System.IO;
using System.Linq;

namespace CS4250.FileService
{
    using System;
    using System.Collections.Generic;

    using CS4250.Domain;

    public class FileService : IFileService
    {
        private const string DocumentsFileName = @"documents.txt";

        private IList<string> documents;

        public FileService()
        {
            this.documents = this.GetAllDocuments();
        }

        public IList<string> GetDocuments()
        {
            return this.documents;
        }

        public Document Get(int id)
        {
            throw new System.NotImplementedException();
        }

        private IList<string> GetAllDocuments()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Data", DocumentsFileName);

            if (!File.Exists(path))
                throw new Exception($"Document data file {path} does not exist!");

            return File.ReadAllLines(path).ToList();
        }
    }
}