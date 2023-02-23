namespace RealTimeChat1.Shared
{
	public class Message
	{
		public string UserImage { get; set; }
		public string UserName { get; set; }
		public string MessageText { get; set; }
		public string SendTime { get; set; }

		public Message(string userImage, string userName, string messageText, string sendTime)
		{
			UserImage = userImage;
			UserName = userName;
			MessageText = messageText;
			SendTime = sendTime;	
		}
	}
}
