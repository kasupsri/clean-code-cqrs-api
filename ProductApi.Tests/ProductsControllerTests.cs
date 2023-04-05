using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductApi.Application.Commands;
using ProductApi.Application.Queries;
using ProductApi.Controllers;
using ProductApi.Domain.Models;
using Xunit;

namespace ProductApi.Tests
{
    public class ProductsControllerTests
    {
        [Fact]
        public async Task GetAllProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var expectedProducts = new[] { new Product(), new Product() };
            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetAllProductsQuery>(), default))
                .ReturnsAsync(expectedProducts)
                .Verifiable();
            var controller = new ProductsController(mediatorMock.Object);

            // Act
            var actionResult = await controller.GetAllProducts();

            // Assert
            var result = Assert.IsType<OkObjectResult>(actionResult);
            var actualProducts = Assert.IsType<Product[]>(result.Value);
            Assert.Equal(expectedProducts, actualProducts);
            mediatorMock.Verify();
        }

        [Fact]
        public async Task GetProductById_ShouldReturnProduct()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var expectedProduct = new Product { Id = 1 };
            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetProductByIdQuery>(), default))
                .ReturnsAsync(expectedProduct)
                .Verifiable();
            var controller = new ProductsController(mediatorMock.Object);

            // Act
            var actionResult = await controller.GetProductById(expectedProduct.Id);

            // Assert
            var result = Assert.IsType<OkObjectResult>(actionResult);
            var actualProduct = Assert.IsType<Product>(result.Value);
            Assert.Equal(expectedProduct, actualProduct);
            mediatorMock.Verify();
        }

        [Fact]
        public async Task CreateProduct_ShouldReturnCreatedProduct()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var expectedProduct = new Product { Id = 1, Name = "Test Product" };
            mediatorMock
                .Setup(m => m.Send(It.IsAny<CreateProductCommand>(), default))
                .ReturnsAsync(expectedProduct)
                .Verifiable();
            var controller = new ProductsController(mediatorMock.Object);
            var command = new CreateProductCommand { Name = expectedProduct.Name };

            // Act
            var actionResult = await controller.CreateProduct(command);

            // Assert
            var result = Assert.IsType<CreatedAtActionResult>(actionResult);
            var actualProduct = Assert.IsType<Product>(result.Value);
            Assert.Equal(expectedProduct, actualProduct);
            mediatorMock.Verify();
        }
    }
}
