using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {

    public class request_contr {
        request cur_request;

        public table find_by_group(string value) {
            cur_request = new group_request();
            return cur_request.execute(value);
        }

        public table find_by_specialty(string value) {
            cur_request = new specialty_request();
            return cur_request.execute(value);
        }

        public table find_by_faculty(string value) {
            cur_request = new  faculty_request();
            return cur_request.execute(value);
        }

        public table find_by_rating(string value) {
            cur_request = new rating_request();
            return cur_request.execute(value);
        }

        public table find_by_rating_2() {
            cur_request = new _2_request();
            return cur_request.execute();
        }

        public table find_by_rating_3() {
            cur_request = new _3_request();
            return cur_request.execute();
        }

        public table find_by_rating_4() {
            cur_request = new _4_request();
            return cur_request.execute();
        }

        public table find_by_rating_4_and_5() {
            cur_request = new _4_and_5_request();
            return cur_request.execute();
        }

        public table find_by_rating_5() {
            cur_request = new _5_request();
            return cur_request.execute();
        }
    }
}
