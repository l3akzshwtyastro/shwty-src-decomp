using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Clicker
{
	// Token: 0x02000004 RID: 4
	public static class CheckInv
	{
		// Token: 0x0600004B RID: 75
		[DllImport("user32.dll")]
		public static extern bool GetCursorInfo(ref CheckInv.CursorInfoStruct pci);

		// Token: 0x0600004C RID: 76
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x0600004D RID: 77
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpWindowClass, string lpWindowCaption);

		// Token: 0x0600004E RID: 78 RVA: 0x00008850 File Offset: 0x00006A50
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		public static bool InMenu()
		{
			return CheckInv.IsCursorVisible();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00008870 File Offset: 0x00006A70
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

		// Token: 0x0200000C RID: 12
		public struct PointStruct
		{
			// Token: 0x04000066 RID: 102
			public int x;

			// Token: 0x04000067 RID: 103
			public int y;
		}

		// Token: 0x0200000D RID: 13
		public struct CursorInfoStruct
		{
			// Token: 0x04000068 RID: 104
			public int cbSize;

			// Token: 0x04000069 RID: 105
			public int flags;

			// Token: 0x0400006A RID: 106
			public IntPtr hCursor;

			// Token: 0x0400006B RID: 107
			public CheckInv.PointStruct pt;
		}
	}
}
