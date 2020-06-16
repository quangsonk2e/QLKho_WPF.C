using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanlyWPF.ViewModel
{
    public class dangnhap
    {

        public dangnhap()
        {
            checklogin = new RelayCommand<Window>(c => true, c =>
            {
                c.Hide();
                MessageBox.Show("Bạn đã nhập 111111111111");
                MainWindow a = new MainWindow();

                a.Show();
            });
        }
        public ICommand checklogin { get; set; }
    }
}
