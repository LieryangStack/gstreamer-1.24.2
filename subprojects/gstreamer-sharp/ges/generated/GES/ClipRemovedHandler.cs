// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void ClipRemovedHandler(object o, ClipRemovedArgs args);

	public class ClipRemovedArgs : GLib.SignalArgs {
		public GES.Clip Clip{
			get {
				return (GES.Clip) Args [0];
			}
		}

	}
}
