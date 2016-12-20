using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {
    abstract class request {
        protected table result;

        abstract public table execute(string value);

        virtual protected void find(table search_table, int index, string value ) {
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

    class group_request: request {

        public override table execute(string value) {
            List<string> columns = table_student.instanse().get_columns();
            result = new table_custom(value, columns);

            int index;
            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код группы") break;

            find(table_student.instanse(), index, value);

            return result;
        }
    }

    class faculty_request : request {
        public override table execute(string value) {

            // the first step
            List<string> columns = table_group.instanse().get_columns();
            result = new table_custom(value, columns);

            int index;
            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код факультета") break;

            find(table_group.instanse(), index, value);
            table group = result;

            // the second step
            columns = table_student.instanse().get_columns();
            result = new table_custom(value, columns);

            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код группы") break;


            foreach(table_record record in group) {
                    find(table_student.instanse(), index, record[1].get_value());
            }

            return result;
        }
    }

    class specialty_request : request {
        public override table execute(string value) {

            // the first step
            List<string> columns = table_group.instanse().get_columns();
            result = new table_custom(value, columns);

            int index;
            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код специальности") break;

            find(table_group.instanse(), index, value);
            table group = result;

            // the second step
            columns = table_student.instanse().get_columns();
            result = new table_custom(value, columns);

            for (index = 0; index < columns.Count; ++index)
                if (columns[index] == "Код группы") break;


            foreach (table_record record in group) {
                find(table_student.instanse(), index, record[1].get_value());
            }

            return result;
        }
    }
}
