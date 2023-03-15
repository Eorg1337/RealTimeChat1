using Microsoft.AspNetCore.Components;
using System.Security.Cryptography.X509Certificates;


namespace RealTimeChat1.Shared
{
	public partial class UserDisplayUnit
	{
		[Parameter]
		public User User { get; set; } = new User();

		[Parameter]
		public  EventCallback<User> OnClickCallBack { get; set; }

		public void OnClick()
		{
			OnClickCallBack.InvokeAsync(User);
		}
	}
}
