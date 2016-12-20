using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework {
    class main_contr {
        file_contr file_mngr;
        public parser_to_table parser;
        public request_contr request_mngr;
        public report_contr report_mngr;

        public void add_from_file() { file_mngr.add_from_file();}
        public void output_to_file() { file_mngr.output_from_file();}


        public main_contr() {
            file_mngr = new file_contr();
            parser = new parser_to_table();
            request_mngr = new request_contr();
            report_mngr = new report_contr();
        }
    }
}
