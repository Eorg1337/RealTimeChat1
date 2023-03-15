namespace RealTimeChat1.Shared
{
	public class Message
	{
		public User User { get; set; }	
		public string UserImage { get { return User.UserImage; } } 
		public string UserName { get { return User.UserName; } }
		public string MessageText { get; set; } = "Text";
		public string SendTime { get; set; } = "Time";

		public Message(User user, string messageText, string sendTime)
		{
			User = user;	
			MessageText = messageText;
			SendTime = sendTime;	
		}
	}
}
