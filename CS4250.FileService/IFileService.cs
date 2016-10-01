namespace CS4250.FileService
{
    using System.Collections;
    using System.Collections.Generic;

    using CS4250.Domain;

    public interface IFileService
    {
        Document Get(int id);
        IList<Document> GetByCategory(string category);
    }
}