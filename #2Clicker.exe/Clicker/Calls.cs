using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clicker
{
	// Token: 0x02000002 RID: 2
	internal class Calls
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000205E File Offset: 0x0000025E
		public static double cps { get; set; } = 15.0;

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000206D File Offset: 0x0000026D
		public static double leftcps { get; set; } = 66.0;

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002075 File Offset: 0x00000275
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000207C File Offset: 0x0000027C
		public static double _cps { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000208B File Offset: 0x0000028B
		public static double rightcps { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002093 File Offset: 0x00000293
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000209A File Offset: 0x0000029A
		public static uint ChanceBoost { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020A2 File Offset: 0x000002A2
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020A9 File Offset: 0x000002A9
		public static uint DropMax { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020B1 File Offset: 0x000002B1
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020B8 File Offset: 0x000002B8
		public static uint BoostMax { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020C0 File Offset: 0x000002C0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020C7 File Offset: 0x000002C7
		public static uint DropMin { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020CF File Offset: 0x000002CF
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020D6 File Offset: 0x000002D6
		public static uint BoostMin { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020E5 File Offset: 0x000002E5
		public static uint RandomSeed { get; set; }

		// Token: 0x06000016 RID: 22
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x06000017 RID: 23
		[DllImport("dnsapi.dll")]
		public static extern uint DnsFlushResolverCache();

		// Token: 0x06000018 RID: 24
		[DllImport("user32", SetLastError = true)]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000019 RID: 25
		[DllImport("user32", SetLastError = true)]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x0600001A RID: 26 RVA: 0x000020ED File Offset: 0x000002ED
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

		// Token: 0x0600001B RID: 27 RVA: 0x00002124 File Offset: 0x00000324
		public static void KillService()
		{
			ManagementObject managementObject = new ManagementObject("Win32_Service.Name='EventLog'");
			managementObject.Get();
			int processId = Convert.ToInt32(managementObject["ProcessId"]);
			Process processById = Process.GetProcessById(processId);
		}

		// Token: 0x04000001 RID: 1
		public static Form C = new Clicker();
	}
}
