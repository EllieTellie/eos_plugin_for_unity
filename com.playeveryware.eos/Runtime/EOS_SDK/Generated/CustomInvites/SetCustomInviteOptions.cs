// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.CustomInvites
{
	public struct SetCustomInviteOptions
	{
		/// <summary>
		/// Local user creating / sending a Custom Invite
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// String payload for the Custom Invite (must be less than <see cref="CustomInvitesInterface.MaxPayloadLength" />)
		/// </summary>
		public Utf8String Payload { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SetCustomInviteOptionsInternal : ISettable<SetCustomInviteOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_Payload;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public Utf8String Payload
		{
			set
			{
				Helper.Set(value, ref m_Payload);
			}
		}

		public void Set(ref SetCustomInviteOptions other)
		{
			m_ApiVersion = CustomInvitesInterface.SetcustominviteApiLatest;
			LocalUserId = other.LocalUserId;
			Payload = other.Payload;
		}

		public void Set(ref SetCustomInviteOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = CustomInvitesInterface.SetcustominviteApiLatest;
				LocalUserId = other.Value.LocalUserId;
				Payload = other.Value.Payload;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_Payload);
		}
	}
}