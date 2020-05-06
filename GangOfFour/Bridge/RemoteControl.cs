namespace GangOfFour.Bridge
{
	public class RemoteControl
	{
		/// <summary>
		/// Bridge
		/// </summary>
		protected readonly IDevice device;

		public RemoteControl(IDevice device)
		{
			this.device = device;
		}

		public void TurnOn() => device.TurnOn();

		public void TurnOff() => device.TurnOff();
	}
}
