﻿using System;

namespace Byond.TopicSender
{
	/// <summary>
	/// <see cref="System.Net.Sockets.Socket"/> parameters used by the <see cref="TopicClient"/>/
	/// </summary>
	public sealed class SocketParameters
	{
		/// <summary>
		/// The timeout for the send operation.
		/// </summary>
		public TimeSpan SendTimeout { get; set; }

		/// <summary>
		/// The timeout for the receive operation.
		/// </summary>
		public TimeSpan ReceiveTimeout { get; set; }

		/// <summary>
		/// The timeout for the receive operation.
		/// </summary>
		public TimeSpan ConnectTimeout { get; set; }

		/// <summary>
		/// The timeout for the disconnect operation.
		/// </summary>
		public TimeSpan DisconnectTimeout { get; set; }
	}
}
