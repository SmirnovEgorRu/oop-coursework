using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {
    interface request {
        table execute(object arg = null);
    }

    // ---------------------------
    abstract class request_by_value: request {
        protected table result;

        public abstract table execute(object arg);

        protected void find(table search_table, int index, string value) {
            search_table.Reset();
            int n = search_table.get_columns().Count;

            foreach (table_record record in search_table) {
                if (record[index].get_value() == value) {
                    string[] arg = record.get_values();
                    result.add_record(arg);
                }
            }
        }
    }

    class group_request: request_by_value {

        public override table execute(object value) {
            List<string> columns = table_student.instanse().get_columns();
            result = new table_custom(Convert.ToString(value), columns);

            int index;
            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код группы") break;

            find(table_student.instanse(), index, Convert.ToString(value));

            return result;
        }
    }

    class faculty_request : request_by_value {
        public override table execute(object value) {

            // the first step
            List<string> columns = table_group.instanse().get_columns();
            result = new table_custom(Convert.ToString(value), columns);

            int index;
            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код факультета") break;

            find(table_group.instanse(), index, Convert.ToString(value));
            table group = result;

            // the second step
            columns = table_student.instanse().get_columns();
            result = new table_custom(Convert.ToString(value), columns);

            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код группы") break;


            foreach(table_record record in group) {
                    find(table_student.instanse(), index, record[1].get_value());
            }

            return result;
        }
    }

    class specialty_request : request_by_value {
        public override table execute(object value) {

            // the first step
            List<string> columns = table_group.instanse().get_columns();
            result = new table_custom(Convert.ToString(value), columns);

            int index;
            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код специальности") break;

            find(table_group.instanse(), index, Convert.ToString(value));
            table group = result;

            // the second step
            columns = table_student.instanse().get_columns();
            result = new table_custom(Convert.ToString(value), columns);

            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код группы") break;


            foreach (table_record record in group) {
                find(table_student.instanse(), index, record[1].get_value());
            }

            return result;
        }
    }

    class rating_request : request_by_value {
        public override table execute(object value) {
            List<string> columns = table_academic_progress.instanse().get_columns();
            result = new table_custom("Запрос успеваемости", columns);

            find(table_academic_progress.instanse(), 0, Convert.ToString(value));

            return result;
        }
    }

    // ---------------------------
    abstract class request_by_rating : request {
        protected table result;

        public abstract table execute(object arg);
        protected abstract bool add_check(bool _2, bool _3, bool _4, bool _5);

        protected void find() {
            table_student.instanse().Reset();

            foreach (table_record student_record in table_student.instanse()) {
                bool _2 = false;
                bool _3 = false;
                bool _4 = false;
                bool _5 = false;

                foreach (table_record record in table_academic_progress.instanse()) {
                    if (student_record[0].get_value() == record[0].get_absolute_value()) {
                        if (record[2].get_value() == "зачет" && record[3].get_value() == "не зачет") { _2 = true; break; }
                        else if (record[2].get_value() == "экзамен" && record[3].get_value() == "2") { _2 = true; break; }
                        else if (record[2].get_value() == "экзамен" && record[3].get_value() == "3") _3 = true;
                        else if (record[2].get_value() == "экзамен" && record[3].get_value() == "4") _4 = true;
                        else if (record[2].get_value() == "экзамен" && record[3].get_value() == "5") _5 = true;
                    }
                }
                table_academic_progress.instanse().Reset();

                if (add_check(_2, _3, _4, _5)) {
                    string[] arg = student_record.get_values();
                    result.add_record(arg);
                }
            }
            table_student.instanse().Reset();
        }
    }

    class _2_request : request_by_rating {
        public override table execute(object value = null) {
            List<string> columns = table_student.instanse().get_columns();
            result = new table_custom("Не сдавшие", columns);

            find();

            return result;
        }

        protected override bool add_check(bool _2, bool _3, bool _4, bool _5) {
            if (_2) return true;
            return false;
        }
    }

    class _3_request : request_by_rating {

        public override table execute(object value = null) {
            List<string> columns = table_student.instanse().get_columns();
            result = new table_custom("Сдавшие на тройки", columns);

            find();

            return result;
        }

        protected override bool add_check(bool _2, bool _3, bool _4, bool _5) {
            if (_2) return false;
            else if (_3) return true;

            return false;
        }
    }

    class _4_request : request_by_rating {
        public override table execute(object value = null) {
            List<string> columns = table_student.instanse().get_columns();
            result = new table_custom("Сдавшие на одни четверки", columns);

            find();

            return result;
        }

        protected override bool add_check(bool _2, bool _3, bool _4, bool _5) {
            if (_2 || _3 || _5) return false;
            else if (_4) return true;
            return false;
        }
    }

    class _4_and_5_request : request_by_rating {
        public override table execute(object value = null) {
            List<string> columns = table_student.instanse().get_columns();
            result = new table_custom("Сдавшие на четверки и пятерки", columns);

            find();

            return result;
        }

        protected override bool add_check(bool _2, bool _3, bool _4, bool _5) {
            if (_2 || _3) return false;
            else if (_5 && _4) return true;
            return false;
        }
    }

    class _5_request : request_by_rating {
        public override table execute(object value = null) {
            List<string> columns = table_student.instanse().get_columns();
            result = new table_custom("Сдавшие на одни пятерки", columns);

            find();

            return result;
        }

        protected override bool add_check(bool _2, bool _3, bool _4, bool _5) {
            if (_2 || _3 || _4) return false;
            else if (_5) return true;
            return false;
        }
    }


    abstract class report: request {
        protected table result;
        public abstract table execute(object arg);
    }

    class group_report: report {

        public override table execute(object arg) {
            var columns = new List<string>();
            columns.Add("Группа");
            columns.Add("Фамилия");
            columns.Add("Имя");
            columns.Add("Отчество");

            result = new table_custom("Отчет по группам", columns);

            find();

            return result;
        }

        private void find() {

            foreach (table_record record in table_group.instanse()) {
                bool flag = true;
                foreach (table_record student_record in table_student.instanse()) {
                    if (record[0].get_absolute_value() == student_record[4].get_absolute_value()) {
                        string[] arg = new string[4];
                        if (flag) arg[0] = record[1].get_absolute_value();
                        else arg[0] = "";

                        for (int i = 1; i <= 3; ++i)
                            arg[i] = student_record[i].get_absolute_value();

                        result.add_record(arg);
                        flag = false;
                    }
                }
            }
        }
    }

    class rating_report : report {

        public override table execute(object arg) {
            var columns = new List<string>();
            columns.Add("Фамилия");
            columns.Add("Имя");
            columns.Add("Отчество");
            columns.Add("Группа");
            columns.Add("Название предмета");
            columns.Add("Оценка");

            result = new table_custom("Отчет по студентам", columns);

            find();

            return result;
        }

        private void find() {

            foreach (table_record record in table_student.instanse()) {
                bool flag = true;
                foreach (table_record rating_record in table_academic_progress.instanse()) {
                    if (record[0].get_absolute_value() == rating_record[0].get_absolute_value()) {
                        string[] arg = new string[6];
                        if (flag) {
                            arg[0] = record[1].get_value();
                            arg[1] = record[2].get_value();
                            arg[2] = record[3].get_value();
                            arg[3] = record[4].get_value();
                        } 
                        else {
                            arg[0] = "";
                            arg[1] = "";
                            arg[2] = "";
                            arg[3] = "";
                        }

                        arg[4] = rating_record[1].get_value();
                        arg[5] = rating_record[3].get_value();

                        result.add_record(arg);
                        flag = false;
                    }
                }
            }
        }
    }


}
