namespace MoneyManager
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtWhat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAllamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobxCurr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtNeg = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(304, 226);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 13);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(243, 259);
            this.txtResult.TabIndex = 1;
            // 
            // txtWhat
            // 
            this.txtWhat.Location = new System.Drawing.Point(304, 252);
            this.txtWhat.Name = "txtWhat";
            this.txtWhat.Size = new System.Drawing.Size(120, 20);
            this.txtWhat.TabIndex = 2;
            this.txtWhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAllamount
            // 
            this.txtAllamount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAllamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAllamount.ForeColor = System.Drawing.Color.Silver;
            this.txtAllamount.Location = new System.Drawing.Point(349, 21);
            this.txtAllamount.Multiline = true;
            this.txtAllamount.Name = "txtAllamount";
            this.txtAllamount.ReadOnly = true;
            this.txtAllamount.Size = new System.Drawing.Size(43, 13);
            this.txtAllamount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 35);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(180, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "What";
            // 
            // combobxCurr
            // 
            this.combobxCurr.FormattingEnabled = true;
            this.combobxCurr.Items.AddRange(new object[] {
            "€",
            "$",
            "Kč"});
            this.combobxCurr.Location = new System.Drawing.Point(427, 225);
            this.combobxCurr.Name = "combobxCurr";
            this.combobxCurr.Size = new System.Drawing.Size(36, 21);
            this.combobxCurr.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Month";
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonth.Location = new System.Drawing.Point(349, 41);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(43, 13);
            this.txtMonth.TabIndex = 14;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(349, 192);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 23);
            this.btnMonth.TabIndex = 15;
            this.btnMonth.Text = "New Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnLoad1
            // 
            this.btnLoad1.Location = new System.Drawing.Point(6, 35);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(180, 23);
            this.btnLoad1.TabIndex = 16;
            this.btnLoad1.Text = "Load ";
            this.btnLoad1.UseVisualStyleBackColor = true;
            this.btnLoad1.Click += new System.EventHandler(this.btnLoad1_Click);
            // 
            // btnLoad2
            // 
            this.btnLoad2.Location = new System.Drawing.Point(6, 35);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(180, 23);
            this.btnLoad2.TabIndex = 17;
            this.btnLoad2.Text = "Load ";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(6, 6);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(180, 23);
            this.btnSave1.TabIndex = 18;
            this.btnSave1.Text = "Save ";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(6, 6);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(180, 23);
            this.btnSave2.TabIndex = 19;
            this.btnSave2.Text = "Save ";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(269, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 91);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 65);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoad1);
            this.tabPage2.Controls.Add(this.btnSave1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 65);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnLoad2);
            this.tabPage3.Controls.Add(this.btnSave2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 65);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 280);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(478, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "©Jan Kubát 2019";
            // 
            // txtPos
            // 
            this.txtPos.BackColor = System.Drawing.SystemColors.Control;
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPos.Location = new System.Drawing.Point(349, 59);
            this.txtPos.Name = "txtPos";
            this.txtPos.ReadOnly = true;
            this.txtPos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPos.Size = new System.Drawing.Size(100, 13);
            this.txtPos.TabIndex = 23;
            this.txtPos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(265, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Income";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(265, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Expense";
            // 
            // txtCurrency
            // 
            this.txtCurrency.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrency.Location = new System.Drawing.Point(427, 228);
            this.txtCurrency.Multiline = true;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ReadOnly = true;
            this.txtCurrency.Size = new System.Drawing.Size(22, 15);
            this.txtCurrency.TabIndex = 29;
            this.txtCurrency.Visible = false;
            // 
            // txtNeg
            // 
            this.txtNeg.BackColor = System.Drawing.SystemColors.Control;
            this.txtNeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNeg.ForeColor = System.Drawing.Color.Red;
            this.txtNeg.Location = new System.Drawing.Point(349, 81);
            this.txtNeg.Name = "txtNeg";
            this.txtNeg.ReadOnly = true;
            this.txtNeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNeg.Size = new System.Drawing.Size(100, 13);
            this.txtNeg.TabIndex = 30;
            this.txtNeg.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 302);
            this.Controls.Add(this.txtNeg);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combobxCurr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAllamount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWhat);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(494, 340);
            this.MinimumSize = new System.Drawing.Size(494, 340);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyManager 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtWhat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAllamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobxCurr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.Button btnLoad2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtNeg;
    }
}

