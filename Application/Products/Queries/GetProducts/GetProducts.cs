using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Common.Mappings;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetProducts
{
    public class GetProducts : IRequest<PaginationList<ProductVm>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class GetProductsHandler : IRequestHandler<GetProducts, PaginationList<ProductVm>>
    {
        private readonly IApplicationDbContext _context;
        public GetProductsHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginationList<ProductVm>> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            var items = await _context.Products.Select(x => new ProductVm
            {
                ProductName = x.ProductName,
                Description = x.Description,
                Price = x.Price,
                Quantity = x.Quantity,


            }).PaginationListAsync(request.PageNumber, request.PageSize);
            return items;
        }
    }
}
