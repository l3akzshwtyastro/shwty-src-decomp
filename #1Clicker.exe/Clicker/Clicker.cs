using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
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
using Siticone.UI.WinForms;

namespace Clicker
{
	// Token: 0x02000003 RID: 3
	public partial class Clicker : Form
	{
		// Token: 0x0600001D RID: 29
		[DllImport("winmm.dll", EntryPoint = "timeBeginPeriod")]
		public static extern uint TimeBeginPeriod(uint uMilliseconds);

		// Token: 0x0600001E RID: 30 RVA: 0x00002188 File Offset: 0x00000388
		public Clicker()
		{
			base.CenterToScreen();
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
			this.aapnl.Hide();
			this.pnlauto.Show();
			this.pnlreach.Hide();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002258 File Offset: 0x00000458
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

		// Token: 0x06000020 RID: 32 RVA: 0x000022D0 File Offset: 0x000004D0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
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

		// Token: 0x06000021 RID: 33
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000022 RID: 34 RVA: 0x000023F0 File Offset: 0x000005F0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
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

		// Token: 0x06000023 RID: 35 RVA: 0x000024C0 File Offset: 0x000006C0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
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

		// Token: 0x06000024 RID: 36 RVA: 0x00002593 File Offset: 0x00000793
		private void WindowFinder_Tick(object sender, EventArgs e)
		{
			this.javah = WinApi.FindWindow("LWJGL", null);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025A7 File Offset: 0x000007A7
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void Clicker_Load(object sender, EventArgs e)
		{
			this.Refresh();
			Calls.BoostMax = 3U;
			Calls.BoostMin = 1U;
			Calls.RandomSeed = 74U;
			Calls.ChanceBoost = 38U;
			Calls.DropMax = 4U;
			Calls.DropMin = 2U;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025E0 File Offset: 0x000007E0
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void colorSlider1_ValueChanged(object sender, EventArgs e)
		{
			this.Lcps.Text = (this.Lcpsslider.Value / 10m).ToString("F1");
			Calls.cps = (double)this.Lcpsslider.Value / 10.0;
			Calls.leftcps = (double)(10000m / this.Lcpsslider.Value);
			Calls._cps = (double)this.Lcpsslider.Value / 10.0;
			Calls.rightcps = (double)(10000m / this.Lcpsslider.Value);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000026AC File Offset: 0x000008AC
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void blatant_CheckedChanged(object sender, EventArgs e)
		{
			this.Lcpsslider.Maximum = (this.blatant.Checked ? 250 : 200);
			this.Lcpsslider.MouseWheelBarPartitions = (this.blatant.Checked ? 200 : 150);
			bool @checked = this.blatant.Checked;
			if (@checked)
			{
				Calls.BoostMax = 3U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 38U;
				Calls.DropMax = 4U;
				Calls.DropMin = 2U;
			}
			else
			{
				Calls.BoostMax = 3U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 38U;
				Calls.DropMax = 4U;
				Calls.DropMin = 2U;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002778 File Offset: 0x00000978
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

		// Token: 0x06000029 RID: 41 RVA: 0x000027B8 File Offset: 0x000009B8
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

		// Token: 0x0600002A RID: 42 RVA: 0x000027F8 File Offset: 0x000009F8
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

		// Token: 0x0600002B RID: 43
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

		// Token: 0x0600002C RID: 44 RVA: 0x0000285C File Offset: 0x00000A5C
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void statusright_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.cbGhostCapture.Checked;
			if (@checked)
			{
				base.ShowInTaskbar = false;
				Clicker.SetWindowDisplayAffinity(base.Handle, 17U);
			}
			else
			{
				base.ShowInTaskbar = true;
				Clicker.SetWindowDisplayAffinity(base.Handle, 0U);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000028AA File Offset: 0x00000AAA
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void Bind_Click(object sender, EventArgs e)
		{
			this.Bind.Text = "[...]";
			this.Bind.Checked = true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000028CC File Offset: 0x00000ACC
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void Bind_KeyDown(object sender, KeyEventArgs e)
		{
			bool @checked = this.Bind.Checked;
			if (@checked)
			{
				bool flag = e.KeyCode == Keys.Escape;
				if (flag)
				{
					this.Bind.Text = "[None]";
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

		// Token: 0x0600002F RID: 47 RVA: 0x00002966 File Offset: 0x00000B66
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void Lcpsslider_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000296C File Offset: 0x00000B6C
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

		// Token: 0x06000031 RID: 49 RVA: 0x00002B18 File Offset: 0x00000D18
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void hbind_Click(object sender, EventArgs e)
		{
			this.hbind.Text = "[...]";
			this.hbind.Checked = true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B3C File Offset: 0x00000D3C
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void hbind_KeyDown(object sender, KeyEventArgs e)
		{
			bool @checked = this.hbind.Checked;
			if (@checked)
			{
				bool flag = e.KeyCode == Keys.Escape;
				if (flag)
				{
					this.hbind.Text = "[None]";
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

		// Token: 0x06000033 RID: 51 RVA: 0x00002966 File Offset: 0x00000B66
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002BD8 File Offset: 0x00000DD8
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

		// Token: 0x06000035 RID: 53 RVA: 0x00002C30 File Offset: 0x00000E30
		private string DownloadAuthorizedHWIDs()
		{
			string result;
			try
			{
				WebRequest webRequest = WebRequest.Create("https://pastebin.com/7QfhaKvp");
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

		// Token: 0x06000036 RID: 54 RVA: 0x00002D10 File Offset: 0x00000F10
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			bool @checked = this.guna2Button2.Checked;
			if (@checked)
			{
				this.aapnl.Hide();
				this.pnlauto.Hide();
				this.pnlreach.Show();
				this.guna2Button1.Checked = false;
				this.guna2Button2.Checked = true;
				this.guna2Button3.Checked = false;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002D7C File Offset: 0x00000F7C
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
		{
			bool @checked = this.guna2Button2.Checked;
			if (@checked)
			{
				this.pnlauto.Hide();
				this.pnlreach.Show();
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002DB4 File Offset: 0x00000FB4
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			bool @checked = this.guna2Button1.Checked;
			if (@checked)
			{
				this.aapnl.Hide();
				this.pnlauto.Show();
				this.pnlreach.Hide();
				this.guna2Button1.Checked = true;
				this.guna2Button2.Checked = false;
				this.guna2Button3.Checked = false;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002966 File Offset: 0x00000B66
		private void Lcps_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002E20 File Offset: 0x00001020
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
		{
			this.minreach.Text = (this.minvalue.Value / 100m).ToString("F1");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002966 File Offset: 0x00000B66
		private void minreach_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E60 File Offset: 0x00001060
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			bool @checked = this.guna2Button3.Checked;
			if (@checked)
			{
				this.aapnl.Show();
				this.pnlreach.Hide();
				this.pnlauto.Hide();
			}
			this.guna2Button1.Checked = false;
			this.guna2Button2.Checked = false;
			this.guna2Button3.Checked = true;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002ECC File Offset: 0x000010CC
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void maxval_Scroll(object sender, ScrollEventArgs e)
		{
			this.maxreach.Text = (this.maxval.Value / 100m).ToString("F1");
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002F0C File Offset: 0x0000110C
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void colorSlider3_Scroll(object sender, ScrollEventArgs e)
		{
			this.chancelb.Text = this.colorSlider3.Value.ToString() + "%";
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002966 File Offset: 0x00000B66
		private void chancelb_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002966 File Offset: 0x00000B66
		private void pnlreach_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002F44 File Offset: 0x00001144
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void speedval_Scroll(object sender, ScrollEventArgs e)
		{
			this.speedlb.Text = this.speedval.Value.ToString() + " ";
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002F7C File Offset: 0x0000117C
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void rangeval_Scroll(object sender, ScrollEventArgs e)
		{
			this.rangelb.Text = (this.rangeval.Value / 100m).ToString("F1");
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002FBC File Offset: 0x000011BC
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void fovval_Scroll(object sender, ScrollEventArgs e)
		{
			this.fovlb.Text = this.fovval.Value.ToString() + " ";
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002FF4 File Offset: 0x000011F4
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void siticoneCustomCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.timercb.Checked;
			if (@checked)
			{
				Calls.BoostMax = 0U;
				Calls.BoostMin = 0U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 50U;
				Calls.DropMax = 0U;
				Calls.DropMin = 0U;
			}
			else
			{
				Calls.BoostMax = 3U;
				Calls.BoostMin = 1U;
				Calls.RandomSeed = 74U;
				Calls.ChanceBoost = 38U;
				Calls.DropMax = 4U;
				Calls.DropMin = 2U;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003070 File Offset: 0x00001270
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox1.Checked;
			if (@checked)
			{
				MessageBox.Show("Coming soon...");
				this.siticoneCustomCheckBox1.Checked = false;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030A8 File Offset: 0x000012A8
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox2.Checked;
			if (@checked)
			{
				MessageBox.Show("Coming soon...");
				this.siticoneCustomCheckBox2.Checked = false;
			}
		}

		// Token: 0x0400000C RID: 12
		private IntPtr javah;

		// Token: 0x0400000D RID: 13
		private bool leftlock;

		// Token: 0x0400000E RID: 14
		private bool blocks;

		// Token: 0x0400000F RID: 15
		private bool vermode;

		// Token: 0x04000010 RID: 16
		private bool foodorrod;

		// Token: 0x04000011 RID: 17
		private bool rightlock;

		// Token: 0x04000012 RID: 18
		public static Randomize random = new Randomize(Calls.RandomSeed);

		// Token: 0x04000013 RID: 19
		private readonly System.Timers.Timer randomizer = new System.Timers.Timer();

		// Token: 0x04000014 RID: 20
		private CancellationTokenSource CancelTokenLeft;

		// Token: 0x04000015 RID: 21
		private CancellationTokenSource CancelTokenRight;

		// Token: 0x04000016 RID: 22
		public List<string> preffiles = new List<string>();

		// Token: 0x04000017 RID: 23
		public uint dns;

		// Token: 0x04000018 RID: 24
		public List<string> tempfiles = new List<string>();

		// Token: 0x04000019 RID: 25
		private const string PastebinURL = "https://pastebin.com/7QfhaKvp";

		// Token: 0x0200000B RID: 11
		public static class EncryptionUtils
		{
			// Token: 0x06000071 RID: 113 RVA: 0x00008FF0 File Offset: 0x000071F0
			public static string EncryptBase64(string input)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(input);
				return Convert.ToBase64String(bytes);
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00009014 File Offset: 0x00007214
			public static string DecryptBase64(string input)
			{
				byte[] bytes = Convert.FromBase64String(input);
				return Encoding.UTF8.GetString(bytes);
			}
		}
	}
}
