using System;

namespace rss_editor
{
	public partial class successfulCreateDialog : Gtk.Dialog
	{
		public successfulCreateDialog ()
		{
			this.Build ();
		}

		protected void buttonOk_Clicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
	}
}

