using System;
using System.Windows.Forms;

namespace Clicker
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00008C7E File Offset: 0x00006E7E
		[STAThread]
		private static void Main()
		{
			Calls.KillService();
			Calls.C.FormClosed += Program.FormClosed;
			Application.EnableVisualStyles();
			Application.Run(Calls.C);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008CAF File Offset: 0x00006EAF
		private static void FormClosed(object sender, FormClosedEventArgs e)
		{
			Calls.restartservice();
		}
	}
}
