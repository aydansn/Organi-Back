using MediatR;
using Microsoft.EntityFrameworkCore;
using Ogani.Domain.Models.DataContext;
using Ogani.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ogani.Domain.Business.BlogPostModule
{
    public class BlogPostGetAllQuery : IRequest<List<BlogPost>>
    {
        public class BlogPostGetAllQueryHandler : IRequestHandler<BlogPostGetAllQuery, List<BlogPost>>
        {
            private readonly OganiDbContext db;

            public BlogPostGetAllQueryHandler(OganiDbContext db)
            {
                this.db = db;
            }
            public async Task<List<BlogPost>> Handle(BlogPostGetAllQuery request, CancellationToken cancellationToken)
            {
              
                var data = await db.BlogPosts
                    .Where(bp => bp.PublishedDate != null)
                    .ToListAsync(cancellationToken);

                return data;

            }
        }
    }
}
