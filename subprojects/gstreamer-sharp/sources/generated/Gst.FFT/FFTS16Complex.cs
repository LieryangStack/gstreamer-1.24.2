// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.FFT {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FFTS16Complex : IEquatable<FFTS16Complex> {

		public short R;
		public short I;

		public static Gst.FFT.FFTS16Complex Zero = new Gst.FFT.FFTS16Complex ();

		public static Gst.FFT.FFTS16Complex New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.FFT.FFTS16Complex.Zero;
			return (Gst.FFT.FFTS16Complex) Marshal.PtrToStructure (raw, typeof (Gst.FFT.FFTS16Complex));
		}

		public bool Equals (FFTS16Complex other)
		{
			return true && R.Equals (other.R) && I.Equals (other.I);
		}

		public override bool Equals (object other)
		{
			return other is FFTS16Complex && Equals ((FFTS16Complex) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ R.GetHashCode () ^ I.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
