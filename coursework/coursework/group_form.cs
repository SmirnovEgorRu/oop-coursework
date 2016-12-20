using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework {
    partial class group_form : Form {
        Action<string> callback;
        string text;

        public group_form(Action<string> new_callback) {
            InitializeComponent();
            callback = new_callback;
        }

        private void group_form_Load(object sender, EventArgs e) {
            this.FormClosing+=close;

            var group = table_group.instanse();
            group.Reset();
            foreach (table_record record in group) {
                combo_box.Items.Add(record[1].get_value());
            }
        }

        private void close(object sender, EventArgs e) {
            if (text == null) callback("%error%");
            else callback(text);
        }

        private void button_Click(object sender, EventArgs e) {
            text = Convert.ToString(combo_box.SelectedItem);
            this.Close();
        }
    }
}
