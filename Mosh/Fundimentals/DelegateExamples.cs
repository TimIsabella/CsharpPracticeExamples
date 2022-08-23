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
			filterHandler = RemoveRedEyeFilter;				 //Add method of matching signature to delegate container
			filterHandler += PhotoSize.Resize;               //Add method of matching signature to delegate container

			var filters = new PhotoFilters(); 
			filterHandler += filters.ApplyBrightness;        //Add method of matching signature to delegate container
			filterHandler += filters.ApplyContrast;          //Add method of matching signature to delegate container
			
			processor.Process(filterHandler);   //All delegated methods within 'filterHandler' will be called
		}

		public class Photo
		{
			public static Photo Load()
			{ return new Photo(); }
		}

		public class PhotoProcessor
		{
			/////////// DELEGATES -- holds a pointer to a method or a group of pointers to methods ///////////
			//Establishes the delegate signature as 'methodName(Photo photo)'
			public delegate void PhotoFilterHandler(Photo photo);

			public void Process(PhotoFilterHandler filterHandler)
			{
				var photo = Photo.Load(); //Simulate loading image -- returns 'Photo' object

				///DELEGATE DUMPS METHODS HERE///
				filterHandler(photo);
			}
		}

		/////////// Filters For Delegate ///////////

		//Matches delegate signature 'methodName(Photo photo)'
		public static void RemoveRedEyeFilter(Photo photo)
		{ Console.WriteLine("Apply red-eye filter"); }

		public class PhotoFilters
		{
			//Matches delegate signature 'methodName(Photo photo)'
			public void ApplyBrightness(Photo photo)
			{ Console.WriteLine("Apply brightness"); }

			//Matches delegate signature 'methodName(Photo photo)'
			public void ApplyContrast(Photo photo)
			{ Console.WriteLine("Apply contrast"); }
		}

		public class PhotoSize
		{
			//Matches delegate signature 'methodName(Photo photo)'
			public static void Resize(Photo photo)
			{ Console.WriteLine("Resize photo"); }
		}
	}
}
