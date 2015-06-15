using System;

namespace rss_editor
{
	public partial class successfulPublishDialog : Gtk.Dialog
	{
		public successfulPublishDialog ()
		{
			this.Build ();
		}

		protected void buttonOk_Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}

