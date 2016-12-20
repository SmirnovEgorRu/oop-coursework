using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace coursework {
    class table_record: IEnumerable, IEnumerator {
        private List<table_field> fields;
        private int index;

        public IEnumerator GetEnumerator() {
            return this;
        }

        public bool MoveNext() {
            if (index == fields.Count - 1) {
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
                return fields[index];
            }
        }

        public table_field this[int i] {
            get {
                return fields[i];
            }
        }

        public int size() {
            return fields.Count;
        }

        public string[] get_values() {
            string[] arg = new string[size()];

            for (int i = 0; i < size(); ++i)
                arg[i] = fields[i].get_value();

            return arg;
        }

        public table_record(List<table_field> new_fields) {
            fields = new_fields;
            index = -1;
        }
    }
}
