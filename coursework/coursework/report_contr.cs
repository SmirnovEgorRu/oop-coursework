using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {
    public class report_contr {
        request cur_request;

        public table report_by_group() {
            cur_request = new group_report();
            return cur_request.execute();
        }

        public table report_by_rating() {
            cur_request = new rating_report();
            return cur_request.execute();
        }
    }
}
