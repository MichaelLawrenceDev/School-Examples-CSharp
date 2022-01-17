namespace Phone_Form
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
            this.comboBox_ContactList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_PhoneInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_serialNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_phoneNum = new System.Windows.Forms.TextBox();
            this.button_DialPhone = new System.Windows.Forms.Button();
            this.groupBox_SimCard = new System.Windows.Forms.GroupBox();
            this.button_addSimCard = new System.Windows.Forms.Button();
            this.button_removeSim = new System.Windows.Forms.Button();
            this.textBox_simCard = new System.Windows.Forms.TextBox();
            this.groupBox_ContactInfo = new System.Windows.Forms.GroupBox();
            this.button_removeContact = new System.Windows.Forms.Button();
            this.textBox_contactName = new System.Windows.Forms.TextBox();
            this.button_addContact = new System.Windows.Forms.Button();
            this.textBox_contactNumber = new System.Windows.Forms.TextBox();
            this.groupBox_PhoneInfo.SuspendLayout();
            this.groupBox_SimCard.SuspendLayout();
            this.groupBox_ContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_ContactList
            // 
            this.comboBox_ContactList.FormattingEnabled = true;
            this.comboBox_ContactList.Location = new System.Drawing.Point(25, 48);
            this.comboBox_ContactList.Name = "comboBox_ContactList";
            this.comboBox_ContactList.Size = new System.Drawing.Size(175, 21);
            this.comboBox_ContactList.TabIndex = 0;
            this.comboBox_ContactList.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ContactList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact List:";
            // 
            // groupBox_PhoneInfo
            // 
            this.groupBox_PhoneInfo.Controls.Add(this.label4);
            this.groupBox_PhoneInfo.Controls.Add(this.textBox_serialNum);
            this.groupBox_PhoneInfo.Controls.Add(this.label3);
            this.groupBox_PhoneInfo.Controls.Add(this.textBox_model);
            this.groupBox_PhoneInfo.Controls.Add(this.label2);
            this.groupBox_PhoneInfo.Controls.Add(this.textBox_phoneNum);
            this.groupBox_PhoneInfo.Location = new System.Drawing.Point(249, 12);
            this.groupBox_PhoneInfo.Name = "groupBox_PhoneInfo";
            this.groupBox_PhoneInfo.Size = new System.Drawing.Size(200, 157);
            this.groupBox_PhoneInfo.TabIndex = 1;
            this.groupBox_PhoneInfo.TabStop = false;
            this.groupBox_PhoneInfo.Text = "Phone Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Serial Number";
            // 
            // textBox_serialNum
            // 
            this.textBox_serialNum.Location = new System.Drawing.Point(21, 123);
            this.textBox_serialNum.Name = "textBox_serialNum";
            this.textBox_serialNum.ReadOnly = true;
            this.textBox_serialNum.Size = new System.Drawing.Size(157, 20);
            this.textBox_serialNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(21, 79);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.ReadOnly = true;
            this.textBox_model.Size = new System.Drawing.Size(157, 20);
            this.textBox_model.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone Number";
            // 
            // textBox_phoneNum
            // 
            this.textBox_phoneNum.Location = new System.Drawing.Point(21, 36);
            this.textBox_phoneNum.Name = "textBox_phoneNum";
            this.textBox_phoneNum.ReadOnly = true;
            this.textBox_phoneNum.Size = new System.Drawing.Size(157, 20);
            this.textBox_phoneNum.TabIndex = 1;
            // 
            // button_DialPhone
            // 
            this.button_DialPhone.Location = new System.Drawing.Point(39, 213);
            this.button_DialPhone.Name = "button_DialPhone";
            this.button_DialPhone.Size = new System.Drawing.Size(144, 33);
            this.button_DialPhone.TabIndex = 1;
            this.button_DialPhone.Text = "DIAL";
            this.button_DialPhone.UseVisualStyleBackColor = true;
            this.button_DialPhone.Click += new System.EventHandler(this.Button_DialPhone_Click);
            // 
            // groupBox_SimCard
            // 
            this.groupBox_SimCard.Controls.Add(this.button_addSimCard);
            this.groupBox_SimCard.Controls.Add(this.button_removeSim);
            this.groupBox_SimCard.Controls.Add(this.textBox_simCard);
            this.groupBox_SimCard.Location = new System.Drawing.Point(249, 175);
            this.groupBox_SimCard.Name = "groupBox_SimCard";
            this.groupBox_SimCard.Size = new System.Drawing.Size(200, 71);
            this.groupBox_SimCard.TabIndex = 3;
            this.groupBox_SimCard.TabStop = false;
            this.groupBox_SimCard.Text = "Sim Card Options";
            // 
            // button_addSimCard
            // 
            this.button_addSimCard.Location = new System.Drawing.Point(104, 42);
            this.button_addSimCard.Name = "button_addSimCard";
            this.button_addSimCard.Size = new System.Drawing.Size(75, 23);
            this.button_addSimCard.TabIndex = 1;
            this.button_addSimCard.Text = "Add Sim Card";
            this.button_addSimCard.UseVisualStyleBackColor = true;
            this.button_addSimCard.Click += new System.EventHandler(this.Button_addSimCard_Click);
            // 
            // button_removeSim
            // 
            this.button_removeSim.Enabled = false;
            this.button_removeSim.Location = new System.Drawing.Point(21, 42);
            this.button_removeSim.Name = "button_removeSim";
            this.button_removeSim.Size = new System.Drawing.Size(75, 23);
            this.button_removeSim.TabIndex = 0;
            this.button_removeSim.Text = "Remove";
            this.button_removeSim.UseVisualStyleBackColor = true;
            this.button_removeSim.Click += new System.EventHandler(this.Button_removeSim_Click);
            // 
            // textBox_simCard
            // 
            this.textBox_simCard.Location = new System.Drawing.Point(22, 19);
            this.textBox_simCard.Name = "textBox_simCard";
            this.textBox_simCard.Size = new System.Drawing.Size(157, 20);
            this.textBox_simCard.TabIndex = 0;
            // 
            // groupBox_ContactInfo
            // 
            this.groupBox_ContactInfo.Controls.Add(this.button_removeContact);
            this.groupBox_ContactInfo.Controls.Add(this.textBox_contactName);
            this.groupBox_ContactInfo.Location = new System.Drawing.Point(25, 81);
            this.groupBox_ContactInfo.Name = "groupBox_ContactInfo";
            this.groupBox_ContactInfo.Size = new System.Drawing.Size(175, 88);
            this.groupBox_ContactInfo.TabIndex = 4;
            this.groupBox_ContactInfo.TabStop = false;
            this.groupBox_ContactInfo.Text = "Selected Contact Information";
            // 
            // button_removeContact
            // 
            this.button_removeContact.Location = new System.Drawing.Point(39, 52);
            this.button_removeContact.Name = "button_removeContact";
            this.button_removeContact.Size = new System.Drawing.Size(95, 22);
            this.button_removeContact.TabIndex = 0;
            this.button_removeContact.Text = "Remove Contact";
            this.button_removeContact.UseVisualStyleBackColor = true;
            this.button_removeContact.Click += new System.EventHandler(this.Button_removeContact_Click);
            // 
            // textBox_contactName
            // 
            this.textBox_contactName.Location = new System.Drawing.Point(14, 20);
            this.textBox_contactName.Name = "textBox_contactName";
            this.textBox_contactName.ReadOnly = true;
            this.textBox_contactName.Size = new System.Drawing.Size(144, 20);
            this.textBox_contactName.TabIndex = 6;
            // 
            // button_addContact
            // 
            this.button_addContact.Location = new System.Drawing.Point(105, 20);
            this.button_addContact.Name = "button_addContact";
            this.button_addContact.Size = new System.Drawing.Size(95, 22);
            this.button_addContact.TabIndex = 0;
            this.button_addContact.Text = "Add Contact";
            this.button_addContact.UseVisualStyleBackColor = true;
            this.button_addContact.Click += new System.EventHandler(this.Button_addContact_Click);
            // 
            // textBox_contactNumber
            // 
            this.textBox_contactNumber.Location = new System.Drawing.Point(39, 182);
            this.textBox_contactNumber.Name = "textBox_contactNumber";
            this.textBox_contactNumber.Size = new System.Drawing.Size(144, 20);
            this.textBox_contactNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 259);
            this.Controls.Add(this.button_addContact);
            this.Controls.Add(this.textBox_contactNumber);
            this.Controls.Add(this.groupBox_ContactInfo);
            this.Controls.Add(this.groupBox_SimCard);
            this.Controls.Add(this.button_DialPhone);
            this.Controls.Add(this.groupBox_PhoneInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ContactList);
            this.Name = "Form1";
            this.Text = "Phone Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_PhoneInfo.ResumeLayout(false);
            this.groupBox_PhoneInfo.PerformLayout();
            this.groupBox_SimCard.ResumeLayout(false);
            this.groupBox_SimCard.PerformLayout();
            this.groupBox_ContactInfo.ResumeLayout(false);
            this.groupBox_ContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ContactList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_PhoneInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_phoneNum;
        private System.Windows.Forms.Button button_DialPhone;
        private System.Windows.Forms.GroupBox groupBox_SimCard;
        private System.Windows.Forms.TextBox textBox_simCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_serialNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.Button button_addSimCard;
        private System.Windows.Forms.Button button_removeSim;
        private System.Windows.Forms.GroupBox groupBox_ContactInfo;
        private System.Windows.Forms.Button button_addContact;
        private System.Windows.Forms.TextBox textBox_contactNumber;
        private System.Windows.Forms.TextBox textBox_contactName;
        private System.Windows.Forms.Button button_removeContact;
    }
}

