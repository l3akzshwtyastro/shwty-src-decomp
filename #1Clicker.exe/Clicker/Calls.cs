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
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public static double cps { get; set; } = 15.0;

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000205F File Offset: 0x0000025F
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		public static double leftcps { get; set; } = 66.0;

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206E File Offset: 0x0000026E
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002075 File Offset: 0x00000275
		public static double _cps { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000207D File Offset: 0x0000027D
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		public static double rightcps { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000208C File Offset: 0x0000028C
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002093 File Offset: 0x00000293
		public static uint ChanceBoost { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000209B File Offset: 0x0000029B
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020A2 File Offset: 0x000002A2
		public static uint DropMax { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020AA File Offset: 0x000002AA
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020B1 File Offset: 0x000002B1
		public static uint BoostMax { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020B9 File Offset: 0x000002B9
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020C0 File Offset: 0x000002C0
		public static uint DropMin { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020CF File Offset: 0x000002CF
		public static uint BoostMin { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020D7 File Offset: 0x000002D7
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020DE File Offset: 0x000002DE
		public static uint RandomSeed { get; set; }

		// Token: 0x06000015 RID: 21
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x06000016 RID: 22
		[DllImport("dnsapi.dll")]
		public static extern uint DnsFlushResolverCache();

		// Token: 0x06000017 RID: 23
		[DllImport("user32", SetLastError = true)]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000018 RID: 24
		[DllImport("user32", SetLastError = true)]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06000019 RID: 25 RVA: 0x000020E6 File Offset: 0x000002E6
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

		// Token: 0x0600001A RID: 26 RVA: 0x0000211C File Offset: 0x0000031C
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
