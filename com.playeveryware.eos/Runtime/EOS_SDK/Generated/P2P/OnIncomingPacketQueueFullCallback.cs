// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Callback for information related to incoming connection requests.
	/// </summary>
	public delegate void OnIncomingPacketQueueFullCallback(ref OnIncomingPacketQueueFullInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnIncomingPacketQueueFullCallbackInternal(ref OnIncomingPacketQueueFullInfoInternal data);
}