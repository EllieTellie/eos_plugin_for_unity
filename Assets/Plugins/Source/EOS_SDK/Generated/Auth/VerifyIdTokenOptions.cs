// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.VerifyIdToken" /> function.
	/// </summary>
	public struct VerifyIdTokenOptions
	{
		/// <summary>
		/// The ID token to verify.
		/// Use <see cref="EpicAccountId.FromString" /> to populate the AccountId field of this struct.
		/// </summary>
		public IdToken? IdToken { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct VerifyIdTokenOptionsInternal : ISettable<VerifyIdTokenOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_IdToken;

		public IdToken? IdToken
		{
			set
			{
				Helper.Set<IdToken, IdTokenInternal>(ref value, ref m_IdToken);
			}
		}

		public void Set(ref VerifyIdTokenOptions other)
		{
			m_ApiVersion = AuthInterface.VerifyidtokenApiLatest;
			IdToken = other.IdToken;
		}

		public void Set(ref VerifyIdTokenOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AuthInterface.VerifyidtokenApiLatest;
				IdToken = other.Value.IdToken;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_IdToken);
		}
	}
}