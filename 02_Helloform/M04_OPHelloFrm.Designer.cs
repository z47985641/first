
namespace _02_Helloform
{
    partial class M04_OPHelloFrm
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
            this.BtnOPFrm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.method_try = new System.Windows.Forms.Button();
            this.OP_method = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOPFrm
            // 
            this.BtnOPFrm.Location = new System.Drawing.Point(12, 12);
            this.BtnOPFrm.Name = "BtnOPFrm";
            this.BtnOPFrm.Size = new System.Drawing.Size(377, 217);
            this.BtnOPFrm.TabIndex = 0;
            this.BtnOPFrm.Text = "Open Hello Form";
            this.BtnOPFrm.UseVisualStyleBackColor = true;
            this.BtnOPFrm.Click += new System.EventHandler(this.BtnOPFrm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 217);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Method ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // method_try
            // 
            this.method_try.Location = new System.Drawing.Point(12, 235);
            this.method_try.Name = "method_try";
            this.method_try.Size = new System.Drawing.Size(377, 217);
            this.method_try.TabIndex = 2;
            this.method_try.Text = "Method ";
            this.method_try.UseVisualStyleBackColor = true;
            this.method_try.Click += new System.EventHandler(this.method_try_Click);
            // 
            // OP_method
            // 
            this.OP_method.Location = new System.Drawing.Point(395, 235);
            this.OP_method.Name = "OP_method";
            this.OP_method.Size = new System.Drawing.Size(377, 217);
            this.OP_method.TabIndex = 3;
            this.OP_method.Text = "OPEN Method ";
            this.OP_method.UseVisualStyleBackColor = true;
            this.OP_method.Click += new System.EventHandler(this.OP_method_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 142);
            this.button2.TabIndex = 1;
            this.button2.Text = "封裝 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 142);
            this.button3.TabIndex = 4;
            this.button3.Text = "Partial";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 142);
            this.button4.TabIndex = 5;
            this.button4.Text = "Partial";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // M04_OPHelloFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 460);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OP_method);
            this.Controls.Add(this.method_try);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnOPFrm);
            this.Name = "M04_OPHelloFrm";
            this.Text = "Open";
            this.Load += new System.EventHandler(this.M04_OPHelloFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOPFrm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button method_try;
        private System.Windows.Forms.Button OP_method;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}