using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clicker
{
	// Token: 0x02000004 RID: 4
	internal class Calls
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002102 File Offset: 0x00000302
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002109 File Offset: 0x00000309
		public static double cps { get; set; } = 15.0;

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002111 File Offset: 0x00000311
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002118 File Offset: 0x00000318
		public static double leftcps { get; set; } = 66.0;

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002120 File Offset: 0x00000320
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002127 File Offset: 0x00000327
		public static double _cps { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000212F File Offset: 0x0000032F
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002136 File Offset: 0x00000336
		public static double rightcps { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002145 File Offset: 0x00000345
		public static uint ChanceBoost { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000214D File Offset: 0x0000034D
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002154 File Offset: 0x00000354
		public static uint DropMax { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000215C File Offset: 0x0000035C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002163 File Offset: 0x00000363
		public static uint BoostMax { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000216B File Offset: 0x0000036B
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002172 File Offset: 0x00000372
		public static uint DropMin { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000217A File Offset: 0x0000037A
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002181 File Offset: 0x00000381
		public static uint BoostMin { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002189 File Offset: 0x00000389
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002190 File Offset: 0x00000390
		public static uint RandomSeed { get; set; }

		// Token: 0x0600001D RID: 29
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x0600001E RID: 30
		[DllImport("dnsapi.dll")]
		public static extern uint DnsFlushResolverCache();

		// Token: 0x0600001F RID: 31
		[DllImport("user32", SetLastError = true)]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000020 RID: 32
		[DllImport("user32", SetLastError = true)]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06000021 RID: 33 RVA: 0x00002198 File Offset: 0x00000398
		public static void restartservice()
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C ping 192.168.1.1 -n 5 && sc start eventlog",
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "cmd.exe"
			});
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021D0 File Offset: 0x000003D0
		public static void KillService()
		{
			ManagementObject managementObject = new ManagementObject("Win32_Service.Name='EventLog'");
			managementObject.Get();
			int processId = Convert.ToInt32(managementObject["ProcessId"]);
			Process processById = Process.GetProcessById(processId);
		}

		// Token: 0x04000004 RID: 4
		public static Form C = new Clicker();
	}
}
