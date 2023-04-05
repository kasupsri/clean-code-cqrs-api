using MediatR;
using ProductApi.Domain.Models;
using System.Collections.Generic;

namespace ProductApi.Application.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
