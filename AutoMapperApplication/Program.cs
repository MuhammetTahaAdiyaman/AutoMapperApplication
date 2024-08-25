using AutoMapper;
using System;

namespace AutoMapperApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = new MapperConfiguration(opt =>
            {   //kaynak ve hedef alanı veriyoruz neyden neye çevireceğiz bunu belirtiyoruz kısaca
                opt.CreateMap<Product, ProductListDto>();   
            });

            var mapper = configuration.CreateMapper();

            mapper.Map<ProductListDto>(new Product
            {
                Id = 1,
                Name = "Telefon",
                Stock = 10
            });

            //burada biz product nesnesini productlistdto'ya bu şekilde çevirmiş olduk.
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }

    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
