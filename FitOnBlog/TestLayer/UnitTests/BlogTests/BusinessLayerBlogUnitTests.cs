using BusinessLayer.Abstracts;
using BusinessLayer.Concretes;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLayer.UnitTests.BlogTests
{
    [TestClass]
    public class BusinessLayerBlogUnitTests
    {
        [TestMethod]
        public void GetByIdShouldReturnCorrectBlog()
        {
            // Arrange
            var expectedBlog = new Blog { BlogId = 1, Title = "Test Blog" };

            var mockRepository = new Mock<IBlogDal>();
            var mockCategoryService = new Mock<ICategoryService>();

            mockRepository.Setup(x => x.GetById(1)).Returns(expectedBlog);

            var service = new BlogManager(mockRepository.Object, mockCategoryService.Object);

            // Act
            var result = service.GetById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBlog.Title, result.Title);
            mockRepository.Verify(x => x.GetById(1), Times.Once);

        }

        [TestMethod]
        public void GetListAllShouldReturnAllBlogs()
        {
            // Arrange
            var expectedBlogs = new List<Blog> {
                                new Blog { BlogId = 1, Title = "Blog 1" },
                                new Blog { BlogId = 2, Title = "Blog 2" }
                                };

            var mockRepository = new Mock<IBlogDal>();
            var mockCategoryService = new Mock<ICategoryService>();

            mockRepository.Setup(x => x.GetListAll()).Returns(expectedBlogs);

            var service = new BlogManager(mockRepository.Object, mockCategoryService.Object);

            // Act
            var result = service.GetListAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBlogs, result);
            mockRepository.Verify(x => x.GetListAll(), Times.Once);
        }
    }
}
