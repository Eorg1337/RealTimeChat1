using Microsoft.AspNetCore.Components;
using System.Diagnostics.Metrics;

namespace RealTimeChat1.Shared
{
	public partial class ChatUserPresentation
	{
		[Parameter]
		public  User User { get; set; } = ContactsList.selectedUser;
	
		public  void GetUser(User user)
		{
			User = user;
		}
	}
}

