
namespace Hotel
{
    partial class EditGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGuest));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PrivilegiiBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriviousBox = new System.Windows.Forms.TextBox();
            this.PassportBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(274, 282);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(177, 44);
            this.CloseBtn.TabIndex = 31;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.Location = new System.Drawing.Point(9, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Информация о прошлых заездах";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Привилегии";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(366, 171);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(166, 26);
            this.dateTimePicker.TabIndex = 28;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // PrivilegiiBox
            // 
            this.PrivilegiiBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PrivilegiiBox.FormattingEnabled = true;
            this.PrivilegiiBox.Items.AddRange(new object[] {
            "-",
            "+"});
            this.PrivilegiiBox.Location = new System.Drawing.Point(121, 171);
            this.PrivilegiiBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrivilegiiBox.Name = "PrivilegiiBox";
            this.PrivilegiiBox.Size = new System.Drawing.Size(60, 27);
            this.PrivilegiiBox.TabIndex = 27;
            this.PrivilegiiBox.SelectedIndexChanged += new System.EventHandler(this.PrivilegiiBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Паспортные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(223, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "ФИО";
            // 
            // PriviousBox
            // 
            this.PriviousBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PriviousBox.Location = new System.Drawing.Point(301, 222);
            this.PriviousBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriviousBox.Multiline = true;
            this.PriviousBox.Name = "PriviousBox";
            this.PriviousBox.Size = new System.Drawing.Size(231, 24);
            this.PriviousBox.TabIndex = 22;
            this.PriviousBox.TextChanged += new System.EventHandler(this.PriviousBox_TextChanged);
            this.PriviousBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriviousBox_KeyPress);
            // 
            // PassportBox
            // 
            this.PassportBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PassportBox.Location = new System.Drawing.Point(209, 71);
            this.PassportBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassportBox.Multiline = true;
            this.PassportBox.Name = "PassportBox";
            this.PassportBox.Size = new System.Drawing.Size(189, 27);
            this.PassportBox.TabIndex = 21;
            this.PassportBox.TextChanged += new System.EventHandler(this.PassportBox_TextChanged);
            this.PassportBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassportBox_KeyPress);
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.phoneBox.Location = new System.Drawing.Point(173, 121);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(189, 24);
            this.phoneBox.TabIndex = 20;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NameBox.Location = new System.Drawing.Point(67, 23);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(444, 28);
            this.NameBox.TabIndex = 19;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(38, 282);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(232, 44);
            this.EditBtn.TabIndex = 18;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // EditGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 371);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.PrivilegiiBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriviousBox);
            this.Controls.Add(this.PassportBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EditBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditGuest";
            this.Text = "Редактировать гостя";
            this.Load += new System.EventHandler(this.EditGuest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox PrivilegiiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriviousBox;
        private System.Windows.Forms.TextBox PassportBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button EditBtn;
    }
}