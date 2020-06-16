using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanlyWPF.ViewModel
{
    public class test
    {
        
        public test()
        {
            mesText = new RelayCommand<object>(c =>true, c => {                
                //MessageBox.Show("Bạn đã nhập");
                Login a = new Login();
                
            });
        }
        public ICommand mesText { get; set; }
    }
}
