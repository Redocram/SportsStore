using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Models;
using System.IO;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository { get; set; }
        private IProductImageRepository imageRepository { get; set; }
        /// <summary>
        /// The number pf Products per page</summary>
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository, IProductImageRepository imageRepository)
        {
            this.productRepository = productRepository;
            this.imageRepository = imageRepository;
        }

        /// <summary>
        /// List the Products, ordered by primary key, skip over the products that occur before the start of the current page, and take the number of products specified by the PageSize field.</summary>
        /// <param name="page">The page that I want to see</param>
        /// <returns>A view with all Products ordered by their ID</returns>
        public ViewResult List(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = productRepository.Products
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                ProductImages = imageRepository.ProductImages // for now it's useless to pass this to the view
                .OrderBy(i => i.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = productRepository.Products.Count()
                }
            };
            return View(model);           
        }

        public FileContentResult GetImage(int productId)
        {
            return File(imageRepository.ProductImages.Where(i => i.ProductID == productId).FirstOrDefault().ImageData, imageRepository.ProductImages.Where(i => i.ProductID == productId).FirstOrDefault().ImageMimeType);
        }

    }
}