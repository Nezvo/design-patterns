using GangOfFour.Adapter.ExternalFilters;

namespace GangOfFour.Adapter
{
	/// <summary>
	/// Adapter
	/// </summary>
	public class CaramelFilterAdapterUsingComposition : IFilter
	{
		private readonly CaramelFilter caramel;

		public CaramelFilterAdapterUsingComposition(CaramelFilter caramel)
		{
			this.caramel = caramel;
		}

		public void Apply(Image image)
		{
			caramel.Init();
			caramel.Render(image);
		}
	}
}
