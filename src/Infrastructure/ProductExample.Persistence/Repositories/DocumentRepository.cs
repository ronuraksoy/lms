using Lms.Application.Features.Document.Queries.GetDocumentPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class DocumentRepository : AAuditableRepository<Document, ApplicationDbContext>, IDocumentRepository
    {
        public DocumentRepository(ApplicationDbContext dbContext, ILogger<Document> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Document>> GetPagedList(GetDocumentPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
