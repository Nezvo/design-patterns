using System;

namespace GangOfFour.State
{
	/// <summary>
	/// Context
	/// </summary>
	public class Canvas
	{
		public ITool CurrentTool { get; set; }

		/// <summary>
		/// Request
		/// </summary>
		public void MouseDown() => CurrentTool.MouseDown();

		/// <summary>
		/// Request
		/// </summary>
		public void MouseUp() => CurrentTool.MouseUp();
	}
}
