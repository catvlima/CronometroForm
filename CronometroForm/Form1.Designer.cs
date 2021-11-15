
namespace CronometroForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.bt_OnOff = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contador.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_Contador.Location = new System.Drawing.Point(41, 74);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(341, 50);
            this.lbl_Contador.TabIndex = 2;
            this.lbl_Contador.Text = "00:00:00:00";
            // 
            // bt_OnOff
            // 
            this.bt_OnOff.BackColor = System.Drawing.Color.Black;
            this.bt_OnOff.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_OnOff.ForeColor = System.Drawing.Color.SeaGreen;
            this.bt_OnOff.Location = new System.Drawing.Point(273, 153);
            this.bt_OnOff.Name = "bt_OnOff";
            this.bt_OnOff.Size = new System.Drawing.Size(109, 65);
            this.bt_OnOff.TabIndex = 3;
            this.bt_OnOff.Text = "Ligar";
            this.bt_OnOff.UseVisualStyleBackColor = false;
            this.bt_OnOff.Click += new System.EventHandler(this.bt_OnOff_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(421, 248);
            this.Controls.Add(this.bt_OnOff);
            this.Controls.Add(this.lbl_Contador);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.Button bt_OnOff;
        private System.Windows.Forms.Timer timer1;
    }
}

