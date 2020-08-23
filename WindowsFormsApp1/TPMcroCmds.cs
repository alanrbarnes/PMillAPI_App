using Autodesk.ProductInterface.PowerMILL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TPMcroCmds
    {
        //String macroPath = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/"

        //Method to run Macros
        public void runMacroAB(String path, PMAutomation projectUse)
        {
            PMMacro macro = projectUse.LoadMacro(new Autodesk.FileSystem.File(path));
            macro.RunComplete();
        }

        //Method to run command
        private void executecommandAB(String cmd, PMAutomation projectUse)
        { projectUse.Execute(cmd); }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Multi-Macros
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //MultiFacing Macro
        public void RunMacro6InchMultiFace(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/ThickBlockFacingWithIngersolCutter.mac";
            runMacroAB(path, projectUse);
        }

        //60+ MultiFacingMacro
        public void RunMacro60Plus6InchMultiFace(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/IngersolCutterFacingPlus60.mac";
            runMacroAB(path, projectUse);
        }

        //Multi-Side Champhering Cham FaceMill
        public void RunMacroChamAllSides(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/ChamAllSidesChamFaceMill.mac";
            runMacroAB(path, projectUse);
        }

        //Multi-Side Champhering SinglePoint
        public void RunMacroChamAllSidesSinglePoint(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/ChamAllSidesSinglePoint.mac";
            runMacroAB(path, projectUse);
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Drilling Methods
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //CenterDrill
        public void RunMacroCenterDrill(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\centerdrill.mac";
            runMacroAB(path, projectUse);
        }

        //CircleMill
        public void RunMacroCircleMill(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\circleMill.mac";
            runMacroAB(path, projectUse);
        }

        //ClearanceDrill
        public void RunMacroClearanceDrill(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\clearanceDrill.mac";
            runMacroAB(path, projectUse);
        }

        //Cbre CupDrill
        public void RunMacroCbreCupDrill(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\cbreCupdrill.mac";
            runMacroAB(path, projectUse);
        }

        //CupDrill
        public void RunMacroCupDrill(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\cupDrill.mac";
            runMacroAB(path, projectUse);
        }

        //CircleMill Dowel Holes
        public void RunMacroCircleMillDowels(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\DowelHolesCircleMill.mac";
            runMacroAB(path, projectUse);
        }

        //FCS Holes
        public void RunMacroFCS(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\FCSHoles.mac";
            runMacroAB(path, projectUse);
        }

        //Gundrilling
        public void RunMacroGundrilling(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\Gundrilling.mac";
            runMacroAB(path, projectUse);
        }

        //OpenUp PipeTap
        public void RunMacroOpenUpPipeTap(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\openUpPipeTap.mac";
            runMacroAB(path, projectUse);
        }

        //Pipe Cycle2 Tap 
        public void RunMacroPipeCycle2(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\PipeCycle2DrillTap.mac";
            runMacroAB(path, projectUse);
        }

        //Reaming
        public void RunMacroReaming(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\reaming.mac";
            runMacroAB(path, projectUse);
        }

        //Screw Holes
        public void RunMacroScrewHoles(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\ScrewHoleDrilling.mac";
            runMacroAB(path, projectUse);
        }

        //Champher
        public void RunMacroChampher(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\champher.mac";
            runMacroAB(path, projectUse);
        }

        //ThreadMIll
        public void RunMacrothreadMill(PMAutomation projectUse)
        {
            String path = "L:\\CAM-Library\\Niigata\\NiigataMacros\\CreateToolPathMacros\\DrillingMacros\\threadMill.mac";
            runMacroAB(path, projectUse);
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Setup Macros
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //Create WorkPlane from Box, Active Workplane
        public void RunMacroActiveWorkplaneBox(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/SetupMacros/createBoxActive.mac";
            runMacroAB(path, projectUse);
        }
        
        //Create Workplane from Box, Named Workplane
        public void RunMacroNamedWorkplaneBox(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/SetupMacros/createBoxCOR.mac";
            runMacroAB(path, projectUse);
        }

        //Create Workplane from Box
        public void RunMacroWorkplaneFromBox(PMAutomation projectUse)
        {
            String cmd = "MODE WORKPLANE_CREATE ; INTERACTIVE BLOCK";
            executecommandAB(cmd, projectUse);
        }

        //Create Workplane from Point
        public void RunMacroWorkplaneFromPoint(PMAutomation projectUse)
        {
            String cmd = "MODE WORKPLANE_CREATE ; INTERACTIVE POINT";
            executecommandAB(cmd, projectUse);
        }

        //Activate WorkPlane
        public void RunMacroActivateWorkplane(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/WorkPlaneMacros/ActivateWorkplane1.mac";
            runMacroAB(path, projectUse);
        }

        //Create standard workplanes
        public void RunMacroStdWorkplanes(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/WorkPlaneMacros/createWorkplanes.mac";
            runMacroAB(path, projectUse);
        }

        //Orient Workplane
        public void RunMacroOrientWorkplane(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/WorkPlaneMacros/EditWorkplane1.mac";
            runMacroAB(path, projectUse);
        }

        //Move CenterOfRotaion Workplane
        public void RunMacroMoveCenterOfRotation(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/WorkPlaneMacros/CenterOfRotationMove.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!
        ////Tool Database
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //Load Niigata Database
        public void RunMacroLoadNiigDB(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/NewNiigataToolsDatabase.mac";
            runMacroAB(path, projectUse);
        }

        //Query Database

        //All Tools
        public void RunMacroQueryAllTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/queryAllTools.mac";
            runMacroAB(path, projectUse);
        }

        //AllStandard Tools
        public void RunMacroQueryStdTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/standardTools.mac";
            runMacroAB(path, projectUse);
        }

        //All Non-Standard Tools
        public void RunMacroQueryNonStdTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/notStandardTools.mac";
            runMacroAB(path, projectUse);
        }

        //Dapra tools
        public void RunMacroQueryDapraTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/dapraTools.mac";
            runMacroAB(path, projectUse);
        }

        //MiniMill Tools
        public void RunMacroQueryMiniMillTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/minimillTools.mac";
            runMacroAB(path, projectUse);
        }

        //EndMill Tools
        public void RunMacroQueryEndMillTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/endMIllTools.mac";
            runMacroAB(path, projectUse);
        }

        //Cup drills
        public void RunMacroQueryCupDrillTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/cupDrillTools.mac";
            runMacroAB(path, projectUse);
        }

        //FaceMills
        public void RunMacroQueryFaceMillTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/faceMillTools.mac";
            runMacroAB(path, projectUse);
        }

        //SpadeDrills
        public void RunMacroQuerySpadeDrillTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/spadeDrillTools.mac";
            runMacroAB(path, projectUse);
        }

        //Inch Tap Drills
        public void RunMacroQueryInchTapDrills(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/inchDrillTools.mac";
            runMacroAB(path, projectUse);
        }

        //Metric Tap Drills
        public void RunMacroQueryMetricTapDrills(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/metricDrillTools.mac";
            runMacroAB(path, projectUse);
        }

        //Inch Taps
        public void RunMacroQueryInchTaps(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/inchTapTools.mac";
            runMacroAB(path, projectUse);
        }

        //Metric Taps
        public void RunMacroQueryMetricTaps(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/metricTapTools.mac";
            runMacroAB(path, projectUse);
        }

        //Pipe Drills
        public void RunMacroQueryPipeDrills(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/pipeDrillTools.mac";
            runMacroAB(path, projectUse);
        }

        //Pipe Taps
        public void RunMacroQueryPipeTaps(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/pipeTapTools.mac";
            runMacroAB(path, projectUse);
        }

        //Thread Mills
        public void RunMacroQueryThreadMills(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/threadmillTools.mac";
            runMacroAB(path, projectUse);
        }

        //Gundrills
        public void RunMacroQueryGundrills(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/gundrillTools.mac";
            runMacroAB(path, projectUse);
        }

        //Special Indexable
        public void RunMacroQuerySpecialIndexable(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/specialIndexableTools.mac";
            runMacroAB(path, projectUse);
        }

        //CounterBore Tools
        public void RunMacroQueryCbreTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/cbreTools.mac";
            runMacroAB(path, projectUse);
        }

        //Boring Tools
        public void RunMacroQueryBoringTools(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/QueryDatabase/boringTools.mac";
            runMacroAB(path, projectUse);
        }

        //Store Active Tool to all Databases
        public void RunMacroSaveActiveToolToAll(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/DatabaseMacros/ExportCurrentToolToAllDataBases.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Editing Macros
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //Add standard Holder
        public void RunMacroAddStdHolder(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ToolsMacros/addStdToolHolder.mac";
            runMacroAB(path, projectUse);
        }

        //Sort Tools By Number
        public void RunMacroSortToolsByNumber(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ToolsMacros/SortToolsInOrder.mac";
            runMacroAB(path, projectUse);
        }

        //Set Rapid and Plunge for Selected Toolpaths
        public void RunMacroSetSelectedRapidPlunge(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/setSelectedPlungeAndRapid.mac";
            runMacroAB(path, projectUse);
        }

        //Set Rapid for Selected Toolpaths
        public void RunMacroSetSelectedRapid(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/SetSelectedRapid.mac";
            runMacroAB(path, projectUse);
        }

        //Set Plunge for Selected Toolpaths
        public void RunMacroSetSelectedPlunge(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/SetSelectedPlunge.mac";
            runMacroAB(path, projectUse);
        }

        //Set moves to Circular rapids
        public void RunMacroSelectedCircularRapid(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/CircularRapids.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected to Plane Rapids
        public void RunMacroSelectedPlaneRapids(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/ThickBlockFacingWithIngersolCutter.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected Links to Skim Skim Safe
        public void RunMacroSelectedSkimSkimSafe(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/SetSkimSkimSafe.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected Links to Skim Skim Incremental
        public void RunMacroSelectedSkimSkimIncremental(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/SetSkimSkimIncremental.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected Links to Skim Safe Safe
        public void RunMacroSelectedSkimSafeSafe(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/SetSkimSafeSafe.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected Links to Safe Safe Safe
        public void RunMacroSelectedSafeSafeSafe(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/SetSafeSafeSafe.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected Links to Raster Style
        public void RunMacroSelectedRasterStyleLink(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/SetRasterLinks.mac";
            runMacroAB(path, projectUse);
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //General Editing
        //Move and Multiply toolpaths
        public void RunMacroMandM_StepDownTP(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/moveFace.mac";
            runMacroAB(path, projectUse);
        }

        //Recalculate Template Toolpath
        public void RunMacroRecalcTemplateTP(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/RecalcToolPaths.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Coolant
        //Set Selected to No Coolant
        public void RunMacroNoCoolant(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/NoCoolant.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected to Standard Coolant
        public void RunMacroStandardCoolant(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/StandardCoolant.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected to Thru Coolant
        public void RunMacroThruCoolant(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/ThruCoolant.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected to Air Coolant
        public void RunMacroAirCoolant(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/AirCoolant.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected to Default Coolant
        public void RunMacroDefaultCoolant(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/defaultCoolant.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Verification
        //Collision Check Selected TP to model .06 Spindle and Shank
        public void RunMacroColisionCheck60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/VerificationMacros/verifySelectedToolpaths06Model.mac";
            runMacroAB(path, projectUse);
        }

        //Gouge Check Selected TP to model .06 Spindle and Shank
        public void RunMacroGougeCheck60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/VerificationMacros/gougeCheckToModel.mac";
            runMacroAB(path, projectUse);
        }

        //Collision Check Selected TP to Stock model .06 Spindle and Shank
        public void RunMacroCollisionCheckStockMdl(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/VerificationMacros/CollisionCheckToStockModel.mac";
            runMacroAB(path, projectUse);
        }

        //Gouge Check Selected TP to Stock model .06 Spindle and Shank
        public void RunMacroGougeCheckStockMdl(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/VerificationMacros/GougeCheckToStockModel.mac";
            runMacroAB(path, projectUse);
        }

        //Collision Check all TP in selected NC file
        public void RunMacroCollisionCheckNC(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/VerificationMacros/CollisionCheckTPInNC.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!
        //Model Editing
        //Delete Bad Surfaces
        public void RunMacroDeleteBadSurf(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/ModelMacros/deleteBadSurfaces.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Milling Methods
        //Parts Counter Pocket
        public void RunMacroPartsCounter(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/PartsCounter.mac";
            runMacroAB(path, projectUse);
        }

        //Side Lock Pockets
        public void RunMacroSideLockPockets(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/LockPockets.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected to Default Coolant
        //public void RunMacroDefaultCoolant(PMAutomation projectUse)
        //{
        //    String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/defaultCoolant.mac";
        //    runMacroAB(path, projectUse);
        //}

        //Generate Corner Champher
        public void RunMacroGenCornerCham(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/FinishingMacros/CornerCham.mac";
            runMacroAB(path, projectUse);
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Champher Macros
        //Champher 1 side with champher face mill, 1Inch lead
        public void RunMacroCham1Side(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/ChampherMacros/ChamOneSide.mac";
            runMacroAB(path, projectUse);
        }

        //Champher 1 side with single point champher
        public void RunMacroCham1SideSP(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/ChampherMacros/SinglePointCham.mac";
            runMacroAB(path, projectUse);
        }

        //Profile Champher
        public void RunMacroProfileCham(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/ChampherMacros/ProfileCham.mac";
            runMacroAB(path, projectUse);
        }

        //Champher all sides with champher face mill
        public void RunMacroChamAll(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/ChamAllSidesChamFaceMill.mac";
            runMacroAB(path, projectUse);
        }

        //Champher all side with single point champher
        public void RunMacroChamAllSP(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/MultiSideMacros/ChamAllSidesSinglePoint.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Finishing
        //OffsetFlatFinishing
        public void RunMacroOSFlatFinish(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/FinishingMacros/FlatFinishing.mac";
            runMacroAB(path, projectUse);
        }

        //Engrave with Pattern
        public void RunMacroSimpleEngrave(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/FinishingMacros/Engrave.mac";
            runMacroAB(path, projectUse);
        }

        //Engraving using the 3D Offset finishing TP
        public void RunMacroPocketEngrave(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/FinishingMacros/3dOffsetEngrave.mac";
            runMacroAB(path, projectUse);
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!
        //Roughing Macros
        //.500 Chip surfer Roughing + .06
        public void RunMacroCSRoughPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/500CSRoughing.mac";
            runMacroAB(path, projectUse);
        }

        //1Inch MiniMill Roughing + .06
        public void RunMacro1InchMiniRoughPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/1InchMiniRoughing.mac";
            runMacroAB(path, projectUse);
        }

        //1.25Inch Hi-Pos Roughing + .06
        public void RunMacro1250HiPosRoughingPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/1_25HiPosRoughing.mac";
            runMacroAB(path, projectUse);
        }

        //3Inch Helido Roughing + .06
        public void RunMacro3InchHelidoRoughingPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/3InchHelidoRoughing.mac";
            runMacroAB(path, projectUse);
        }

        //3Inch Button Roughing + .06
        public void RunMacro3InchButtonRoughingPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/3InchButtonRoughing.mac";
            runMacroAB(path, projectUse);
        }

        //!!!!!!!!!!!!!!!!!!!
        //Rest Roughing
        //.500 High Feed Dapra rest roughing
        public void RunMacroRestRough500HFDapra(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/RestRoughing/500DapraRestRough.mac";
            runMacroAB(path, projectUse);
        }

        //.500 chip surfer rest roughing
        public void RunMacroCSRestRoughPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/RestRoughing/500CSRestRough.mac";
            runMacroAB(path, projectUse);
        }

        //.750 Dapra Rest Roughing not implemented
        //public void RunMacro750DapraRestRoughPlus60(PMAutomation projectUse)
        //{
        //    String path = "";
        //    runMacroAB(path, projectUse);
        //}

        //1Inch MiniMill Rest Roughing + .06
        public void RunMacro1InchMiniRestRoughPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/RestRoughing/1InchMiniRestRough.mac";
            runMacroAB(path, projectUse);
        }

        //1.25 Hi-Pos Rest roughing + .06
        public void RunMacro1250HiPosRestRoughPlus60(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/CreateToolPathMacros/RoughingMacros/RestRoughing/1_25HiPosRestRough.mac";
            runMacroAB(path, projectUse);
        }


        //!!!!!!!!!!!!!!!!!!!!!
        //Boundary Commands
        //Create Boundary from Model
        public void RunMacroBoundaryFromModel(PMAutomation projectUse)
        {
            String cmd = "CREATE BOUNDARY ; SKETCH FORM BOUNDARY  \\N EDIT BOUNDARY $boundary.name INSERT MODEL \\N  EDIT BOUNDARY $boundary.name ACCEPT BOUNDARY ACCEPT";
            executecommandAB(cmd, projectUse);
        }

        //Create Boundary from Sketch
        public void RunMacroBoundaryFromSketch(PMAutomation projectUse)
        {
            String cmd = "CREATE BOUNDARY ; SKETCH FORM BOUNDARY \\N EDIT BOUNDARY $boundary.name CURVEEDITOR START";
            executecommandAB(cmd, projectUse);
        }

        //Create Contact Point Boundary
        public void RunMacroContactPointBoundary(PMAutomation projectUse)
        {
            String cmd = "CREATE BOUNDARY ; CONTACTPOINT FORM BOUNDARY \\N  EDIT BOUNDARY $boundary.name INSERT MODEL \\N EDIT BOUNDARY $boundary.name ACCEPT BOUNDARY ACCEPT";
            executecommandAB(cmd, projectUse);
        }

        //!!!!!!!!!!!!!!!!!
        //Pattern Commands
        //Paste As new Pattern
        public void RunMacroPasteNewPattern(PMAutomation projectUse)
        {
            String cmd = "CREATE PATTERN CLIPBOARD";
            executecommandAB(cmd, projectUse);
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!
        //Hole Feature Commands
        //Create a new 3D Hole Featureset
        public void RunMacroCreate3DHoleFeatureset(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/HoleFeatureMacros/3DHoleFeatures.mac";
            runMacroAB(path, projectUse);
        }

        //Create a new Single side Hole feature set for the current workplane
        public void RunMacroCreateSimpleHoleFeatureset(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/HoleFeatureMacros/SingleSideHoleFeature.mac";
            runMacroAB(path, projectUse);
        }

        //Delete Perpendicular Holes in Hole featureset
        public void RunMacroDeleteVertHoles(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/HoleFeatureMacros/FeatureSelector.mac";
            runMacroAB(path, projectUse);
        }

        //Separate Deep Holes From Shallow Holes From Specified Depth
        public void RunMacroSeparateShallowDeep(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/HoleFeatureMacros/DeepHoleSelector.mac";
            runMacroAB(path, projectUse);
        }

        //Create new Featuresets based on all of the hole diameters in a featureset and organize accordingly
        public void RunMacroHoleDiameterSeparate(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/HoleFeatureMacros/TestSeparateHoleFeatures.mac";
            runMacroAB(path, projectUse);
        }

        //Set all of the holes in a featureset to a specified diameter
        public void RunMacroHoleFeatureDiameterChange(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/HoleFeatureMacros/MoveHoleSize.mac";
            runMacroAB(path, projectUse);
        }

        //Get the total number of inches in a hole feature
        public void RunMacroHoleFeatureTotalInches(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/FileEditingMacros/TotalDrillInches";
            runMacroAB(path, projectUse);
        }

        //Get the depth of a selected hole
        public void RunMacroSelectedHoleDepth(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/FileEditingMacros/SelectedHoleDepth.mac";
            runMacroAB(path, projectUse);
        }

        //Convert all of the Compound hole features to simple holes
        //Makes one hole based on the last non-tapered hole in the featureset
        public void RunMacroConvertToSimpleHoles(PMAutomation projectUse)
        {
            String path = "L:/CAM-Library/Niigata/NiigataMacros/HoleFeatureMacros/CleanupHoleFeatures.mac";
            runMacroAB(path, projectUse);
        }

        //Set Selected to Default Coolant
        //public void RunMacroDefaultCoolant(PMAutomation projectUse)
        //{
        //    String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/defaultCoolant.mac";
        //    runMacroAB(path, projectUse);
        //}

        //Set Selected to Default Coolant
        //public void RunMacroDefaultCoolant(PMAutomation projectUse)
        //{
        //    String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/defaultCoolant.mac";
        //    runMacroAB(path, projectUse);
        //}

        //Set Selected to Default Coolant
        //public void RunMacroDefaultCoolant(PMAutomation projectUse)
        //{
        //    String path = "L:/CAM-Library/Niigata/NiigataMacros/ModifyToolPathMacros/defaultCoolant.mac";
        //    runMacroAB(path, projectUse);
        //}
    }
}
