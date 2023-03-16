using System;
using RealTimeChat1.Shared;

namespace RealTimeChat1.Services
{
	public delegate void TransferEventHandler();
	public class instanceTransferService
	{
		public event TransferEventHandler MyEvent;
		public User user;

		public void ChangeStatus(User _user)
		{
			user = _user;

			MyEvent?.Invoke();
		}
	}

}
