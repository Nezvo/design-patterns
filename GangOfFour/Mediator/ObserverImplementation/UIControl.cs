using System;
using System.Collections.Generic;

namespace GangOfFour.Mediator.ObserverImplementation
{
	public abstract class UIControl
	{
		private readonly List<Action> eventHandlers = new List<Action>();

		public void AddEventHandler(Action action) => eventHandlers.Add(action);

		protected void NotifyEventHandlers() => eventHandlers.ForEach(action => action());
	}
}
