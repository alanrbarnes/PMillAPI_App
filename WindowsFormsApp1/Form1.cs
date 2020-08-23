//reference for appplication open in window
//https://www.youtube.com/watch?v=N6GWgxEvibE

using Autodesk.ProductInterface.PowerMILL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Reflection;
//For opening Excell
using System.Threading;

using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace WindowsFormsApp1
{
    

    public partial class Form1 : Form
    {
        //Global variables
        List<object> comList;
        bool b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16 = false;
        PMAutomation projectUse;
        PMProject session;
        PMProject s;
        TPMcroCmds mcro = new TPMcroCmds();
        Button previousButton;
        Button currentButton;
        String macroPath = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/";


        //PMConnection con = new PMConnection();

        public Form1()
        {
            InitializeComponent();

        }


        //For Opening Excell
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void rgrOpenButton_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");


            String pth = "C:\\Users\\abarnes\\Desktop\\shortcuts\\SpreadSheets\\BIGMILLS - Shortcut";
            Process p = Process.Start(pth);
            //Process p = Process.Start("calc.exe");

            //if (p.MainWindowHandle == null)
            //{ MessageBox.Show("No"); }

            Thread.Sleep(500);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, panel2.Handle);
            //SetParent(, this.Handle);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Function Page Buttons
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //run the multi-facing operation
        private void button1_Click_2(object sender, EventArgs e)
        {mcro.RunMacro6InchMultiFace(projectUse);}

        //run the multi-facing operation + 60
        private void button3_Click_1(object sender, EventArgs e)
        {mcro.RunMacro60Plus6InchMultiFace(projectUse);}

        //Multi-side champhering, champher facemill
        private void button2_Click(object sender, EventArgs e)
        { mcro.RunMacroChamAllSides(projectUse); }

        //Multi-side champhering, singlePoint
        private void button4_Click(object sender, EventArgs e)
        { mcro.RunMacroChamAllSidesSinglePoint(projectUse); }

        //!!!!!!!!!!!!!!!!
        //Drilling Methods
        //!!!!!!!!!!!!!!!!
        //CenterDrill
        private void button1_Click_1(object sender, EventArgs e)
        { mcro.RunMacroCenterDrill(projectUse); }

        //CircleMill
        private void button28_Click(object sender, EventArgs e)
        { mcro.RunMacroCircleMill(projectUse); }

        //ClearanceDrill
        private void button29_Click(object sender, EventArgs e)
        { mcro.RunMacroClearanceDrill(projectUse); }

        //Cbre CupDrill
        private void button30_Click(object sender, EventArgs e)
        { mcro.RunMacroCbreCupDrill(projectUse); }

        //CupDrill
        private void button31_Click(object sender, EventArgs e)
        { mcro.RunMacroCupDrill(projectUse); }

        //CircleMill Dowel Holes
        private void button32_Click(object sender, EventArgs e)
        { mcro.RunMacroCircleMillDowels(projectUse); }

        //FCS Holes
        private void button33_Click(object sender, EventArgs e)
        { mcro.RunMacroFCS(projectUse); }

        //GunDrilling
        private void button34_Click(object sender, EventArgs e)
        {mcro.RunMacroGundrilling(projectUse); }

        //OpenUp PipeTap
        private void button35_Click(object sender, EventArgs e)
        { mcro.RunMacroOpenUpPipeTap(projectUse); }

        //Pipe Cycle2 Tap
        private void button36_Click(object sender, EventArgs e)
        { mcro.RunMacroPipeCycle2(projectUse); }

        //Reaming
        private void button37_Click(object sender, EventArgs e)
        { mcro.RunMacroReaming(projectUse); }

        //Drill Screw Holes
        private void button38_Click(object sender, EventArgs e)
        { mcro.RunMacroScrewHoles(projectUse); }

        //SinglePoint Champher
        private void button39_Click(object sender, EventArgs e)
        { mcro.RunMacroChampher(projectUse); }

        //ThreadMIll
        private void button40_Click(object sender, EventArgs e)
        { mcro.RunMacrothreadMill(projectUse); }


        private void button3_Click(object sender, EventArgs e)
        {

        }


        //Utilities
        //Button to Connect to Niigata Tool DB
        private void button43_Click(object sender, EventArgs e)
        {
            { mcro.RunMacroLoadNiigDB(projectUse); }
        }




        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Helper Methods
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



        //Method to run command
        private void executecommandAB(String cmd)
        {projectUse.Execute(cmd);}


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //buttons for connecting to workspace
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void button1_Click(object sender, EventArgs e)
        { Connect(b1, 0, wsButton1); }

        private void wsButton2_Click(object sender, EventArgs e)
        { Connect(b2, 1, wsButton2);}

        private void wsButton3_Click(object sender, EventArgs e)
        { Connect(b3, 2, wsButton3); }

        private void folderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void wsButton4_Click(object sender, EventArgs e)
        { Connect(b4, 3, wsButton4); }

        private void wsButton5_Click(object sender, EventArgs e)
        { Connect(b5, 4, wsButton5); }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button83_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button84_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button112_Click(object sender, EventArgs e)
        {
            //AddProjectPanel();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            //AddOperationPanel();
        }

        private void wsButton6_Click(object sender, EventArgs e)
        { Connect(b6, 5, wsButton6); }

        private void wsButton7_Click(object sender, EventArgs e)
        { Connect(b7, 6, wsButton7); }

        private void wsButton8_Click(object sender, EventArgs e)
        { Connect(b8, 7, wsButton8); }

        private void wsButton9_Click(object sender, EventArgs e)
        { Connect(b9, 8, wsButton9); }

        private void wsButton10_Click(object sender, EventArgs e)
        { Connect(b10, 9, wsButton10); }

        private void wsButton11_Click(object sender, EventArgs e)
        { Connect(b11, 10, wsButton11); }

        private void wsButton12_Click(object sender, EventArgs e)
        { Connect(b12, 11, wsButton12); }

        private void wsButton13_Click(object sender, EventArgs e)
        { Connect(b13, 12, wsButton13); }

        private void wsButton14_Click(object sender, EventArgs e)
        { Connect(b14, 13, wsButton14); }

        private void wsButton15_Click(object sender, EventArgs e)
        { Connect(b15, 14, wsButton15); }

        private void button15_Click(object sender, EventArgs e)
        { Connect(b16, 15, wsButton16); }



        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Visual Planning Layout
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private void AddProjectPanel(String panel)
        {

        }

        private void AddOperationPanel(String panel)
        {

        }

        private void Connect(bool x, int index, Button xButton)
        {
            if (x)
            {
                //Connect to Powermill instance
                projectUse = new PMAutomation(comList[index]);

                //Change the color of the button in use to red
                //And change the color of all other buttons to green
                SetButtonColor(x, index, xButton);

                //create project instance from instance
                session = projectUse.ActiveProject;

                int i = 0;
                //Add the name of the file to the text box
                setProjectLabel(x, index, xButton, i);
            }
        }

        private bool SetButtonColor(bool x, int index, Button xButton)
        {
            bool result = true;

            
                //System.Threading.Thread.Sleep(2000);

                s = projectUse.ActiveProject;
                if (currentButton != null)
                {
                    previousButton = currentButton;
                    previousButton.BackColor = Color.LightGreen;
                }
                currentButton = xButton;
                currentButton.BackColor = Color.Red;
                Thread.Sleep(2000);
            return result;

          
        }

        private bool setProjectLabel(bool x, int index, Button xButton, int i)
        {
            bool result = true;
            if (i > 3)
            { return result; }
            i = i + 1;

            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\FileEditingMacros\\getNameOfProject.mac";
            mcro.runMacroAB(path, projectUse);

            //Wait 5 seconds before proceeding
            



            //list of all the featuresets in the project
            PMFeatureSetsCollection fset = session.FeatureSets;
            

            Thread.Sleep(2000);
            try
            {
                //active feature in the project
                PMFeatureSet activeFeature = fset.ActiveItem;
                //last feature in the list
                //PMFeatureSet activeFeature = fset.LastItem();
                //name of the active feature in the project
                String featureName = activeFeature.Name.ToString();
                Console.WriteLine(featureName);
                //System.Threading.Thread.Sleep(3000);
                projectLabel.Text = "Active Project: \n" + featureName;
                activeFeature.Delete();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Press One more time");

                Connect(x, index, xButton);
                    //setProjectLabel(i);
            }
            return result;
        }




        //method that gets list of all workspaces
        private void connectButton_Click(object sender, EventArgs e)
        {
            comList = WindowsFormsApp1.PMConnection.PConn();
            int i = 0;
            foreach (object obj in comList)
            {
                switch (i)
                {
                    case 0:
                        wsButton1.BackColor = Color.LightGreen;
                        b1 = true;
                        break;
                    case 1:
                        wsButton2.BackColor = Color.LightGreen;
                        b2 = true;
                        break;
                    case 2:
                        wsButton3.BackColor = Color.LightGreen;
                        b3 = true;
                        break;
                    case 3:
                        wsButton4.BackColor = Color.LightGreen;
                        b4 = true;
                        break;
                    case 4:
                        wsButton5.BackColor = Color.LightGreen;
                        b5 = true;
                        break;
                    case 5:
                        wsButton6.BackColor = Color.LightGreen;
                        b6 = true;
                        break;
                    case 6:
                        wsButton7.BackColor = Color.LightGreen;
                        b7 = true;
                        break;
                    case 7:
                        wsButton8.BackColor = Color.LightGreen;
                        b8 = true;
                        break;
                    case 8:
                        wsButton9.BackColor = Color.LightGreen;
                        b9 = true;
                        break;
                    case 9:
                        wsButton10.BackColor = Color.LightGreen;
                        b10 = true;
                        break;
                    case 10:
                        wsButton11.BackColor = Color.LightGreen;
                        b11 = true;
                        break;
                    case 11:
                        wsButton12.BackColor = Color.LightGreen;
                        b12 = true;
                        break;
                    case 12:
                        wsButton13.BackColor = Color.LightGreen;
                        b13 = true;
                        break;
                    case 13:
                        wsButton14.BackColor = Color.LightGreen;
                        b14 = true;
                        break;
                    case 14:
                        wsButton15.BackColor = Color.LightGreen;
                        b15 = true;
                        break;
                    case 15:
                        wsButton16.BackColor = Color.LightGreen;
                        b16 = true;
                        break;
                    default:
                        break;
                }
                i++;
            }

        }
    }
}
