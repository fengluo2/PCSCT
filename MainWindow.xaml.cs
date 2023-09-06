using PCSCT.BindintEntiy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PCSCT
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
            //Grid1.Children.RemoveRange(1, 2);
        }


        private void Init()
        {
            ToolbarMenuSetting toolbarMenuSetting = new ToolbarMenuSetting();
            MenuViewFileSystem.DataContext = toolbarMenuSetting;
            MenuViewMonitor.DataContext = toolbarMenuSetting;
            ViewFileSystem.DataContext = toolbarMenuSetting;
            ViewMonitor.DataContext = toolbarMenuSetting;
        }

        private void ToobarMenuButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("ToobarMenuButtonClick");
            Debug.WriteLine(((MenuItem)sender).Name);
            switch (((MenuItem)sender).Name)
            {
                case "MenuConnectOpen":
                    break;
                case "MenuConnectNew":
                    break;
                case "MenuConnectManage":
                    break;
                case "MenuViewFileSystem":
                    break;
                case "MenuViewMonitor":
                    break;
                case "MenuAbout":
                    break;
            }
        }
    }
}
