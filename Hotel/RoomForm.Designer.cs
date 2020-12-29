
namespace Hotel
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.NumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NaborBox = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RaitingBox = new System.Windows.Forms.ComboBox();
            this.StateBox = new System.Windows.Forms.ComboBox();
            Pbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbtn
            // 
            Pbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            Pbtn.FlatAppearance.BorderSize = 0;
            Pbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Pbtn.Location = new System.Drawing.Point(122, 188);
            Pbtn.Margin = new System.Windows.Forms.Padding(2);
            Pbtn.Name = "Pbtn";
            Pbtn.Size = new System.Drawing.Size(70, 24);
            Pbtn.TabIndex = 14;
            Pbtn.Text = "Выбрать";
            Pbtn.UseVisualStyleBackColor = true;
            Pbtn.Click += new System.EventHandler(this.Pbtn_Click);
            Pbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pbtn_MouseMove);
            // 
            // NumBox
            // 
            this.NumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumBox.Location = new System.Drawing.Point(37, 45);
            this.NumBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumBox.Multiline = true;
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(73, 29);
            this.NumBox.TabIndex = 0;
            this.NumBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            this.NumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(156, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена за ночь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оценка номера";
            // 
            // PriceBox
            // 
            this.PriceBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PriceBox.Location = new System.Drawing.Point(160, 45);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriceBox.Maximum = new decimal(new int[] {
            99999990,
            0,
            0,
            0});
            this.PriceBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(60, 20);
            this.PriceBox.TabIndex = 7;
            this.PriceBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceBox.ValueChanged += new System.EventHandler(this.PriceBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(166, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Состояние";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(33, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Набор особенностей";
            // 
            // NaborBox
            // 
            this.NaborBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NaborBox.Location = new System.Drawing.Point(36, 188);
            this.NaborBox.Margin = new System.Windows.Forms.Padding(2);
            this.NaborBox.Multiline = true;
            this.NaborBox.Name = "NaborBox";
            this.NaborBox.ReadOnly = true;
            this.NaborBox.Size = new System.Drawing.Size(73, 24);
            this.NaborBox.TabIndex = 13;
            this.NaborBox.TextChanged += new System.EventHandler(this.NaborBox_TextChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CreateBtn.Location = new System.Drawing.Point(33, 242);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(83, 29);
            this.CreateBtn.TabIndex = 15;
            this.CreateBtn.Text = "Добавить";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(133, 242);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 29);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Закрыть";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RaitingBox
            // 
            this.RaitingBox.FormattingEnabled = true;
            this.RaitingBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RaitingBox.Location = new System.Drawing.Point(37, 116);
            this.RaitingBox.Margin = new System.Windows.Forms.Padding(2);
            this.RaitingBox.Name = "RaitingBox";
            this.RaitingBox.Size = new System.Drawing.Size(60, 21);
            this.RaitingBox.TabIndex = 28;
            this.RaitingBox.SelectedIndexChanged += new System.EventHandler(this.RaitingBox_SelectedIndexChanged);
            // 
            // StateBox
            // 
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Items.AddRange(new object[] {
            "готов",
            "забронирован",
            "уборка",
            "на ремонте",
            "другое"});
            this.StateBox.Location = new System.Drawing.Point(179, 116);
            this.StateBox.Margin = new System.Windows.Forms.Padding(2);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(76, 21);
            this.StateBox.TabIndex = 29;
            this.StateBox.SelectedIndexChanged += new System.EventHandler(this.StateBox_SelectedIndexChanged);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 286);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.RaitingBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(Pbtn);
            this.Controls.Add(this.NaborBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm";
            this.Text = "Добавить номер";
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NaborBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox RaitingBox;
        private System.Windows.Forms.ComboBox StateBox;
    }
}