namespace SimpleCalculator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.KeyA = new System.Windows.Forms.TextBox();
            this.KeyC = new System.Windows.Forms.TextBox();
            this.KeyB = new System.Windows.Forms.TextBox();
            this.KeyXYZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "X^2  +      X  +      = 0";
            // 
            // KeyA
            // 
            this.KeyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyA.Location = new System.Drawing.Point(12, 36);
            this.KeyA.Name = "KeyA";
            this.KeyA.Size = new System.Drawing.Size(35, 38);
            this.KeyA.TabIndex = 1;
            // 
            // KeyC
            // 
            this.KeyC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyC.Location = new System.Drawing.Point(220, 39);
            this.KeyC.Name = "KeyC";
            this.KeyC.Size = new System.Drawing.Size(35, 38);
            this.KeyC.TabIndex = 2;
            // 
            // KeyB
            // 
            this.KeyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyB.Location = new System.Drawing.Point(128, 39);
            this.KeyB.Name = "KeyB";
            this.KeyB.Size = new System.Drawing.Size(35, 38);
            this.KeyB.TabIndex = 3;
            // 
            // KeyXYZ
            // 
            this.KeyXYZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyXYZ.Location = new System.Drawing.Point(50, 93);
            this.KeyXYZ.Name = "KeyXYZ";
            this.KeyXYZ.Size = new System.Drawing.Size(205, 23);
            this.KeyXYZ.TabIndex = 4;
            this.KeyXYZ.Text = "Решить";
            this.KeyXYZ.UseVisualStyleBackColor = true;
            this.KeyXYZ.Click += new System.EventHandler(this.KeyXYZ_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 128);
            this.Controls.Add(this.KeyXYZ);
            this.Controls.Add(this.KeyB);
            this.Controls.Add(this.KeyC);
            this.Controls.Add(this.KeyA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XYZ Квадратное уравнение";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyA;
        private System.Windows.Forms.TextBox KeyC;
        private System.Windows.Forms.TextBox KeyB;
        private System.Windows.Forms.Button KeyXYZ;
    }
}