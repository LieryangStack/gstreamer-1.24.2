// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServer {

	using System;

	public delegate void PreAnnounceRequestHandler(object o, PreAnnounceRequestArgs args);

	public class PreAnnounceRequestArgs : GLib.SignalArgs {
		public Gst.RtspServer.RTSPContext Ctx{
			get {
				return (Gst.RtspServer.RTSPContext) Args [0];
			}
		}

	}
}
