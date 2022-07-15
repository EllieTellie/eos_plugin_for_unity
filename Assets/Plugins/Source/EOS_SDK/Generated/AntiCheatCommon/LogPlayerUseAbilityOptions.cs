// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	public struct LogPlayerUseAbilityOptions
	{
		/// <summary>
		/// Locally unique value used in RegisterClient/RegisterPeer
		/// </summary>
		public System.IntPtr PlayerHandle { get; set; }

		/// <summary>
		/// Game defined unique identifier for the ability being used
		/// </summary>
		public uint AbilityId { get; set; }

		/// <summary>
		/// Duration of the ability effect in milliseconds. If not applicable, use 0.
		/// </summary>
		public uint AbilityDurationMs { get; set; }

		/// <summary>
		/// Cooldown until the ability can be used again in milliseconds. If not applicable, use 0.
		/// </summary>
		public uint AbilityCooldownMs { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LogPlayerUseAbilityOptionsInternal : ISettable<LogPlayerUseAbilityOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_PlayerHandle;
		private uint m_AbilityId;
		private uint m_AbilityDurationMs;
		private uint m_AbilityCooldownMs;

		public System.IntPtr PlayerHandle
		{
			set
			{
				m_PlayerHandle = value;
			}
		}

		public uint AbilityId
		{
			set
			{
				m_AbilityId = value;
			}
		}

		public uint AbilityDurationMs
		{
			set
			{
				m_AbilityDurationMs = value;
			}
		}

		public uint AbilityCooldownMs
		{
			set
			{
				m_AbilityCooldownMs = value;
			}
		}

		public void Set(ref LogPlayerUseAbilityOptions other)
		{
			m_ApiVersion = AntiCheatCommonInterface.LogplayeruseabilityApiLatest;
			PlayerHandle = other.PlayerHandle;
			AbilityId = other.AbilityId;
			AbilityDurationMs = other.AbilityDurationMs;
			AbilityCooldownMs = other.AbilityCooldownMs;
		}

		public void Set(ref LogPlayerUseAbilityOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AntiCheatCommonInterface.LogplayeruseabilityApiLatest;
				PlayerHandle = other.Value.PlayerHandle;
				AbilityId = other.Value.AbilityId;
				AbilityDurationMs = other.Value.AbilityDurationMs;
				AbilityCooldownMs = other.Value.AbilityCooldownMs;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_PlayerHandle);
		}
	}
}