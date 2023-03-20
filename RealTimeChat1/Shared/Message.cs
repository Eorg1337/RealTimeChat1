
using System;

namespace RealTimeChat1.Shared
{
	public class Message
	{
		public User User { get; }	
		public string UserImage { get { return User.UserImage; } } 
		public string UserName { get { return User.UserName; } }
		public string MessageText { get; set; } = "Text";
		public DateTime SendTime { get; set; } = DateTime.Now;

		public Message(User user, string messageText)
		{
			User = user;	
			MessageText = messageText;
			SendTime = DateTime.Now;	
		}

		public Message(string messageText)
		{
			User = new User();
			MessageText = messageText;
			SendTime = DateTime.Now;
		}

		public Message()
		{
			User = new User();
		}
	}
}
