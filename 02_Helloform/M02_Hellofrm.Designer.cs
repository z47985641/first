
namespace _02_Helloform
{
    partial class M02_Hellofrm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_name = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_name
            // 
            this.Btn_name.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_name.Location = new System.Drawing.Point(345, 225);
            this.Btn_name.Name = "Btn_name";
            this.Btn_name.Size = new System.Drawing.Size(100, 29);
            this.Btn_name.TabIndex = 0;
            this.Btn_name.Text = "Hello";
            this.Btn_name.UseVisualStyleBackColor = true;
            this.Btn_name.Click += new System.EventHandler(this.Btn_name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(289, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 :";
            // 
            // TXT_name
            // 
            this.TXT_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXT_name.Location = new System.Drawing.Point(345, 190);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(100, 29);
            this.TXT_name.TabIndex = 2;
            // 
            // M02_Hellofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXT_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "M02_Hellofrm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_name;
    }
}

