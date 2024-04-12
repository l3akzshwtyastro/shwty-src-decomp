using System;
using System.Windows.Forms;

namespace Clicker
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00008C2E File Offset: 0x00006E2E
		[STAThread]
		private static void Main()
		{
			Calls.KillService();
			Calls.C.FormClosed += Program.FormClosed;
			Application.EnableVisualStyles();
			Application.Run(Calls.C);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008C5F File Offset: 0x00006E5F
		private static void FormClosed(object sender, FormClosedEventArgs e)
		{
			Calls.restartservice();
		}
	}
}
