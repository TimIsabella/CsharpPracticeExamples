using System;

namespace Mosh
{
	public class DelegateExamples
	{
		public static void DelegateExamplesMain()
		{
			Console.WriteLine("\n *********** DELEGATE *********** \n");

			var processor = new PhotoProcessor();

			/////////// Delegate ///////////

			PhotoProcessor.PhotoFilterHandler filterHandler; //Instantiate the delegate container
			filterHandler = RemoveRedEyeFilter;				 //Add mathod of matching signature to delegate container
			filterHandler += PhotoSize.Resize;               //Add mathod of matching signature to delegate container

			var filters = new PhotoFilters(); 
			filterHandler += filters.ApplyBrightness;        //Add mathod of matching signature to delegate container
			filterHandler += filters.ApplyContrast;          //Add mathod of matching signature to delegate container

			/////////////////////////////////

			processor.Process("photo.jpg", filterHandler);	 //All delegated methods under 'filter handler' will be called
		}

		public class Photo
		{
			public static Photo Load(string path)
			{
				return new Photo();
			}

			public void Save()
			{ }
		}

		public class PhotoProcessor
		{
			//'delegate' -- holds a pointer to a method or a group of pointers to methods
			//Inherits the resulting methods for this class to utilize
			//Establishes the delegate signature as 'methodName(Photo photo)'
			public delegate void PhotoFilterHandler(Photo photo);

			public void Process(string path, PhotoFilterHandler filterHandler)
			{
				//System.Action<>
				//System.Func<>
				
				var photo = Photo.Load(path);

				//Delegate
				filterHandler(photo);

				photo.Save();
			}
		}

		/////////// Filters ///////////

		//Matches delegate signature
		public static void RemoveRedEyeFilter(Photo photo)
		{ Console.WriteLine("Apply red-eye filter"); }

		public class PhotoFilters
		{
			//Matches delegate signature
			public void ApplyBrightness(Photo photo)
			{ Console.WriteLine("Apply brightness"); }

			//Matches delegate signature
			public void ApplyContrast(Photo photo)
			{ Console.WriteLine("Apply contrast"); }
		}

		public class PhotoSize
		{
			//Matches delegate signature
			public static void Resize(Photo photo)
			{ Console.WriteLine("Resize photo"); }
		}
		
	}
}
