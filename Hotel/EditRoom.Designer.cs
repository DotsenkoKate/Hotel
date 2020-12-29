
namespace Hotel
{
    partial class EditRoom
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
            System.Windows.Forms.Button Pbtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoom));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.RaitingBox = new System.Windows.Forms.ComboBox();
            this.NaborBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumBox = new System.Windows.Forms.TextBox();
            Pbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbtn
            // 
            Pbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            Pbtn.FlatAppearance.BorderSize = 0;
            Pbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Pbtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            Pbtn.Location = new System.Drawing.Point(143, 187);
            Pbtn.Margin = new System.Windows.Forms.Padding(2);
            Pbtn.Name = "Pbtn";
            Pbtn.Size = new System.Drawing.Size(79, 40);
            Pbtn.TabIndex = 38;
            Pbtn.Text = "Выбрать";
            Pbtn.UseVisualStyleBackColor = true;
            Pbtn.Click += new System.EventHandler(this.Pbtn_Click);
            Pbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pbtn_MouseMove);
            // 
            // CancelBtn
            // 
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(186, 240);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 29);
            this.CancelBtn.TabIndex = 29;
            this.CancelBtn.Text = "Закрыть";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditBtn.Location = new System.Drawing.Point(22, 240);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(126, 29);
            this.EditBtn.TabIndex = 28;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Items.AddRange(new object[] {
            "готов",
            "забронирован",
            "уборка",
            "на ремонте",
            "другое"});
            this.StateBox.Location = new System.Drawing.Point(187, 124);
            this.StateBox.Margin = new System.Windows.Forms.Padding(2);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(97, 23);
            this.StateBox.TabIndex = 40;
            this.StateBox.SelectedIndexChanged += new System.EventHandler(this.StateBox_SelectedIndexChanged);
            // 
            // RaitingBox
            // 
            this.RaitingBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.RaitingBox.FormattingEnabled = true;
            this.RaitingBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RaitingBox.Location = new System.Drawing.Point(55, 124);
            this.RaitingBox.Margin = new System.Windows.Forms.Padding(2);
            this.RaitingBox.Name = "RaitingBox";
            this.RaitingBox.Size = new System.Drawing.Size(60, 27);
            this.RaitingBox.TabIndex = 39;
            this.RaitingBox.SelectedIndexChanged += new System.EventHandler(this.RaitingBox_SelectedIndexChanged);
            this.RaitingBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RaitingBox_KeyPress);
            // 
            // NaborBox
            // 
            this.NaborBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NaborBox.Location = new System.Drawing.Point(54, 196);
            this.NaborBox.Margin = new System.Windows.Forms.Padding(2);
            this.NaborBox.Multiline = true;
            this.NaborBox.Name = "NaborBox";
            this.NaborBox.ReadOnly = true;
            this.NaborBox.Size = new System.Drawing.Size(73, 24);
            this.NaborBox.TabIndex = 37;
            this.NaborBox.TextChanged += new System.EventHandler(this.NaborBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(51, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Набор особенностей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(192, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Состояние";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PriceBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PriceBox.Location = new System.Drawing.Point(201, 56);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriceBox.Maximum = new decimal(new int[] {
            99999990,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(60, 26);
            this.PriceBox.TabIndex = 34;
            this.PriceBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceBox.ValueChanged += new System.EventHandler(this.PriceBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Оценка номера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(183, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Цена за ночь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Номер";
            // 
            // NumBox
            // 
            this.NumBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NumBox.Location = new System.Drawing.Point(44, 53);
            this.NumBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumBox.Multiline = true;
            this.NumBox.Name = "NumBox";
            this.NumBox.ReadOnly = true;
            this.NumBox.Size = new System.Drawing.Size(73, 29);
            this.NumBox.TabIndex = 30;
            this.NumBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 296);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.RaitingBox);
            this.Controls.Add(Pbtn);
            this.Controls.Add(this.NaborBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditRoom";
            this.Text = "Редактировать номер";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.ComboBox RaitingBox;
        private System.Windows.Forms.TextBox NaborBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumBox;
    }
}