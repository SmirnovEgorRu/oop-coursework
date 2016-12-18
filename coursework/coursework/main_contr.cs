using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace coursework {
    class main_contr {
        file_contr file_mngr;

        public void add_from_file() { file_mngr.add_from_file();}
        public void output_to_file() { file_mngr.output_from_file();}

        public main_contr() {
            file_mngr = new file_contr();
        }
    }
}
