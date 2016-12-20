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
    public partial class password_form : Form {
        Func<bool> access;

        public password_form(Func<bool> new_access) {
            InitializeComponent();
            access = new_access;
            TopMost = true;

        }
        private void close(object sender, EventArgs e) {
            Properties.Settings settings = new Properties.Settings();
            string password = settings.Пароль;
            string input = text_box.Text;

            if (password != input) {
                var pass = new password_form(access);
                pass.Show();
            }
        }

        private void button_Click(object sender, EventArgs e) {
            Properties.Settings settings = new Properties.Settings();
            string password = settings.Пароль;
            string input = text_box.Text;

            if (password == input) {
                access();
                this.Close();
            } 
            else {
                MessageBox.Show("Неправильный пароль!", "Ошибка");
            }
        }

        private void password_form_Load(object sender, EventArgs e) {
            this.FormClosed += close;
        }
    }
}
