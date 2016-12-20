namespace coursework {
    partial class main_form {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деканатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаНесдавшихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаСтудентовСТройкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаОтличниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыПоГруппамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label_for_student = new System.Windows.Forms.Label();
            this.rating_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(26, 72);
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(1017, 422);
            this.data_grid.TabIndex = 0;
            this.data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1071, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1071, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "очистить таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьИзФайловToolStripMenuItem,
            this.сохранитьВФайлыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // загрузитьИзФайловToolStripMenuItem
            // 
            this.загрузитьИзФайловToolStripMenuItem.Name = "загрузитьИзФайловToolStripMenuItem";
            this.загрузитьИзФайловToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.загрузитьИзФайловToolStripMenuItem.Text = "Загрузить из файлов";
            this.загрузитьИзФайловToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзФайловToolStripMenuItem_Click);
            // 
            // сохранитьВФайлыToolStripMenuItem
            // 
            this.сохранитьВФайлыToolStripMenuItem.Name = "сохранитьВФайлыToolStripMenuItem";
            this.сохранитьВФайлыToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сохранитьВФайлыToolStripMenuItem.Text = "Сохранить в файлы";
            this.сохранитьВФайлыToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВФайлыToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.предметыToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.группыToolStripMenuItem,
            this.успеваемостиToolStripMenuItem,
            this.факультетыToolStripMenuItem,
            this.деканатыToolStripMenuItem,
            this.специальностиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // предметыToolStripMenuItem
            // 
            this.предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            this.предметыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.предметыToolStripMenuItem.Text = "Предметы";
            this.предметыToolStripMenuItem.Click += new System.EventHandler(this.предметыToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // успеваемостиToolStripMenuItem
            // 
            this.успеваемостиToolStripMenuItem.Name = "успеваемостиToolStripMenuItem";
            this.успеваемостиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.успеваемостиToolStripMenuItem.Text = "Успеваемости";
            this.успеваемостиToolStripMenuItem.Click += new System.EventHandler(this.успеваемостиToolStripMenuItem_Click);
            // 
            // факультетыToolStripMenuItem
            // 
            this.факультетыToolStripMenuItem.Name = "факультетыToolStripMenuItem";
            this.факультетыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.факультетыToolStripMenuItem.Text = "Факультеты";
            this.факультетыToolStripMenuItem.Click += new System.EventHandler(this.факультетыToolStripMenuItem_Click);
            // 
            // деканатыToolStripMenuItem
            // 
            this.деканатыToolStripMenuItem.Name = "деканатыToolStripMenuItem";
            this.деканатыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.деканатыToolStripMenuItem.Text = "Деканаты";
            this.деканатыToolStripMenuItem.Click += new System.EventHandler(this.деканатыToolStripMenuItem_Click);
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            this.специальностиToolStripMenuItem.Click += new System.EventHandler(this.специальностиToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросНаГруппуToolStripMenuItem,
            this.запросНаСпециальностьToolStripMenuItem,
            this.запросНаФакультетToolStripMenuItem,
            this.запросНаНесдавшихToolStripMenuItem,
            this.запросНаСтудентовСТройкамиToolStripMenuItem,
            this.запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem,
            this.запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem,
            this.запросНаОтличниковToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // запросНаГруппуToolStripMenuItem
            // 
            this.запросНаГруппуToolStripMenuItem.Name = "запросНаГруппуToolStripMenuItem";
            this.запросНаГруппуToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаГруппуToolStripMenuItem.Text = "Запрос на группу";
            this.запросНаГруппуToolStripMenuItem.Click += new System.EventHandler(this.запросНаГруппуToolStripMenuItem_Click);
            // 
            // запросНаСпециальностьToolStripMenuItem
            // 
            this.запросНаСпециальностьToolStripMenuItem.Name = "запросНаСпециальностьToolStripMenuItem";
            this.запросНаСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаСпециальностьToolStripMenuItem.Text = "Запрос на специальность";
            this.запросНаСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.запросНаСпециальностьToolStripMenuItem_Click);
            // 
            // запросНаФакультетToolStripMenuItem
            // 
            this.запросНаФакультетToolStripMenuItem.Name = "запросНаФакультетToolStripMenuItem";
            this.запросНаФакультетToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаФакультетToolStripMenuItem.Text = "Запрос на факультет";
            this.запросНаФакультетToolStripMenuItem.Click += new System.EventHandler(this.запросНаФакультетToolStripMenuItem_Click);
            // 
            // запросНаНесдавшихToolStripMenuItem
            // 
            this.запросНаНесдавшихToolStripMenuItem.Name = "запросНаНесдавшихToolStripMenuItem";
            this.запросНаНесдавшихToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаНесдавшихToolStripMenuItem.Text = "Запрос на студентов несдавших сессию";
            this.запросНаНесдавшихToolStripMenuItem.Click += new System.EventHandler(this.запросНаНесдавшихToolStripMenuItem_Click);
            // 
            // запросНаСтудентовСТройкамиToolStripMenuItem
            // 
            this.запросНаСтудентовСТройкамиToolStripMenuItem.Name = "запросНаСтудентовСТройкамиToolStripMenuItem";
            this.запросНаСтудентовСТройкамиToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаСтудентовСТройкамиToolStripMenuItem.Text = "Запрос на студентов с тройками";
            this.запросНаСтудентовСТройкамиToolStripMenuItem.Click += new System.EventHandler(this.запросНаСтудентовСТройкамиToolStripMenuItem_Click);
            // 
            // запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem
            // 
            this.запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem.Name = "запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem";
            this.запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem.Text = "Запрос на студентов с одними четверками";
            this.запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem.Click += new System.EventHandler(this.запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem_Click);
            // 
            // запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem
            // 
            this.запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem.Name = "запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem";
            this.запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem.Text = "Запрос на студентов с четверками и пятерками";
            this.запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem.Click += new System.EventHandler(this.запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem_Click);
            // 
            // запросНаОтличниковToolStripMenuItem
            // 
            this.запросНаОтличниковToolStripMenuItem.Name = "запросНаОтличниковToolStripMenuItem";
            this.запросНаОтличниковToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.запросНаОтличниковToolStripMenuItem.Text = "Запрос на студентов с одними пятерками";
            this.запросНаОтличниковToolStripMenuItem.Click += new System.EventHandler(this.запросНаОтличниковToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыПоГруппамToolStripMenuItem,
            this.студентыПоToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // студентыПоГруппамToolStripMenuItem
            // 
            this.студентыПоГруппамToolStripMenuItem.Name = "студентыПоГруппамToolStripMenuItem";
            this.студентыПоГруппамToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.студентыПоГруппамToolStripMenuItem.Text = "Студенты по группам";
            this.студентыПоГруппамToolStripMenuItem.Click += new System.EventHandler(this.студентыПоГруппамToolStripMenuItem_Click);
            // 
            // студентыПоToolStripMenuItem
            // 
            this.студентыПоToolStripMenuItem.Name = "студентыПоToolStripMenuItem";
            this.студентыПоToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.студентыПоToolStripMenuItem.Text = "Студенты с успеваемостью";
            this.студентыПоToolStripMenuItem.Click += new System.EventHandler(this.студентыПоToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1071, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "удалить строки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_for_student
            // 
            this.label_for_student.AutoSize = true;
            this.label_for_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_for_student.Location = new System.Drawing.Point(26, 28);
            this.label_for_student.Name = "label_for_student";
            this.label_for_student.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_for_student.Size = new System.Drawing.Size(0, 20);
            this.label_for_student.TabIndex = 6;
            // 
            // rating_view
            // 
            this.rating_view.Location = new System.Drawing.Point(1071, 297);
            this.rating_view.Name = "rating_view";
            this.rating_view.Size = new System.Drawing.Size(94, 52);
            this.rating_view.TabIndex = 7;
            this.rating_view.Text = "успеваемость студента";
            this.rating_view.UseVisualStyleBackColor = true;
            this.rating_view.Click += new System.EventHandler(this.button4_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 519);
            this.Controls.Add(this.rating_view);
            this.Controls.Add(this.label_for_student);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзФайловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деканатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаСпециальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаНесдавшихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаСтудентовСТройкамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаОтличниковToolStripMenuItem;
        private System.Windows.Forms.Label label_for_student;
        private System.Windows.Forms.Button rating_view;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыПоГруппамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыПоToolStripMenuItem;
    }
}

