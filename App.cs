using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SampleApplication
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            String assembName = Assembly.GetExecutingAssembly().Location;
            String path = System.IO.Path.GetDirectoryName(assembName);

            // create a tab
            String tabName = "Panel01";
            application.CreateRibbonTab(tabName);

            // creatte a panel
            RibbonPanel demoPanel = application.CreateRibbonPanel(tabName, "!&MORE!");

            // create PushButon
            PushButtonData butonData1 = new PushButtonData("btn1", "btn1", assembName, "SampleApplication.Test");
            butonData1.LargeImage = new BitmapImage(new Uri(path + @"\icon.png"));

            demoPanel.AddItem(butonData1);
            demoPanel.AddSeparator();

            // add tooltip
            butonData1.ToolTip = "This is a tooltip";
            butonData1.ToolTipImage = new BitmapImage(new Uri(path + @"\icon.png"));

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Failed;
        }
    }
}