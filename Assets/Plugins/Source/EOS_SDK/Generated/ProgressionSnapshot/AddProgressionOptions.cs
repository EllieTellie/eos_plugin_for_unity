// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.ProgressionSnapshot
{
	public struct AddProgressionOptions
	{
		/// <summary>
		/// The Snapshot Id received via a <see cref="ProgressionSnapshotInterface.BeginSnapshot" /> function.
		/// </summary>
		public uint SnapshotId { get; set; }

		/// <summary>
		/// The key in a key/value pair of progression entry
		/// </summary>
		public Utf8String Key { get; set; }

		/// <summary>
		/// The value in a key/value pair of progression entry
		/// </summary>
		public Utf8String Value { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddProgressionOptionsInternal : ISettable<AddProgressionOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_SnapshotId;
		private System.IntPtr m_Key;
		private System.IntPtr m_Value;

		public uint SnapshotId
		{
			set
			{
				m_SnapshotId = value;
			}
		}

		public Utf8String Key
		{
			set
			{
				Helper.Set(value, ref m_Key);
			}
		}

		public Utf8String Value
		{
			set
			{
				Helper.Set(value, ref m_Value);
			}
		}

		public void Set(ref AddProgressionOptions other)
		{
			m_ApiVersion = ProgressionSnapshotInterface.AddprogressionApiLatest;
			SnapshotId = other.SnapshotId;
			Key = other.Key;
			Value = other.Value;
		}

		public void Set(ref AddProgressionOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = ProgressionSnapshotInterface.AddprogressionApiLatest;
				SnapshotId = other.Value.SnapshotId;
				Key = other.Value.Key;
				Value = other.Value.Value;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Key);
			Helper.Dispose(ref m_Value);
		}
	}
}