using Back_end_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back_end_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly DocumentDbContext _documentDbContext;

        public DocumentsController(DocumentDbContext documentDbContext)
        {
            _documentDbContext = documentDbContext;
        }

        [HttpGet]
        [Route("GetDocument")]
        public async Task<IEnumerable<Documents>> GetDocument()
        {
            return await _documentDbContext.Documents.ToListAsync();
        }




        [HttpPost]
        [Route("AddDocument")]
        public async Task<Documents> AddDocument(Documents objDoc)
        {
            _documentDbContext.Documents.Add(objDoc);
            await _documentDbContext.SaveChangesAsync();
            return objDoc;
        }

        [HttpPatch]
        [Route("UpdateDocument/{id}")]
        public async Task<Documents> UpdateDocument(Documents objDoc)
        {
            _documentDbContext.Entry(objDoc).State = EntityState.Modified;
            await _documentDbContext.SaveChangesAsync();
            return objDoc;
        }

        [HttpDelete]
        [Route("DeleteDocument/{id}")]
        public bool DeleteDocument(int id)
        {
            bool a = false;
            var document = _documentDbContext.Documents.Find(id);
            if (document != null)
            {
                a = true;
                _documentDbContext.Entry(document).State = EntityState.Deleted;
                _documentDbContext.SaveChanges();

            }
            else
            {
                a = false;
            }
            return a;
        }

    }
}
