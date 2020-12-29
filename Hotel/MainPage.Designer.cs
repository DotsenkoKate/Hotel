
namespace Hotel
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Guest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rooms = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.HideBtn = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_Гостя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_рождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Паспортные_данные = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Информация_о_прошлых_заездах = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Привилегии = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_телефона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.StatisticBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Состояние = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена_за_ночь = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оценка_номера = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Набор_особенностей = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Гостя,
            this.ФИО,
            this.Дата_рождения,
            this.Паспортные_данные,
            this.Информация_о_прошлых_заездах,
            this.Привилегии,
            this.Номер_телефона});
            this.dataGridView1.Location = new System.Drawing.Point(20, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // номераToolStripMenuItem
            // 
            this.номераToolStripMenuItem.Name = "номераToolStripMenuItem";
            this.номераToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.номераToolStripMenuItem.Text = "Номера";
            // 
            // администраторыToolStripMenuItem
            // 
            this.администраторыToolStripMenuItem.Name = "администраторыToolStripMenuItem";
            this.администраторыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.администраторыToolStripMenuItem.Text = "Персонал";
            // 
            // гостиToolStripMenuItem
            // 
            this.гостиToolStripMenuItem.Name = "гостиToolStripMenuItem";
            this.гостиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.гостиToolStripMenuItem.Text = "Гости";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Location = new System.Drawing.Point(20, 281);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(106, 47);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить ";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeBtn.Location = new System.Drawing.Point(163, 281);
            this.ChangeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(134, 47);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "Редактировать ";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Location = new System.Drawing.Point(340, 281);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(112, 47);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Удалить ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guest,
            this.toolStripSeparator1,
            this.rooms,
            this.toolStripSeparator2,
            this.HideBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Guest
            // 
            this.Guest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Guest.Image = ((System.Drawing.Image)(resources.GetObject("Guest.Image")));
            this.Guest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(42, 22);
            this.Guest.Text = "Гости";
            this.Guest.ToolTipText = "Гости";
            this.Guest.Click += new System.EventHandler(this.Guest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // rooms
            // 
            this.rooms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rooms.Image = ((System.Drawing.Image)(resources.GetObject("rooms.Image")));
            this.rooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(55, 22);
            this.rooms.Text = "Номера";
            this.rooms.Click += new System.EventHandler(this.rooms_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // HideBtn
            // 
            this.HideBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HideBtn.Image = ((System.Drawing.Image)(resources.GetObject("HideBtn.Image")));
            this.HideBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.Size = new System.Drawing.Size(83, 22);
            this.HideBtn.Text = "Свернуть все";
            this.HideBtn.Click += new System.EventHandler(this.HideBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.Состояние,
            this.Цена_за_ночь,
            this.Оценка_номера,
            this.Набор_особенностей});
            this.dataGridView2.Location = new System.Drawing.Point(20, 48);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(482, 218);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // id_Гостя
            // 
            this.id_Гостя.HeaderText = "id Гостя";
            this.id_Гостя.MinimumWidth = 6;
            this.id_Гостя.Name = "id_Гостя";
            this.id_Гостя.ReadOnly = true;
            this.id_Гостя.Width = 70;
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.MinimumWidth = 6;
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            this.ФИО.Width = 200;
            // 
            // Дата_рождения
            // 
            this.Дата_рождения.HeaderText = "Дата рождения";
            this.Дата_рождения.MinimumWidth = 6;
            this.Дата_рождения.Name = "Дата_рождения";
            this.Дата_рождения.ReadOnly = true;
            this.Дата_рождения.Width = 75;
            // 
            // Паспортные_данные
            // 
            this.Паспортные_данные.HeaderText = "Паспортные данные";
            this.Паспортные_данные.MinimumWidth = 6;
            this.Паспортные_данные.Name = "Паспортные_данные";
            this.Паспортные_данные.ReadOnly = true;
            this.Паспортные_данные.Width = 125;
            // 
            // Информация_о_прошлых_заездах
            // 
            this.Информация_о_прошлых_заездах.HeaderText = "Информация о прошлых заездах";
            this.Информация_о_прошлых_заездах.MinimumWidth = 6;
            this.Информация_о_прошлых_заездах.Name = "Информация_о_прошлых_заездах";
            this.Информация_о_прошлых_заездах.ReadOnly = true;
            this.Информация_о_прошлых_заездах.Width = 125;
            // 
            // Привилегии
            // 
            this.Привилегии.HeaderText = "Привилегии";
            this.Привилегии.MinimumWidth = 6;
            this.Привилегии.Name = "Привилегии";
            this.Привилегии.ReadOnly = true;
            this.Привилегии.Width = 90;
            // 
            // Номер_телефона
            // 
            this.Номер_телефона.HeaderText = "Номер телефона";
            this.Номер_телефона.MinimumWidth = 6;
            this.Номер_телефона.Name = "Номер_телефона";
            this.Номер_телефона.ReadOnly = true;
            this.Номер_телефона.Width = 125;
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ShowBtn.Location = new System.Drawing.Point(533, 163);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(100, 32);
            this.ShowBtn.TabIndex = 6;
            this.ShowBtn.Text = "Показать";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // StatisticBox
            // 
            this.StatisticBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticBox.FormattingEnabled = true;
            this.StatisticBox.Items.AddRange(new object[] {
            "Самый востребованный номер",
            "Рейтинг номеров",
            "Стоимость проживания"});
            this.StatisticBox.Location = new System.Drawing.Point(520, 119);
            this.StatisticBox.Name = "StatisticBox";
            this.StatisticBox.Size = new System.Drawing.Size(174, 25);
            this.StatisticBox.TabIndex = 7;
            this.StatisticBox.SelectedIndexChanged += new System.EventHandler(this.StatisticBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(504, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Статистические данные";
            // 
            // Номер
            // 
            this.Номер.HeaderText = "Номер";
            this.Номер.MinimumWidth = 6;
            this.Номер.Name = "Номер";
            this.Номер.ReadOnly = true;
            this.Номер.Width = 125;
            // 
            // Состояние
            // 
            this.Состояние.HeaderText = "Состояние";
            this.Состояние.MinimumWidth = 6;
            this.Состояние.Name = "Состояние";
            this.Состояние.ReadOnly = true;
            this.Состояние.Width = 125;
            // 
            // Цена_за_ночь
            // 
            this.Цена_за_ночь.HeaderText = "Цена за ночь";
            this.Цена_за_ночь.MinimumWidth = 6;
            this.Цена_за_ночь.Name = "Цена_за_ночь";
            this.Цена_за_ночь.ReadOnly = true;
            this.Цена_за_ночь.Width = 75;
            // 
            // Оценка_номера
            // 
            this.Оценка_номера.HeaderText = "Оценка номера";
            this.Оценка_номера.MinimumWidth = 6;
            this.Оценка_номера.Name = "Оценка_номера";
            this.Оценка_номера.ReadOnly = true;
            this.Оценка_номера.Width = 125;
            // 
            // Набор_особенностей
            // 
            this.Набор_особенностей.HeaderText = "Набор особенностей";
            this.Набор_особенностей.Name = "Набор_особенностей";
            this.Набор_особенностей.ReadOnly = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatisticBox);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "База учета";
            this.Activated += new System.EventHandler(this.MainPage_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem номераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гостиToolStripMenuItem;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Guest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton rooms;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton HideBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Гостя;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_рождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Паспортные_данные;
        private System.Windows.Forms.DataGridViewTextBoxColumn Информация_о_прошлых_заездах;
        private System.Windows.Forms.DataGridViewTextBoxColumn Привилегии;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_телефона;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.ComboBox StatisticBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Состояние;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена_за_ночь;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оценка_номера;
        private System.Windows.Forms.DataGridViewTextBoxColumn Набор_особенностей;
    }
}