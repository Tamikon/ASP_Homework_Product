using System.Collections.Generic;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public class ProductList
    {
        List<Product> listOfProducts = new List<Product>()
        {
          new Product("ASUS ROG Zephyrus Duo 16", "2560х1600, AMD Ryzen 9 7945HX 2.5 ГГц, NVIDIA GeForce RTX 4090", 499990),
          new Product("GIGABYTE Gб", "1920х1200, Intel Core i7 12650H 2.3 ГГц, NVIDIA GeForce RTX 4050", 105990),
          new Product("MSI Sword 17 A12VF-810XRU", "1920х1080,  Intel Core i7 12650H 2.3 ГГц, NVIDIA GeForce RTX 4060", 170990)
        };

        public List<Product> GetProducts()
        {
            return listOfProducts;
        }
    }
}