// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Audio.AudioRingBufferStateGType))]
	public enum AudioRingBufferState {

		Stopped = 0,
		Paused = 1,
		Started = 2,
		Error = 3,
	}

	internal class AudioRingBufferStateGType {
		[DllImport ("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_ring_buffer_state_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_ring_buffer_state_get_type ());
			}
		}
	}
#endregion
}
