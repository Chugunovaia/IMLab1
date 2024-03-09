namespace IMLab1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button = new System.Windows.Forms.Button();
			this.nWeight = new System.Windows.Forms.NumericUpDown();
			this.nSize = new System.Windows.Forms.NumericUpDown();
			this.nSpeed = new System.Windows.Forms.NumericUpDown();
			this.nAngle = new System.Windows.Forms.NumericUpDown();
			this.nHeight = new System.Windows.Forms.NumericUpDown();
			this.weight = new System.Windows.Forms.Label();
			this.angle = new System.Windows.Forms.Label();
			this.size = new System.Windows.Forms.Label();
			this.height = new System.Windows.Forms.Label();
			this.speed = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Cdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CDist = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CMaxH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CSpEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ndt = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ndt)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button);
			this.panel1.Controls.Add(this.ndt);
			this.panel1.Controls.Add(this.nWeight);
			this.panel1.Controls.Add(this.nSize);
			this.panel1.Controls.Add(this.nSpeed);
			this.panel1.Controls.Add(this.nAngle);
			this.panel1.Controls.Add(this.nHeight);
			this.panel1.Controls.Add(this.weight);
			this.panel1.Controls.Add(this.angle);
			this.panel1.Controls.Add(this.size);
			this.panel1.Controls.Add(this.height);
			this.panel1.Controls.Add(this.speed);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1109, 92);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(1017, 32);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(80, 44);
			this.button.TabIndex = 5;
			this.button.Text = "Старт";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// nWeight
			// 
			this.nWeight.Location = new System.Drawing.Point(546, 60);
			this.nWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nWeight.Name = "nWeight";
			this.nWeight.Size = new System.Drawing.Size(120, 22);
			this.nWeight.TabIndex = 4;
			this.nWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nWeight.ValueChanged += new System.EventHandler(this.nWeight_ValueChanged);
			// 
			// nSize
			// 
			this.nSize.Location = new System.Drawing.Point(546, 32);
			this.nSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nSize.Name = "nSize";
			this.nSize.Size = new System.Drawing.Size(120, 22);
			this.nSize.TabIndex = 4;
			this.nSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nSpeed
			// 
			this.nSpeed.Location = new System.Drawing.Point(344, 32);
			this.nSpeed.Name = "nSpeed";
			this.nSpeed.Size = new System.Drawing.Size(120, 22);
			this.nSpeed.TabIndex = 4;
			// 
			// nAngle
			// 
			this.nAngle.Location = new System.Drawing.Point(104, 62);
			this.nAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.nAngle.Name = "nAngle";
			this.nAngle.Size = new System.Drawing.Size(120, 22);
			this.nAngle.TabIndex = 4;
			// 
			// nHeight
			// 
			this.nHeight.Location = new System.Drawing.Point(104, 32);
			this.nHeight.Name = "nHeight";
			this.nHeight.Size = new System.Drawing.Size(120, 22);
			this.nHeight.TabIndex = 4;
			// 
			// weight
			// 
			this.weight.AutoSize = true;
			this.weight.Location = new System.Drawing.Point(483, 62);
			this.weight.Name = "weight";
			this.weight.Size = new System.Drawing.Size(48, 16);
			this.weight.TabIndex = 3;
			this.weight.Text = "Масса";
			// 
			// angle
			// 
			this.angle.AutoSize = true;
			this.angle.Location = new System.Drawing.Point(12, 62);
			this.angle.Name = "angle";
			this.angle.Size = new System.Drawing.Size(87, 16);
			this.angle.TabIndex = 1;
			this.angle.Text = "Угол броска";
			// 
			// size
			// 
			this.size.AutoSize = true;
			this.size.Location = new System.Drawing.Point(483, 34);
			this.size.Name = "size";
			this.size.Size = new System.Drawing.Size(57, 16);
			this.size.TabIndex = 2;
			this.size.Text = "Размер";
			// 
			// height
			// 
			this.height.AutoSize = true;
			this.height.Location = new System.Drawing.Point(12, 34);
			this.height.Name = "height";
			this.height.Size = new System.Drawing.Size(86, 16);
			this.height.TabIndex = 0;
			this.height.Text = "Нач. высота";
			// 
			// speed
			// 
			this.speed.AutoSize = true;
			this.speed.Location = new System.Drawing.Point(240, 34);
			this.speed.Name = "speed";
			this.speed.Size = new System.Drawing.Size(98, 16);
			this.speed.TabIndex = 1;
			this.speed.Text = "Нач. скорость";
			// 
			// chart1
			// 
			chartArea3.AxisX.Minimum = 0D;
			chartArea3.AxisY.Minimum = 0D;
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			this.chart1.Location = new System.Drawing.Point(0, 98);
			this.chart1.Name = "chart1";
			series3.BorderWidth = 3;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Name = "Series1";
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(693, 475);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cdt,
            this.CDist,
            this.CMaxH,
            this.CSpEnd});
			this.dataGridView1.Location = new System.Drawing.Point(699, 98);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 10;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(398, 399);
			this.dataGridView1.TabIndex = 2;
			// 
			// Cdt
			// 
			this.Cdt.HeaderText = "Time step";
			this.Cdt.MinimumWidth = 6;
			this.Cdt.Name = "Cdt";
			this.Cdt.Width = 96;
			// 
			// CDist
			// 
			this.CDist.HeaderText = "Distance";
			this.CDist.MinimumWidth = 6;
			this.CDist.Name = "CDist";
			this.CDist.Width = 89;
			// 
			// CMaxH
			// 
			this.CMaxH.HeaderText = "MaxHeight";
			this.CMaxH.MinimumWidth = 6;
			this.CMaxH.Name = "CMaxH";
			// 
			// CSpEnd
			// 
			this.CSpEnd.HeaderText = "End Speed";
			this.CSpEnd.MinimumWidth = 6;
			this.CSpEnd.Name = "CSpEnd";
			this.CSpEnd.Width = 104;
			// 
			// ndt
			// 
			this.ndt.DecimalPlaces = 2;
			this.ndt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.ndt.Location = new System.Drawing.Point(855, 32);
			this.ndt.Name = "ndt";
			this.ndt.Size = new System.Drawing.Size(120, 22);
			this.ndt.TabIndex = 4;
			this.ndt.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ndt.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1326, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 44);
			this.button1.TabIndex = 5;
			this.button1.Text = "Старт";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(821, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "dt";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 579);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ndt)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label height;
		private System.Windows.Forms.Label weight;
		private System.Windows.Forms.Label angle;
		private System.Windows.Forms.Label size;
		private System.Windows.Forms.Label speed;
		private System.Windows.Forms.NumericUpDown nWeight;
		private System.Windows.Forms.NumericUpDown nSize;
		private System.Windows.Forms.NumericUpDown nSpeed;
		private System.Windows.Forms.NumericUpDown nAngle;
		private System.Windows.Forms.NumericUpDown nHeight;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cdt;
		private System.Windows.Forms.DataGridViewTextBoxColumn CDist;
		private System.Windows.Forms.DataGridViewTextBoxColumn CMaxH;
		private System.Windows.Forms.DataGridViewTextBoxColumn CSpEnd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown ndt;
	}
}

