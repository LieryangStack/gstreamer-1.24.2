// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.TypeFindProbabilityGType))]
	public enum TypeFindProbability {

		None = 0,
		Minimum = 1,
		Possible = 50,
		Likely = 80,
		NearlyCertain = 99,
		Maximum = 100,
	}

	internal class TypeFindProbabilityGType {
		[DllImport ("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_probability_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_type_find_probability_get_type ());
			}
		}
	}
#endregion
}
