// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Mods
{
	/// <summary>
	/// Input parameters for the <see cref="ModsInterface.InstallMod" /> Function.
	/// </summary>
	public class InstallModOptions
	{
		/// <summary>
		/// The Epic Account ID of the user for which the mod should be installed
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The mod to install
		/// </summary>
		public ModIdentifier Mod { get; set; }

		/// <summary>
		/// Indicates whether the mod should be uninstalled after exiting the game or not.
		/// </summary>
		public bool RemoveAfterExit { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct InstallModOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_Mod;
		private int m_RemoveAfterExit;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public ModIdentifier Mod
		{
			set
			{
				Helper.TryMarshalSet<ModIdentifierInternal, ModIdentifier>(ref m_Mod, value);
			}
		}

		public bool RemoveAfterExit
		{
			set
			{
				Helper.TryMarshalSet(ref m_RemoveAfterExit, value);
			}
		}

		public void Set(InstallModOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ModsInterface.InstallmodApiLatest;
				LocalUserId = other.LocalUserId;
				Mod = other.Mod;
				RemoveAfterExit = other.RemoveAfterExit;
			}
		}

		public void Set(object other)
		{
			Set(other as InstallModOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_Mod);
		}
	}
}