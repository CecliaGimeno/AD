
// This file has been generated by the GUI designer. Do not modify.
namespace PCategoria
{
	public partial class CategoriaView
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action saveAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.Toolbar toolbar1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label1;
		private global::Gtk.Entry entryNombre;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PCategoria.CategoriaView
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.saveAction = new global::Gtk.Action ("saveAction", null, null, "gtk-save");
			w1.Add (this.saveAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "PCategoria.CategoriaView";
			this.Title = global::Mono.Unix.Catalog.GetString ("CategoriaView");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child PCategoria.CategoriaView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='saveAction' action='saveAction'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.vbox1.Add (this.toolbar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryNombre = new global::Gtk.Entry ();
			this.entryNombre.CanFocus = true;
			this.entryNombre.Name = "entryNombre";
			this.entryNombre.IsEditable = true;
			this.entryNombre.InvisibleChar = '•';
			this.hbox1.Add (this.entryNombre);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNombre]));
			w4.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}
