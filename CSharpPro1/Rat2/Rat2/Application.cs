using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Autodesk.Revit.UI;
using System.Reflection;
using System.Windows.Media.Imaging;



namespace Rat2
{
    public class Application : IExternalApplication
    {

        // On Shutdown method
        public Result OnShutdown(UIControlledApplication application) => Result.Succeeded;

        // On StartUp method
        public Result OnStartup(UIControlledApplication application)
        {
            // add new ribbon panel
            RibbonPanel ribbonPanel = CreateRibbonPanel(application);
            return Result.Succeeded;
        }


        // Method for creating the Ribbon Panel
        public RibbonPanel CreateRibbonPanel(UIControlledApplication app)
        {
            string tab = "ShivaDev";
            RibbonPanel ribbonPanel = null;

            // create the tab first
            try
            {
                app.CreateRibbonTab(tab);

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            try
            {
                app.CreateRibbonPanel(tab, "rat1PanelName");

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            List<RibbonPanel> panels = app.GetRibbonPanels(tab);
            foreach (var panel in panels.Where(p => p.Name == "rat1PanelName")) // why to filter?
            {
                ribbonPanel = panel;
            }
            return ribbonPanel;
        }
    }
}
