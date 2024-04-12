using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Clicker.Mods;
using ColorSlider;
using Guna.UI2.Native;
using Guna.UI2.WinForms;

namespace Clicker
{
	// Token: 0x02000005 RID: 5
	public partial class Clicker : Form
	{
		// Token: 0x06000025 RID: 37
		[DllImport("winmm.dll", EntryPoint = "timeBeginPeriod")]
		public static extern uint TimeBeginPeriod(uint uMilliseconds);

		// Token: 0x06000026 RID: 38 RVA: 0x0000223C File Offset: 0x0000043C
		public Clicker()
		{
			this.IsHWIDAuthorized();
			this.randomizer.Elapsed += this.randomvent;
			this.InitializeComponent();
			Clicker.TimeBeginPeriod(1U);
			this.randomizer.Enabled = true;
			Calls.BoostMax = 4U;
			Calls.BoostMin = 2U;
			Calls.RandomSeed = 100U;
			Calls.ChanceBoost = 65U;
			Calls.DropMax = 3U;
			Calls.DropMin = 1U;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000022F4 File Offset: 0x000004F4
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg == 786;
			if (flag)
			{
				int num = m.WParam.ToInt32();
				bool flag2 = num == 1;
				if (flag2)
				{
					this.statusleft.Checked = !this.statusleft.Checked;
				}
				bool flag3 = num == 2;
				if (flag3)
				{
					base.Visible = !base.Visible;
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000236C File Offset: 0x0000056C
		private void Clickvent()
		{
			while (!this.CancelTokenLeft.IsCancellationRequested)
			{
				if ((Control.MouseButtons & MouseButtons.Left) <= MouseButtons.None)
				{
					Thread.Sleep(1);
				}
				else
				{
					Thread.Sleep(0);
				}
				bool flag = (this.Inventory.Checked && Clicker.GetAsyncKeyState(Keys.LShiftKey) != 0 && CheckInv.IsCursorVisible()) || (this.Inventory.Checked && !CheckInv.IsCursorVisible()) || (!this.Inventory.Checked && !CheckInv.IsCursorVisible() && Clicker.GetAsyncKeyState(Keys.LShiftKey) == 0);
				if (flag)
				{
					bool flag2 = this.vermode;
					if (flag2)
					{
						Core.Mode18(this.javah, (int)Calls.leftcps).Wait();
					}
					else
					{
						bool flag3 = this.blocks;
						if (flag3)
						{
							Core.breakblock(this.javah, (int)Calls.leftcps).Wait();
						}
						else
						{
							Core.leftclick(this.javah, (int)Calls.leftcps).Wait();
						}
					}
				}
			}
		}

		// Token: 0x06000029 RID: 41
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600002A RID: 42 RVA: 0x0000248C File Offset: 0x0000068C
		private void RightClickvent()
		{
			while (!this.CancelTokenRight.IsCancellationRequested)
			{
				if ((Control.MouseButtons & MouseButtons.Right) <= MouseButtons.None)
				{
					Thread.Sleep(1);
				}
				else
				{
					Thread.Sleep(0);
				}
				bool flag = (this.Inventory.Checked && Clicker.GetAsyncKeyState(Keys.LShiftKey) != 0 && CheckInv.IsCursorVisible()) || (this.Inventory.Checked && !CheckInv.IsCursorVisible()) || (!this.Inventory.Checked && !CheckInv.IsCursorVisible() && Clicker.GetAsyncKeyState(Keys.LShiftKey) == 0);
				if (flag)
				{
					Core.rightclick(this.javah, (int)Calls.rightcps).Wait();
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000255C File Offset: 0x0000075C
		private void randomvent(object sender, ElapsedEventArgs e)
		{
			this.randomizer.Interval = (double)Clicker.random.Rnd(500, 1000);
			int num = Clicker.random.Rnd(0, 100);
			bool flag = (long)num < (long)((ulong)Calls.ChanceBoost);
			if (flag)
			{
				int num2 = Clicker.random.Rnd(Calls.BoostMin, Calls.BoostMax);
				Calls.leftcps = 1000.0 / (Calls.cps + (double)num2);
			}
			else
			{
				int num3 = Clicker.random.Rnd(Calls.DropMin, Calls.DropMax);
				Calls.leftcps = 1000.0 / (Calls.cps - (double)num3);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000262F File Offset: 0x0000082F
		private void WindowFinder_Tick(object sender, EventArgs e)
		{
			this.javah = WinApi.FindWindow("LWJGL", null);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002643 File Offset: 0x00000843
		private void Clicker_Load(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002650 File Offset: 0x00000850
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void colorSlider1_ValueChanged(object sender, EventArgs e)
		{
			this.Lcps.Text = (this.Lcpsslider.Value / 10m).ToString("F1");
			Calls.cps = (double)this.Lcpsslider.Value / 10.0;
			Calls.leftcps = (double)(10000m / this.Lcpsslider.Value);
			Calls._cps = (double)this.Lcpsslider.Value / 10.0;
			Calls.rightcps = (double)(10000m / this.Lcpsslider.Value);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000271C File Offset: 0x0000091C
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void blatant_CheckedChanged(object sender, EventArgs e)
		{
			this.Lcpsslider.Maximum = (this.blatant.Checked ? 250 : 200);
			this.Lcpsslider.MouseWheelBarPartitions = (this.blatant.Checked ? 200 : 150);
			bool @checked = this.blatant.Checked;
			if (@checked)
			{
				Calls.BoostMax = 4U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 55U;
				Calls.DropMax = 2U;
				Calls.DropMin = 1U;
			}
			else
			{
				Calls.BoostMax = 3U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 35U;
				Calls.DropMax = 4U;
				Calls.DropMin = 2U;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000027E8 File Offset: 0x000009E8
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void breakblock_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.breakblock.Checked;
			if (@checked)
			{
				this.blocks = true;
				this.mode.Checked = false;
			}
			else
			{
				this.blocks = false;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002828 File Offset: 0x00000A28
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void mode_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.mode.Checked;
			if (@checked)
			{
				this.vermode = true;
				this.breakblock.Checked = false;
			}
			else
			{
				this.vermode = false;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002868 File Offset: 0x00000A68
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void statusleft_CheckedChanged(object sender, EventArgs e)
		{
			this.CancelTokenLeft = new CancellationTokenSource();
			bool @checked = this.statusleft.Checked;
			if (@checked)
			{
				new Task(delegate(object Action)
				{
					this.Clickvent();
				}, this.CancelTokenLeft.Token, TaskCreationOptions.LongRunning).Start();
			}
			else
			{
				this.CancelTokenLeft.Cancel();
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000028CC File Offset: 0x00000ACC
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void statusright_CheckedChanged(object sender, EventArgs e)
		{
			this.CancelTokenRight = new CancellationTokenSource();
			bool @checked = this.statusright.Checked;
			if (@checked)
			{
				new Task(delegate(object Action)
				{
					this.RightClickvent();
				}, this.CancelTokenRight.Token, TaskCreationOptions.LongRunning).Start();
			}
			else
			{
				this.CancelTokenRight.Cancel();
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000292E File Offset: 0x00000B2E
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void Bind_Click(object sender, EventArgs e)
		{
			this.Bind.Text = "[...]";
			this.Bind.Checked = true;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002950 File Offset: 0x00000B50
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void Bind_KeyDown(object sender, KeyEventArgs e)
		{
			bool @checked = this.Bind.Checked;
			if (@checked)
			{
				bool flag = e.KeyCode == Keys.Escape;
				if (flag)
				{
					this.Bind.Text = "[bind]";
				}
				else
				{
					this.Bind.Text = string.Format("[{0}]", e.KeyCode);
					Calls.UnregisterHotKey(base.Handle, 1);
					Keys keyCode = e.KeyCode;
					Calls.RegisterHotKey(base.Handle, 1, 0U, (uint)keyCode);
				}
				this.Bind.Checked = false;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000029EA File Offset: 0x00000BEA
		private void Lcpsslider_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000029F0 File Offset: 0x00000BF0
		private void Clicker_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = new ServiceController("EventLog").Status == ServiceControllerStatus.Stopped;
			if (flag)
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Prefetch";
				string[] files = Directory.GetFiles(path);
				foreach (string text in files)
				{
					bool flag2 = text.ToLower().Contains(AppDomain.CurrentDomain.FriendlyName.ToLower());
					if (flag2)
					{
						this.preffiles.Add(text);
					}
				}
				string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp";
				string[] files2 = Directory.GetFiles(path2);
				foreach (string item in files2)
				{
					this.tempfiles.Add(item);
				}
				foreach (string path3 in this.tempfiles)
				{
					try
					{
						File.Delete(path3);
					}
					catch
					{
					}
				}
				foreach (string path4 in this.preffiles)
				{
					try
					{
						File.Delete(path4);
					}
					catch
					{
					}
				}
				Calls.DnsFlushResolverCache();
				base.Close();
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002B9C File Offset: 0x00000D9C
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void hbind_Click(object sender, EventArgs e)
		{
			this.hbind.Text = "[...]";
			this.hbind.Checked = true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002BC0 File Offset: 0x00000DC0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void hbind_KeyDown(object sender, KeyEventArgs e)
		{
			bool @checked = this.hbind.Checked;
			if (@checked)
			{
				bool flag = e.KeyCode == Keys.Escape;
				if (flag)
				{
					this.hbind.Text = "[bind]";
				}
				else
				{
					this.hbind.Text = string.Format("[{0}]", e.KeyCode);
					Calls.UnregisterHotKey(base.Handle, 2);
					Keys keyCode = e.KeyCode;
					Calls.RegisterHotKey(base.Handle, 2, 0U, (uint)keyCode);
				}
				this.hbind.Checked = false;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000029EA File Offset: 0x00000BEA
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C5C File Offset: 0x00000E5C
		public bool IsHWIDAuthorized()
		{
			string text = Clicker.EncryptionUtils.EncryptBase64(HWID.getUniqueSerialId());
			string text2 = this.DownloadAuthorizedHWIDs();
			bool flag = text2.Contains(text);
			bool result;
			if (flag)
			{
				base.Show();
				result = true;
			}
			else
			{
				MessageBox.Show("Invalid HWID");
				Clipboard.SetText(text);
				base.Close();
				result = false;
			}
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002CB4 File Offset: 0x00000EB4
		private string DownloadAuthorizedHWIDs()
		{
			string result;
			try
			{
				WebRequest webRequest = WebRequest.Create("https://pastebin.com/pM19uS51");
				webRequest.Method = "GET";
				using (WebResponse response = webRequest.GetResponse())
				{
					using (Stream responseStream = response.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error downloading authorized HWIDs: " + ex.Message, "Failed");
				Environment.Exit(-1);
				return string.Empty;
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002D94 File Offset: 0x00000F94
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void statusleft_CheckedChanged_1(object sender, EventArgs e)
		{
			this.CancelTokenLeft = new CancellationTokenSource();
			bool @checked = this.statusleft.Checked;
			if (@checked)
			{
				new Task(delegate(object Action)
				{
					this.Clickvent();
				}, this.CancelTokenLeft.Token, TaskCreationOptions.LongRunning).Start();
				Calls.BoostMax = 2U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 35U;
				Calls.DropMax = 4U;
				Calls.DropMin = 1U;
			}
			else
			{
				this.CancelTokenLeft.Cancel();
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002E24 File Offset: 0x00001024
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void blatant_CheckedChanged_1(object sender, EventArgs e)
		{
			this.Lcpsslider.Maximum = (this.blatant.Checked ? 300 : 250);
			this.Lcpsslider.MouseWheelBarPartitions = (this.blatant.Checked ? 200 : 150);
			bool @checked = this.blatant.Checked;
			if (@checked)
			{
				Calls.BoostMax = 4U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 55U;
				Calls.DropMax = 2U;
				Calls.DropMin = 1U;
			}
			else
			{
				Calls.BoostMax = 2U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 35U;
				Calls.DropMax = 4U;
				Calls.DropMin = 1U;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002EF0 File Offset: 0x000010F0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void statusright_CheckedChanged_1(object sender, EventArgs e)
		{
			this.CancelTokenRight = new CancellationTokenSource();
			bool @checked = this.statusright.Checked;
			if (@checked)
			{
				new Task(delegate(object Action)
				{
					this.RightClickvent();
				}, this.CancelTokenRight.Token, TaskCreationOptions.LongRunning).Start();
			}
			else
			{
				this.CancelTokenRight.Cancel();
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002F54 File Offset: 0x00001154
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void mode_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.mode.Checked;
			if (@checked)
			{
				this.vermode = true;
				this.breakblock.Checked = false;
			}
			else
			{
				this.vermode = false;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002F94 File Offset: 0x00001194
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void breakblock_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.breakblock.Checked;
			if (@checked)
			{
				this.blocks = true;
				this.mode.Checked = false;
			}
			else
			{
				this.blocks = false;
			}
		}

		// Token: 0x06000042 RID: 66
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

		// Token: 0x06000043 RID: 67 RVA: 0x00002FD4 File Offset: 0x000011D4
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.NINJAMODE.Checked;
			if (@checked)
			{
				base.ShowInTaskbar = false;
				Clicker.SetWindowDisplayAffinity(base.Handle, 17U);
			}
			else
			{
				Clicker.SetWindowDisplayAffinity(base.Handle, 0U);
				base.ShowInTaskbar = true;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000029EA File Offset: 0x00000BEA
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000029EA File Offset: 0x00000BEA
		private void Clicker_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x0400000F RID: 15
		private IntPtr javah;

		// Token: 0x04000010 RID: 16
		private bool leftlock;

		// Token: 0x04000011 RID: 17
		private bool blocks;

		// Token: 0x04000012 RID: 18
		private bool vermode;

		// Token: 0x04000013 RID: 19
		private bool foodorrod;

		// Token: 0x04000014 RID: 20
		private bool rightlock;

		// Token: 0x04000015 RID: 21
		public static Randomize random = new Randomize(Calls.RandomSeed);

		// Token: 0x04000016 RID: 22
		private readonly System.Timers.Timer randomizer = new System.Timers.Timer();

		// Token: 0x04000017 RID: 23
		private CancellationTokenSource CancelTokenLeft;

		// Token: 0x04000018 RID: 24
		private CancellationTokenSource CancelTokenRight;

		// Token: 0x04000019 RID: 25
		private string HWIDcomp = WindowsIdentity.GetCurrent().User.Value;

		// Token: 0x0400001A RID: 26
		public List<string> preffiles = new List<string>();

		// Token: 0x0400001B RID: 27
		public uint dns;

		// Token: 0x0400001C RID: 28
		public List<string> tempfiles = new List<string>();

		// Token: 0x0400001D RID: 29
		private const string PastebinURL = "https://pastebin.com/pM19uS51";

		// Token: 0x02000006 RID: 6
		public static class EncryptionUtils
		{
			// Token: 0x0600004D RID: 77 RVA: 0x00004AD8 File Offset: 0x00002CD8
			public static string EncryptBase64(string input)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(input);
				return Convert.ToBase64String(bytes);
			}

			// Token: 0x0600004E RID: 78 RVA: 0x00004AFC File Offset: 0x00002CFC
			public static string DecryptBase64(string input)
			{
				byte[] bytes = Convert.FromBase64String(input);
				return Encoding.UTF8.GetString(bytes);
			}
		}
	}
}
