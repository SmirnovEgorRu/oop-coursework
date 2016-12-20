using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework {
    partial class main_form : Form {
        main_contr main_mngr;
        parser_to_table parser;
        request_contr request_mngr;
        report_contr report_mngr;
        table current_table;

        public main_form() {
            InitializeComponent();
            main_mngr = new main_contr();
            parser = new parser_to_table();
            request_mngr = new request_contr();
            report_mngr = new report_contr();
        }

        private void display(table table_for_display) {
            clear_data_grid();

            if (table_for_display.get_name() == "Студент") rating_view.Enabled = true;
            else rating_view.Enabled = false;

            if (table_for_display.get_name() != "Запрос успеваемости") label_for_student.Text = "";

            List<string> columns_name =  table_for_display.get_columns();
            current_table = table_for_display;
            int column_width = (data_grid.Width-70) / columns_name.Count();

            int index = 1;
            foreach (string name in columns_name) {
                var column = new DataGridViewColumn();
                column.HeaderText = name;
                if (index == columns_name.Count()) column.Width = column_width + (data_grid.Width - column_width * index);
                else column.Width = column_width;
                //column.ReadOnly = true;
                column.Name = name;
                column.Frozen = true;
                column.CellTemplate = new DataGridViewTextBoxCell();
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                data_grid.Columns.Add(column);
                ++index;
            }

            int index_raw = 0;
            table_for_display.Reset();
            foreach (table_record record in table_for_display) {
                data_grid.Rows.Add();
                int index_column = 0;

                foreach (table_field field in record) {
                    data_grid[index_column++, index_raw].Value = field.get_value();
                }

                ++index_raw;
            }
        }

        private void clear_data_grid() {
            data_grid.Rows.Clear();
            data_grid.Columns.Clear();
        }


        private void main_form_Load(object sender, EventArgs e) {
            data_grid.ColumnHeaderMouseClick += data_grid_ColumnHeaderMouseClick;
            rating_view.Enabled = false;
        }

        private void data_grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            DataGridViewColumn newColumn = data_grid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = data_grid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null) {
                if (oldColumn == newColumn && data_grid.SortOrder == SortOrder.Ascending) direction = ListSortDirection.Descending;
                else {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            } 
            else direction = ListSortDirection.Ascending;

            data_grid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void button1_Click(object sender, EventArgs e) {
            clear_data_grid();
        }

        private void button2_Click(object sender, EventArgs e) {
            parser.parse(data_grid, current_table);
        }

        private void button3_Click(object sender, EventArgs e) {
            clear_data_grid();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void загрузитьИзФайловToolStripMenuItem_Click(object sender, EventArgs e) {
            main_mngr.add_from_file();
            if (current_table != null) display(current_table);
            else display(table_student.instanse());
        }

        private void сохранитьВФайлыToolStripMenuItem_Click(object sender, EventArgs e) {
            main_mngr.output_to_file();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e) {display(table_student.instanse());}
        private void предметыToolStripMenuItem_Click(object sender, EventArgs e) {display(table_subject.instanse()); }
        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e) {display(table_teacher.instanse());}
        private void группыToolStripMenuItem_Click(object sender, EventArgs e) { display(table_group.instanse());}
        private void успеваемостиToolStripMenuItem_Click(object sender, EventArgs e) {display(table_academic_progress.instanse());}
        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e) {display(table_faculty.instanse());}
        private void деканатыToolStripMenuItem_Click(object sender, EventArgs e) {display(table_deanery.instanse());}
        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e) {display(table_specialty.instanse());}

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}

        private void button1_Click_1(object sender, EventArgs e) {
            foreach (DataGridViewRow raw in data_grid.SelectedRows) 
                data_grid.Rows.RemoveAt(raw.Index);
        }

        private void запросНаГруппуToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Enabled = false;
            var form = new group_form(callback_group);
            form.Show();
        }

        private void запросНаСпециальностьToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Enabled = false;
            var form = new specialty_form(callback_specialty);
            form.Show();
        }

        private void запросНаФакультетToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Enabled = false;
            var form = new faculty_form(callback_faculty);
            form.Show();
        }

        private void callback_group(string group) {
            this.Enabled = true;
            if (group != "%error%") {
                table result = request_mngr.find_by_group(group);
                display(result);
            }
        }

        private void callback_faculty(string faculty) {
            this.Enabled = true;
            if (faculty != "%error%") {
                table result = request_mngr.find_by_faculty(faculty);
                display(result);
            }
        }

        private void callback_specialty(string specialty) {
            this.Enabled = true;
            if (specialty != "%error%") {
                table result = request_mngr.find_by_specialty(specialty);
                display(result);
            }
        }

        private void запросНаНесдавшихToolStripMenuItem_Click(object sender, EventArgs e) {
            table result = request_mngr.find_by_rating_2();
            display(result);
        }

        private void запросНаСтудентовСТройкамиToolStripMenuItem_Click(object sender, EventArgs e) {
            table result = request_mngr.find_by_rating_3();
            display(result);
        }

        private void запросНаСтудентовСОднимиЧетверкамиToolStripMenuItem_Click(object sender, EventArgs e) {
            table result = request_mngr.find_by_rating_4();
            display(result);
        }

        private void запросНаСтудентовСЧетверкамиИПятеркамиToolStripMenuItem_Click(object sender, EventArgs e) {
            table result = request_mngr.find_by_rating_4_and_5();
            display(result);
        }

        private void запросНаОтличниковToolStripMenuItem_Click(object sender, EventArgs e) {
            table result = request_mngr.find_by_rating_5();
            display(result);
        }

        private void button4_Click(object sender, EventArgs e) {
            label_for_student.Text = "";
            if (data_grid.SelectedRows.Count > 0 && current_table !=null) {
                if (current_table.get_name() == "Студент") {

                    int index = data_grid.SelectedRows[0].Index;

                    label_for_student.Text = Convert.ToString(data_grid[1, index].Value) + " ";
                    label_for_student.Text += Convert.ToString(data_grid[2, index].Value) + " ";
                    label_for_student.Text += Convert.ToString(data_grid[3, index].Value) + " ";
                    label_for_student.Text += Convert.ToString(data_grid[4, index].Value);

                    string str = Convert.ToString(data_grid[0, index].Value);
                    table result = request_mngr.find_by_rating(str);
                    display(result);
                }
            }
        }

        private void студентыПоToolStripMenuItem_Click(object sender, EventArgs e) {
            table result = report_mngr.report_by_rating();
            display(result);
        }

        private void студентыПоГруппамToolStripMenuItem_Click(object sender, EventArgs e) {
            table result = report_mngr.report_by_group();
            display(result);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Курсовая работа по дисциплине ООП\nстудент: Смирнов Егор\nгруппа: 14-СБК", "О программе");
        }
    }
}
