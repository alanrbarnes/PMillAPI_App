using Autodesk.ProductInterface.PowerMILL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PMConnection
    {
        private static readonly dynamic comObject;
        static List<object> listOfInstances;
        private static object powerMill;

        public static List<object> PConn()
        {
            //This is the powermill method that returns a list of com objects
            List<object> comList = PMAutomation.GetListOfPmComObjects();

            return comList;

            //PMAutomation projectUse = new PMAutomation(comList[2]);
            //PMProject s = projectUse.ActiveProject;

            //Autodesk.FileSystem.File importFile = new Autodesk.FileSystem.File("L:\\CAM-Library\\Niigata\\FCSComponents\\GaugePlate_R1.dgk");
            //PMModel myModel = s.Models.CreateModel(importFile);

            //powerMill.DialogsOff;

            //powerMill.DialogsOn;

        }
    }
}
