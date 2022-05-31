#region  NAMESPACES
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
#endregion

namespace TestPlugin3
{
    public class App : IExternalApplication
    {

        public Result OnShutdown(UIControlledApplication application)
        {

            return Result.Succeeded;
        }
        public Result OnStartup(UIControlledApplication application)
        {

            // Create the Ribbon Panel
            const string panelName = "Panel-1";
            var ribbonPanel = CreateRibbonPanel(application, panelName);

            // Get the assembly location
            var thisAssembly = Assembly.GetExecutingAssembly().Location;

            // Button Command settings
            const string buttonName = "button1";    // internal name that is going to be used to refer inside c#
            const string buttonText = "Hallo";  // Button Name in Revit
            const string buttonToolTip = "Temp tool tip";   // tool tip when hovered over the button
            const string buttonCommand = "TestPlugin3.CmdHW1"; // command class that the button should execute on click

            PushButtonData pushButtonData = new PushButtonData(buttonName, buttonText, thisAssembly, buttonCommand);

            // Add the pushButtonData to the ribbonPanel.
            // Same way to add different types of buttons to the panel
            var pushButton = ribbonPanel.AddItem(pushButtonData);

            // Validate if the Push button is of type button. if so then set these props. Different methods.
            if (pushButton is PushButton button)
            {
                button.ToolTip = buttonToolTip;
                var path = Path.Combine(Path.GetDirectoryName(thisAssembly), "Resources", "button1.ico");
                Uri uri = new Uri(path);
                BitmapImage bitmapImage = new BitmapImage(uri);
                button.LargeImage = bitmapImage;
            }

            return Result.Succeeded;
        }

        public RibbonPanel CreateRibbonPanel(UIControlledApplication app, string panelName)
        {
            RibbonPanel ribbonPanel = null;

            // Name declarations -> Push to a separate file
            const string tabName = "Test Kit 1";
            const string panelName2 = "Panel-2";


            app.CreateRibbonTab(tabName);
            app.CreateRibbonPanel(tabName, panelName);
            app.CreateRibbonPanel(tabName, panelName2);

            List<RibbonPanel> panels = app.GetRibbonPanels(tabName);

            foreach (RibbonPanel panel in panels.Where(panel => panel.Name == panelName))
            {
                ribbonPanel = panel;
                //ribbonPanel.AddItem(panel);
            }
            
            
            return ribbonPanel;
        }
    }
}