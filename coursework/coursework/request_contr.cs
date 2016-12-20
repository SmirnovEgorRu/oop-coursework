using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {

    class request_contr {
        request cur_request;

        public table find(string value, string name) {
            switch (name) {
                case "Группа": cur_request = new group_request(); break;
                case "Специальность": cur_request = new specialty_request(); break;
                case "Факультет": cur_request = new faculty_request(); break;
                default: break;
            }

            return cur_request.execute(value);
        }

    }

}
