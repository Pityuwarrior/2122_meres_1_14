
namespace _2122_meres_1_14
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakszama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakosszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.keretosszeg,
            this.szamlakszama,
            this.szamlakosszege});
            this.dgv.Location = new System.Drawing.Point(12, 45);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(692, 258);
            this.dgv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új pályázat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(428, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.FillWeight = 20.30457F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // keretosszeg
            // 
            this.keretosszeg.FillWeight = 126.5651F;
            this.keretosszeg.HeaderText = "keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            // 
            // szamlakszama
            // 
            this.szamlakszama.FillWeight = 126.5651F;
            this.szamlakszama.HeaderText = "Számlák száma";
            this.szamlakszama.Name = "szamlakszama";
            // 
            // szamlakosszege
            // 
            this.szamlakosszege.FillWeight = 126.5651F;
            this.szamlakosszege.HeaderText = "számlák összege";
            this.szamlakosszege.Name = "szamlakosszege";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakszama;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakosszege;
    }
}

