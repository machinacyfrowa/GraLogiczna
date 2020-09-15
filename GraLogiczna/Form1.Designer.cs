namespace GraLogiczna
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stawkaPlus = new System.Windows.Forms.Button();
            this.stawkaMinus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saldoBox = new System.Windows.Forms.TextBox();
            this.wygranaBox = new System.Windows.Forms.TextBox();
            this.stawkaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SALDO KONTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "STAWKA";
            // 
            // stawkaPlus
            // 
            this.stawkaPlus.Location = new System.Drawing.Point(239, 512);
            this.stawkaPlus.Name = "stawkaPlus";
            this.stawkaPlus.Size = new System.Drawing.Size(75, 23);
            this.stawkaPlus.TabIndex = 4;
            this.stawkaPlus.Text = "+";
            this.stawkaPlus.UseVisualStyleBackColor = true;
            this.stawkaPlus.Click += new System.EventHandler(this.StawkaButtonClick);
            // 
            // stawkaMinus
            // 
            this.stawkaMinus.Location = new System.Drawing.Point(320, 512);
            this.stawkaMinus.Name = "stawkaMinus";
            this.stawkaMinus.Size = new System.Drawing.Size(75, 23);
            this.stawkaMinus.TabIndex = 5;
            this.stawkaMinus.Text = "-";
            this.stawkaMinus.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "ROLL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RollButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "WYGRana";
            // 
            // saldoBox
            // 
            this.saldoBox.Location = new System.Drawing.Point(12, 515);
            this.saldoBox.Name = "saldoBox";
            this.saldoBox.Size = new System.Drawing.Size(92, 20);
            this.saldoBox.TabIndex = 8;
            this.saldoBox.Text = "100";
            // 
            // wygranaBox
            // 
            this.wygranaBox.Location = new System.Drawing.Point(111, 515);
            this.wygranaBox.Name = "wygranaBox";
            this.wygranaBox.Size = new System.Drawing.Size(59, 20);
            this.wygranaBox.TabIndex = 9;
            this.wygranaBox.Text = "0";
            // 
            // stawkaBox
            // 
            this.stawkaBox.Location = new System.Drawing.Point(177, 515);
            this.stawkaBox.Name = "stawkaBox";
            this.stawkaBox.Size = new System.Drawing.Size(56, 20);
            this.stawkaBox.TabIndex = 10;
            this.stawkaBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 539);
            this.Controls.Add(this.stawkaBox);
            this.Controls.Add(this.wygranaBox);
            this.Controls.Add(this.saldoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stawkaMinus);
            this.Controls.Add(this.stawkaPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stawkaPlus;
        private System.Windows.Forms.Button stawkaMinus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saldoBox;
        private System.Windows.Forms.TextBox wygranaBox;
        private System.Windows.Forms.TextBox stawkaBox;
    }
}

