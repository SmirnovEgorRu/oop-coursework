using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {

    abstract class table_field {
        public string name { get; protected set; }
        public string type { get; protected set; }
        protected string value;

        virtual public string get_value() { return value; }
        virtual public string get_absolute_value() { return value; }
        virtual public void set_value(string new_value) { value = new_value; }
    }

    class str_table_field: table_field {
        public str_table_field(string new_name) { type = "str"; name = new_name; }
    }

    class date_table_field : table_field {
        public date_table_field(string new_name) { type = "date"; name = new_name; }
    }

    class int_table_field : table_field {
        public int_table_field(string new_name) { type = "int"; name = new_name; }
    }

    class key_table_field : table_field {
        private table related_table;
        private table_record primary_record;
        private int index;

        override public string get_value() {
            related_table.Reset();
            foreach (table_record record in related_table) {
                int key = Convert.ToInt32(record[0].get_absolute_value());
                if (Convert.ToInt32(value) == key) {
                    primary_record = record;
                    break;
                }
            }
            related_table.Reset();

            if (primary_record != null) return primary_record[index].get_value();
            else return "%undef%";
        }

        override public void set_value(string new_value) {
            value = new_value;

            related_table.Reset();
            foreach (table_record record in related_table) {
                if (value == record[index].get_value()) {
                    primary_record = record;
                    break;
                }
            }
            related_table.Reset();
        }

        public key_table_field(string new_name, table new_table, int new_index) {
            name = new_name;
            related_table = new_table;
            index = new_index;
            type = "str";
        }
    }

}
