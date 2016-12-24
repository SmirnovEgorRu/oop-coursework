using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework {
    public class main_contr {
        private file_contr file_mngr;
        private parser_to_table parser;
        private request_contr request_mngr;
        private report_contr report_mngr;

        public void add_from_file() {
            file_mngr.add_from_file();
        }

        public void output_to_file() {
            file_mngr.output_from_file();
        }

        public table find_by_value(string value, request_contr.by_value type) {
            return request_mngr.find_by_value(value, type);
        }

        public table find_by_rating(request_contr.by_rating type) {
            return request_mngr.find_by_rating(type);
        }

        public table report_by_group() {
            return report_mngr.report_by_group();
        }

        public table report_by_rating() {
            return report_mngr.report_by_rating();
        }

        public void parse(DataGridView data_grid, table source_table) {
            parser.parse(data_grid, source_table);
        }

        public main_contr() {
            // имеем возможность выбирать именно те модули, которые нужны
            file_mngr = new file_contr();
            parser = new parser_to_table();
            request_mngr = new request_contr();
            report_mngr = new report_contr();
        }
    }
}
