using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Clicker
{
	// Token: 0x02000005 RID: 5
	public static class CheckInv
	{
		// Token: 0x0600004E RID: 78
		[DllImport("user32.dll")]
		public static extern bool GetCursorInfo(ref CheckInv.CursorInfoStruct pci);

		// Token: 0x0600004F RID: 79
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000050 RID: 80
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpWindowClass, string lpWindowCaption);

		// Token: 0x06000051 RID: 81 RVA: 0x000088A0 File Offset: 0x00006AA0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		public static bool InMenu()
		{
			return CheckInv.IsCursorVisible();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000088C0 File Offset: 0x00006AC0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		public static bool IsCursorVisible()
		{
			CheckInv.CursorInfoStruct cursorInfoStruct = new CheckInv.CursorInfoStruct
			{
				cbSize = Marshal.SizeOf(typeof(CheckInv.CursorInfoStruct))
			};
			CheckInv.GetCursorInfo(ref cursorInfoStruct);
			bool flag = cursorInfoStruct.hCursor.ToInt32() > 100000;
			return !flag;
		}

		// Token: 0x02000006 RID: 6
		public struct PointStruct
		{
			// Token: 0x04000060 RID: 96
			public int x;

			// Token: 0x04000061 RID: 97
			public int y;
		}

		// Token: 0x02000007 RID: 7
		public struct CursorInfoStruct
		{
			// Token: 0x04000062 RID: 98
			public int cbSize;

			// Token: 0x04000063 RID: 99
			public int flags;

			// Token: 0x04000064 RID: 100
			public IntPtr hCursor;

			// Token: 0x04000065 RID: 101
			public CheckInv.PointStruct pt;
		}
	}
}
