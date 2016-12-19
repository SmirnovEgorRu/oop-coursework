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
    public partial class main_form : Form {
        main_contr main_mngr;


        public main_form() {
            InitializeComponent();
            main_mngr = new main_contr();
        }

        private void display(table table_for_display) {
            List<string> columns_name =  table_for_display.get_columns();

            foreach(string name in columns_name) {
                var column = new DataGridViewColumn();
                column.HeaderText = name;
                column.Width = (data_grid.Width-50) / columns_name.Count();
                //column.ReadOnly = true;
                column.Name = name;
                column.Frozen = true;
                column.CellTemplate = new DataGridViewTextBoxCell();
                data_grid.Columns.Add(column);
            }


            int index_raw = 0;
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
            main_mngr.add_from_file();

        }

        private void button1_Click(object sender, EventArgs e) {
            display(table_student.instanse());
            //display(table_subject.instanse());
            //display(table_deanery.instanse());
            //display(table_academic_progress.instanse());
            //display(table_faculty.instanse());
            //display(table_group.instanse());
            //display(table_specialty.instanse());
            //display(table_teacher.instanse());
        }


    }
}
