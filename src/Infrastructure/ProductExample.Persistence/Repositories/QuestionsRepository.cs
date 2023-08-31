﻿using Lms.Application.Features.Questions.Queries.GetQuestionPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class QuestionsRepository : AAuditableRepository<Questions, ApplicationDbContext>, IQuestionsRepository
    {
        public QuestionsRepository(ApplicationDbContext dbContext, ILogger<Questions> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Questions>> GetPagedList(GetQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
