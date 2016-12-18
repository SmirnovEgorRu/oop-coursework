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

        private void add_record(string[] arg) {
            records.Add(factory.create_fields(arg));
        }

        void delete_record(table_record record) {
            records.Remove(record);
        }

        protected table() {
            records = new List<table_record>();
        }
    }

    class table_student: table {
        table_student() {
            factory = new student_factory();
            name_table = "Студент";
        }
    }

    class table_subject : table {
        table_subject() {
            factory = new subject_factory();
            name_table = "Предмет";
      }
    }

    class table_academic_progress: table {
        table_academic_progress() {
            factory = new academic_progress_factory();
            name_table = "Успеваемость";
        }
    }

    class table_teacher : table {
        table_teacher() {
            factory = new teacher_factory();
            name_table = "Преподаватель";
        }
}

    class table_group : table {
        table_group() {
            factory = new group_factory();
            name_table = "Группа";
        }
}

    class table_deanery : table {
        table_deanery() {
        factory = new deanery_factory();
        name_table = "Деканат";
    }
}
   
    class table_specialty : table {
        table_specialty() {
        factory = new specialty_factory();
        name_table = "Специальность";
    }
}

    class table_faculty : table {
        table_faculty() {
        factory = new faculty_factory();
        name_table = "Факультет";
    }
}

}
