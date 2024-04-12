namespace Clicker
{
	// Token: 0x02000003 RID: 3
	public partial class Clicker : global::System.Windows.Forms.Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000030E0 File Offset: 0x000012E0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003118 File Offset: 0x00001318
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.hbind = new global::Guna.UI2.WinForms.Guna2Button();
			this.Bind = new global::Guna.UI2.WinForms.Guna2Button();
			this.Lcps = new global::System.Windows.Forms.Label();
			this.Lcpsslider = new global::ColorSlider.ColorSlider();
			this.WindowFinder = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.statusleft = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.cbGhostCapture = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.breakblock = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.mode = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.blatant = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.Inventory = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.guna2VSeparator1 = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.siticoneCustomCheckBox1 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.siticoneCustomCheckBox2 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.timercb = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.pnlauto = new global::System.Windows.Forms.Panel();
			this.pnlreach = new global::System.Windows.Forms.Panel();
			this.label25 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox10 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label26 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox11 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.chancelb = new global::System.Windows.Forms.Label();
			this.colorSlider3 = new global::ColorSlider.ColorSlider();
			this.label18 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox5 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox8 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.maxval = new global::ColorSlider.ColorSlider();
			this.maxreach = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.minvalue = new global::ColorSlider.ColorSlider();
			this.minreach = new global::System.Windows.Forms.Label();
			this.guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label11 = new global::System.Windows.Forms.Label();
			this.aapnl = new global::System.Windows.Forms.Panel();
			this.label23 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox7 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label24 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox9 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox4 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox6 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.label22 = new global::System.Windows.Forms.Label();
			this.fovval = new global::ColorSlider.ColorSlider();
			this.fovlb = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.rangeval = new global::ColorSlider.ColorSlider();
			this.rangelb = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.speedval = new global::ColorSlider.ColorSlider();
			this.speedlb = new global::System.Windows.Forms.Label();
			this.guna2Button5 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label12 = new global::System.Windows.Forms.Label();
			this.pnlauto.SuspendLayout();
			this.pnlreach.SuspendLayout();
			this.aapnl.SuspendLayout();
			base.SuspendLayout();
			this.hbind.Animated = true;
			this.hbind.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.hbind.ButtonMode = 2;
			this.hbind.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.hbind.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.hbind.CheckedState.Parent = this.hbind;
			this.hbind.CustomImages.Parent = this.hbind;
			this.hbind.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.hbind.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.hbind.ForeColor = global::System.Drawing.Color.White;
			this.hbind.HoverState.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.hbind.HoverState.Parent = this.hbind;
			this.hbind.Location = new global::System.Drawing.Point(306, 251);
			this.hbind.Name = "hbind";
			this.hbind.ShadowDecoration.Parent = this.hbind;
			this.hbind.Size = new global::System.Drawing.Size(45, 13);
			this.hbind.TabIndex = 3;
			this.hbind.Text = "[None]";
			this.hbind.Click += new global::System.EventHandler(this.hbind_Click);
			this.hbind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.hbind_KeyDown);
			this.Bind.Animated = true;
			this.Bind.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Bind.ButtonMode = 2;
			this.Bind.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.Bind.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.Bind.CheckedState.Parent = this.Bind;
			this.Bind.CustomImages.Parent = this.Bind;
			this.Bind.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Bind.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.Bind.ForeColor = global::System.Drawing.Color.White;
			this.Bind.HoverState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Bind.HoverState.Parent = this.Bind;
			this.Bind.Location = new global::System.Drawing.Point(307, 0);
			this.Bind.Name = "Bind";
			this.Bind.PressedColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Bind.ShadowDecoration.Parent = this.Bind;
			this.Bind.Size = new global::System.Drawing.Size(48, 19);
			this.Bind.TabIndex = 3;
			this.Bind.Text = "Bind";
			this.Bind.Click += new global::System.EventHandler(this.Bind_Click);
			this.Bind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Bind_KeyDown);
			this.Lcps.AutoSize = true;
			this.Lcps.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Lcps.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.Lcps.Location = new global::System.Drawing.Point(304, 94);
			this.Lcps.Margin = new global::System.Windows.Forms.Padding(5);
			this.Lcps.Name = "Lcps";
			this.Lcps.Size = new global::System.Drawing.Size(32, 17);
			this.Lcps.TabIndex = 2;
			this.Lcps.Text = "10,0";
			this.Lcps.Click += new global::System.EventHandler(this.Lcps_Click);
			this.Lcpsslider.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Lcpsslider.BarInnerColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.Lcpsslider.BarPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Lcpsslider.BarPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Lcpsslider.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.Lcpsslider.DrawSemitransparentThumb = false;
			this.Lcpsslider.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Lcpsslider.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Lcpsslider.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Lcpsslider.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.Lcpsslider.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider lcpsslider = this.Lcpsslider;
			int[] array = new int[4];
			array[0] = 5;
			lcpsslider.LargeChange = new decimal(array);
			this.Lcpsslider.Location = new global::System.Drawing.Point(62, 94);
			this.Lcpsslider.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider lcpsslider2 = this.Lcpsslider;
			int[] array2 = new int[4];
			array2[0] = 200;
			lcpsslider2.Maximum = new decimal(array2);
			global::ColorSlider.ColorSlider lcpsslider3 = this.Lcpsslider;
			int[] array3 = new int[4];
			array3[0] = 50;
			lcpsslider3.Minimum = new decimal(array3);
			this.Lcpsslider.MouseEffects = false;
			this.Lcpsslider.MouseWheelBarPartitions = 150;
			this.Lcpsslider.Name = "Lcpsslider";
			global::ColorSlider.ColorSlider lcpsslider4 = this.Lcpsslider;
			int[] array4 = new int[4];
			array4[0] = 1;
			lcpsslider4.ScaleDivisions = new decimal(array4);
			global::ColorSlider.ColorSlider lcpsslider5 = this.Lcpsslider;
			int[] array5 = new int[4];
			array5[0] = 1;
			lcpsslider5.ScaleSubDivisions = new decimal(array5);
			this.Lcpsslider.ShowDivisionsText = false;
			this.Lcpsslider.ShowSmallScale = false;
			this.Lcpsslider.Size = new global::System.Drawing.Size(240, 17);
			global::ColorSlider.ColorSlider lcpsslider6 = this.Lcpsslider;
			int[] array6 = new int[4];
			array6[0] = 1;
			lcpsslider6.SmallChange = new decimal(array6);
			this.Lcpsslider.TabIndex = 0;
			this.Lcpsslider.ThumbInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Lcpsslider.ThumbOuterColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Lcpsslider.ThumbPenColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Lcpsslider.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.Lcpsslider.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.Lcpsslider.TickAdd = 0f;
			this.Lcpsslider.TickColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Lcpsslider.TickDivide = 0f;
			this.Lcpsslider.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider lcpsslider7 = this.Lcpsslider;
			int[] array7 = new int[4];
			array7[0] = 100;
			lcpsslider7.Value = new decimal(array7);
			this.Lcpsslider.ValueChanged += new global::System.EventHandler(this.colorSlider1_ValueChanged);
			this.Lcpsslider.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.Lcpsslider_Scroll);
			this.WindowFinder.Enabled = true;
			this.WindowFinder.Interval = 250;
			this.WindowFinder.Tick += new global::System.EventHandler(this.WindowFinder_Tick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(3, 94);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(56, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Average";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label2.Location = new global::System.Drawing.Point(276, 248);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 17);
			this.label2.TabIndex = 180;
			this.label2.Text = "Hide";
			this.statusleft.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.statusleft.CheckedState.BorderRadius = 5;
			this.statusleft.CheckedState.BorderThickness = 1;
			this.statusleft.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.statusleft.CheckedState.Parent = this.statusleft;
			this.statusleft.Location = new global::System.Drawing.Point(24, 69);
			this.statusleft.Name = "statusleft";
			this.statusleft.ShadowDecoration.Parent = this.statusleft;
			this.statusleft.Size = new global::System.Drawing.Size(20, 20);
			this.statusleft.TabIndex = 181;
			this.statusleft.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.statusleft.UncheckedState.BorderRadius = 5;
			this.statusleft.UncheckedState.BorderThickness = 1;
			this.statusleft.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.statusleft.UncheckedState.Parent = this.statusleft;
			this.statusleft.CheckedChanged += new global::System.EventHandler(this.statusleft_CheckedChanged);
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label9.Location = new global::System.Drawing.Point(255, 211);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(92, 17);
			this.label9.TabIndex = 201;
			this.label9.Text = "Ghost Capture";
			this.cbGhostCapture.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.cbGhostCapture.CheckedState.BorderRadius = 5;
			this.cbGhostCapture.CheckedState.BorderThickness = 1;
			this.cbGhostCapture.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.cbGhostCapture.CheckedState.Parent = this.cbGhostCapture;
			this.cbGhostCapture.Location = new global::System.Drawing.Point(233, 210);
			this.cbGhostCapture.Name = "cbGhostCapture";
			this.cbGhostCapture.ShadowDecoration.Parent = this.cbGhostCapture;
			this.cbGhostCapture.Size = new global::System.Drawing.Size(20, 20);
			this.cbGhostCapture.TabIndex = 200;
			this.cbGhostCapture.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.cbGhostCapture.UncheckedState.BorderRadius = 5;
			this.cbGhostCapture.UncheckedState.BorderThickness = 1;
			this.cbGhostCapture.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.cbGhostCapture.UncheckedState.Parent = this.cbGhostCapture;
			this.cbGhostCapture.CheckedChanged += new global::System.EventHandler(this.statusright_CheckedChanged);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label7.Location = new global::System.Drawing.Point(255, 180);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(81, 17);
			this.label7.TabIndex = 199;
			this.label7.Text = "Break blocks";
			this.breakblock.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.breakblock.CheckedState.BorderRadius = 5;
			this.breakblock.CheckedState.BorderThickness = 1;
			this.breakblock.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.breakblock.CheckedState.Parent = this.breakblock;
			this.breakblock.Location = new global::System.Drawing.Point(233, 179);
			this.breakblock.Name = "breakblock";
			this.breakblock.ShadowDecoration.Parent = this.breakblock;
			this.breakblock.Size = new global::System.Drawing.Size(20, 20);
			this.breakblock.TabIndex = 198;
			this.breakblock.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.breakblock.UncheckedState.BorderRadius = 5;
			this.breakblock.UncheckedState.BorderThickness = 1;
			this.breakblock.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.breakblock.UncheckedState.Parent = this.breakblock;
			this.breakblock.CheckedChanged += new global::System.EventHandler(this.breakblock_CheckedChanged);
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label8.Location = new global::System.Drawing.Point(28, 211);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(79, 17);
			this.label8.TabIndex = 197;
			this.label8.Text = "No hit delay";
			this.mode.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.mode.CheckedState.BorderRadius = 5;
			this.mode.CheckedState.BorderThickness = 1;
			this.mode.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.mode.CheckedState.Parent = this.mode;
			this.mode.Location = new global::System.Drawing.Point(5, 210);
			this.mode.Name = "mode";
			this.mode.ShadowDecoration.Parent = this.mode;
			this.mode.Size = new global::System.Drawing.Size(20, 20);
			this.mode.TabIndex = 196;
			this.mode.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.mode.UncheckedState.BorderRadius = 5;
			this.mode.UncheckedState.BorderThickness = 1;
			this.mode.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.mode.UncheckedState.Parent = this.mode;
			this.mode.CheckedChanged += new global::System.EventHandler(this.mode_CheckedChanged);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label6.Location = new global::System.Drawing.Point(27, 180);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(47, 17);
			this.label6.TabIndex = 195;
			this.label6.Text = "Blatant";
			this.blatant.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.blatant.CheckedState.BorderRadius = 5;
			this.blatant.CheckedState.BorderThickness = 1;
			this.blatant.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.blatant.CheckedState.Parent = this.blatant;
			this.blatant.Location = new global::System.Drawing.Point(5, 178);
			this.blatant.Name = "blatant";
			this.blatant.ShadowDecoration.Parent = this.blatant;
			this.blatant.Size = new global::System.Drawing.Size(20, 20);
			this.blatant.TabIndex = 194;
			this.blatant.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.blatant.UncheckedState.BorderRadius = 5;
			this.blatant.UncheckedState.BorderThickness = 1;
			this.blatant.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.blatant.UncheckedState.Parent = this.blatant;
			this.blatant.CheckedChanged += new global::System.EventHandler(this.blatant_CheckedChanged);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label5.Location = new global::System.Drawing.Point(27, 149);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(89, 17);
			this.label5.TabIndex = 193;
			this.label5.Text = "Inventory click";
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.Inventory.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.Inventory.CheckedState.BorderRadius = 5;
			this.Inventory.CheckedState.BorderThickness = 1;
			this.Inventory.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Inventory.CheckedState.Parent = this.Inventory;
			this.Inventory.Location = new global::System.Drawing.Point(5, 148);
			this.Inventory.Name = "Inventory";
			this.Inventory.ShadowDecoration.Parent = this.Inventory;
			this.Inventory.Size = new global::System.Drawing.Size(20, 20);
			this.Inventory.TabIndex = 192;
			this.Inventory.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.Inventory.UncheckedState.BorderRadius = 5;
			this.Inventory.UncheckedState.BorderThickness = 1;
			this.Inventory.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.Inventory.UncheckedState.Parent = this.Inventory;
			this.guna2VSeparator1.FillColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.guna2VSeparator1.Location = new global::System.Drawing.Point(147, 9);
			this.guna2VSeparator1.Name = "guna2VSeparator1";
			this.guna2VSeparator1.Size = new global::System.Drawing.Size(12, 268);
			this.guna2VSeparator1.TabIndex = 202;
			this.guna2Button1.Animated = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button1.ButtonMode = 2;
			this.guna2Button1.Checked = true;
			this.guna2Button1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button1.CheckedState.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(51, 70);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(72, 19);
			this.guna2Button1.TabIndex = 203;
			this.guna2Button1.Text = "Autoclicker";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2Button2.Animated = true;
			this.guna2Button2.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button2.ButtonMode = 2;
			this.guna2Button2.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button2.CheckedState.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.guna2Button2.HoverState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Location = new global::System.Drawing.Point(50, 140);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.PressedColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(46, 20);
			this.guna2Button2.TabIndex = 205;
			this.guna2Button2.Text = "Reach";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Button2.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.guna2Button2_MouseClick);
			this.siticoneCustomCheckBox1.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Location = new global::System.Drawing.Point(24, 140);
			this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox1.TabIndex = 204;
			this.siticoneCustomCheckBox1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckedChanged += new global::System.EventHandler(this.siticoneCustomCheckBox1_CheckedChanged);
			this.guna2Button3.Animated = true;
			this.guna2Button3.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button3.ButtonMode = 2;
			this.guna2Button3.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button3.CheckedState.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.guna2Button3.HoverState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Location = new global::System.Drawing.Point(50, 210);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.PressedColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new global::System.Drawing.Size(78, 20);
			this.guna2Button3.TabIndex = 207;
			this.guna2Button3.Text = "Aim Assist";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.siticoneCustomCheckBox2.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.siticoneCustomCheckBox2.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox2.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox2.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox2.CheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.Location = new global::System.Drawing.Point(24, 210);
			this.siticoneCustomCheckBox2.Name = "siticoneCustomCheckBox2";
			this.siticoneCustomCheckBox2.ShadowDecoration.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox2.TabIndex = 206;
			this.siticoneCustomCheckBox2.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox2.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox2.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox2.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox2.UncheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckedChanged += new global::System.EventHandler(this.siticoneCustomCheckBox2_CheckedChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(3, 29);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(78, 17);
			this.label3.TabIndex = 208;
			this.label3.Text = "Left Clicker :";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label4.Location = new global::System.Drawing.Point(256, 149);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(80, 17);
			this.label4.TabIndex = 210;
			this.label4.Text = "Timer Mode";
			this.timercb.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.timercb.CheckedState.BorderRadius = 5;
			this.timercb.CheckedState.BorderThickness = 1;
			this.timercb.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.timercb.CheckedState.Parent = this.timercb;
			this.timercb.Location = new global::System.Drawing.Point(233, 148);
			this.timercb.Name = "timercb";
			this.timercb.ShadowDecoration.Parent = this.timercb;
			this.timercb.Size = new global::System.Drawing.Size(20, 20);
			this.timercb.TabIndex = 209;
			this.timercb.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.timercb.UncheckedState.BorderRadius = 5;
			this.timercb.UncheckedState.BorderThickness = 1;
			this.timercb.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.timercb.UncheckedState.Parent = this.timercb;
			this.timercb.CheckedChanged += new global::System.EventHandler(this.siticoneCustomCheckBox3_CheckedChanged);
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(40, 11);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(83, 17);
			this.label10.TabIndex = 211;
			this.label10.Text = "Silent Client";
			this.pnlauto.Controls.Add(this.label3);
			this.pnlauto.Controls.Add(this.label4);
			this.pnlauto.Controls.Add(this.Bind);
			this.pnlauto.Controls.Add(this.timercb);
			this.pnlauto.Controls.Add(this.Lcpsslider);
			this.pnlauto.Controls.Add(this.Lcps);
			this.pnlauto.Controls.Add(this.label1);
			this.pnlauto.Controls.Add(this.label2);
			this.pnlauto.Controls.Add(this.hbind);
			this.pnlauto.Controls.Add(this.Inventory);
			this.pnlauto.Controls.Add(this.label5);
			this.pnlauto.Controls.Add(this.blatant);
			this.pnlauto.Controls.Add(this.label6);
			this.pnlauto.Controls.Add(this.label9);
			this.pnlauto.Controls.Add(this.mode);
			this.pnlauto.Controls.Add(this.cbGhostCapture);
			this.pnlauto.Controls.Add(this.label8);
			this.pnlauto.Controls.Add(this.label7);
			this.pnlauto.Controls.Add(this.breakblock);
			this.pnlauto.Location = new global::System.Drawing.Point(161, 9);
			this.pnlauto.Name = "pnlauto";
			this.pnlauto.Size = new global::System.Drawing.Size(352, 264);
			this.pnlauto.TabIndex = 212;
			this.pnlreach.Controls.Add(this.label25);
			this.pnlreach.Controls.Add(this.siticoneCustomCheckBox10);
			this.pnlreach.Controls.Add(this.label26);
			this.pnlreach.Controls.Add(this.siticoneCustomCheckBox11);
			this.pnlreach.Controls.Add(this.chancelb);
			this.pnlreach.Controls.Add(this.colorSlider3);
			this.pnlreach.Controls.Add(this.label18);
			this.pnlreach.Controls.Add(this.label16);
			this.pnlreach.Controls.Add(this.siticoneCustomCheckBox5);
			this.pnlreach.Controls.Add(this.label17);
			this.pnlreach.Controls.Add(this.siticoneCustomCheckBox8);
			this.pnlreach.Controls.Add(this.label14);
			this.pnlreach.Controls.Add(this.maxval);
			this.pnlreach.Controls.Add(this.maxreach);
			this.pnlreach.Controls.Add(this.label13);
			this.pnlreach.Controls.Add(this.minvalue);
			this.pnlreach.Controls.Add(this.minreach);
			this.pnlreach.Controls.Add(this.guna2Button4);
			this.pnlreach.Controls.Add(this.label11);
			this.pnlreach.Location = new global::System.Drawing.Point(162, 9);
			this.pnlreach.Name = "pnlreach";
			this.pnlreach.Size = new global::System.Drawing.Size(352, 264);
			this.pnlreach.TabIndex = 213;
			this.pnlreach.Paint += new global::System.Windows.Forms.PaintEventHandler(this.pnlreach_Paint);
			this.label25.AutoSize = true;
			this.label25.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label25.Location = new global::System.Drawing.Point(255, 135);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(88, 17);
			this.label25.TabIndex = 233;
			this.label25.Text = "Rare Distance";
			this.siticoneCustomCheckBox10.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox10.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox10.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox10.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox10.CheckedState.Parent = this.siticoneCustomCheckBox10;
			this.siticoneCustomCheckBox10.Location = new global::System.Drawing.Point(5, 132);
			this.siticoneCustomCheckBox10.Name = "siticoneCustomCheckBox10";
			this.siticoneCustomCheckBox10.ShadowDecoration.Parent = this.siticoneCustomCheckBox10;
			this.siticoneCustomCheckBox10.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox10.TabIndex = 230;
			this.siticoneCustomCheckBox10.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox10.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox10.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox10.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox10.UncheckedState.Parent = this.siticoneCustomCheckBox10;
			this.label26.AutoSize = true;
			this.label26.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label26.Location = new global::System.Drawing.Point(31, 135);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(90, 17);
			this.label26.TabIndex = 231;
			this.label26.Text = "Sprinting Only";
			this.siticoneCustomCheckBox11.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox11.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox11.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox11.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox11.CheckedState.Parent = this.siticoneCustomCheckBox11;
			this.siticoneCustomCheckBox11.Location = new global::System.Drawing.Point(232, 132);
			this.siticoneCustomCheckBox11.Name = "siticoneCustomCheckBox11";
			this.siticoneCustomCheckBox11.ShadowDecoration.Parent = this.siticoneCustomCheckBox11;
			this.siticoneCustomCheckBox11.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox11.TabIndex = 232;
			this.siticoneCustomCheckBox11.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox11.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox11.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox11.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox11.UncheckedState.Parent = this.siticoneCustomCheckBox11;
			this.chancelb.AutoSize = true;
			this.chancelb.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.chancelb.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.chancelb.Location = new global::System.Drawing.Point(303, 217);
			this.chancelb.Margin = new global::System.Windows.Forms.Padding(5);
			this.chancelb.Name = "chancelb";
			this.chancelb.Size = new global::System.Drawing.Size(33, 17);
			this.chancelb.TabIndex = 229;
			this.chancelb.Text = "75%";
			this.chancelb.Click += new global::System.EventHandler(this.chancelb_Click);
			this.colorSlider3.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.colorSlider3.BarInnerColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.colorSlider3.BarPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.colorSlider3.BarPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.colorSlider3.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.colorSlider3.DrawSemitransparentThumb = false;
			this.colorSlider3.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.colorSlider3.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.colorSlider3.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.colorSlider3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.colorSlider3.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider = this.colorSlider3;
			int[] array8 = new int[4];
			array8[0] = 5;
			colorSlider.LargeChange = new decimal(array8);
			this.colorSlider3.Location = new global::System.Drawing.Point(60, 217);
			this.colorSlider3.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider colorSlider2 = this.colorSlider3;
			int[] array9 = new int[4];
			array9[0] = 100;
			colorSlider2.Maximum = new decimal(array9);
			global::ColorSlider.ColorSlider colorSlider3 = this.colorSlider3;
			int[] array10 = new int[4];
			array10[0] = 10;
			colorSlider3.Minimum = new decimal(array10);
			this.colorSlider3.MouseEffects = false;
			this.colorSlider3.MouseWheelBarPartitions = 150;
			this.colorSlider3.Name = "colorSlider3";
			global::ColorSlider.ColorSlider colorSlider4 = this.colorSlider3;
			int[] array11 = new int[4];
			array11[0] = 1;
			colorSlider4.ScaleDivisions = new decimal(array11);
			global::ColorSlider.ColorSlider colorSlider5 = this.colorSlider3;
			int[] array12 = new int[4];
			array12[0] = 1;
			colorSlider5.ScaleSubDivisions = new decimal(array12);
			this.colorSlider3.ShowDivisionsText = false;
			this.colorSlider3.ShowSmallScale = false;
			this.colorSlider3.Size = new global::System.Drawing.Size(240, 17);
			global::ColorSlider.ColorSlider colorSlider6 = this.colorSlider3;
			int[] array13 = new int[4];
			array13[0] = 1;
			colorSlider6.SmallChange = new decimal(array13);
			this.colorSlider3.TabIndex = 228;
			this.colorSlider3.ThumbInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.colorSlider3.ThumbOuterColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.colorSlider3.ThumbPenColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.colorSlider3.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.colorSlider3.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.colorSlider3.TickAdd = 0f;
			this.colorSlider3.TickColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.colorSlider3.TickDivide = 0f;
			this.colorSlider3.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider7 = this.colorSlider3;
			int[] array14 = new int[4];
			array14[0] = 75;
			colorSlider7.Value = new decimal(array14);
			this.colorSlider3.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.colorSlider3_Scroll);
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(2, 217);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(50, 17);
			this.label18.TabIndex = 227;
			this.label18.Text = "Chance";
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label16.Location = new global::System.Drawing.Point(255, 168);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(86, 17);
			this.label16.TabIndex = 226;
			this.label16.Text = "Vertical check";
			this.siticoneCustomCheckBox5.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox5.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox5.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox5.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox5.CheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.Location = new global::System.Drawing.Point(5, 165);
			this.siticoneCustomCheckBox5.Name = "siticoneCustomCheckBox5";
			this.siticoneCustomCheckBox5.ShadowDecoration.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox5.TabIndex = 217;
			this.siticoneCustomCheckBox5.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox5.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox5.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox5.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox5.UncheckedState.Parent = this.siticoneCustomCheckBox5;
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label17.Location = new global::System.Drawing.Point(31, 168);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(100, 17);
			this.label17.TabIndex = 218;
			this.label17.Text = "Backtrack mode";
			this.siticoneCustomCheckBox8.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox8.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox8.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox8.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox8.CheckedState.Parent = this.siticoneCustomCheckBox8;
			this.siticoneCustomCheckBox8.Location = new global::System.Drawing.Point(232, 165);
			this.siticoneCustomCheckBox8.Name = "siticoneCustomCheckBox8";
			this.siticoneCustomCheckBox8.ShadowDecoration.Parent = this.siticoneCustomCheckBox8;
			this.siticoneCustomCheckBox8.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox8.TabIndex = 225;
			this.siticoneCustomCheckBox8.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox8.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox8.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox8.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox8.UncheckedState.Parent = this.siticoneCustomCheckBox8;
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(3, 95);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(65, 17);
			this.label14.TabIndex = 216;
			this.label14.Text = "Maximum";
			this.maxval.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.maxval.BarInnerColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.maxval.BarPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.maxval.BarPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.maxval.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.maxval.DrawSemitransparentThumb = false;
			this.maxval.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.maxval.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.maxval.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.maxval.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.maxval.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider8 = this.maxval;
			int[] array15 = new int[4];
			array15[0] = 5;
			colorSlider8.LargeChange = new decimal(array15);
			this.maxval.Location = new global::System.Drawing.Point(62, 95);
			this.maxval.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider colorSlider9 = this.maxval;
			int[] array16 = new int[4];
			array16[0] = 350;
			colorSlider9.Maximum = new decimal(array16);
			global::ColorSlider.ColorSlider colorSlider10 = this.maxval;
			int[] array17 = new int[4];
			array17[0] = 300;
			colorSlider10.Minimum = new decimal(array17);
			this.maxval.MouseEffects = false;
			this.maxval.MouseWheelBarPartitions = 150;
			this.maxval.Name = "maxval";
			global::ColorSlider.ColorSlider colorSlider11 = this.maxval;
			int[] array18 = new int[4];
			array18[0] = 1;
			colorSlider11.ScaleDivisions = new decimal(array18);
			global::ColorSlider.ColorSlider colorSlider12 = this.maxval;
			int[] array19 = new int[4];
			array19[0] = 1;
			colorSlider12.ScaleSubDivisions = new decimal(array19);
			this.maxval.ShowDivisionsText = false;
			this.maxval.ShowSmallScale = false;
			this.maxval.Size = new global::System.Drawing.Size(240, 17);
			global::ColorSlider.ColorSlider colorSlider13 = this.maxval;
			int[] array20 = new int[4];
			array20[0] = 1;
			colorSlider13.SmallChange = new decimal(array20);
			this.maxval.TabIndex = 214;
			this.maxval.ThumbInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.maxval.ThumbOuterColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.maxval.ThumbPenColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.maxval.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.maxval.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.maxval.TickAdd = 0f;
			this.maxval.TickColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.maxval.TickDivide = 0f;
			this.maxval.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider14 = this.maxval;
			int[] array21 = new int[4];
			array21[0] = 320;
			colorSlider14.Value = new decimal(array21);
			this.maxval.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.maxval_Scroll);
			this.maxreach.AutoSize = true;
			this.maxreach.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.maxreach.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.maxreach.Location = new global::System.Drawing.Point(304, 95);
			this.maxreach.Margin = new global::System.Windows.Forms.Padding(5);
			this.maxreach.Name = "maxreach";
			this.maxreach.Size = new global::System.Drawing.Size(25, 17);
			this.maxreach.TabIndex = 215;
			this.maxreach.Text = "3,2";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(3, 65);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(62, 17);
			this.label13.TabIndex = 213;
			this.label13.Text = "Minimum";
			this.minvalue.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.minvalue.BarInnerColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.minvalue.BarPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.minvalue.BarPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.minvalue.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.minvalue.DrawSemitransparentThumb = false;
			this.minvalue.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.minvalue.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.minvalue.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.minvalue.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.minvalue.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider15 = this.minvalue;
			int[] array22 = new int[4];
			array22[0] = 5;
			colorSlider15.LargeChange = new decimal(array22);
			this.minvalue.Location = new global::System.Drawing.Point(62, 65);
			this.minvalue.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider colorSlider16 = this.minvalue;
			int[] array23 = new int[4];
			array23[0] = 350;
			colorSlider16.Maximum = new decimal(array23);
			global::ColorSlider.ColorSlider colorSlider17 = this.minvalue;
			int[] array24 = new int[4];
			array24[0] = 300;
			colorSlider17.Minimum = new decimal(array24);
			this.minvalue.MouseEffects = false;
			this.minvalue.MouseWheelBarPartitions = 150;
			this.minvalue.Name = "minvalue";
			global::ColorSlider.ColorSlider colorSlider18 = this.minvalue;
			int[] array25 = new int[4];
			array25[0] = 1;
			colorSlider18.ScaleDivisions = new decimal(array25);
			global::ColorSlider.ColorSlider colorSlider19 = this.minvalue;
			int[] array26 = new int[4];
			array26[0] = 1;
			colorSlider19.ScaleSubDivisions = new decimal(array26);
			this.minvalue.ShowDivisionsText = false;
			this.minvalue.ShowSmallScale = false;
			this.minvalue.Size = new global::System.Drawing.Size(240, 17);
			global::ColorSlider.ColorSlider colorSlider20 = this.minvalue;
			int[] array27 = new int[4];
			array27[0] = 1;
			colorSlider20.SmallChange = new decimal(array27);
			this.minvalue.TabIndex = 211;
			this.minvalue.ThumbInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.minvalue.ThumbOuterColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.minvalue.ThumbPenColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.minvalue.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.minvalue.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.minvalue.TickAdd = 0f;
			this.minvalue.TickColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.minvalue.TickDivide = 0f;
			this.minvalue.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider21 = this.minvalue;
			int[] array28 = new int[4];
			array28[0] = 310;
			colorSlider21.Value = new decimal(array28);
			this.minvalue.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.colorSlider1_Scroll);
			this.minreach.AutoSize = true;
			this.minreach.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.minreach.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.minreach.Location = new global::System.Drawing.Point(304, 65);
			this.minreach.Margin = new global::System.Windows.Forms.Padding(5);
			this.minreach.Name = "minreach";
			this.minreach.Size = new global::System.Drawing.Size(25, 17);
			this.minreach.TabIndex = 212;
			this.minreach.Text = "3,1";
			this.minreach.Click += new global::System.EventHandler(this.minreach_Click);
			this.guna2Button4.Animated = true;
			this.guna2Button4.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button4.ButtonMode = 2;
			this.guna2Button4.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.guna2Button4.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button4.CheckedState.Parent = this.guna2Button4;
			this.guna2Button4.CustomImages.Parent = this.guna2Button4;
			this.guna2Button4.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button4.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.guna2Button4.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button4.HoverState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button4.HoverState.Parent = this.guna2Button4;
			this.guna2Button4.Location = new global::System.Drawing.Point(307, 0);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.PressedColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
			this.guna2Button4.Size = new global::System.Drawing.Size(48, 19);
			this.guna2Button4.TabIndex = 210;
			this.guna2Button4.Text = "Bind";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(3, 29);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(50, 17);
			this.label11.TabIndex = 209;
			this.label11.Text = "Reach :";
			this.aapnl.Controls.Add(this.label23);
			this.aapnl.Controls.Add(this.siticoneCustomCheckBox7);
			this.aapnl.Controls.Add(this.label24);
			this.aapnl.Controls.Add(this.siticoneCustomCheckBox9);
			this.aapnl.Controls.Add(this.label19);
			this.aapnl.Controls.Add(this.siticoneCustomCheckBox4);
			this.aapnl.Controls.Add(this.label21);
			this.aapnl.Controls.Add(this.siticoneCustomCheckBox6);
			this.aapnl.Controls.Add(this.label22);
			this.aapnl.Controls.Add(this.fovval);
			this.aapnl.Controls.Add(this.fovlb);
			this.aapnl.Controls.Add(this.label20);
			this.aapnl.Controls.Add(this.rangeval);
			this.aapnl.Controls.Add(this.rangelb);
			this.aapnl.Controls.Add(this.label15);
			this.aapnl.Controls.Add(this.speedval);
			this.aapnl.Controls.Add(this.speedlb);
			this.aapnl.Controls.Add(this.guna2Button5);
			this.aapnl.Controls.Add(this.label12);
			this.aapnl.Location = new global::System.Drawing.Point(161, 9);
			this.aapnl.Name = "aapnl";
			this.aapnl.Size = new global::System.Drawing.Size(356, 265);
			this.aapnl.TabIndex = 214;
			this.label23.AutoSize = true;
			this.label23.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label23.Location = new global::System.Drawing.Point(256, 191);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(78, 17);
			this.label23.TabIndex = 234;
			this.label23.Text = "Team Mode";
			this.siticoneCustomCheckBox7.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox7.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox7.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox7.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox7.CheckedState.Parent = this.siticoneCustomCheckBox7;
			this.siticoneCustomCheckBox7.Location = new global::System.Drawing.Point(7, 221);
			this.siticoneCustomCheckBox7.Name = "siticoneCustomCheckBox7";
			this.siticoneCustomCheckBox7.ShadowDecoration.Parent = this.siticoneCustomCheckBox7;
			this.siticoneCustomCheckBox7.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox7.TabIndex = 231;
			this.siticoneCustomCheckBox7.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox7.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox7.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox7.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox7.UncheckedState.Parent = this.siticoneCustomCheckBox7;
			this.label24.AutoSize = true;
			this.label24.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label24.Location = new global::System.Drawing.Point(33, 224);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(101, 17);
			this.label24.TabIndex = 232;
			this.label24.Text = "Target invisibles";
			this.siticoneCustomCheckBox9.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox9.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox9.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox9.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox9.CheckedState.Parent = this.siticoneCustomCheckBox9;
			this.siticoneCustomCheckBox9.Location = new global::System.Drawing.Point(233, 188);
			this.siticoneCustomCheckBox9.Name = "siticoneCustomCheckBox9";
			this.siticoneCustomCheckBox9.ShadowDecoration.Parent = this.siticoneCustomCheckBox9;
			this.siticoneCustomCheckBox9.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox9.TabIndex = 233;
			this.siticoneCustomCheckBox9.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox9.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox9.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox9.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox9.UncheckedState.Parent = this.siticoneCustomCheckBox9;
			this.label19.AutoSize = true;
			this.label19.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label19.Location = new global::System.Drawing.Point(256, 224);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(90, 17);
			this.label19.TabIndex = 230;
			this.label19.Text = "Weapons only";
			this.siticoneCustomCheckBox4.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox4.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox4.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox4.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox4.CheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.Location = new global::System.Drawing.Point(7, 188);
			this.siticoneCustomCheckBox4.Name = "siticoneCustomCheckBox4";
			this.siticoneCustomCheckBox4.ShadowDecoration.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox4.TabIndex = 227;
			this.siticoneCustomCheckBox4.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox4.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox4.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox4.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox4.UncheckedState.Parent = this.siticoneCustomCheckBox4;
			this.label21.AutoSize = true;
			this.label21.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label21.Location = new global::System.Drawing.Point(33, 191);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(81, 17);
			this.label21.TabIndex = 228;
			this.label21.Text = "Require click";
			this.siticoneCustomCheckBox6.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox6.CheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox6.CheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox6.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneCustomCheckBox6.CheckedState.Parent = this.siticoneCustomCheckBox6;
			this.siticoneCustomCheckBox6.Location = new global::System.Drawing.Point(233, 221);
			this.siticoneCustomCheckBox6.Name = "siticoneCustomCheckBox6";
			this.siticoneCustomCheckBox6.ShadowDecoration.Parent = this.siticoneCustomCheckBox6;
			this.siticoneCustomCheckBox6.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox6.TabIndex = 229;
			this.siticoneCustomCheckBox6.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.siticoneCustomCheckBox6.UncheckedState.BorderRadius = 5;
			this.siticoneCustomCheckBox6.UncheckedState.BorderThickness = 1;
			this.siticoneCustomCheckBox6.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneCustomCheckBox6.UncheckedState.Parent = this.siticoneCustomCheckBox6;
			this.label22.AutoSize = true;
			this.label22.Location = new global::System.Drawing.Point(4, 138);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(32, 17);
			this.label22.TabIndex = 222;
			this.label22.Text = "FOV";
			this.fovval.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.fovval.BarInnerColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.fovval.BarPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.fovval.BarPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.fovval.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.fovval.DrawSemitransparentThumb = false;
			this.fovval.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.fovval.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.fovval.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.fovval.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.fovval.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider22 = this.fovval;
			int[] array29 = new int[4];
			array29[0] = 5;
			colorSlider22.LargeChange = new decimal(array29);
			this.fovval.Location = new global::System.Drawing.Point(62, 137);
			this.fovval.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider colorSlider23 = this.fovval;
			int[] array30 = new int[4];
			array30[0] = 180;
			colorSlider23.Maximum = new decimal(array30);
			global::ColorSlider.ColorSlider colorSlider24 = this.fovval;
			int[] array31 = new int[4];
			array31[0] = 30;
			colorSlider24.Minimum = new decimal(array31);
			this.fovval.MouseEffects = false;
			this.fovval.MouseWheelBarPartitions = 150;
			this.fovval.Name = "fovval";
			global::ColorSlider.ColorSlider colorSlider25 = this.fovval;
			int[] array32 = new int[4];
			array32[0] = 1;
			colorSlider25.ScaleDivisions = new decimal(array32);
			global::ColorSlider.ColorSlider colorSlider26 = this.fovval;
			int[] array33 = new int[4];
			array33[0] = 1;
			colorSlider26.ScaleSubDivisions = new decimal(array33);
			this.fovval.ShowDivisionsText = false;
			this.fovval.ShowSmallScale = false;
			this.fovval.Size = new global::System.Drawing.Size(240, 17);
			global::ColorSlider.ColorSlider colorSlider27 = this.fovval;
			int[] array34 = new int[4];
			array34[0] = 1;
			colorSlider27.SmallChange = new decimal(array34);
			this.fovval.TabIndex = 220;
			this.fovval.ThumbInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.fovval.ThumbOuterColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.fovval.ThumbPenColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.fovval.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.fovval.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.fovval.TickAdd = 0f;
			this.fovval.TickColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.fovval.TickDivide = 0f;
			this.fovval.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider28 = this.fovval;
			int[] array35 = new int[4];
			array35[0] = 60;
			colorSlider28.Value = new decimal(array35);
			this.fovval.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.fovval_Scroll);
			this.fovlb.AutoSize = true;
			this.fovlb.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.fovlb.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.fovlb.Location = new global::System.Drawing.Point(309, 138);
			this.fovlb.Margin = new global::System.Windows.Forms.Padding(5);
			this.fovlb.Name = "fovlb";
			this.fovlb.Size = new global::System.Drawing.Size(22, 17);
			this.fovlb.TabIndex = 221;
			this.fovlb.Text = "60";
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(4, 109);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(45, 17);
			this.label20.TabIndex = 219;
			this.label20.Text = "Range";
			this.rangeval.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.rangeval.BarInnerColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.rangeval.BarPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.rangeval.BarPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.rangeval.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.rangeval.DrawSemitransparentThumb = false;
			this.rangeval.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.rangeval.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.rangeval.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.rangeval.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.rangeval.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider29 = this.rangeval;
			int[] array36 = new int[4];
			array36[0] = 5;
			colorSlider29.LargeChange = new decimal(array36);
			this.rangeval.Location = new global::System.Drawing.Point(62, 109);
			this.rangeval.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider colorSlider30 = this.rangeval;
			int[] array37 = new int[4];
			array37[0] = 600;
			colorSlider30.Maximum = new decimal(array37);
			global::ColorSlider.ColorSlider colorSlider31 = this.rangeval;
			int[] array38 = new int[4];
			array38[0] = 300;
			colorSlider31.Minimum = new decimal(array38);
			this.rangeval.MouseEffects = false;
			this.rangeval.MouseWheelBarPartitions = 150;
			this.rangeval.Name = "rangeval";
			global::ColorSlider.ColorSlider colorSlider32 = this.rangeval;
			int[] array39 = new int[4];
			array39[0] = 1;
			colorSlider32.ScaleDivisions = new decimal(array39);
			global::ColorSlider.ColorSlider colorSlider33 = this.rangeval;
			int[] array40 = new int[4];
			array40[0] = 1;
			colorSlider33.ScaleSubDivisions = new decimal(array40);
			this.rangeval.ShowDivisionsText = false;
			this.rangeval.ShowSmallScale = false;
			this.rangeval.Size = new global::System.Drawing.Size(240, 17);
			global::ColorSlider.ColorSlider colorSlider34 = this.rangeval;
			int[] array41 = new int[4];
			array41[0] = 1;
			colorSlider34.SmallChange = new decimal(array41);
			this.rangeval.TabIndex = 217;
			this.rangeval.ThumbInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.rangeval.ThumbOuterColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.rangeval.ThumbPenColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.rangeval.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.rangeval.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.rangeval.TickAdd = 0f;
			this.rangeval.TickColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.rangeval.TickDivide = 0f;
			this.rangeval.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider35 = this.rangeval;
			int[] array42 = new int[4];
			array42[0] = 450;
			colorSlider35.Value = new decimal(array42);
			this.rangeval.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.rangeval_Scroll);
			this.rangelb.AutoSize = true;
			this.rangelb.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.rangelb.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.rangelb.Location = new global::System.Drawing.Point(309, 109);
			this.rangelb.Margin = new global::System.Windows.Forms.Padding(5);
			this.rangelb.Name = "rangelb";
			this.rangelb.Size = new global::System.Drawing.Size(25, 17);
			this.rangelb.TabIndex = 218;
			this.rangelb.Text = "4,5";
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(3, 79);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(45, 17);
			this.label15.TabIndex = 216;
			this.label15.Text = "Speed";
			this.speedval.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.speedval.BarInnerColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.speedval.BarPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.speedval.BarPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.speedval.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.speedval.DrawSemitransparentThumb = false;
			this.speedval.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.speedval.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.speedval.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.speedval.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.speedval.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider36 = this.speedval;
			int[] array43 = new int[4];
			array43[0] = 5;
			colorSlider36.LargeChange = new decimal(array43);
			this.speedval.Location = new global::System.Drawing.Point(61, 79);
			this.speedval.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider colorSlider37 = this.speedval;
			int[] array44 = new int[4];
			array44[0] = 30;
			colorSlider37.Maximum = new decimal(array44);
			global::ColorSlider.ColorSlider colorSlider38 = this.speedval;
			int[] array45 = new int[4];
			array45[0] = 1;
			colorSlider38.Minimum = new decimal(array45);
			this.speedval.MouseEffects = false;
			this.speedval.MouseWheelBarPartitions = 150;
			this.speedval.Name = "speedval";
			global::ColorSlider.ColorSlider colorSlider39 = this.speedval;
			int[] array46 = new int[4];
			array46[0] = 1;
			colorSlider39.ScaleDivisions = new decimal(array46);
			global::ColorSlider.ColorSlider colorSlider40 = this.speedval;
			int[] array47 = new int[4];
			array47[0] = 1;
			colorSlider40.ScaleSubDivisions = new decimal(array47);
			this.speedval.ShowDivisionsText = false;
			this.speedval.ShowSmallScale = false;
			this.speedval.Size = new global::System.Drawing.Size(240, 17);
			global::ColorSlider.ColorSlider colorSlider41 = this.speedval;
			int[] array48 = new int[4];
			array48[0] = 1;
			colorSlider41.SmallChange = new decimal(array48);
			this.speedval.TabIndex = 214;
			this.speedval.ThumbInnerColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.speedval.ThumbOuterColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.speedval.ThumbPenColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.speedval.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.speedval.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.speedval.TickAdd = 0f;
			this.speedval.TickColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.speedval.TickDivide = 0f;
			this.speedval.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider42 = this.speedval;
			int[] array49 = new int[4];
			array49[0] = 15;
			colorSlider42.Value = new decimal(array49);
			this.speedval.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.speedval_Scroll);
			this.speedlb.AutoSize = true;
			this.speedlb.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.speedlb.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.speedlb.Location = new global::System.Drawing.Point(308, 79);
			this.speedlb.Margin = new global::System.Windows.Forms.Padding(5);
			this.speedlb.Name = "speedlb";
			this.speedlb.Size = new global::System.Drawing.Size(22, 17);
			this.speedlb.TabIndex = 215;
			this.speedlb.Text = "15";
			this.guna2Button5.Animated = true;
			this.guna2Button5.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button5.ButtonMode = 2;
			this.guna2Button5.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.guna2Button5.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button5.CheckedState.Parent = this.guna2Button5;
			this.guna2Button5.CustomImages.Parent = this.guna2Button5;
			this.guna2Button5.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button5.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.guna2Button5.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button5.HoverState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button5.HoverState.Parent = this.guna2Button5;
			this.guna2Button5.Location = new global::System.Drawing.Point(307, 0);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.PressedColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
			this.guna2Button5.Size = new global::System.Drawing.Size(48, 19);
			this.guna2Button5.TabIndex = 211;
			this.guna2Button5.Text = "Bind";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(3, 29);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(70, 17);
			this.label12.TabIndex = 210;
			this.label12.Text = "AimAssist :";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			base.ClientSize = new global::System.Drawing.Size(526, 283);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.siticoneCustomCheckBox2);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.siticoneCustomCheckBox1);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.guna2VSeparator1);
			base.Controls.Add(this.statusleft);
			base.Controls.Add(this.pnlauto);
			base.Controls.Add(this.aapnl);
			base.Controls.Add(this.pnlreach);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			base.MaximizeBox = false;
			base.Name = "Clicker";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "silent client";
			base.Load += new global::System.EventHandler(this.Clicker_Load);
			this.pnlauto.ResumeLayout(false);
			this.pnlauto.PerformLayout();
			this.pnlreach.ResumeLayout(false);
			this.pnlreach.PerformLayout();
			this.aapnl.ResumeLayout(false);
			this.aapnl.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label Lcps;

		// Token: 0x0400001C RID: 28
		private global::Guna.UI2.WinForms.Guna2Button Bind;

		// Token: 0x0400001D RID: 29
		private global::Guna.UI2.WinForms.Guna2Button hbind;

		// Token: 0x0400001E RID: 30
		private global::ColorSlider.ColorSlider Lcpsslider;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Timer WindowFinder;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000022 RID: 34
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox statusleft;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000024 RID: 36
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox cbGhostCapture;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000026 RID: 38
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox breakblock;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000028 RID: 40
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox mode;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400002A RID: 42
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox blatant;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400002C RID: 44
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox Inventory;

		// Token: 0x0400002D RID: 45
		private global::Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;

		// Token: 0x0400002E RID: 46
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400002F RID: 47
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000030 RID: 48
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000031 RID: 49
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000032 RID: 50
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox2;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000035 RID: 53
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox timercb;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Panel pnlauto;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Panel pnlreach;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400003A RID: 58
		private global::ColorSlider.ColorSlider minvalue;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label minreach;

		// Token: 0x0400003C RID: 60
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label18;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000040 RID: 64
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox5;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000042 RID: 66
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox8;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000044 RID: 68
		private global::ColorSlider.ColorSlider maxval;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label maxreach;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label chancelb;

		// Token: 0x04000047 RID: 71
		private global::ColorSlider.ColorSlider colorSlider3;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Panel aapnl;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400004A RID: 74
		private global::ColorSlider.ColorSlider speedval;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label speedlb;

		// Token: 0x0400004C RID: 76
		private global::Guna.UI2.WinForms.Guna2Button guna2Button5;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400004F RID: 79
		private global::ColorSlider.ColorSlider fovval;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label fovlb;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000052 RID: 82
		private global::ColorSlider.ColorSlider rangeval;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label rangelb;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000055 RID: 85
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox7;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000057 RID: 87
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox9;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000059 RID: 89
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox4;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400005B RID: 91
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox6;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400005D RID: 93
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox10;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400005F RID: 95
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox11;
	}
}
