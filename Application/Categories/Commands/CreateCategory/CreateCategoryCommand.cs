using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommands:IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommands, int>
    {
        private readonly IApplicationDbContext _dbContext;
        public CreateCategoryCommandHandler(IApplicationDbContext context)
        {
            this._dbContext = context;
        }
        public async Task<int> Handle(CreateCategoryCommands command, CancellationToken cancellationToken)
        {
            var entity = new Category
            {
                Name = command.Name,
                CreatedDate = DateTime.UtcNow,
                Description = command.Description,
            };
            _dbContext.Categories.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}

