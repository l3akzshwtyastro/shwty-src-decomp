namespace Clicker
{
	// Token: 0x02000005 RID: 5
	public partial class Clicker : global::System.Windows.Forms.Form
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003024 File Offset: 0x00001224
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000305C File Offset: 0x0000125C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Clicker.Clicker));
			this.hbind = new global::Guna.UI2.WinForms.Guna2Button();
			this.Bind = new global::Guna.UI2.WinForms.Guna2Button();
			this.Lcps = new global::System.Windows.Forms.Label();
			this.Lcpsslider = new global::ColorSlider.ColorSlider();
			this.WindowFinder = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.mode = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.statusright = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.breakblock = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.blatant = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.statusleft = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.Inventory = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.NINJAMODE = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.label10 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.hbind.Animated = true;
			this.hbind.BackColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.hbind.ButtonMode = 2;
			this.hbind.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.hbind.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.hbind.CheckedState.Parent = this.hbind;
			this.hbind.CustomImages.Parent = this.hbind;
			this.hbind.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.hbind.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.hbind.ForeColor = global::System.Drawing.Color.White;
			this.hbind.HoverState.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.hbind.HoverState.Parent = this.hbind;
			this.hbind.Location = new global::System.Drawing.Point(348, 64);
			this.hbind.Name = "hbind";
			this.hbind.ShadowDecoration.Parent = this.hbind;
			this.hbind.Size = new global::System.Drawing.Size(45, 13);
			this.hbind.TabIndex = 3;
			this.hbind.Text = "[bind]";
			this.hbind.Click += new global::System.EventHandler(this.hbind_Click);
			this.hbind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.hbind_KeyDown);
			this.Bind.Animated = true;
			this.Bind.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Bind.ButtonMode = 2;
			this.Bind.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Bind.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.Bind.CheckedState.Parent = this.Bind;
			this.Bind.CustomImages.Parent = this.Bind;
			this.Bind.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Bind.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.Bind.ForeColor = global::System.Drawing.Color.White;
			this.Bind.HoverState.FillColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.Bind.HoverState.Parent = this.Bind;
			this.Bind.Location = new global::System.Drawing.Point(104, 57);
			this.Bind.Name = "Bind";
			this.Bind.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Bind.ShadowDecoration.Parent = this.Bind;
			this.Bind.Size = new global::System.Drawing.Size(48, 19);
			this.Bind.TabIndex = 3;
			this.Bind.Text = "[bind]";
			this.Bind.Click += new global::System.EventHandler(this.Bind_Click);
			this.Bind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Bind_KeyDown);
			this.Lcps.AutoSize = true;
			this.Lcps.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Lcps.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.Lcps.Location = new global::System.Drawing.Point(349, 115);
			this.Lcps.Margin = new global::System.Windows.Forms.Padding(5);
			this.Lcps.Name = "Lcps";
			this.Lcps.Size = new global::System.Drawing.Size(32, 17);
			this.Lcps.TabIndex = 2;
			this.Lcps.Text = "15.0";
			this.Lcpsslider.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Lcpsslider.BarInnerColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.Lcpsslider.BarPenColorBottom = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.Lcpsslider.BarPenColorTop = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.Lcpsslider.BorderRoundRectSize = new global::System.Drawing.Size(8, 8);
			this.Lcpsslider.DrawSemitransparentThumb = false;
			this.Lcpsslider.ElapsedInnerColor = global::System.Drawing.Color.White;
			this.Lcpsslider.ElapsedPenColorBottom = global::System.Drawing.Color.White;
			this.Lcpsslider.ElapsedPenColorTop = global::System.Drawing.Color.White;
			this.Lcpsslider.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.Lcpsslider.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider lcpsslider = this.Lcpsslider;
			int[] array = new int[4];
			array[0] = 5;
			lcpsslider.LargeChange = new decimal(array);
			this.Lcpsslider.Location = new global::System.Drawing.Point(59, 115);
			this.Lcpsslider.Margin = new global::System.Windows.Forms.Padding(5);
			global::ColorSlider.ColorSlider lcpsslider2 = this.Lcpsslider;
			int[] array2 = new int[4];
			array2[0] = 250;
			lcpsslider2.Maximum = new decimal(array2);
			global::ColorSlider.ColorSlider lcpsslider3 = this.Lcpsslider;
			int[] array3 = new int[4];
			array3[0] = 100;
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
			this.Lcpsslider.Size = new global::System.Drawing.Size(280, 17);
			global::ColorSlider.ColorSlider lcpsslider6 = this.Lcpsslider;
			int[] array6 = new int[4];
			array6[0] = 1;
			lcpsslider6.SmallChange = new decimal(array6);
			this.Lcpsslider.TabIndex = 0;
			this.Lcpsslider.ThumbInnerColor = global::System.Drawing.Color.White;
			this.Lcpsslider.ThumbPenColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Lcpsslider.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.Lcpsslider.ThumbSize = new global::System.Drawing.Size(15, 15);
			this.Lcpsslider.TickAdd = 0f;
			this.Lcpsslider.TickColor = global::System.Drawing.Color.White;
			this.Lcpsslider.TickDivide = 0f;
			this.Lcpsslider.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider lcpsslider7 = this.Lcpsslider;
			int[] array7 = new int[4];
			array7[0] = 150;
			lcpsslider7.Value = new decimal(array7);
			this.Lcpsslider.ValueChanged += new global::System.EventHandler(this.colorSlider1_ValueChanged);
			this.Lcpsslider.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.Lcpsslider_Scroll);
			this.WindowFinder.Enabled = true;
			this.WindowFinder.Interval = 250;
			this.WindowFinder.Tick += new global::System.EventHandler(this.WindowFinder_Tick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(56, 89);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(87, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Average cps :";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label2.Location = new global::System.Drawing.Point(318, 61);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 17);
			this.label2.TabIndex = 180;
			this.label2.Text = "Hide";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label3.Location = new global::System.Drawing.Point(56, 58);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(47, 17);
			this.label3.TabIndex = 182;
			this.label3.Text = "Enable";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label9.Location = new global::System.Drawing.Point(314, 190);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(78, 17);
			this.label9.TabIndex = 201;
			this.label9.Text = "Right clicker";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label7.Location = new global::System.Drawing.Point(178, 156);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(81, 17);
			this.label7.TabIndex = 199;
			this.label7.Text = "Break blocks";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label8.Location = new global::System.Drawing.Point(314, 156);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(79, 17);
			this.label8.TabIndex = 197;
			this.label8.Text = "No hit delay";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label6.Location = new global::System.Drawing.Point(54, 156);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(47, 17);
			this.label6.TabIndex = 195;
			this.label6.Text = "Blatant";
			this.mode.Animated = true;
			this.mode.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.mode.CheckedState.BorderRadius = 3;
			this.mode.CheckedState.BorderThickness = 0;
			this.mode.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.mode.CheckMarkColor = global::System.Drawing.Color.Black;
			this.mode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.mode.ForeColor = global::System.Drawing.Color.White;
			this.mode.Location = new global::System.Drawing.Point(297, 156);
			this.mode.Margin = new global::System.Windows.Forms.Padding(1);
			this.mode.Name = "mode";
			this.mode.Size = new global::System.Drawing.Size(122, 20);
			this.mode.TabIndex = 202;
			this.mode.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.mode.UncheckedState.BorderRadius = 1;
			this.mode.UncheckedState.BorderThickness = 0;
			this.mode.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.mode.UseVisualStyleBackColor = true;
			this.mode.CheckedChanged += new global::System.EventHandler(this.mode_CheckedChanged_1);
			this.statusright.Animated = true;
			this.statusright.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.statusright.CheckedState.BorderRadius = 3;
			this.statusright.CheckedState.BorderThickness = 0;
			this.statusright.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.statusright.CheckMarkColor = global::System.Drawing.Color.Black;
			this.statusright.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.statusright.ForeColor = global::System.Drawing.Color.White;
			this.statusright.Location = new global::System.Drawing.Point(296, 190);
			this.statusright.Margin = new global::System.Windows.Forms.Padding(1);
			this.statusright.Name = "statusright";
			this.statusright.Size = new global::System.Drawing.Size(122, 20);
			this.statusright.TabIndex = 203;
			this.statusright.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.statusright.UncheckedState.BorderRadius = 1;
			this.statusright.UncheckedState.BorderThickness = 0;
			this.statusright.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.statusright.UseVisualStyleBackColor = true;
			this.statusright.CheckedChanged += new global::System.EventHandler(this.statusright_CheckedChanged_1);
			this.breakblock.Animated = true;
			this.breakblock.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.breakblock.CheckedState.BorderRadius = 3;
			this.breakblock.CheckedState.BorderThickness = 0;
			this.breakblock.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.breakblock.CheckMarkColor = global::System.Drawing.Color.Black;
			this.breakblock.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.breakblock.ForeColor = global::System.Drawing.Color.White;
			this.breakblock.Location = new global::System.Drawing.Point(161, 156);
			this.breakblock.Margin = new global::System.Windows.Forms.Padding(1);
			this.breakblock.Name = "breakblock";
			this.breakblock.Size = new global::System.Drawing.Size(17, 20);
			this.breakblock.TabIndex = 204;
			this.breakblock.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.breakblock.UncheckedState.BorderRadius = 1;
			this.breakblock.UncheckedState.BorderThickness = 0;
			this.breakblock.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.breakblock.UseVisualStyleBackColor = true;
			this.breakblock.CheckedChanged += new global::System.EventHandler(this.breakblock_CheckedChanged_1);
			this.blatant.Animated = true;
			this.blatant.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.blatant.CheckedState.BorderRadius = 3;
			this.blatant.CheckedState.BorderThickness = 0;
			this.blatant.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.blatant.CheckMarkColor = global::System.Drawing.Color.Black;
			this.blatant.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.blatant.ForeColor = global::System.Drawing.Color.White;
			this.blatant.Location = new global::System.Drawing.Point(37, 156);
			this.blatant.Margin = new global::System.Windows.Forms.Padding(1);
			this.blatant.Name = "blatant";
			this.blatant.Size = new global::System.Drawing.Size(63, 20);
			this.blatant.TabIndex = 206;
			this.blatant.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.blatant.UncheckedState.BorderRadius = 1;
			this.blatant.UncheckedState.BorderThickness = 0;
			this.blatant.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.blatant.UseVisualStyleBackColor = true;
			this.blatant.CheckedChanged += new global::System.EventHandler(this.blatant_CheckedChanged_1);
			this.statusleft.Animated = true;
			this.statusleft.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.statusleft.CheckedState.BorderRadius = 3;
			this.statusleft.CheckedState.BorderThickness = 0;
			this.statusleft.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.statusleft.CheckMarkColor = global::System.Drawing.Color.Black;
			this.statusleft.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.statusleft.ForeColor = global::System.Drawing.Color.White;
			this.statusleft.Location = new global::System.Drawing.Point(37, 58);
			this.statusleft.Margin = new global::System.Windows.Forms.Padding(1);
			this.statusleft.Name = "statusleft";
			this.statusleft.Size = new global::System.Drawing.Size(66, 20);
			this.statusleft.TabIndex = 207;
			this.statusleft.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.statusleft.UncheckedState.BorderRadius = 1;
			this.statusleft.UncheckedState.BorderThickness = 0;
			this.statusleft.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.statusleft.UseVisualStyleBackColor = true;
			this.statusleft.CheckedChanged += new global::System.EventHandler(this.statusleft_CheckedChanged_1);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(160, 10);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(102, 21);
			this.label4.TabIndex = 208;
			this.label4.Text = "FRT CLICKER";
			this.Inventory.Animated = true;
			this.Inventory.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.Inventory.CheckedState.BorderRadius = 3;
			this.Inventory.CheckedState.BorderThickness = 0;
			this.Inventory.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Inventory.CheckMarkColor = global::System.Drawing.Color.Black;
			this.Inventory.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Inventory.ForeColor = global::System.Drawing.Color.White;
			this.Inventory.Location = new global::System.Drawing.Point(37, 190);
			this.Inventory.Margin = new global::System.Windows.Forms.Padding(1);
			this.Inventory.Name = "Inventory";
			this.Inventory.Size = new global::System.Drawing.Size(17, 20);
			this.Inventory.TabIndex = 205;
			this.Inventory.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.Inventory.UncheckedState.BorderRadius = 1;
			this.Inventory.UncheckedState.BorderThickness = 0;
			this.Inventory.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.Inventory.UseVisualStyleBackColor = true;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label5.Location = new global::System.Drawing.Point(55, 191);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(89, 17);
			this.label5.TabIndex = 193;
			this.label5.Text = "Inventory click";
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.NINJAMODE.Animated = true;
			this.NINJAMODE.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.NINJAMODE.CheckedState.BorderRadius = 3;
			this.NINJAMODE.CheckedState.BorderThickness = 0;
			this.NINJAMODE.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.NINJAMODE.CheckMarkColor = global::System.Drawing.Color.Black;
			this.NINJAMODE.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.NINJAMODE.ForeColor = global::System.Drawing.Color.White;
			this.NINJAMODE.Location = new global::System.Drawing.Point(161, 187);
			this.NINJAMODE.Margin = new global::System.Windows.Forms.Padding(1);
			this.NINJAMODE.Name = "NINJAMODE";
			this.NINJAMODE.Size = new global::System.Drawing.Size(17, 20);
			this.NINJAMODE.TabIndex = 212;
			this.NINJAMODE.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.NINJAMODE.UncheckedState.BorderRadius = 1;
			this.NINJAMODE.UncheckedState.BorderThickness = 0;
			this.NINJAMODE.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.NINJAMODE.UseVisualStyleBackColor = true;
			this.NINJAMODE.CheckedChanged += new global::System.EventHandler(this.guna2CheckBox1_CheckedChanged);
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.label10.Location = new global::System.Drawing.Point(179, 188);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(70, 17);
			this.label10.TabIndex = 211;
			this.label10.Text = "Ninja Mod";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(430, 231);
			base.Controls.Add(this.NINJAMODE);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.Inventory);
			base.Controls.Add(this.breakblock);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.hbind);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.Lcps);
			base.Controls.Add(this.Lcpsslider);
			base.Controls.Add(this.Bind);
			base.Controls.Add(this.mode);
			base.Controls.Add(this.statusright);
			base.Controls.Add(this.statusleft);
			base.Controls.Add(this.blatant);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			base.MaximizeBox = false;
			base.Name = "Clicker";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lunar Client";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Clicker_FormClosed);
			base.Load += new global::System.EventHandler(this.Clicker_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001E RID: 30
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label Lcps;

		// Token: 0x04000020 RID: 32
		private global::Guna.UI2.WinForms.Guna2Button Bind;

		// Token: 0x04000021 RID: 33
		private global::Guna.UI2.WinForms.Guna2Button hbind;

		// Token: 0x04000022 RID: 34
		private global::ColorSlider.ColorSlider Lcpsslider;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Timer WindowFinder;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400002B RID: 43
		private global::Guna.UI2.WinForms.Guna2CheckBox mode;

		// Token: 0x0400002C RID: 44
		private global::Guna.UI2.WinForms.Guna2CheckBox statusright;

		// Token: 0x0400002D RID: 45
		private global::Guna.UI2.WinForms.Guna2CheckBox breakblock;

		// Token: 0x0400002E RID: 46
		private global::Guna.UI2.WinForms.Guna2CheckBox blatant;

		// Token: 0x0400002F RID: 47
		private global::Guna.UI2.WinForms.Guna2CheckBox statusleft;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000031 RID: 49
		private global::Guna.UI2.WinForms.Guna2CheckBox Inventory;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000033 RID: 51
		private global::Guna.UI2.WinForms.Guna2CheckBox NINJAMODE;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label10;
	}
}
