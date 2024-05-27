using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand:IRequest<int>
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IApplicationDbContext _dbContext;
        public CreateProductCommandHandler(IApplicationDbContext context)
        {
            this._dbContext = context;
        }
        public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                ProductName = command.ProductName,
                Price = command.Price,
                Quantity = command.Quantity,
                created_at = DateTime.UtcNow,
                Description = command.Description,
            };
            _dbContext.Products.Add(entity);
            //await _dbContext.SaveChangesAsync(cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
