using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightWithAngular
{
    public class Globals
    {
        private static IDictionary<string, string> _initParams;

        public static void SetInitParams(IDictionary<string, string> initParams)
        {
            _initParams = initParams;
        }

        public static string ScriptObject
        {
            get { return _initParams["scriptObjectType"]; }
        }

        public static string ScriptObject_Reload
        {
            get { return _initParams["scriptObjectReload"]; }
        }
    }
}
