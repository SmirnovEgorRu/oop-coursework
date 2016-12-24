using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework {
    public class parser_to_table {

        public void parse(DataGridView data_grid, table source_table) {
            string table_name = source_table.get_name();
            
            switch (table_name) {
                case "Студент": student(data_grid, source_table); break;
                case "Преподаватель": teacher(data_grid, source_table); break;
                case "Предмет": subject(data_grid, source_table); break;
                case "Успеваемость": academic_progress(data_grid, source_table); break;
                case "Группа": group(data_grid, source_table); break;
                case "Деканат": deanery(data_grid, source_table); break;
                case "Специальность": specialty(data_grid, source_table); break;
                case "Факультет": faculty(data_grid, source_table); break;
                case "Запрос успеваемости": request_rating(data_grid, source_table); break;
                default: break;
            }
        }

        void student(DataGridView data_grid, table source_table) {
            source_table.clear();

            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                bool error = false;
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j) {
                    if (j == 4) {
                        string key = table_group.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                        if (key != "%undef%") arg[j] = key;
                        else error = true;
                    }
                    else arg[j] = Convert.ToString(data_grid[j, i].Value);
                }

                if (!error) source_table.add_record(arg);
            }
        }

        void group(DataGridView data_grid, table source_table) {
            source_table.clear();
            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                bool error = false;
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j) {
                    if (j == 3) {
                        string key = table_specialty.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                        if (key != "%undef%") arg[j] = key;
                        else error = true;
                    } 
                    else if (j == 4) {
                        string key = table_faculty.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                        if (key != "%undef%") arg[j] = key;
                        else error = true;
                    }
                    else arg[j] = Convert.ToString(data_grid[j, i].Value);
                }

                if (!error) source_table.add_record(arg);
            }
        }

        void subject(DataGridView data_grid, table source_table) {
            source_table.clear();
            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j)
                    arg[j] = Convert.ToString(data_grid[j, i].Value);

                source_table.add_record(arg);
            }
        }

        void academic_progress(DataGridView data_grid, table source_table) {
            source_table.clear();
            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                bool error = false;
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j) {
                    //if (j == 0) {
                    //    string key = table_student.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                    //    if (key != "%undef%") arg[j] = key;
                    //    else error = true;
                    //}
                     if (j == 1) {
                        string key = table_subject.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                        if (key != "%undef%") arg[j] = key;
                        else error = true;
                    }
                    //else if (j == 5) {
                    //    string key = table_teacher.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                    //    if (key != "%undef%") arg[j] = key;
                    //    else error = true;
                    //}
                    else arg[j] = Convert.ToString(data_grid[j, i].Value);
                }

                if (!error) source_table.add_record(arg);
            }
        }

        void teacher(DataGridView data_grid, table source_table) {
            source_table.clear();
            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j)
                    arg[j] = Convert.ToString(data_grid[j, i].Value);

                source_table.add_record(arg);
            }
        }

        void deanery(DataGridView data_grid, table source_table) {
            source_table.clear();
            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                bool error = false;
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j) {
                    if (j == 0) {
                        string key = table_faculty.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                        if (key != "%undef%") arg[j] = key;
                        else error = true;
                    } else arg[j] = Convert.ToString(data_grid[j, i].Value);
                }

                if (!error) source_table.add_record(arg);
            }
        }

        void specialty(DataGridView data_grid, table source_table) {
            source_table.clear();
            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j)
                    arg[j] = Convert.ToString(data_grid[j, i].Value);

                source_table.add_record(arg);
            }
        }

        void faculty(DataGridView data_grid, table source_table) {
            source_table.clear();
            for (int i = 0, n_raw = data_grid.RowCount-1; i < n_raw; ++i) {
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j)
                    arg[j] = Convert.ToString(data_grid[j, i].Value);

                source_table.add_record(arg);
            }
        }

        void request_rating(DataGridView data_grid, table source_table) {
            var student = table_student.instanse();

            int size = source_table.size();

            if (size < 1) return;
            string index = source_table[0][0].get_absolute_value();

            var rating = table_academic_progress.instanse();

            List<table_record> to_delete = new List<table_record>();


            rating.Reset();
            foreach (table_record record in rating) {
                string n_index = record[0].get_value();
                if (index == n_index) {
                    to_delete.Add(record);
                }
            }

            foreach (table_record record in to_delete) {
                rating.delete_record(record);
            }

                for (int i = 0, n_raw = data_grid.RowCount - 1; i < n_raw; ++i) {
                bool error = false;
                string[] arg = new string[data_grid.ColumnCount];

                for (int j = 0, n_columns = data_grid.ColumnCount; j < n_columns; ++j) {
                    if (j == 1) {
                        string key = table_subject.instanse().find(Convert.ToString(data_grid[j, i].Value), 1, 0);
                        if (key != "%undef%") arg[j] = key;
                        else error = true;
                    }
                    else arg[j] = Convert.ToString(data_grid[j, i].Value);
                }
                if (!error) rating.add_record(arg);
            }
        }

    }
}
