using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace TestPlugin3
{
    [Transaction(TransactionMode.Manual)]
    public class CmdHW1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Hola", "Hello yoloo world");

            return Result.Succeeded;
        }
    }
}
