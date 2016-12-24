using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace coursework {
    public class file_contr {
        public void add_from_file() {
            read("files/предметы.csv", table_subject.instanse());
            read("files/парс-препод.csv", table_teacher.instanse());
            read("files/специальность.csv", table_specialty.instanse());
            read("files/факультеты.csv", table_faculty.instanse());
            read("files/деканат.csv", table_deanery.instanse());
            read("files/группа.csv", table_group.instanse());
            read("files/студент.csv", table_student.instanse());
            read("files/успеваемость.csv", table_academic_progress.instanse());
        }
        public void output_from_file() {
            write("files/предметы.csv", table_subject.instanse());
            write("files/парс-препод.csv", table_teacher.instanse());
            write("files/специальность.csv", table_specialty.instanse());
            write("files/факультеты.csv", table_faculty.instanse());
            write("files/деканат.csv", table_deanery.instanse());
            write("files/группа.csv", table_group.instanse());
            write("files/студент.csv", table_student.instanse());
            write("files/успеваемость.csv", table_academic_progress.instanse());
        }

        private void write(string file_name, table new_table) {

            FileStream file = new FileStream(file_name, FileMode.Create); 
            StreamWriter writer = new StreamWriter(file);

            foreach(table_record record in new_table) {
                bool flag = false;
                foreach (table_field field in record) {
                    if (flag) writer.Write(";");
                    flag = true;
                    writer.Write(field.get_absolute_value());
                }
                writer.Write("\n");
            }

            writer.Close();
        }
        private void read(string file_name, table new_table) {
            new_table.clear();

            FileStream file = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            string str;
            while ((str = reader.ReadLine()) != null) {
                string[] elements = str.Split(';');
                if (elements.Count<string>() > 1)
                    new_table.add_record(elements);
            }
        }

    }
}
