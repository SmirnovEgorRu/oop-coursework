using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using coursework;

namespace UnitTest {
    [TestClass]
    public class UnitTest {
        file_contr file_mngr;

        [TestMethod]
        public void add_record_test() {
            file_mngr = new file_contr();
            file_mngr.add_from_file();
            var student = table_student.instanse();

            const int n = 10;
            string[] arg = new string[n] { "0", "Фамилия", "Имя", "Отчество", "1", "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg);

            var record = student[student.size() - 1];
            string[] out_arg = record.get_values();

            for (int i = 1; i < n; ++i) {
                if (arg[i] == "1") continue;    // record.get_values(); возврашает название группы, а не ее код
                Assert.AreEqual(arg[i], out_arg[i]);
            }
        }

        [TestMethod]
        public void delete_record_test() {
            file_mngr = new file_contr();
            file_mngr.add_from_file();

            var student = table_student.instanse();
            var size = student.size();

            var record = student[student.size() - 1];
            student.delete_record(record);
            var new_size = student.size();

            Assert.AreEqual(new_size + 1, size);
        }

        [TestMethod]
        public void factory_test() {
            file_mngr = new file_contr();
            file_mngr.add_from_file();

            var factory = new specialty_factory();
            var specialty = table_specialty.instanse();

            const int n = 3;
            string[] arg = new string[n] { "Код специальности", "Наименование специальности", "Стоимость обучения" };

            var record = factory.create_fields(arg);
            string[] out_arg = record.get_values();

            for (int i = 0; i < n; ++i)
                Assert.AreEqual(arg[i], out_arg[i]);
        }

        [TestMethod]
        public void clear_record_test() {
            file_mngr = new file_contr();
            file_mngr.add_from_file();

            var student = table_student.instanse();

            student.clear();
            var new_size = student.size();

            Assert.AreEqual(new_size , 0);
        }

        [TestMethod]
        public void request_group_record_test() {
            var student = table_student.instanse();
            var group = table_group.instanse();

            student.clear();
            group.clear();

            const string code_group = "0";
            const string name_code = "группа";

            string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_group = new string[] { code_group, name_code, "Курс", "Код специальности", "Код факультета" };
            group.add_record(arg_group);

            var contr = new request_contr();

            table new_table = contr.find_by_value(name_code, request_contr.by_value.group);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_faculty_record_test() {
            var student = table_student.instanse();
            var group = table_group.instanse();
            var faculty = table_faculty.instanse();

            student.clear();
            group.clear();
            faculty.clear();

            const string code_group = "0";
            const string name_group = "группа";
            const string name_faculty = "факультет";
            const string code_faculty = "1";

            string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_group = new string[] { code_group, name_group, "Курс", "Код специальности", code_faculty };
            group.add_record(arg_group);

            string[] arg_faculty = new string[] { code_faculty, name_faculty };
            faculty.add_record(arg_faculty);


            var contr = new request_contr();

            table new_table = contr.find_by_value(name_faculty, request_contr.by_value.faculty);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_specialty_record_test() {
            var student = table_student.instanse();
            var group = table_group.instanse();
            var specialty = table_specialty.instanse();

            student.clear();
            group.clear();
            specialty.clear();

            const string code_group = "0";
            const string name_group = "группа";
            const string name_specialty = "специальность";
            const string code_specialty = "1";

            string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_group = new string[] { code_group, name_group, "Курс", code_specialty, "код факультета"};
            group.add_record(arg_group);

            string[] arg_faculty = new string[] { code_specialty, name_specialty, "стоимость обучения" };
            specialty.add_record(arg_faculty);


            var contr = new request_contr();

            table new_table = contr.find_by_value(name_specialty, request_contr.by_value.specialty);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_rating_record_test() {
            var student = table_student.instanse();
            var rating = table_academic_progress.instanse();

            student.clear();
            rating.clear();

            const string code_group = "0";
            const string code_student = "0";

            string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_rating = new string[] { code_student, "Код предмета",  "Форма контроля", "Оценка", "Дата", "Код преподавателя" };
            rating.add_record(arg_rating);

            var contr = new request_contr();

            table new_table = contr.find_by_value(code_student, request_contr.by_value.rating);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_by_rating_2_test() {
            var student = table_student.instanse();
            var rating = table_academic_progress.instanse();

            student.clear();
            rating.clear();

            const string code_group = "0";
            const string code_student = "0";
            const string rate = "2";

            string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
            rating.add_record(arg_rating);

            var contr = new request_contr();

            table new_table = contr.find_by_rating(request_contr.by_rating._2);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_by_rating_3_test() {
            var student = table_student.instanse();
            var rating = table_academic_progress.instanse();

            student.clear();
            rating.clear();

            const string code_group = "0";
            const string code_student = "0";
            const string rate = "3";

            string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
            rating.add_record(arg_rating);

            var contr = new request_contr();

            table new_table = contr.find_by_rating(request_contr.by_rating._3);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_by_rating_4_test() {
            var student = table_student.instanse();
            var rating = table_academic_progress.instanse();

            student.clear();
            rating.clear();

            const string code_group = "0";
            const string code_student = "0";
            const string rate = "4";

            string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
            rating.add_record(arg_rating);

            var contr = new request_contr();

            table new_table = contr.find_by_rating(request_contr.by_rating._4);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_by_rating_5_test() {
            var student = table_student.instanse();
            var rating = table_academic_progress.instanse();

            student.clear();
            rating.clear();

            const string code_group = "0";
            const string code_student = "0";
            const string rate = "5";

            string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
            rating.add_record(arg_rating);

            var contr = new request_contr();

            table new_table = contr.find_by_rating(request_contr.by_rating._5);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }

        [TestMethod]
        public void request_by_rating_4_and_5_test() {
            var student = table_student.instanse();
            var rating = table_academic_progress.instanse();

            student.clear();
            rating.clear();

            const string code_group = "0";
            const string code_student = "0";
            const string rate_1 = "5";
            const string rate_2 = "4";

            string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate_2, "Дата", "Код преподавателя" };
            rating.add_record(arg_rating);

            arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate_1, "Дата", "Код преподавателя" };
            rating.add_record(arg_rating);

            var contr = new request_contr();

            table new_table = contr.find_by_rating(request_contr.by_rating._4_and_5);
            int new_size = new_table.size();

            Assert.AreEqual(new_size, 1);
        }


        [TestMethod]
        public void report_group_test() {
            var student = table_student.instanse();
            var group = table_group.instanse();

            student.clear();
            group.clear();

            const string code_group = "0";
            const string name_code = "группа";

            string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };

            const int n = 10;
            for (int i = 0; i < n; i++) {
                student.add_record(arg_student);
            }

            string[] arg_group = new string[] { code_group, name_code, "Курс", "Код специальности", "Код факультета" };
            group.add_record(arg_group);

            var contr = new report_contr();

            table new_table = contr.report_by_group();
            int new_size = new_table.size();

            Assert.AreEqual(new_size, n);
        }

        [TestMethod]
        public void report_by_rating_record_test() {
            var student = table_student.instanse();
            var rating = table_academic_progress.instanse();

            student.clear();
            rating.clear();

            const string code_group = "0";
            const string code_student = "0";

            string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
            student.add_record(arg_student);

            string[] arg_rating = new string[] { code_student, "Код предмета", "Форма контроля", "Оценка", "Дата", "Код преподавателя" };

            const int n = 10;
            for (int i = 0; i < n; i++)
                rating.add_record(arg_rating);

            var contr = new report_contr();

            table new_table = contr.report_by_rating();
            int new_size = new_table.size();

            Assert.AreEqual(new_size, n);
        }


        [TestMethod]
        public void file_read_test() {
            var student = table_student.instanse();

            student.clear();
            int size = student.size();

            file_mngr = new file_contr();
            file_mngr.add_from_file();

            int new_size = student.size();

            Assert.AreNotEqual(size, new_size);
        }
    }
}



[TestClass]
public class UnitTest {
    file_contr file_mngr;

    [TestMethod]
    public void add_record_test() {
        file_mngr = new file_contr();
        file_mngr.add_from_file();
        var student = table_student.instanse();

        const int n = 10;
        string[] arg = new string[n] { "0", "Фамилия", "Имя", "Отчество", "1", "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg);

        var record = student[student.size() - 1];
        string[] out_arg = record.get_values();

        for (int i = 1; i < n; ++i) {
            if (arg[i] == "1") continue;    // record.get_values(); возврашает название группы, а не ее код
            Assert.AreEqual(arg[i], out_arg[i]);
        }
    }

    [TestMethod]
    public void delete_record_test() {
        file_mngr = new file_contr();
        file_mngr.add_from_file();

        var student = table_student.instanse();
        var size = student.size();

        var record = student[student.size() - 1];
        student.delete_record(record);
        var new_size = student.size();

        Assert.AreEqual(new_size + 1, size);
    }

    [TestMethod]
    public void factory_test() {
        file_mngr = new file_contr();
        file_mngr.add_from_file();

        var factory = new specialty_factory();
        var specialty = table_specialty.instanse();

        const int n = 3;
        string[] arg = new string[n] { "Код специальности", "Наименование специальности", "Стоимость обучения" };

        var record = factory.create_fields(arg);
        string[] out_arg = record.get_values();

        for (int i = 0; i < n; ++i)
            Assert.AreEqual(arg[i], out_arg[i]);
    }

    [TestMethod]
    public void clear_record_test() {
        file_mngr = new file_contr();
        file_mngr.add_from_file();

        var student = table_student.instanse();

        student.clear();
        var new_size = student.size();

        Assert.AreEqual(new_size, 0);
    }

    [TestMethod]
    public void request_group_record_test() {
        var student = table_student.instanse();
        var group = table_group.instanse();

        student.clear();
        group.clear();

        const string code_group = "0";
        const string name_code = "группа";

        string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_group = new string[] { code_group, name_code, "Курс", "Код специальности", "Код факультета" };
        group.add_record(arg_group);

        var contr = new request_contr();

        table new_table = contr.find_by_value(name_code, request_contr.by_value.group);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_faculty_record_test() {
        var student = table_student.instanse();
        var group = table_group.instanse();
        var faculty = table_faculty.instanse();

        student.clear();
        group.clear();
        faculty.clear();

        const string code_group = "0";
        const string name_group = "группа";
        const string name_faculty = "факультет";
        const string code_faculty = "1";

        string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_group = new string[] { code_group, name_group, "Курс", "Код специальности", code_faculty };
        group.add_record(arg_group);

        string[] arg_faculty = new string[] { code_faculty, name_faculty };
        faculty.add_record(arg_faculty);


        var contr = new request_contr();

        table new_table = contr.find_by_value(name_faculty, request_contr.by_value.faculty);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_specialty_record_test() {
        var student = table_student.instanse();
        var group = table_group.instanse();
        var specialty = table_specialty.instanse();

        student.clear();
        group.clear();
        specialty.clear();

        const string code_group = "0";
        const string name_group = "группа";
        const string name_specialty = "специальность";
        const string code_specialty = "1";

        string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_group = new string[] { code_group, name_group, "Курс", code_specialty, "код факультета" };
        group.add_record(arg_group);

        string[] arg_faculty = new string[] { code_specialty, name_specialty, "стоимость обучения" };
        specialty.add_record(arg_faculty);


        var contr = new request_contr();

        table new_table = contr.find_by_value(name_specialty, request_contr.by_value.specialty);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_rating_record_test() {
        var student = table_student.instanse();
        var rating = table_academic_progress.instanse();

        student.clear();
        rating.clear();

        const string code_group = "0";
        const string code_student = "0";

        string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_rating = new string[] { code_student, "Код предмета", "Форма контроля", "Оценка", "Дата", "Код преподавателя" };
        rating.add_record(arg_rating);

        var contr = new request_contr();

        table new_table = contr.find_by_value(code_student, request_contr.by_value.rating);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_by_rating_2_test() {
        var student = table_student.instanse();
        var rating = table_academic_progress.instanse();

        student.clear();
        rating.clear();

        const string code_group = "0";
        const string code_student = "0";
        const string rate = "2";

        string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
        rating.add_record(arg_rating);

        var contr = new request_contr();

        table new_table = contr.find_by_rating(request_contr.by_rating._2);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_by_rating_3_test() {
        var student = table_student.instanse();
        var rating = table_academic_progress.instanse();

        student.clear();
        rating.clear();

        const string code_group = "0";
        const string code_student = "0";
        const string rate = "3";

        string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
        rating.add_record(arg_rating);

        var contr = new request_contr();

        table new_table = contr.find_by_rating(request_contr.by_rating._3);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_by_rating_4_test() {
        var student = table_student.instanse();
        var rating = table_academic_progress.instanse();

        student.clear();
        rating.clear();

        const string code_group = "0";
        const string code_student = "0";
        const string rate = "4";

        string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
        rating.add_record(arg_rating);

        var contr = new request_contr();

        table new_table = contr.find_by_rating(request_contr.by_rating._4);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_by_rating_5_test() {
        var student = table_student.instanse();
        var rating = table_academic_progress.instanse();

        student.clear();
        rating.clear();

        const string code_group = "0";
        const string code_student = "0";
        const string rate = "5";

        string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate, "Дата", "Код преподавателя" };
        rating.add_record(arg_rating);

        var contr = new request_contr();

        table new_table = contr.find_by_rating(request_contr.by_rating._5);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }

    [TestMethod]
    public void request_by_rating_4_and_5_test() {
        var student = table_student.instanse();
        var rating = table_academic_progress.instanse();

        student.clear();
        rating.clear();

        const string code_group = "0";
        const string code_student = "0";
        const string rate_1 = "5";
        const string rate_2 = "4";

        string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate_2, "Дата", "Код преподавателя" };
        rating.add_record(arg_rating);

        arg_rating = new string[] { code_student, "Код предмета", "экзамен", rate_1, "Дата", "Код преподавателя" };
        rating.add_record(arg_rating);

        var contr = new request_contr();

        table new_table = contr.find_by_rating(request_contr.by_rating._4_and_5);
        int new_size = new_table.size();

        Assert.AreEqual(new_size, 1);
    }


    [TestMethod]
    public void report_group_test() {
        var student = table_student.instanse();
        var group = table_group.instanse();

        student.clear();
        group.clear();

        const string code_group = "0";
        const string name_code = "группа";

        string[] arg_student = new string[] { "0", "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };

        const int n = 10;
        for (int i = 0; i < n; i++) {
            student.add_record(arg_student);
        }

        string[] arg_group = new string[] { code_group, name_code, "Курс", "Код специальности", "Код факультета" };
        group.add_record(arg_group);

        var contr = new report_contr();

        table new_table = contr.report_by_group();
        int new_size = new_table.size();

        Assert.AreEqual(new_size, n);
    }

    [TestMethod]
    public void report_by_rating_record_test() {
        var student = table_student.instanse();
        var rating = table_academic_progress.instanse();

        student.clear();
        rating.clear();

        const string code_group = "0";
        const string code_student = "0";

        string[] arg_student = new string[] { code_student, "Фамилия", "Имя", "Отчество", code_group, "Форма обучения", "Дата рождения", "Адрес", "Телефон", "E-mail" };
        student.add_record(arg_student);

        string[] arg_rating = new string[] { code_student, "Код предмета", "Форма контроля", "Оценка", "Дата", "Код преподавателя" };

        const int n = 10;
        for (int i = 0; i < n; i++)
            rating.add_record(arg_rating);

        var contr = new report_contr();

        table new_table = contr.report_by_rating();
        int new_size = new_table.size();

        Assert.AreEqual(new_size, n);
    }


    [TestMethod]
    public void file_read_test() {
        var student = table_student.instanse();

        student.clear();
        int size = student.size();

        file_mngr = new file_contr();
        file_mngr.add_from_file();

        int new_size = student.size();

        Assert.AreNotEqual(size, new_size);
    }
}