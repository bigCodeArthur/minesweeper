namespace minesweeper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblwidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(3, 3);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1310, 946);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblwidth);
            this.flowLayoutPanel1.Controls.Add(this.numWidth);
            this.flowLayoutPanel1.Controls.Add(this.lblHeight);
            this.flowLayoutPanel1.Controls.Add(this.numHeight);
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1319, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 946);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblwidth
            // 
            this.lblwidth.AutoSize = true;
            this.lblwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwidth.Location = new System.Drawing.Point(3, 0);
            this.lblwidth.Name = "lblwidth";
            this.lblwidth.Size = new System.Drawing.Size(97, 33);
            this.lblwidth.TabIndex = 0;
            this.lblwidth.Text = "Width:";
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWidth.Location = new System.Drawing.Point(106, 3);
            this.numWidth.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(179, 35);
            this.numWidth.TabIndex = 1;
            this.numWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(3, 41);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(102, 33);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "height:";
            // 
            // numHeight
            // 
            this.numHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHeight.Location = new System.Drawing.Point(111, 44);
            this.numHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(174, 35);
            this.numHeight.TabIndex = 3;
            this.numHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(199, 48);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Generate!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCanvas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1616, 952);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1616, 952);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Validated += new System.EventHandler(this.Form1_Validated);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblwidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

