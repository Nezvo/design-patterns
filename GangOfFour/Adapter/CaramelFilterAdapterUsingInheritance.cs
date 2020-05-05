using GangOfFour.Adapter.ExternalFilters;

namespace GangOfFour.Adapter
{
	/// <summary>
	/// Adapter
	/// </summary>
	public class CaramelFilterAdapterUsingInheritance : CaramelFilter, IFilter
	{
		public void Apply(Image image)
		{
			Init();
			Render(image);
		}
	}
}
