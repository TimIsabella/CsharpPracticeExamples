using System;
using System.Collections.Generic;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class OpenClose
	{
		public static void OpenCloseMain()
		{
			Console.WriteLine("\n *********** OPEN-CLOSE PRINCIPAL *********** \n");

			var fruitProduct = new Product("Apple", ProductColor.Green, ProductSize.Small);
			var treeProduct = new Product("Tree", ProductColor.Green, ProductSize.Large);
			var houseProduct = new Product("House", ProductColor.Blue, ProductSize.Large);
			var hatProduct = new Product("Hat", ProductColor.Red, ProductSize.Medium);

			var products = new Product[] { fruitProduct, treeProduct, houseProduct, hatProduct };

			var productFilter = new ProductFilter();

			//Green colored products
			foreach(var product in productFilter.Filter(products, new ColorSpecification(ProductColor.Green)))
			{ Console.WriteLine($"Green products: {product.Name} is {product.Color}"); }
		}

		///////////

		public enum ProductColor
		{ Red, Green, Blue }

		public enum ProductSize
		{ Large, Medium, Small }

		public class Product
		{
			public string Name;
			public ProductColor Color;
			public ProductSize Size;

			public Product(string name, ProductColor color, ProductSize size)
			{
				if(name == null) { throw new ArgumentNullException(paramName: nameof(name)); }
				
				Name = name;
				Color = color;
				Size = size;
			}
		}

		///////////

		public class ColorSpecification : ISpecification<Product>
		{
			private ProductColor _color;

			public ColorSpecification(ProductColor color)
			{ _color = color; }

			public bool IsSatisfied(Product item)
			{ return item.Color == _color; }
		}

		public class ProductFilter
		{
			public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
			{
				foreach(var item in items)
				{ if(specification.IsSatisfied(item)) yield return item; }
			}
		}

		public interface ISpecification<T>
		{ bool IsSatisfied(T item); }

		public interface IFilter<T>
		{ IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification); }
	}
}
