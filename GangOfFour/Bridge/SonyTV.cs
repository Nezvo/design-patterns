using System;

namespace GangOfFour.Bridge
{
	class SonyTV : IDevice
	{
		public void SetChannel(int number) => Console.WriteLine("Sony set channel");

		public void TurnOff() => Console.WriteLine("Sony turn off");

		public void TurnOn() => Console.WriteLine("Sony turn on");
	}
}
