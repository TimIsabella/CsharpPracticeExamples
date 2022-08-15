using System;
using System.Collections.Generic;

namespace Mosh
{
	public class InterfacePolymorphismExamples
	{
		public static void InterfacePolymorphismExamplesMain()
		{
			Console.WriteLine("\n *********** INTERFACE POLYMORPHISM EXAMPLES *********** \n");

			var encoder = new VideoEncoder();
			encoder.RegisterNotificationChannel(new MailNotificationChannel());
			encoder.RegisterNotificationChannel(new SmsNotificationChannel());
			encoder.RegisterNotificationChannel(new PidgeonNotificationChannel());
			encoder.Encode(new Video("Funny Video.mp4"));
		}

		public class VideoEncoder
		{
			//'IList' of interfaces to be filled -- IList is specific to interfaces
			//'readonly' specifies that items in the List can only be added or removed
			private readonly IList<INotificationChannel> _notificationChannels;
			
			public VideoEncoder()
			{
				//Set '_notificationChannels' to 'List' of incoming interfaces
				_notificationChannels = new List<INotificationChannel>();
			}

			public void Encode(Video video)
			{
				//Video encoding code here...

				//Loop through all List of 'INotificationChannel' and call each 'Send' method
				foreach(var channel in _notificationChannels)
				{ channel.Send(new Message(video.VideoName())); }
			}

			public void RegisterNotificationChannel(INotificationChannel channel)
			{
				_notificationChannels.Add(channel);
			}
		}

		public class Video
		{
			private string _videoName;
			public Video(string videoName)
			{ _videoName = videoName; }
			public string VideoName()
			{ return _videoName; }
		}

		public class Message
		{
			private string _videoName;
			public Message(string videoName)
			{ _videoName = videoName; }
			public string VideoName()
			{ return _videoName; }

			public void MsgComplete()
			{ Console.WriteLine("...message complete!"); }
		}

		///////////////////////////////// Interfaces /////////////////////////////////

		public interface INotificationChannel
		{
			void Send(Message message);
		}

		public class MailNotificationChannel : INotificationChannel
		{
			public void Send(Message msg)
			{ Console.WriteLine($"Sending by Mail: {msg.VideoName()}"); msg.MsgComplete(); }
		}

		public class SmsNotificationChannel : INotificationChannel
		{
			public void Send(Message msg)
			{ Console.WriteLine($"Sending by SMS: {msg.VideoName()}"); msg.MsgComplete(); }
		}

		public class PidgeonNotificationChannel : INotificationChannel
		{
			public void Send(Message msg)
			{ Console.WriteLine($"Sending by pidgeon: {msg.VideoName()}"); msg.MsgComplete(); }
		}
	}
}
