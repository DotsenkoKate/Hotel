
namespace Hotel
{
    partial class CreateGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGuest));
            this.CreateGuestBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.PassportBox = new System.Windows.Forms.TextBox();
            this.PriviousBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrivilegiiBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateGuestBtn
            // 
            this.CreateGuestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateGuestBtn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateGuestBtn.Location = new System.Drawing.Point(76, 283);
            this.CreateGuestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateGuestBtn.Name = "CreateGuestBtn";
            this.CreateGuestBtn.Size = new System.Drawing.Size(177, 44);
            this.CreateGuestBtn.TabIndex = 0;
            this.CreateGuestBtn.Text = "Добавить";
            this.CreateGuestBtn.UseVisualStyleBackColor = true;
            this.CreateGuestBtn.Click += new System.EventHandler(this.CreateGuestBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NameBox.Location = new System.Drawing.Point(76, 21);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(423, 27);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.phoneBox.Location = new System.Drawing.Point(182, 122);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(189, 24);
            this.phoneBox.TabIndex = 5;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // PassportBox
            // 
            this.PassportBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PassportBox.Location = new System.Drawing.Point(205, 77);
            this.PassportBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassportBox.Multiline = true;
            this.PassportBox.Name = "PassportBox";
            this.PassportBox.Size = new System.Drawing.Size(189, 27);
            this.PassportBox.TabIndex = 6;
            this.PassportBox.TextChanged += new System.EventHandler(this.PassportBox_TextChanged);
            this.PassportBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassportBox_KeyPress);
            // 
            // PriviousBox
            // 
            this.PriviousBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PriviousBox.Location = new System.Drawing.Point(300, 220);
            this.PriviousBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriviousBox.Multiline = true;
            this.PriviousBox.Name = "PriviousBox";
            this.PriviousBox.Size = new System.Drawing.Size(239, 24);
            this.PriviousBox.TabIndex = 8;
            this.PriviousBox.TextChanged += new System.EventHandler(this.PriviousBox_TextChanged);
            this.PriviousBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriviousBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(214, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Паспортные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(18, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер телефона";
            // 
            // PrivilegiiBox
            // 
            this.PrivilegiiBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PrivilegiiBox.FormattingEnabled = true;
            this.PrivilegiiBox.Items.AddRange(new object[] {
            "-",
            "+"});
            this.PrivilegiiBox.Location = new System.Drawing.Point(136, 171);
            this.PrivilegiiBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrivilegiiBox.Name = "PrivilegiiBox";
            this.PrivilegiiBox.Size = new System.Drawing.Size(60, 27);
            this.PrivilegiiBox.TabIndex = 13;
            this.PrivilegiiBox.SelectedIndexChanged += new System.EventHandler(this.PrivilegiiBox_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(370, 173);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(169, 26);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(18, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Привилегии";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.Location = new System.Drawing.Point(11, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Информация о прошлых заездах";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(283, 283);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(177, 44);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CreateGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 351);
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
            this.Controls.Add(this.CreateGuestBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateGuest";
            this.Text = "Добавить гостя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateGuestBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox PassportBox;
        private System.Windows.Forms.TextBox PriviousBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrivilegiiBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseBtn;
    }
}