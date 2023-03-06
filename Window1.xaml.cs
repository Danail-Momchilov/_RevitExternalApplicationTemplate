using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace SampleApplication
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public UIDocument uidoc { get; }
        public Document doc { get; }
        public Window1(UIDocument UiDoc)
        {
            uidoc = UiDoc;
            doc = UiDoc.Document;
            InitializeComponent();
        }

        private void OnClick1(object sender, RoutedEventArgs e)
        {
            TaskDialog dial = new TaskDialog("Sample Title");
            dial.Show();
        }
    }
}
