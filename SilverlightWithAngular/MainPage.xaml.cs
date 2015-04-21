using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightWithAngular
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string scriptObjName = Globals.ScriptObject;
            string scriptObjReload = Globals.ScriptObject_Reload;

            // Get instance of the script object
            ScriptObject so = (ScriptObject)HtmlPage.Window.Invoke(scriptObjName);
            so.Invoke(scriptObjReload);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            throw new Exception("You make me puke!");
        }
    }
}
