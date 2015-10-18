namespace HoNFreeAvatar
{
    partial class ChangePath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePath));
            this.lb_SBT = new System.Windows.Forms.Label();
            this.lb_Garena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lb_Super = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_SBT
            // 
            this.lb_SBT.AutoSize = true;
            this.lb_SBT.Location = new System.Drawing.Point(13, 13);
            this.lb_SBT.Name = "lb_SBT";
            this.lb_SBT.Size = new System.Drawing.Size(81, 13);
            this.lb_SBT.TabIndex = 0;
            this.lb_SBT.Text = "Soon Beta Test";
            // 
            // lb_Garena
            // 
            this.lb_Garena.AutoSize = true;
            this.lb_Garena.Location = new System.Drawing.Point(13, 39);
            this.lb_Garena.Name = "lb_Garena";
            this.lb_Garena.Size = new System.Drawing.Size(42, 13);
            this.lb_Garena.TabIndex = 1;
            this.lb_Garena.Text = "Garena";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(186, 104);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lb_Super
            // 
            this.lb_Super.AutoSize = true;
            this.lb_Super.Location = new System.Drawing.Point(13, 65);
            this.lb_Super.Name = "lb_Super";
            this.lb_Super.Size = new System.Drawing.Size(35, 13);
            this.lb_Super.TabIndex = 5;
            this.lb_Super.Text = "Super";
            // 
            // ChangePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 149);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lb_Super);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Garena);
            this.Controls.Add(this.lb_SBT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePath";
            this.Text = "Change Path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SBT;
        private System.Windows.Forms.Label lb_Garena;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lb_Super;
    }
}