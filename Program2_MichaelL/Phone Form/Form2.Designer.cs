namespace Phone_Form
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_createPhone = new System.Windows.Forms.Button();
            this.textBox_phoneNum = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_serialNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Num:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial Num:";
            // 
            // button_createPhone
            // 
            this.button_createPhone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_createPhone.Location = new System.Drawing.Point(103, 138);
            this.button_createPhone.Name = "button_createPhone";
            this.button_createPhone.Size = new System.Drawing.Size(123, 23);
            this.button_createPhone.TabIndex = 3;
            this.button_createPhone.Text = "Create";
            this.button_createPhone.UseVisualStyleBackColor = true;
            this.button_createPhone.Click += new System.EventHandler(this.Button_createPhone_Click);
            // 
            // textBox_phoneNum
            // 
            this.textBox_phoneNum.Location = new System.Drawing.Point(103, 33);
            this.textBox_phoneNum.Name = "textBox_phoneNum";
            this.textBox_phoneNum.Size = new System.Drawing.Size(123, 20);
            this.textBox_phoneNum.TabIndex = 0;
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(103, 66);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(123, 20);
            this.textBox_model.TabIndex = 1;
            // 
            // textBox_serialNum
            // 
            this.textBox_serialNum.Location = new System.Drawing.Point(103, 98);
            this.textBox_serialNum.Name = "textBox_serialNum";
            this.textBox_serialNum.Size = new System.Drawing.Size(123, 20);
            this.textBox_serialNum.TabIndex = 2;
            // 
            // Form2
            // 
            this.AcceptButton = this.button_createPhone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 183);
            this.Controls.Add(this.textBox_serialNum);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.textBox_phoneNum);
            this.Controls.Add(this.button_createPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Create Phone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_createPhone;
        private System.Windows.Forms.TextBox textBox_phoneNum;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_serialNum;
    }
}