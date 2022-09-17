using System;
using System.Collections.Generic;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class OpenClosed
	{
		public static void OpenClosedMain()
		{
			Console.WriteLine("\n *********** OPEN-CLOSED PRINCIPAL *********** \n");
			///- Entities shoud be open for extension and closed for modification

			var fruitProduct = new Product("Apple", ProductColor.Green, ProductSize.Small);
			var treeProduct = new Product("Tree", ProductColor.Green, ProductSize.Large);
			var houseProduct = new Product("House", ProductColor.Blue, ProductSize.Large);
			var hatProduct = new Product("Hat", ProductColor.Red, ProductSize.Medium);

			var products = new Product[] { fruitProduct, treeProduct, houseProduct, hatProduct };

			var productFilter = new ProductFilter();

			//Product filtering parameters
			var colorChoice = ProductColor.Green;
			var sizeChoice = ProductSize.Large;

			//Single filter by color
			Console.WriteLine("Single filtered list...");
			var singleFilteredProducts = productFilter.Filter(products, new ColorSpecification(colorChoice));
			foreach(var product in singleFilteredProducts)
			{ Console.WriteLine($"Products filtered by '{colorChoice}': {product.Name} is {product.Color}, and size is {product.Size}"); }

			//Multi filter by color and size
			Console.WriteLine("\nDouble filtered list...");
			var multiFilteredProducts = productFilter.Filter(products, new AndSpecification<Product>(new ColorSpecification(colorChoice), new SizeSpecification(sizeChoice)));
			foreach(var product in multiFilteredProducts)
			{ Console.WriteLine($"Products filtered by '{colorChoice}' and '{sizeChoice}': {product.Name} is {product.Color}, and size is {product.Size}"); }
		}

		/////////// Product ///////////

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

		public enum ProductColor
		{ Red, Green, Blue }
		public enum ProductSize
		{ Large, Medium, Small }

		/////////// Filter ///////////
		public class ProductFilter : IProductFilter<Product>
		{
			public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
			{
				foreach(var item in items)
				{ if(specification.IsSatisfied(item)) yield return item; }
			}
		}

		/////////// Color Specification ///////////
		public class ColorSpecification : ISpecification<Product>
		{
			private ProductColor _color;

			public ColorSpecification(ProductColor color)
			{ _color = color; }

			public bool IsSatisfied(Product item)
			{ return item.Color == _color; }
		}

		/////////// Size Specification ///////////
		public class SizeSpecification : ISpecification<Product>
		{
			private ProductSize _size;

			public SizeSpecification(ProductSize size)
			{ _size = size; }

			public bool IsSatisfied(Product item)
			{ return item.Size == _size; }
		}

		/////////// Multiple Specification or 'Combinator' ///////////
		public class AndSpecification<T> : ISpecification<T>
		{
			private ISpecification<T> _first;
			private ISpecification<T> _second;

			public AndSpecification(ISpecification<T> first, ISpecification<T> second)
			{
				_first = first ?? throw new ArgumentNullException(nameof(first));
				_second = second ?? throw new ArgumentNullException(nameof(second));
			}

			public bool IsSatisfied(T item)
			{ return _first.IsSatisfied(item) && _second.IsSatisfied(item); }
		}

		/////////// Interfaces ///////////

		//Filter interface
		public interface IProductFilter<T>
		{ IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification); }

		//Specification interface
		public interface ISpecification<T>
		{ bool IsSatisfied(T item); }
	}
}
