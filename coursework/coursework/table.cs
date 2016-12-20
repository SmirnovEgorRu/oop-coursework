using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace coursework {
    abstract class table: IEnumerable, IEnumerator {
        protected List<table_record> records;
        protected field_factory factory;
        protected string name_table;
        protected List<string> columns_name;

        // Enumerator
        protected int index;
        public IEnumerator GetEnumerator() {
            return this;
        }
        public bool MoveNext() {
            if (index == records.Count - 1) {
                Reset();
                return false;
            }

            index++;
            return true;
        }
        public void Reset() {
            index = -1;
        }
        public object Current {
            get {
                return records[index];
            }
        }
        public table_record this[int i] {
            get {
                return records[i];
            }
        }

        public int size() {
            return records.Count;
        }

        public void add_record(string[] arg) {
            records.Add(factory.create_fields(arg));
        }

        public void delete_record(table_record record) {
            records.Remove(record);
        }

        public void clear() {
            records.Clear();
        }

        public List<string> get_columns() {
            List<string> clone = new List<string>();

            foreach (string str in columns_name)
                clone.Add(str);

            return clone;
        }

        public string get_name() {
            return name_table;
        }

        protected table() {
            records = new List<table_record>();
            columns_name = new List<string>();
            index = -1;
        }


        public string find(string search_value, int search_index, int return_index) {
            foreach (table_record record in records) {
                if (record[search_index].get_value() == search_value) {
                    return record[return_index].get_absolute_value();
                }
            }

            return "%undef%";
        }

    }

    class table_student: table {
        static table_student _instance;


        static public table_student instanse() {
            if (_instance == null)
                _instance = new table_student();

            return _instance;
        }

        table_student() {
            factory = new student_factory();
            name_table = "Студент";

            columns_name.Add("Код студента");
            columns_name.Add("Фамилия");
            columns_name.Add("Имя");
            columns_name.Add("Отчество");
            columns_name.Add("Код группы");
            columns_name.Add("Форма обучения");
            columns_name.Add("Дата рождения");
            columns_name.Add("Адрес");
            columns_name.Add("Телефон");
            columns_name.Add("E-mail");
        }
    }

    class table_subject : table {
        static table_subject _instance;

        static public table_subject instanse() {
            if (_instance == null)
                _instance = new table_subject();

            return _instance;
        }

        table_subject() {
            factory = new subject_factory();
            name_table = "Предмет";

            columns_name.Add("Код предмета");
            columns_name.Add("Наименования предмета");
            columns_name.Add("Семестр");
            columns_name.Add("Количество часов");
        }
    }

    class table_academic_progress: table {
        static table_academic_progress _instance;

        static public table_academic_progress instanse() {
            if (_instance == null)
                _instance = new table_academic_progress();

            return _instance;
        }

        table_academic_progress() {
            factory = new academic_progress_factory();
            name_table = "Успеваемость";

            columns_name.Add("Код студента");
            columns_name.Add("Код предмета");
            columns_name.Add("Форма контроля");
            columns_name.Add("Оценка");
            columns_name.Add("Дата");
            columns_name.Add("Код преподавателя");
        }
    }

    class table_teacher : table {
        static table_teacher _instance;

        static public table_teacher instanse() {
            if (_instance == null)
                _instance = new table_teacher();

            return _instance;
        }

        table_teacher() {
            factory = new teacher_factory();
            name_table = "Преподаватель";

            columns_name.Add("Код преподавателя");
            columns_name.Add("Фамилия");
            columns_name.Add("Имя");
            columns_name.Add("Отчество");
            columns_name.Add("Дата рождения");
            columns_name.Add("Адрес");
            columns_name.Add("Телефон");
            columns_name.Add("E-mail");
        }
    }

    class table_group : table {
        static table_group _instance;

        static public table_group instanse() {
            if (_instance == null)
                _instance = new table_group();

            return _instance;
        }

        table_group() {
            factory = new group_factory();
            name_table = "Группа";

            columns_name.Add("Код группы");
            columns_name.Add("Наименование группы");
            columns_name.Add("Курс");
            columns_name.Add("Код специальности");
            columns_name.Add("Код факультета");
        }
    }

    class table_deanery : table {
        static table_deanery _instance;

        static public table_deanery instanse() {
            if (_instance == null)
                _instance = new table_deanery();

            return _instance;
        }

        table_deanery() {
            factory = new deanery_factory();
            name_table = "Деканат";

            columns_name.Add("Код факультета");
            columns_name.Add("Адрес");
            columns_name.Add("Телефон");
            columns_name.Add("E-mail");
            columns_name.Add("ФИО Декана");
        }
    }
   
    class table_specialty : table {
        static table_specialty _instance;

        static public table_specialty instanse() {
            if (_instance == null)
                _instance = new table_specialty();

            return _instance;
        }

        table_specialty() {
            factory = new specialty_factory();
            name_table = "Специальность";

            columns_name.Add("Код специальности");
            columns_name.Add("Наименование специальности");
            columns_name.Add("Стоимость обучения");
        }
    }

    class table_faculty : table {
        static table_faculty _instance;

        static public table_faculty instanse() {
            if (_instance == null)
                _instance = new table_faculty();

            return _instance;
        }

        table_faculty() {
            factory = new faculty_factory();
            name_table = "Факультет";

            columns_name.Add("Код факультета");
            columns_name.Add("Наименование факультета");
        }
    }

    class table_custom : table {

        public table_custom(string name, List<string> columns) {
            factory = new custom_factory();
            name_table = name;

            for(int i=0, n = columns.Count; i < n; ++i)
                columns_name.Add(columns[i]);
        }
    }

}


