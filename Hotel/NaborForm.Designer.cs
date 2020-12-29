
namespace Hotel
{
    partial class NaborForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaborForm));
            this.Nabori = new System.Windows.Forms.DataGridView();
            this.id_набора = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кухня = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Бассейн = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ванная = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кодиционер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Напольное_покрытие = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вид = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Спальные_места = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Животные = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ChooseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nabori)).BeginInit();
            this.SuspendLayout();
            // 
            // Nabori
            // 
            this.Nabori.AllowUserToAddRows = false;
            this.Nabori.AllowUserToDeleteRows = false;
            this.Nabori.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nabori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Nabori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_набора,
            this.Кухня,
            this.Бассейн,
            this.Ванная,
            this.Кодиционер,
            this.Напольное_покрытие,
            this.Вид,
            this.Спальные_места,
            this.Животные});
            this.Nabori.Location = new System.Drawing.Point(39, 37);
            this.Nabori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nabori.Name = "Nabori";
            this.Nabori.ReadOnly = true;
            this.Nabori.RowHeadersWidth = 51;
            this.Nabori.RowTemplate.Height = 24;
            this.Nabori.Size = new System.Drawing.Size(508, 266);
            this.Nabori.TabIndex = 0;
            this.Nabori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Nabori_CellClick);
            // 
            // id_набора
            // 
            this.id_набора.HeaderText = "Номер набора";
            this.id_набора.MinimumWidth = 6;
            this.id_набора.Name = "id_набора";
            this.id_набора.ReadOnly = true;
            this.id_набора.Width = 125;
            // 
            // Кухня
            // 
            this.Кухня.HeaderText = "Кухня";
            this.Кухня.MinimumWidth = 6;
            this.Кухня.Name = "Кухня";
            this.Кухня.ReadOnly = true;
            this.Кухня.Width = 125;
            // 
            // Бассейн
            // 
            this.Бассейн.HeaderText = "Бассейн";
            this.Бассейн.MinimumWidth = 6;
            this.Бассейн.Name = "Бассейн";
            this.Бассейн.ReadOnly = true;
            this.Бассейн.Width = 125;
            // 
            // Ванная
            // 
            this.Ванная.HeaderText = "Ванная";
            this.Ванная.MinimumWidth = 6;
            this.Ванная.Name = "Ванная";
            this.Ванная.ReadOnly = true;
            this.Ванная.Width = 125;
            // 
            // Кодиционер
            // 
            this.Кодиционер.HeaderText = "Кодиционер";
            this.Кодиционер.MinimumWidth = 6;
            this.Кодиционер.Name = "Кодиционер";
            this.Кодиционер.ReadOnly = true;
            this.Кодиционер.Width = 125;
            // 
            // Напольное_покрытие
            // 
            this.Напольное_покрытие.HeaderText = "Напольное покрытие";
            this.Напольное_покрытие.MinimumWidth = 6;
            this.Напольное_покрытие.Name = "Напольное_покрытие";
            this.Напольное_покрытие.ReadOnly = true;
            this.Напольное_покрытие.Width = 125;
            // 
            // Вид
            // 
            this.Вид.HeaderText = "Вид";
            this.Вид.MinimumWidth = 6;
            this.Вид.Name = "Вид";
            this.Вид.ReadOnly = true;
            this.Вид.Width = 125;
            // 
            // Спальные_места
            // 
            this.Спальные_места.HeaderText = "Спальные_места";
            this.Спальные_места.MinimumWidth = 6;
            this.Спальные_места.Name = "Спальные_места";
            this.Спальные_места.ReadOnly = true;
            this.Спальные_места.Width = 125;
            // 
            // Животные
            // 
            this.Животные.HeaderText = "Животные";
            this.Животные.MinimumWidth = 6;
            this.Животные.Name = "Животные";
            this.Животные.ReadOnly = true;
            this.Животные.Width = 125;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(306, 323);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(146, 37);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Назад";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseBtn.Location = new System.Drawing.Point(126, 323);
            this.ChooseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(127, 37);
            this.ChooseBtn.TabIndex = 2;
            this.ChooseBtn.Text = "Выбрать";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // NaborForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 375);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Nabori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NaborForm";
            this.Text = "Список наборов особенностей";
            ((System.ComponentModel.ISupportInitialize)(this.Nabori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Nabori;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_набора;
        private System.Windows.Forms.DataGridViewTextBoxColumn Кухня;
        private System.Windows.Forms.DataGridViewTextBoxColumn Бассейн;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ванная;
        private System.Windows.Forms.DataGridViewTextBoxColumn Кодиционер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Напольное_покрытие;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вид;
        private System.Windows.Forms.DataGridViewTextBoxColumn Спальные_места;
        private System.Windows.Forms.DataGridViewTextBoxColumn Животные;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ChooseBtn;
    }
}