// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Input parameters for the <see cref="AchievementsInterface.QueryDefinitions" /> function.
	/// </summary>
	public class QueryDefinitionsOptions
	{
		/// <summary>
		/// Product User ID for user who is querying definitions.
		/// The localized text returned will be based on the locale code of the given user if they have a linked Epic Account ID.
		/// The localized text returned can also be overridden using <see cref="Platform.PlatformInterface.SetOverrideLocaleCode" /> to override the locale.
		/// If the locale code is not overridden and LocalUserId is not valid, default text will be returned.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Deprecated
		/// </summary>
		public EpicAccountId EpicUserId_DEPRECATED { get; set; }

		/// <summary>
		/// Deprecated
		/// </summary>
		public string[] HiddenAchievementIds_DEPRECATED { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryDefinitionsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_EpicUserId_DEPRECATED;
		private System.IntPtr m_HiddenAchievementIds_DEPRECATED;
		private uint m_HiddenAchievementsCount_DEPRECATED;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public EpicAccountId EpicUserId_DEPRECATED
		{
			set
			{
				Helper.TryMarshalSet(ref m_EpicUserId_DEPRECATED, value);
			}
		}

		public string[] HiddenAchievementIds_DEPRECATED
		{
			set
			{
				Helper.TryMarshalSet(ref m_HiddenAchievementIds_DEPRECATED, value, out m_HiddenAchievementsCount_DEPRECATED, true);
			}
		}

		public void Set(QueryDefinitionsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AchievementsInterface.QuerydefinitionsApiLatest;
				LocalUserId = other.LocalUserId;
				EpicUserId_DEPRECATED = other.EpicUserId_DEPRECATED;
				HiddenAchievementIds_DEPRECATED = other.HiddenAchievementIds_DEPRECATED;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryDefinitionsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_EpicUserId_DEPRECATED);
			Helper.TryMarshalDispose(ref m_HiddenAchievementIds_DEPRECATED);
		}
	}
}