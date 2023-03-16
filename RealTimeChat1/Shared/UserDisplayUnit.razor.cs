using Microsoft.AspNetCore.Components;

namespace RealTimeChat1.Shared
{
	public partial class UserDisplayUnit<T>
	{
		[Parameter]
		public User user { get; set; } = new User(userName: "Default");

		[Parameter]
		public T MetaInfo { get; set; }

		[Parameter]
		public EventCallback<User> OnClickCallback { get; set; }

		public void OnClick()
		{
			OnClickCallback.InvokeAsync(user);
		}
	}
}
