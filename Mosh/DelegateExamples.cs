using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class DelegateExamples
	{
		public static void DelegateExamplesMain()
		{
			Console.WriteLine("\n *********** DELEGATE *********** \n");
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
			public void Process(string path)
			{
				var photo = Photo.Load(path);

				var filters = new PhotoFilters();
				filters.ApplyBrightness(photo);
				filters.ApplyContrast(photo);
				filters.Resize(photo);
				
				photo.Save();
			}
		}

		public class PhotoFilters
		{
			public void ApplyBrightness(Photo photo)
			{ Console.WriteLine("Apply brightness"); }

			public void ApplyContrast(Photo photo)
			{ Console.WriteLine("Apply contrast"); }

			public void Resize(Photo photo)
			{ Console.WriteLine("Resize photo"); }
		}
	}
}
