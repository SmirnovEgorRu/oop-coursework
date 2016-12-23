using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework {

    public class request_contr {
        request cur_request;

        public enum by_rating { _2, _3, _4, _4_and_5, _5 }
        public enum by_value { group, faculty, specialty, rating }

        public table find_by_value(string value, by_value type) {
            switch (type) {
                case by_value.rating:    return find_by_rating_for_stuent(value);
                case by_value.group:     return find_by_group(value);
                case by_value.specialty: return find_by_specialty(value);
                case by_value.faculty:   return find_by_faculty(value);
            }
            return null;
        }

        public table find_by_rating(by_rating type) {
            switch (type) {
                case by_rating._2:       return find_by_rating_2();
                case by_rating._3:       return find_by_rating_3();
                case by_rating._4:       return find_by_rating_4();
                case by_rating._4_and_5: return find_by_rating_4_and_5();
                case by_rating._5:       return find_by_rating_5();
            }
            return null;
        }

        private table find_by_group(string value) {
            cur_request = new group_request();
            return cur_request.execute(value);
        }

        private table find_by_specialty(string value) {
            cur_request = new specialty_request();
            return cur_request.execute(value);
        }

        private table find_by_faculty(string value) {
            cur_request = new  faculty_request();
            return cur_request.execute(value);
        }

        private table find_by_rating_for_stuent(string value) {
            cur_request = new rating_request();
            return cur_request.execute(value);
        }

        private table find_by_rating_2() {
            cur_request = new _2_request();
            return cur_request.execute();
        }

        private table find_by_rating_3() {
            cur_request = new _3_request();
            return cur_request.execute();
        }

        private table find_by_rating_4() {
            cur_request = new _4_request();
            return cur_request.execute();
        }

        private table find_by_rating_4_and_5() {
            cur_request = new _4_and_5_request();
            return cur_request.execute();
        }

        private table find_by_rating_5() {
            cur_request = new _5_request();
            return cur_request.execute();
        }
    }
}
