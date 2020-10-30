namespace Serialisierung
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
            this.Lbx_Fahrzeuge = new System.Windows.Forms.ListBox();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbx_Fahrzeuge
            // 
            this.Lbx_Fahrzeuge.FormattingEnabled = true;
            this.Lbx_Fahrzeuge.ItemHeight = 16;
            this.Lbx_Fahrzeuge.Location = new System.Drawing.Point(12, 12);
            this.Lbx_Fahrzeuge.Name = "Lbx_Fahrzeuge";
            this.Lbx_Fahrzeuge.Size = new System.Drawing.Size(316, 420);
            this.Lbx_Fahrzeuge.TabIndex = 0;
            // 
            // Btn_New
            // 
            this.Btn_New.Location = new System.Drawing.Point(334, 12);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(164, 23);
            this.Btn_New.TabIndex = 1;
            this.Btn_New.Text = "Neues Fz";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(334, 41);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(164, 23);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "Lösche Fz";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(334, 70);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(164, 23);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Speichere Fzs";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(334, 99);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(164, 23);
            this.Btn_Load.TabIndex = 4;
            this.Btn_Load.Text = "Lade Fzs";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Lbx_Fahrzeuge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lbx_Fahrzeuge;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Load;
    }
}

