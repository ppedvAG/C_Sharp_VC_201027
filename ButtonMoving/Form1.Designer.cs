namespace ButtonMoving
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
            this.Btn_Left = new System.Windows.Forms.Button();
            this.Btn_Right = new System.Windows.Forms.Button();
            this.Btn_Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Left
            // 
            this.Btn_Left.Location = new System.Drawing.Point(12, 12);
            this.Btn_Left.Name = "Btn_Left";
            this.Btn_Left.Size = new System.Drawing.Size(108, 58);
            this.Btn_Left.TabIndex = 0;
            this.Btn_Left.Text = "Links";
            this.Btn_Left.UseVisualStyleBackColor = true;
            this.Btn_Left.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // Btn_Right
            // 
            this.Btn_Right.Location = new System.Drawing.Point(680, 12);
            this.Btn_Right.Name = "Btn_Right";
            this.Btn_Right.Size = new System.Drawing.Size(108, 58);
            this.Btn_Right.TabIndex = 1;
            this.Btn_Right.Text = "Rechts";
            this.Btn_Right.UseVisualStyleBackColor = true;
            this.Btn_Right.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // Btn_Main
            // 
            this.Btn_Main.Location = new System.Drawing.Point(12, 76);
            this.Btn_Main.Name = "Btn_Main";
            this.Btn_Main.Size = new System.Drawing.Size(776, 23);
            this.Btn_Main.TabIndex = 2;
            this.Btn_Main.Text = "Start";
            this.Btn_Main.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 127);
            this.Controls.Add(this.Btn_Main);
            this.Controls.Add(this.Btn_Right);
            this.Controls.Add(this.Btn_Left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Left;
        private System.Windows.Forms.Button Btn_Right;
        private System.Windows.Forms.Button Btn_Main;
    }
}

