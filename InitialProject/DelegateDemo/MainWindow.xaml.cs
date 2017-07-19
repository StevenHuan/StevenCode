using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DelegateDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btngoru_Click(object sender, RoutedEventArgs e)
        {
            //传统方法
            //获取文本框内容
            string text1 = txt1_Copy.Text.Trim();
            txt1_Copy.Clear();
            if(cb1.IsChecked == true){
                txt1.Text = text1;
            }
            if (cb2.IsChecked == true)
            {
                txt2.Text = text1;
            }

        }
    }
}
