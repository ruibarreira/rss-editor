using System;

namespace rss_editor
{
	public partial class warningNonExistPublicationDialog : Gtk.Dialog
	{
		public warningNonExistPublicationDialog ()
		{
			this.Build ();
		}

		protected void buttonOk_Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}

