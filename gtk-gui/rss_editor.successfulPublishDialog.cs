
// This file has been generated by the GUI designer. Do not modify.
namespace rss_editor
{
	public partial class successfulPublishDialog
	{
		private global::Gtk.Label label1;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget rss_editor.successfulPublishDialog
			this.Name = "rss_editor.successfulPublishDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child rss_editor.successfulPublishDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.WidthRequest = 300;
			w1.HeightRequest = 100;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.WidthRequest = 300;
			this.label1.HeightRequest = 100;
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Successfully published!");
			w1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Internal child rss_editor.successfulPublishDialog.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonOk]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 405;
			this.DefaultHeight = 143;
			this.Show ();
			this.buttonOk.Clicked += new global::System.EventHandler (this.buttonOk_Clicked);
		}
	}
}
