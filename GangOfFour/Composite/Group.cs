using System.Collections.Generic;

namespace GangOfFour.Composite
{
	public class Group : IComponent
	{
		private readonly List<IComponent> components = new List<IComponent>();

		public void Add(IComponent component) => components.Add(component);

		public void Render() => components.ForEach(component => component.Render());

		public void Move() => components.ForEach(component => component.Move());
	}
}
