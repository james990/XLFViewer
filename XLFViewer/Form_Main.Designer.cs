namespace XLFViewer
{
    partial class Form_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.Quite = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.XML = new System.Windows.Forms.Label();
            this.splitContainer_Explore = new System.Windows.Forms.SplitContainer();
            this.textBox_Explore = new System.Windows.Forms.TextBox();
            this.button_Explore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Explore)).BeginInit();
            this.splitContainer_Explore.Panel1.SuspendLayout();
            this.splitContainer_Explore.Panel2.SuspendLayout();
            this.splitContainer_Explore.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_Result.AllowDrop = true;
            this.dataGridView_Result.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_Result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Result.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Result.ColumnHeadersHeight = 24;
            this.dataGridView_Result.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView_Result.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dataGridView_Result.Location = new System.Drawing.Point(10, 12);
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.RowHeadersWidth = 60;
            this.dataGridView_Result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_Result.Size = new System.Drawing.Size(396, 143);
            this.dataGridView_Result.TabIndex = 0;
            this.dataGridView_Result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Quite
            // 
            this.Quite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quite.BackgroundImage")));
            this.Quite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Quite.Location = new System.Drawing.Point(312, 221);
            this.Quite.Name = "Quite";
            this.Quite.Size = new System.Drawing.Size(97, 32);
            this.Quite.TabIndex = 1;
            this.Quite.Text = "Quit\r\n";
            this.Quite.UseVisualStyleBackColor = true;
            this.Quite.Click += new System.EventHandler(this.button1_Click);
            // 
            // Import
            // 
            this.Import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Import.BackgroundImage")));
            this.Import.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Import.Location = new System.Drawing.Point(12, 221);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(101, 32);
            this.Import.TabIndex = 3;
            this.Import.Text = "Load";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Load_Click);
            // 
            // XML
            // 
            this.XML.BackColor = System.Drawing.Color.SandyBrown;
            this.XML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.XML.Location = new System.Drawing.Point(175, 218);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(72, 18);
            this.XML.TabIndex = 7;
            this.XML.Text = "XML Viewer.";
            // 
            // splitContainer_Explore
            // 
            this.splitContainer_Explore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer_Explore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer_Explore.BackgroundImage")));
            this.splitContainer_Explore.Location = new System.Drawing.Point(10, 170);
            this.splitContainer_Explore.Name = "splitContainer_Explore";
            // 
            // splitContainer_Explore.Panel1
            // 
            this.splitContainer_Explore.Panel1.AllowDrop = true;
            this.splitContainer_Explore.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer_Explore.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer_Explore.Panel1.BackgroundImage")));
            this.splitContainer_Explore.Panel1.Controls.Add(this.textBox_Explore);
            // 
            // splitContainer_Explore.Panel2
            // 
            this.splitContainer_Explore.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer_Explore.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer_Explore.Panel2.BackgroundImage")));
            this.splitContainer_Explore.Panel2.Controls.Add(this.button_Explore);
            this.splitContainer_Explore.Size = new System.Drawing.Size(399, 45);
            this.splitContainer_Explore.SplitterDistance = 264;
            this.splitContainer_Explore.TabIndex = 8;
            // 
            // textBox_Explore
            // 
            this.textBox_Explore.Location = new System.Drawing.Point(0, 14);
            this.textBox_Explore.Name = "textBox_Explore";
            this.textBox_Explore.Size = new System.Drawing.Size(260, 20);
            this.textBox_Explore.TabIndex = 0;
            // 
            // button_Explore
            // 
            this.button_Explore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Explore.BackgroundImage")));
            this.button_Explore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Explore.Location = new System.Drawing.Point(34, 10);
            this.button_Explore.Name = "button_Explore";
            this.button_Explore.Size = new System.Drawing.Size(97, 35);
            this.button_Explore.TabIndex = 0;
            this.button_Explore.Text = "Browse";
            this.button_Explore.UseVisualStyleBackColor = true;
            this.button_Explore.Click += new System.EventHandler(this.button_Explore_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(447, 253);
            this.Controls.Add(this.splitContainer_Explore);
            this.Controls.Add(this.XML);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Quite);
            this.Controls.Add(this.dataGridView_Result);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            this.splitContainer_Explore.Panel1.ResumeLayout(false);
            this.splitContainer_Explore.Panel1.PerformLayout();
            this.splitContainer_Explore.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Explore)).EndInit();
            this.splitContainer_Explore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Result;
        private System.Windows.Forms.Button Quite;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Label XML;
        private System.Windows.Forms.SplitContainer splitContainer_Explore;
        private System.Windows.Forms.TextBox textBox_Explore;
        private System.Windows.Forms.Button button_Explore;
    }
}

