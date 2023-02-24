namespace RealTimeChat1.Shared
{
	public class User
	{
		public string UserImage { get; set; } = "https://bootdey.com/img/Content/avatar/avatar5.png";
		public string UserName { get; set; } = "Username";
		public string NetworkStatus { get; set; } = "Last seen recently";

		public User(string userImage = "https://bootdey.com/img/Content/avatar/avatar5.png", string userName="Username", string networkStatus= "Last seen recently")
		{
			UserImage = userImage;
			UserName = userName;
			NetworkStatus=networkStatus;	
		}
	}
}
