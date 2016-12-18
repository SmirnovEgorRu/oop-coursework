using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {
    interface field_factory {
        table_record create_fields(string[] arg);
    }

    class student_factory: field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();
            fields.Add(new int_table_field ("Код студента"));
            fields.Add(new str_table_field ("Фамилия"));
            fields.Add(new str_table_field ("Имя"));
            fields.Add(new str_table_field ("Отчество"));
            fields.Add(new key_table_field ("Код группы", table_group.instanse(), 0));
            fields.Add(new str_table_field ("Форма обучения"));
            fields.Add(new date_table_field("Дата рождения"));
            fields.Add(new str_table_field ("Адрес"));
            fields.Add(new str_table_field ("Телефон"));
            fields.Add(new str_table_field ("E-mail"));

            for (int i=0, n = arg.Count<string>(); i< n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }

    class subject_factory : field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();
            fields.Add(new int_table_field("Код предмета"));
            fields.Add(new str_table_field("Наименования предмета"));
            fields.Add(new int_table_field("Семестр"));
            fields.Add(new int_table_field("Количество часов"));

            for (int i = 0, n = arg.Count<string>(); i < n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }


    class academic_progress_factory : field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();
            fields.Add(new key_table_field("Код студента", table_student.instanse(), 0));
            fields.Add(new key_table_field("Код предмета", table_subject.instanse(), 0));
            fields.Add(new str_table_field("Форма контроля"));
            fields.Add(new str_table_field("Оценка"));
            fields.Add(new date_table_field("Дата"));
            fields.Add(new key_table_field("Код преподавателя", table_teacher.instanse(), 0));

            for (int i = 0, n = arg.Count<string>(); i < n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }

    class teacher_factory : field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();
            fields.Add(new int_table_field ("Код преподавателя"));
            fields.Add(new str_table_field ("Фамилия"));
            fields.Add(new str_table_field ("Имя"));
            fields.Add(new str_table_field ("Отчество"));
            fields.Add(new date_table_field("Дата рождения"));
            fields.Add(new str_table_field ("Адрес"));
            fields.Add(new str_table_field ("Телефон"));
            fields.Add(new str_table_field ("E-mail"));

            for (int i = 0, n = arg.Count<string>(); i < n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }

    class group_factory : field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();
            fields.Add(new int_table_field("Код группы"));
            fields.Add(new str_table_field("Наименование группы"));
            fields.Add(new int_table_field("Курс"));
            fields.Add(new key_table_field("Код специальности", table_specialty.instanse(), 0));
            fields.Add(new key_table_field("Код факультета", table_faculty.instanse(), 0));

            for (int i = 0, n = arg.Count<string>(); i < n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }

    class deanery_factory : field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();
            fields.Add(new int_table_field("Код факультета"));
            fields.Add(new str_table_field("Адрес"));
            fields.Add(new str_table_field("Телефон"));
            fields.Add(new str_table_field("E-mail"));
            fields.Add(new str_table_field("ФИО Декана"));

            for (int i = 0, n = arg.Count<string>(); i < n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }

    class specialty_factory : field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();

            fields.Add(new int_table_field("Код специальности"));
            fields.Add(new str_table_field("Наименование специальности"));
            fields.Add(new int_table_field("Стоимость обучения"));

            for (int i = 0, n = arg.Count<string>(); i < n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }

    class faculty_factory : field_factory {
        public table_record create_fields(string[] arg) {

            List<table_field> fields = new List<table_field>();

            fields.Add(new key_table_field("Код факультета", table_faculty.instanse(), 0));
            fields.Add(new str_table_field("Наименование факультета"));

            for (int i = 0, n = arg.Count<string>(); i < n; ++i)
                fields[i].set_value(arg[i]);

            return new table_record(fields);
        }
    }
}
