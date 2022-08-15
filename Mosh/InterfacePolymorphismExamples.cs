using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class InterfacePolymorphismExamples
	{
		public static void InterfacePolymorphismExamplesMain()
		{
			var encoder = new VideoEncoder();
			encoder.Encode(new Video());
		}

		public class VideoEncoder
		{
			private readonly MailService _mailService;

			public VideoEncoder()
			{
				_mailService = new MailService();
			}

			public void Encode(Video video)
			{
				// Video encoding code

				_mailService.Send(new Mail());
			}
		}

		public class MailService
		{
			public void Send(Mail mail)
			{
				Console.WriteLine("Sending mail...");
			}
		}

		public class Video
		{}

		public class Mail
		{}

		public class Message
		{}

		/////////////////////////////////

		public class MailNotificationChannel : INotificationChannel
		{
			public void Send(Message msg)
			{ Console.WriteLine("Sending Mail..."); }
		}

		public class SmsNotificationChannel : INotificationChannel
		{
			public void Send(Message msg)
			{ Console.WriteLine("Sending SMS..."); }
		}

		public interface INotificationChannel
		{
			void Send(Message message);
		}
	}
}
