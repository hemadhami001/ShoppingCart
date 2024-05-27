using Application.Common.Interfaces;
using Application.Products.Commands.CreateProduct;

using Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;
        public ProductController(IApplicationDbContext dbContext) // Dependency Injection is a practice of recreating the instances rather than creating new one everytime. 
        {
            this._dbContext = dbContext; 
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<int> Post([FromBody] CreateProductCommand command, CancellationToken cancellationToken)
        {
            return await Mediator.Send(command, cancellationToken);
            //CancellationToken cancellationToken = new CancellationToken();
            //var entity= new Product();
            //entity.ProductName = product.ProductName;
            //entity.Description = product.Description;
            //entity.Price = product.Price;
            //entity.created_at = DateTime.Now;

           
            //_dbContext.Products.Add(entity);
            //await _dbContext.SaveChangesAsync(cancellationToken);
            
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    
}
