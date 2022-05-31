#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Media.Imaging;
using System.IO;
using Result = Autodesk.Revit.UI.Result;
#endregion

namespace TestPlugin1
{
    public class App : IExternalApplication
    {

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            // create the ribbon panel
            RibbonPanel panel = CreateRibbonPanel(application);

            // Get the assembly path. This is the path of the folder that the application is being compiled to.
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

            const string buttonName = "button1";
            const string buttonText = "button1Text";
            const string buttonToolTip = "Test tool tip for button1";

            // declaring the panel.AddItem() as PushButton

            PushButtonData pushButtonData = new PushButtonData(buttonName, buttonText, thisAssemblyPath, "TestPlugin1.Command");

            var pushButton = panel.AddItem(pushButtonData);
            if (pushButton is PushButton button)
            {
                button.ToolTip = buttonToolTip;
                Uri uri = new Uri(Path.Combine((Path.GetDirectoryName(thisAssemblyPath)), "Resource", "button1.png"));
                BitmapImage bitmapImage = new BitmapImage(uri);
                button.LargeImage = bitmapImage;
            }

            // declaring the panel.AddItem() as PushButton
            //if (panel.AddItem(new PushButtonData(buttonName, buttonText, thisAssemblyPath, "TestPlugin1.Command")) is PushButton button)
            //{
            //    button.ToolTip = buttonToolTip;
            //    Uri uri = new Uri(Path.Combine((Path.GetDirectoryName(thisAssemblyPath)), "Resource", "button1.png"));
            //    BitmapImage bitmapImage = new BitmapImage(uri);
            //    button.LargeImage = bitmapImage;
            //}
            return Result.Succeeded;
        }

        // Method to create the Ribbon panel for the given UIControlledApplication instance
        public RibbonPanel CreateRibbonPanel(UIControlledApplication app)
        {

            // constant names for the panel, and the tabs inside the panel
            const string panelName = "Panel1";
            const string tab1Name = "Tab1";
            RibbonPanel ribbonPanel = null;

            // Create the tab inside the 'app' instance
            try
            {
                app.CreateRibbonTab(tab1Name);
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't create the Ribbon Panel" + e);
            }

            // Create the panel with the created tab
            try
            {
                app.CreateRibbonPanel(tab1Name, panelName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // Create list of all panels -> for in the 'tabName' of 'app'
            List<RibbonPanel> panels = app.GetRibbonPanels(tab1Name);
            // Get only the panel we own. Shouldn't add tabs to other panels
            foreach (var panel in panels.Where(panel => panel.Name == panelName))
            {
                ribbonPanel = panel;
            }

            return ribbonPanel;
        }



    }
}
