// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct DebugCategory : IEquatable<DebugCategory> {

		private Gst.DebugLevel threshold;
		private uint color;
		private string name;
		private string description;

		public static Gst.DebugCategory Zero = new Gst.DebugCategory ();

		public static Gst.DebugCategory New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.DebugCategory.Zero;
			return (Gst.DebugCategory) Marshal.PtrToStructure (raw, typeof (Gst.DebugCategory));
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_debug_category_free(IntPtr raw);

		[Obsolete]
		public void Free() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_debug_category_free(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_debug_category_reset_threshold(IntPtr raw);

		public void ResetThreshold() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_debug_category_reset_threshold(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref Gst.DebugCategory target)
		{
			target = New (native);
		}

		public bool Equals (DebugCategory other)
		{
			return true && threshold.Equals (other.threshold) && color.Equals (other.color) && name.Equals (other.name) && description.Equals (other.description);
		}

		public override bool Equals (object other)
		{
			return other is DebugCategory && Equals ((DebugCategory) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ threshold.GetHashCode () ^ color.GetHashCode () ^ name.GetHashCode () ^ description.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
