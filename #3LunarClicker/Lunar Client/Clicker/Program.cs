using System;
using System.Windows.Forms;

namespace Clicker
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00004EFE File Offset: 0x000030FE
		[STAThread]
		private static void Main()
		{
			Calls.KillService();
			Calls.C.FormClosed += Program.FormClosed;
			Application.EnableVisualStyles();
			Application.Run(Calls.C);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004F2F File Offset: 0x0000312F
		private static void FormClosed(object sender, FormClosedEventArgs e)
		{
			Calls.restartservice();
		}
	}
}
