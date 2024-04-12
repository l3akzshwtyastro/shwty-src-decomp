using System;
using System.Runtime.InteropServices;

namespace Clicker
{
	// Token: 0x02000007 RID: 7
	public static class CheckInv
	{
		// Token: 0x0600004F RID: 79
		[DllImport("user32.dll")]
		public static extern bool GetCursorInfo(ref CheckInv.CursorInfoStruct pci);

		// Token: 0x06000050 RID: 80
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000051 RID: 81
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpWindowClass, string lpWindowCaption);

		// Token: 0x06000052 RID: 82 RVA: 0x00004B20 File Offset: 0x00002D20
		public static bool InMenu()
		{
			return CheckInv.IsCursorVisible();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004B40 File Offset: 0x00002D40
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

		// Token: 0x02000008 RID: 8
		public struct PointStruct
		{
			// Token: 0x04000035 RID: 53
			public int x;

			// Token: 0x04000036 RID: 54
			public int y;
		}

		// Token: 0x02000009 RID: 9
		public struct CursorInfoStruct
		{
			// Token: 0x04000037 RID: 55
			public int cbSize;

			// Token: 0x04000038 RID: 56
			public int flags;

			// Token: 0x04000039 RID: 57
			public IntPtr hCursor;

			// Token: 0x0400003A RID: 58
			public CheckInv.PointStruct pt;
		}
	}
}
