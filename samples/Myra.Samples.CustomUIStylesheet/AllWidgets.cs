/* Generated by Myra UI Editor at 11/16/2017 2:38:36 AM */

using Myra.Graphics2D.UI;
using Myra.Graphics2D.UI.ColorPicker;

namespace Myra.Samples.CustomUIStylesheet
{
	public partial class AllWidgets: HorizontalSplitPane
	{
		public AllWidgets()
		{
			BuildUI();

			_imageButton.Click += (sender, args) =>
			{
				var debugWindow = new DebugOptionsWindow();
				debugWindow.ShowModal();
			};

			var tree = new Tree
			{
				HasRoot = false,
				GridColumn = 1,
				GridRow = 8
			};

			var node1 = tree.AddSubNode("node1");
			var node2 = node1.AddSubNode("node2");
			var node3 = node2.AddSubNode("node3");
			node3.AddSubNode("node4");
			node3.AddSubNode("node5");
			node3.AddSubNode("node7");
			node3.AddSubNode("node8");
			node3.AddSubNode("node9");
			node3.AddSubNode("node10");

			var node4 = node2.AddSubNode("node6");
			node4.AddSubNode("node11");
			node4.AddSubNode("node12");
			node4.AddSubNode("node13");
			node4.AddSubNode("node14");
			node4.AddSubNode("node15");
			node4.AddSubNode("node16");
			node4.AddSubNode("node17");
			node4.AddSubNode("node18");
			_gridRight.Widgets.Add(tree);
		}
	}
}