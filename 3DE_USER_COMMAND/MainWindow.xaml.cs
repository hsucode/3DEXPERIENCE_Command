using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFAutoCompleteTextbox;



namespace _3DE_USER_COMMAND
{
    //public interface Icatia{ void work(string s); }

    public partial class MainWindow : Window
    {

      
              
        public   INFITF.Application CATIA ;

        private void TITLE_Drop(object sender, DragEventArgs e)
        {

        }


        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

          
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // MessageBox.Show("sad");

              
                HistoryList.Content = textBox1.Text;
                if (textBox1.Text == "CloseThis")
                {
                    Application.Current.Shutdown();

                }


                StartCommand();
            }

            else if (e.Key == Key.Delete)
            {

                if (textBox1.Text != null)
                {
                    textBox1.Text =null;
                }  
            
            }

        }




       

        private void textBox1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
  
            if (e.Key == Key.Down || e.Key ==Key.PageDown || e.Key == Key.Up || e.Key ==Key.PageUp)
            {
     
                if (sender != null)
                {
                    textBox1.PreviewKeyDown += new KeyEventHandler(textBox1_PreviewMouseDown);
                }               
            }
        }


        private void textBox1_PreviewMouseDown(object sender, KeyEventArgs e)
        {
            
             if (textBox1 != null)
            {
                 
                textBox1.Focus();
                e.Handled = true;
            }
        }


        private void HistoryList_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StartCommand();
        }

    

        private void StartCommand()
        {   
            //INFITF.Application CATIA;
            try
            {
                CATIA = System.Runtime.InteropServices.Marshal.GetActiveObject("Catia.Application") as INFITF.Application;
                CATIA.StartCommand(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Sorry ! 3D EXPERIENCE Platform No Started , Please Start it first ! ");

            }
           
        //MessageBox.Show("hahh");
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Will be Close");
            //this.Close();
            Application.Current.Shutdown();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            {
                this.DragMove();
            }
        }


        public string GetCATIAversion()
        {
           return   CATIA.SystemConfiguration.Version.ToString();
                
        }

        private void SettingWindows_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("这是一个初步版本，我会在后续逐步更新！谢谢！");
          
            Form.SettingWindow settingsWindow = new Form.SettingWindow();
            settingsWindow.ShowDialog();

            //string appPath = System.Environment.CurrentDirectory;
            //MessageBox.Show(appPath);

        }

        public MainWindow()
        {
            InitializeComponent();
            //textBox1.AddItem(new AutoCompleteEntry("CATIA", "CAT", "CA", "CAI", "CT"));
                    

textBox1.AddItem(new AutoCompleteEntry("* back","ds","* back","**","*b"));
textBox1.AddItem(new AutoCompleteEntry("* bottom","ds","* bottom","**","*b"));
textBox1.AddItem(new AutoCompleteEntry("* front","ds","* front","nt","*f"));
textBox1.AddItem(new AutoCompleteEntry("* iso","ds","* iso","io","*i"));
textBox1.AddItem(new AutoCompleteEntry("* left","ds","* left","le","*l"));
textBox1.AddItem(new AutoCompleteEntry("* right","ds","* right","rt","*r"));
textBox1.AddItem(new AutoCompleteEntry("* top","ds","* top","tp","*t"));
textBox1.AddItem(new AutoCompleteEntry("3D Alignment","ds","3D Alignment","al","civ"));
textBox1.AddItem(new AutoCompleteEntry("3D Curve","ds","3D Curve","cr","crv"));
textBox1.AddItem(new AutoCompleteEntry("3D Curve Offset","ds","3D Curve Offset","off","crv"));
textBox1.AddItem(new AutoCompleteEntry("3D Master Query","ds","3D Master Query","ma","3d"));
textBox1.AddItem(new AutoCompleteEntry("3D Tag...","ds","3D Tag...","tag","tg"));
textBox1.AddItem(new AutoCompleteEntry("3DMessaging","ds","3DMessaging","ss","ag"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Activate Camera Next","ds","3Dx Activate Camera Next","ra","ca"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Activate Camera Previous","ds","3Dx Activate Camera Previous","ra","ca"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Button Customization","ds","3Dx Button Customization","bt","cu"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Dominant On/Off","ds","3Dx Dominant On/Off","off","on"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Fast Zoom","ds","3Dx Fast Zoom","zom","zm"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Next Configuration","ds","3Dx Next Configuration","ne","co"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Previous Configuration","ds","3Dx Previous Configuration","pre","co"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Rotation On/Off","ds","3Dx Rotation On/Off","ro","on"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Sensitivity Decrease f","ds","3Dx Sensitivity Decrease f","de","3d"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Sensitivity Increase","ds","3Dx Sensitivity Increase","in","3d"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Sensitivity Reset +","ds","3Dx Sensitivity Reset +","re","3d"));
textBox1.AddItem(new AutoCompleteEntry("3Dx Swap View/tree","ds","3Dx Swap View/tree","sw","vi"));
textBox1.AddItem(new AutoCompleteEntry("3Dz Translation On/Off 0","ds","3Dz Translation On/Off 0","on","of"));
textBox1.AddItem(new AutoCompleteEntry("6W","ds","6W","66","ww"));
textBox1.AddItem(new AutoCompleteEntry("About 3DEXPERIENCE Platform","ds","About 3DEXPERIENCE Platform","he","pl"));
textBox1.AddItem(new AutoCompleteEntry("Accelerate","ds","Accelerate","al","ra"));
textBox1.AddItem(new AutoCompleteEntry("Access Rights...","ds","Access Rights...","ri","ar"));
textBox1.AddItem(new AutoCompleteEntry("Action","ds","Action","ekl","kn"));
textBox1.AddItem(new AutoCompleteEntry("Action Bar Customization","ds","Action Bar Customization","ba","cu"));
textBox1.AddItem(new AutoCompleteEntry("Action Pad","ds","Action Pad","pa","pa"));
textBox1.AddItem(new AutoCompleteEntry("Activate","ds","Activate","av","te"));
textBox1.AddItem(new AutoCompleteEntry("Activate Full screen","ds","Activate Full screen","qp","al"));
textBox1.AddItem(new AutoCompleteEntry("Activate Robot Copilot","ds","Activate Robot Copilot","co","ac"));
textBox1.AddItem(new AutoCompleteEntry("Activate Robot Planes","ds","Activate Robot Planes","ro","pl"));
textBox1.AddItem(new AutoCompleteEntry("Activate Tree View","ds","Activate Tree View","vi","on"));
textBox1.AddItem(new AutoCompleteEntry("Activate Update","ds","Activate Update","te","ac"));
textBox1.AddItem(new AutoCompleteEntry("Activate View","ds","Activate View","ac","vi"));
textBox1.AddItem(new AutoCompleteEntry("Activate components","ds","Activate components","ac",""));
textBox1.AddItem(new AutoCompleteEntry("Activate touch mode","ds","Activate touch mode","",""));
textBox1.AddItem(new AutoCompleteEntry("Activate...","ds","Activate...","",""));
textBox1.AddItem(new AutoCompleteEntry("Activate/Deactivate","ds","Activate/Deactivate","",""));
textBox1.AddItem(new AutoCompleteEntry("Adaptive Sweep","ds","Adaptive Sweep","",""));
textBox1.AddItem(new AutoCompleteEntry("Add Dashboard","ds","Add Dashboard","",""));
textBox1.AddItem(new AutoCompleteEntry("Add Leader","ds","Add Leader","",""));
textBox1.AddItem(new AutoCompleteEntry("Add Parameters to Geometry","ds","Add Parameters to Geometry","",""));
textBox1.AddItem(new AutoCompleteEntry("Add Position…","ds","Add Position…","",""));
textBox1.AddItem(new AutoCompleteEntry("Add View...","ds","Add View...","",""));
textBox1.AddItem(new AutoCompleteEntry("Add tab","ds","Add tab","",""));
textBox1.AddItem(new AutoCompleteEntry("Add to favorites","ds","Add to favorites","",""));
textBox1.AddItem(new AutoCompleteEntry("Add...","ds","Add...","",""));
textBox1.AddItem(new AutoCompleteEntry("Add/Update File","ds","Add/Update File","",""));
textBox1.AddItem(new AutoCompleteEntry("Added Feature","ds","Added Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Advanced Search","ds","Advanced Search","",""));
textBox1.AddItem(new AutoCompleteEntry("Affinity","ds","Affinity","",""));
textBox1.AddItem(new AutoCompleteEntry("Album...","ds","Album...","",""));
textBox1.AddItem(new AutoCompleteEntry("Align Viewpoint","ds","Align Viewpoint","",""));
textBox1.AddItem(new AutoCompleteEntry("Aligned Section View/Section Cut","ds","Aligned Section View/Section Cut","",""));
textBox1.AddItem(new AutoCompleteEntry("Alignment information","ds","Alignment information","",""));
textBox1.AddItem(new AutoCompleteEntry("All Axis Systems","ds","All Axis Systems","",""));
textBox1.AddItem(new AutoCompleteEntry("All Bodies","ds","All Bodies","",""));
textBox1.AddItem(new AutoCompleteEntry("All Curves","ds","All Curves","",""));
textBox1.AddItem(new AutoCompleteEntry("All Elements","ds","All Elements","",""));
textBox1.AddItem(new AutoCompleteEntry("All Except Selected Elements","ds","All Except Selected Elements","",""));
textBox1.AddItem(new AutoCompleteEntry("All Geometrical Sets","ds","All Geometrical Sets","",""));
textBox1.AddItem(new AutoCompleteEntry("All Lines","ds","All Lines","",""));
textBox1.AddItem(new AutoCompleteEntry("All Planes","ds","All Planes","",""));
textBox1.AddItem(new AutoCompleteEntry("All Points","ds","All Points","",""));
textBox1.AddItem(new AutoCompleteEntry("All Sketches","ds","All Sketches","",""));
textBox1.AddItem(new AutoCompleteEntry("All Surfaces","ds","All Surfaces","",""));
textBox1.AddItem(new AutoCompleteEntry("All Volumes","ds","All Volumes","",""));
textBox1.AddItem(new AutoCompleteEntry("Allow clipping","ds","Allow clipping","",""));
textBox1.AddItem(new AutoCompleteEntry("Allow selection","ds","Allow selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Ambience Overload...","ds","Ambience Overload...","",""));
textBox1.AddItem(new AutoCompleteEntry("App Options","ds","App Options","",""));
textBox1.AddItem(new AutoCompleteEntry("Application Frame Structure Exposition","ds","Application Frame Structure Exposition","",""));
textBox1.AddItem(new AutoCompleteEntry("Apply Customized View","ds","Apply Customized View","",""));
textBox1.AddItem(new AutoCompleteEntry("Assemble…","ds","Assemble…","",""));
textBox1.AddItem(new AutoCompleteEntry("Assessment Result","ds","Assessment Result","",""));
textBox1.AddItem(new AutoCompleteEntry("Associative Export","ds","Associative Export","",""));
textBox1.AddItem(new AutoCompleteEntry("Asynchronous Relations Update","ds","Asynchronous Relations Update","",""));
textBox1.AddItem(new AutoCompleteEntry("Attributes...","ds","Attributes...","",""));
textBox1.AddItem(new AutoCompleteEntry("Authoring Context","ds","Authoring Context","",""));
textBox1.AddItem(new AutoCompleteEntry("Auto-Clean","ds","Auto-Clean","",""));
textBox1.AddItem(new AutoCompleteEntry("Automatic","ds","Automatic","",""));
textBox1.AddItem(new AutoCompleteEntry("Away","ds","Away","",""));
textBox1.AddItem(new AutoCompleteEntry("Axis","ds","Axis","",""));
textBox1.AddItem(new AutoCompleteEntry("Axis System..","ds","Axis System..","",""));
textBox1.AddItem(new AutoCompleteEntry("Axis To Axis","ds","Axis To Axis","",""));
textBox1.AddItem(new AutoCompleteEntry("AxisToAxis","ds","AxisToAxis","",""));
textBox1.AddItem(new AutoCompleteEntry("Axor,ometric View","ds","Axor,ometric View","",""));
textBox1.AddItem(new AutoCompleteEntry("B.!. Essentials","ds","B.!. Essentials","",""));
textBox1.AddItem(new AutoCompleteEntry("B! Essentials","ds","B! Essentials","",""));
textBox1.AddItem(new AutoCompleteEntry("Back","ds","Back","",""));
textBox1.AddItem(new AutoCompleteEntry("Be right back","ds","Be right back","",""));
textBox1.AddItem(new AutoCompleteEntry("Blend","ds","Blend","",""));
textBox1.AddItem(new AutoCompleteEntry("Body","ds","Body","",""));
textBox1.AddItem(new AutoCompleteEntry("Body in a Set...","ds","Body in a Set...","",""));
textBox1.AddItem(new AutoCompleteEntry("Boolean Operations","ds","Boolean Operations","",""));
textBox1.AddItem(new AutoCompleteEntry("Boundary","ds","Boundary","",""));
textBox1.AddItem(new AutoCompleteEntry("Brief Action Pad","ds","Brief Action Pad","",""));
textBox1.AddItem(new AutoCompleteEntry("Business Innovation","ds","Business Innovation","",""));
textBox1.AddItem(new AutoCompleteEntry("Busy","ds","Busy","",""));
textBox1.AddItem(new AutoCompleteEntry("By BSF","ds","By BSF","",""));
textBox1.AddItem(new AutoCompleteEntry("By Latest","ds","By Latest","",""));
textBox1.AddItem(new AutoCompleteEntry("CATDwc V6/V5 As Specs Checker/Cleaner","ds","CATDwc V6/V5 As Specs Checker/Cleaner","",""));
textBox1.AddItem(new AutoCompleteEntry("CATIA","ds","CATIA","",""));
textBox1.AddItem(new AutoCompleteEntry("CATIA File...","ds","CATIA File...","",""));
textBox1.AddItem(new AutoCompleteEntry("CAVE","ds","CAVE","",""));
textBox1.AddItem(new AutoCompleteEntry("Cancel","ds","Cancel","",""));
textBox1.AddItem(new AutoCompleteEntry("Cancel Check Out","ds","Cancel Check Out","",""));
textBox1.AddItem(new AutoCompleteEntry("Capture","ds","Capture","",""));
textBox1.AddItem(new AutoCompleteEntry("Capture Component Specifications","ds","Capture Component Specifications","",""));
textBox1.AddItem(new AutoCompleteEntry("Capture Management","ds","Capture Management","",""));
textBox1.AddItem(new AutoCompleteEntry("Capture...","ds","Capture...","",""));
textBox1.AddItem(new AutoCompleteEntry("Cascade","ds","Cascade","",""));
textBox1.AddItem(new AutoCompleteEntry("Catalog Browser","ds","Catalog Browser","",""));
textBox1.AddItem(new AutoCompleteEntry("Catalog Browser in Dialog Mode","ds","Catalog Browser in Dialog Mode","",""));
textBox1.AddItem(new AutoCompleteEntry("Center Tree","ds","Center Tree","",""));
textBox1.AddItem(new AutoCompleteEntry("Center Tree On Work Object","ds","Center Tree On Work Object","",""));
textBox1.AddItem(new AutoCompleteEntry("Center Tree on Selected Objects","ds","Center Tree on Selected Objects","",""));
textBox1.AddItem(new AutoCompleteEntry("Centered Rectangle","ds","Centered Rectangle","",""));
textBox1.AddItem(new AutoCompleteEntry("Chamfer","ds","Chamfer","",""));
textBox1.AddItem(new AutoCompleteEntry("Chamfer, Local Modifier","ds","Chamfer, Local Modifier","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Capture Support","ds","Change Capture Support","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Color","ds","Change Color","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Geometrical Set...","ds","Change Geometrical Set...","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Line Thickness","ds","Change Line Thickness","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Line Type","ds","Change Line Type","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Maturity...","ds","Change Maturity...","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Opacity","ds","Change Opacity","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Part Body","ds","Change Part Body","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Responsible...","ds","Change Responsible...","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Sketch Support..","ds","Change Sketch Support..","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Symbol","ds","Change Symbol","",""));
textBox1.AddItem(new AutoCompleteEntry("Change To Add","ds","Change To Add","",""));
textBox1.AddItem(new AutoCompleteEntry("Change To Assemble","ds","Change To Assemble","",""));
textBox1.AddItem(new AutoCompleteEntry("Change To Remove","ds","Change To Remove","",""));
textBox1.AddItem(new AutoCompleteEntry("Change Vew Support..","ds","Change Vew Support..","",""));
textBox1.AddItem(new AutoCompleteEntry("Change layers","ds","Change layers","",""));
textBox1.AddItem(new AutoCompleteEntry("Change rendering style per object","ds","Change rendering style per object","",""));
textBox1.AddItem(new AutoCompleteEntry("Check","ds","Check","",""));
textBox1.AddItem(new AutoCompleteEntry("Check Analysis","ds","Check Analysis","",""));
textBox1.AddItem(new AutoCompleteEntry("Check In","ds","Check In","",""));
textBox1.AddItem(new AutoCompleteEntry("Check linearity","ds","Check linearity","",""));
textBox1.AddItem(new AutoCompleteEntry("Check Out","ds","Check Out","",""));
textBox1.AddItem(new AutoCompleteEntry("Checkout All Files","ds","Checkout All Files","",""));
textBox1.AddItem(new AutoCompleteEntry("Circle","ds","Circle","",""));
textBox1.AddItem(new AutoCompleteEntry("Circular Pattern","ds","Circular Pattern","",""));
textBox1.AddItem(new AutoCompleteEntry("Civil Engineer","ds","Civil Engineer","",""));
textBox1.AddItem(new AutoCompleteEntry("Clipboard","ds","Clipboard","",""));
textBox1.AddItem(new AutoCompleteEntry("Close","ds","Close","",""));
textBox1.AddItem(new AutoCompleteEntry("Close Surface","ds","Close Surface","",""));
textBox1.AddItem(new AutoCompleteEntry("Close Surface…","ds","Close Surface…","",""));
textBox1.AddItem(new AutoCompleteEntry("Closed Profile","ds","Closed Profile","",""));
textBox1.AddItem(new AutoCompleteEntry("Cloud / Points","ds","Cloud / Points","",""));
textBox1.AddItem(new AutoCompleteEntry("Cloud/Mesh Filter","ds","Cloud/Mesh Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Clustering CAVE","ds","Clustering CAVE","",""));
textBox1.AddItem(new AutoCompleteEntry("Collaborate with EBOM","ds","Collaborate with EBOM","",""));
textBox1.AddItem(new AutoCompleteEntry("Collaborative Space Applicability...","ds","Collaborative Space Applicability...","",""));
textBox1.AddItem(new AutoCompleteEntry("Collapse All","ds","Collapse All","",""));
textBox1.AddItem(new AutoCompleteEntry("Color.coding for surfaces","ds","Color.coding for surfaces","",""));
textBox1.AddItem(new AutoCompleteEntry("Colonze by Height Map","ds","Colonze by Height Map","",""));
textBox1.AddItem(new AutoCompleteEntry("Combine","ds","Combine","",""));
textBox1.AddItem(new AutoCompleteEntry("Commands List...","ds","Commands List...","",""));
textBox1.AddItem(new AutoCompleteEntry("Compare Structure,.,","ds","Compare Structure,.,","",""));
textBox1.AddItem(new AutoCompleteEntry("Compare with EBOM...","ds","Compare with EBOM...","",""));
textBox1.AddItem(new AutoCompleteEntry("Concept Explorer ODT Test","ds","Concept Explorer ODT Test","",""));
textBox1.AddItem(new AutoCompleteEntry("Connect Checker Analysis","ds","Connect Checker Analysis","",""));
textBox1.AddItem(new AutoCompleteEntry("Connect Curve","ds","Connect Curve","",""));
textBox1.AddItem(new AutoCompleteEntry("Constraint Defined in a Dialog Box,.,","ds","Constraint Defined in a Dialog Box,.,","",""));
textBox1.AddItem(new AutoCompleteEntry("Constraint Filter","ds","Constraint Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Constraint..","ds","Constraint..","",""));
textBox1.AddItem(new AutoCompleteEntry("Contacts","ds","Contacts","",""));
textBox1.AddItem(new AutoCompleteEntry("Content...","ds","Content...","",""));
textBox1.AddItem(new AutoCompleteEntry("Contents. Index and Search","ds","Contents. Index and Search","",""));
textBox1.AddItem(new AutoCompleteEntry("Contour Map","ds","Contour Map","",""));
textBox1.AddItem(new AutoCompleteEntry("Control Points","ds","Control Points","",""));
textBox1.AddItem(new AutoCompleteEntry("Convert to Polyline","ds","Convert to Polyline","",""));
textBox1.AddItem(new AutoCompleteEntry("Copy","ds","Copy","",""));
textBox1.AddItem(new AutoCompleteEntry("Copy! Paste as result","ds","Copy! Paste as result","",""));
textBox1.AddItem(new AutoCompleteEntry("Core Feature","ds","Core Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Corner","ds","Corner","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Axis System from Robot","ds","Create Axis System from Robot","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Concept Branch","ds","Create Concept Branch","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Concept Point","ds","Create Concept Point","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Datum","ds","Create Datum","",""));
textBox1.AddItem(new AutoCompleteEntry("Create External Parameter","ds","Create External Parameter","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Image Support","ds","Create Image Support","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Import...","ds","Create Import...","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Inertia Data","ds","Create Inertia Data","",""));
textBox1.AddItem(new AutoCompleteEntry("Create New Objects","ds","Create New Objects","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Orientation Link","ds","Create Orientation Link","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Polylirie","ds","Create Polylirie","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Polyline on Cloud","ds","Create Polyline on Cloud","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Positional Link","ds","Create Positional Link","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Surface from Terrain","ds","Create Surface from Terrain","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Technological Results...","ds","Create Technological Results...","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Terrain","ds","Create Terrain","",""));
textBox1.AddItem(new AutoCompleteEntry("Create Terrain From Contour Lines","ds","Create Terrain From Contour Lines","",""));
textBox1.AddItem(new AutoCompleteEntry("Create a Publication","ds","Create a Publication","",""));
textBox1.AddItem(new AutoCompleteEntry("Create materials","ds","Create materials","",""));
textBox1.AddItem(new AutoCompleteEntry("Cube","ds","Cube","",""));
textBox1.AddItem(new AutoCompleteEntry("Curve Change Degree","ds","Curve Change Degree","",""));
textBox1.AddItem(new AutoCompleteEntry("Curve Filter","ds","Curve Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Curve Projection","ds","Curve Projection","",""));
textBox1.AddItem(new AutoCompleteEntry("Curve Smooth","ds","Curve Smooth","",""));
textBox1.AddItem(new AutoCompleteEntry("Custom Dump","ds","Custom Dump","",""));
textBox1.AddItem(new AutoCompleteEntry("Customer Extension","ds","Customer Extension","",""));
textBox1.AddItem(new AutoCompleteEntry("Customize View","ds","Customize View","",""));
textBox1.AddItem(new AutoCompleteEntry("Customize View Parameters","ds","Customize View Parameters","",""));
textBox1.AddItem(new AutoCompleteEntry("Customize...","ds","Customize...","",""));
textBox1.AddItem(new AutoCompleteEntry("Cut","ds","Cut","",""));
textBox1.AddItem(new AutoCompleteEntry("Cut image","ds","Cut image","",""));
textBox1.AddItem(new AutoCompleteEntry("Cutout or Push","ds","Cutout or Push","",""));
textBox1.AddItem(new AutoCompleteEntry("Cutter","ds","Cutter","",""));
textBox1.AddItem(new AutoCompleteEntry("Cutting Plane","ds","Cutting Plane","",""));
textBox1.AddItem(new AutoCompleteEntry("Cylinder","ds","Cylinder","",""));
textBox1.AddItem(new AutoCompleteEntry("Deactivate","ds","Deactivate","",""));
textBox1.AddItem(new AutoCompleteEntry("Deactivate Full Screen","ds","Deactivate Full Screen","",""));
textBox1.AddItem(new AutoCompleteEntry("Deactivate Update","ds","Deactivate Update","",""));
textBox1.AddItem(new AutoCompleteEntry("Deactivate components","ds","Deactivate components","",""));
textBox1.AddItem(new AutoCompleteEntry("Debug Shader","ds","Debug Shader","",""));
textBox1.AddItem(new AutoCompleteEntry("Decimate","ds","Decimate","",""));
textBox1.AddItem(new AutoCompleteEntry("Define Dynamic Level of Detail","ds","Define Dynamic Level of Detail","",""));
textBox1.AddItem(new AutoCompleteEntry("Define Dynamic Pixel Culling","ds","Define Dynamic Pixel Culling","",""));
textBox1.AddItem(new AutoCompleteEntry("Define In Work Object","ds","Define In Work Object","",""));
textBox1.AddItem(new AutoCompleteEntry("Define In Work Set","ds","Define In Work Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Define Selection Set","ds","Define Selection Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Define a Local Area","ds","Define a Local Area","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete","ds","Delete","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete All Except...","ds","Delete All Except...","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete Applied-materials","ds","Delete Applied-materials","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete Orientation Link","ds","Delete Orientation Link","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete Positional Link","ds","Delete Positional Link","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete Useless Elements...","ds","Delete Useless Elements...","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete and Keep Operand In Context","ds","Delete and Keep Operand In Context","",""));
textBox1.AddItem(new AutoCompleteEntry("Delete...","ds","Delete...","",""));
textBox1.AddItem(new AutoCompleteEntry("Deletion","ds","Deletion","",""));
textBox1.AddItem(new AutoCompleteEntry("Depth Effect...","ds","Depth Effect...","",""));
textBox1.AddItem(new AutoCompleteEntry("Design Excavation","ds","Design Excavation","",""));
textBox1.AddItem(new AutoCompleteEntry("Design Table","ds","Design Table","",""));
textBox1.AddItem(new AutoCompleteEntry("Desktop Wall","ds","Desktop Wall","",""));
textBox1.AddItem(new AutoCompleteEntry("Detach Document","ds","Detach Document","",""));
textBox1.AddItem(new AutoCompleteEntry("Details View","ds","Details View","",""));
textBox1.AddItem(new AutoCompleteEntry("Deviation Analysis","ds","Deviation Analysis","",""));
textBox1.AddItem(new AutoCompleteEntry("Diagnostic Report","ds","Diagnostic Report","",""));
textBox1.AddItem(new AutoCompleteEntry("Direct Edit","ds","Direct Edit","",""));
textBox1.AddItem(new AutoCompleteEntry("Direct Modification","ds","Direct Modification","",""));
textBox1.AddItem(new AutoCompleteEntry("Disable Filter","ds","Disable Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Disassemble","ds","Disassemble","",""));
textBox1.AddItem(new AutoCompleteEntry("Disassemble Terrain","ds","Disassemble Terrain","",""));
textBox1.AddItem(new AutoCompleteEntry("Disconnect","ds","Disconnect","",""));
textBox1.AddItem(new AutoCompleteEntry("Discretization","ds","Discretization","",""));
textBox1.AddItem(new AutoCompleteEntry("Display All Results","ds","Display All Results","",""));
textBox1.AddItem(new AutoCompleteEntry("Display Assistance","ds","Display Assistance","",""));
textBox1.AddItem(new AutoCompleteEntry("Display Capture","ds","Display Capture","",""));
textBox1.AddItem(new AutoCompleteEntry("Display Coordinates","ds","Display Coordinates","",""));
textBox1.AddItem(new AutoCompleteEntry("Display Editability Errors...","ds","Display Editability Errors...","",""));
textBox1.AddItem(new AutoCompleteEntry("Display Intersection Points","ds","Display Intersection Points","",""));
textBox1.AddItem(new AutoCompleteEntry("Display Normals","ds","Display Normals","",""));
textBox1.AddItem(new AutoCompleteEntry("Display PolyMesh","ds","Display PolyMesh","",""));
textBox1.AddItem(new AutoCompleteEntry("Do not disturb","ds","Do not disturb","",""));
textBox1.AddItem(new AutoCompleteEntry("Document Template Creation...","ds","Document Template Creation...","",""));
textBox1.AddItem(new AutoCompleteEntry("Download","ds","Download","",""));
textBox1.AddItem(new AutoCompleteEntry("Draft","ds","Draft","",""));
textBox1.AddItem(new AutoCompleteEntry("Draft Analysis","ds","Draft Analysis","",""));
textBox1.AddItem(new AutoCompleteEntry("Draft Properties","ds","Draft Properties","",""));
textBox1.AddItem(new AutoCompleteEntry("Draft, Local Modifier","ds","Draft, Local Modifier","",""));
textBox1.AddItem(new AutoCompleteEntry("Draft…","ds","Draft…","",""));
textBox1.AddItem(new AutoCompleteEntry("Draw","ds","Draw","",""));
textBox1.AddItem(new AutoCompleteEntry("Dump List Content","ds","Dump List Content","",""));
textBox1.AddItem(new AutoCompleteEntry("Duplicate Advanced","ds","Duplicate Advanced","",""));
textBox1.AddItem(new AutoCompleteEntry("Duplicate materials","ds","Duplicate materials","",""));
textBox1.AddItem(new AutoCompleteEntry("Duplicate...","ds","Duplicate...","",""));
textBox1.AddItem(new AutoCompleteEntry("Duplication","ds","Duplication","",""));
textBox1.AddItem(new AutoCompleteEntry("Dynamic Hidden Line Removal","ds","Dynamic Hidden Line Removal","",""));
textBox1.AddItem(new AutoCompleteEntry("Dynamic Sectioning","ds","Dynamic Sectioning","",""));
textBox1.AddItem(new AutoCompleteEntry("Edge Fillet","ds","Edge Fillet","",""));
textBox1.AddItem(new AutoCompleteEntry("Edit Formula","ds","Edit Formula","",""));
textBox1.AddItem(new AutoCompleteEntry("Edit Generative Parameter...","ds","Edit Generative Parameter...","",""));
textBox1.AddItem(new AutoCompleteEntry("Edit Inputs...","ds","Edit Inputs...","",""));
textBox1.AddItem(new AutoCompleteEntry("Edit Parameters","ds","Edit Parameters","",""));
textBox1.AddItem(new AutoCompleteEntry("Edit Polyline","ds","Edit Polyline","",""));
textBox1.AddItem(new AutoCompleteEntry("Edit Publication Properties","ds","Edit Publication Properties","",""));
textBox1.AddItem(new AutoCompleteEntry("Edit Sub Elements in Error...","ds","Edit Sub Elements in Error...","",""));
textBox1.AddItem(new AutoCompleteEntry("Ellipse","ds","Ellipse","",""));
textBox1.AddItem(new AutoCompleteEntry("Engineering Template Instantiation","ds","Engineering Template Instantiation","",""));
textBox1.AddItem(new AutoCompleteEntry("Equivalent Dimensions","ds","Equivalent Dimensions","",""));
textBox1.AddItem(new AutoCompleteEntry("Eraser","ds","Eraser","",""));
textBox1.AddItem(new AutoCompleteEntry("Errortog","ds","Errortog","",""));
textBox1.AddItem(new AutoCompleteEntry("Examine","ds","Examine","",""));
textBox1.AddItem(new AutoCompleteEntry("Exit","ds","Exit","",""));
textBox1.AddItem(new AutoCompleteEntry("Exit App","ds","Exit App","",""));
textBox1.AddItem(new AutoCompleteEntry("Exit Assembly Feature Specifications app.","ds","Exit Assembly Feature Specifications app.","",""));
textBox1.AddItem(new AutoCompleteEntry("Expand All Levels","ds","Expand All Levels","",""));
textBox1.AddItem(new AutoCompleteEntry("Expand First Level","ds","Expand First Level","",""));
textBox1.AddItem(new AutoCompleteEntry("Expand Second Level","ds","Expand Second Level","",""));
textBox1.AddItem(new AutoCompleteEntry("Expand Selection","ds","Expand Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Explode...","ds","Explode...","",""));
textBox1.AddItem(new AutoCompleteEntry("Explore Historic Links...","ds","Explore Historic Links...","",""));
textBox1.AddItem(new AutoCompleteEntry("Export Publications","ds","Export Publications","",""));
textBox1.AddItem(new AutoCompleteEntry("Export in Excel","ds","Export in Excel","",""));
textBox1.AddItem(new AutoCompleteEntry("Export…","ds","Export…","",""));
textBox1.AddItem(new AutoCompleteEntry("External Feature","ds","External Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("External View...","ds","External View...","",""));
textBox1.AddItem(new AutoCompleteEntry("Extract","ds","Extract","",""));
textBox1.AddItem(new AutoCompleteEntry("Extrapolate","ds","Extrapolate","",""));
textBox1.AddItem(new AutoCompleteEntry("Extrapolation","ds","Extrapolation","",""));
textBox1.AddItem(new AutoCompleteEntry("Extremum","ds","Extremum","",""));
textBox1.AddItem(new AutoCompleteEntry("Extrude","ds","Extrude","",""));
textBox1.AddItem(new AutoCompleteEntry("Feature Element Filter","ds","Feature Element Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Filter Point Cloud","ds","Filter Point Cloud","",""));
textBox1.AddItem(new AutoCompleteEntry("Filter Variants","ds","Filter Variants","",""));
textBox1.AddItem(new AutoCompleteEntry("Find Owning Selection Sets...","ds","Find Owning Selection Sets...","",""));
textBox1.AddItem(new AutoCompleteEntry("Find in this app","ds","Find in this app","",""));
textBox1.AddItem(new AutoCompleteEntry("Find...","ds","Find...","",""));
textBox1.AddItem(new AutoCompleteEntry("Fit All In","ds","Fit All In","",""));
textBox1.AddItem(new AutoCompleteEntry("Flag Note","ds","Flag Note","",""));
textBox1.AddItem(new AutoCompleteEntry("Flag Note with Leader","ds","Flag Note with Leader","",""));
textBox1.AddItem(new AutoCompleteEntry("Flush Undo/Redo stacks","ds","Flush Undo/Redo stacks","",""));
textBox1.AddItem(new AutoCompleteEntry("Fly Through","ds","Fly Through","",""));
textBox1.AddItem(new AutoCompleteEntry("Forbid selection","ds","Forbid selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Formula","ds","Formula","",""));
textBox1.AddItem(new AutoCompleteEntry("Forward","ds","Forward","",""));
textBox1.AddItem(new AutoCompleteEntry("Free Edges","ds","Free Edges","",""));
textBox1.AddItem(new AutoCompleteEntry("Free Hand Selection Trap","ds","Free Hand Selection Trap","",""));
textBox1.AddItem(new AutoCompleteEntry("Freeze","ds","Freeze","",""));
textBox1.AddItem(new AutoCompleteEntry("Freeze Robot Position","ds","Freeze Robot Position","",""));
textBox1.AddItem(new AutoCompleteEntry("From list","ds","From list","",""));
textBox1.AddItem(new AutoCompleteEntry("Front View","ds","Front View","",""));
textBox1.AddItem(new AutoCompleteEntry("Full Screen","ds","Full Screen","",""));
textBox1.AddItem(new AutoCompleteEntry("Full Screen For Design","ds","Full Screen For Design","",""));
textBox1.AddItem(new AutoCompleteEntry("Functional Edge Fillet","ds","Functional Edge Fillet","",""));
textBox1.AddItem(new AutoCompleteEntry("Functional Set","ds","Functional Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Functional User Feature","ds","Functional User Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Generate new Document","ds","Generate new Document","",""));
textBox1.AddItem(new AutoCompleteEntry("Generate presentation in active 3D Shape","ds","Generate presentation in active 3D Shape","",""));
textBox1.AddItem(new AutoCompleteEntry("Geolocated Point","ds","Geolocated Point","",""));
textBox1.AddItem(new AutoCompleteEntry("Geometrical Element Filter","ds","Geometrical Element Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Geometrical Set","ds","Geometrical Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Geometrical Set...","ds","Geometrical Set...","",""));
textBox1.AddItem(new AutoCompleteEntry("Geometry","ds","Geometry","",""));
textBox1.AddItem(new AutoCompleteEntry("Geometry Connection Management","ds","Geometry Connection Management","",""));
textBox1.AddItem(new AutoCompleteEntry("Geometry Overview","ds","Geometry Overview","",""));
textBox1.AddItem(new AutoCompleteEntry("Geometry located after the current feature","ds","Geometry located after the current feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Get Features On Support","ds","Get Features On Support","",""));
textBox1.AddItem(new AutoCompleteEntry("Get Started","ds","Get Started","",""));
textBox1.AddItem(new AutoCompleteEntry("Get Support","ds","Get Support","",""));
textBox1.AddItem(new AutoCompleteEntry("Globe View","ds","Globe View","",""));
textBox1.AddItem(new AutoCompleteEntry("Graphic Properties Wizard","ds","Graphic Properties Wizard","",""));
textBox1.AddItem(new AutoCompleteEntry("Groove","ds","Groove","",""));
textBox1.AddItem(new AutoCompleteEntry("HMD","ds","HMD","",""));
textBox1.AddItem(new AutoCompleteEntry("Healing","ds","Healing","",""));
textBox1.AddItem(new AutoCompleteEntry("Helix","ds","Helix","",""));
textBox1.AddItem(new AutoCompleteEntry("Help","ds","Help","",""));
textBox1.AddItem(new AutoCompleteEntry("Hidden line Removal","ds","Hidden line Removal","",""));
textBox1.AddItem(new AutoCompleteEntry("Hide","ds","Hide","",""));
textBox1.AddItem(new AutoCompleteEntry("Hide 3D Tag features","ds","Hide 3D Tag features","",""));
textBox1.AddItem(new AutoCompleteEntry("Hide All","ds","Hide All","",""));
textBox1.AddItem(new AutoCompleteEntry("Hide All Component Specifications","ds","Hide All Component Specifications","",""));
textBox1.AddItem(new AutoCompleteEntry("Hide Components","ds","Hide Components","",""));
textBox1.AddItem(new AutoCompleteEntry("Hide in 3D","ds","Hide in 3D","",""));
textBox1.AddItem(new AutoCompleteEntry("Hide/Show","ds","Hide/Show","",""));
textBox1.AddItem(new AutoCompleteEntry("Hole","ds","Hole","",""));
textBox1.AddItem(new AutoCompleteEntry("Ho me","ds","Ho me","",""));
textBox1.AddItem(new AutoCompleteEntry("Horizontal Alignment","ds","Horizontal Alignment","",""));
textBox1.AddItem(new AutoCompleteEntry("Hyperlinks...","ds","Hyperlinks...","",""));
textBox1.AddItem(new AutoCompleteEntry("Icons w,th Labels","ds","Icons w,th Labels","",""));
textBox1.AddItem(new AutoCompleteEntry("Identify...","ds","Identify...","",""));
textBox1.AddItem(new AutoCompleteEntry("Image Chooser","ds","Image Chooser","",""));
textBox1.AddItem(new AutoCompleteEntry("Image Edition","ds","Image Edition","",""));
textBox1.AddItem(new AutoCompleteEntry("Image Eraser","ds","Image Eraser","",""));
textBox1.AddItem(new AutoCompleteEntry("Immersive Wall","ds","Immersive Wall","",""));
textBox1.AddItem(new AutoCompleteEntry("Impact Analysis","ds","Impact Analysis","",""));
textBox1.AddItem(new AutoCompleteEntry("Import Publications","ds","Import Publications","",""));
textBox1.AddItem(new AutoCompleteEntry("Import geometry","ds","Import geometry","",""));
textBox1.AddItem(new AutoCompleteEntry("Import…","ds","Import…","",""));
textBox1.AddItem(new AutoCompleteEntry("In the Box","ds","In the Box","",""));
textBox1.AddItem(new AutoCompleteEntry("Industry Innovation","ds","Industry Innovation","",""));
textBox1.AddItem(new AutoCompleteEntry("Inherit input surface color","ds","Inherit input surface color","",""));
textBox1.AddItem(new AutoCompleteEntry("Insert Added Volume...","ds","Insert Added Volume...","",""));
textBox1.AddItem(new AutoCompleteEntry("Insert Break Lines","ds","Insert Break Lines","",""));
textBox1.AddItem(new AutoCompleteEntry("Insert Existing Object Parameter","ds","Insert Existing Object Parameter","",""));
textBox1.AddItem(new AutoCompleteEntry("Insert In New...","ds","Insert In New...","",""));
textBox1.AddItem(new AutoCompleteEntry("Insert New Content..","ds","Insert New Content..","",""));
textBox1.AddItem(new AutoCompleteEntry("Insert New Object Parameter","ds","Insert New Object Parameter","",""));
textBox1.AddItem(new AutoCompleteEntry("Insert Object","ds","Insert Object","",""));
textBox1.AddItem(new AutoCompleteEntry("Instantiate From Selection","ds","Instantiate From Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Installation of User Features Types","ds","Installation of User Features Types","",""));
textBox1.AddItem(new AutoCompleteEntry("Instantiate From Representation","ds","Instantiate From Representation","",""));
textBox1.AddItem(new AutoCompleteEntry("Instantiate From Representation...","ds","Instantiate From Representation...","",""));
textBox1.AddItem(new AutoCompleteEntry("Interactive tutorial","ds","Interactive tutorial","",""));
textBox1.AddItem(new AutoCompleteEntry("Internal Feature","ds","Internal Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Intersect Feature","ds","Intersect Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Intersect Terrain","ds","Intersect Terrain","",""));
textBox1.AddItem(new AutoCompleteEntry("Intersect…","ds","Intersect…","",""));
textBox1.AddItem(new AutoCompleteEntry("Intersecting Rectangle Selection Trap","ds","Intersecting Rectangle Selection Trap","",""));
textBox1.AddItem(new AutoCompleteEntry("Intersection","ds","Intersection","",""));
textBox1.AddItem(new AutoCompleteEntry("Invert Orientation","ds","Invert Orientation","",""));
textBox1.AddItem(new AutoCompleteEntry("Isolate","ds","Isolate","",""));
textBox1.AddItem(new AutoCompleteEntry("Isolate Text","ds","Isolate Text","",""));
textBox1.AddItem(new AutoCompleteEntry("Join","ds","Join","",""));
textBox1.AddItem(new AutoCompleteEntry("Join Terrains","ds","Join Terrains","",""));
textBox1.AddItem(new AutoCompleteEntry("Joystick","ds","Joystick","",""));
textBox1.AddItem(new AutoCompleteEntry("Knowledge Engineering Specification","ds","Knowledge Engineering Specification","",""));
textBox1.AddItem(new AutoCompleteEntry("Knowledge Inspector","ds","Knowledge Inspector","",""));
textBox1.AddItem(new AutoCompleteEntry("Knowledge Monitor","ds","Knowledge Monitor","",""));
textBox1.AddItem(new AutoCompleteEntry("Knowledge Pattern","ds","Knowledge Pattern","",""));
textBox1.AddItem(new AutoCompleteEntry("Knowledge Report","ds","Knowledge Report","",""));
textBox1.AddItem(new AutoCompleteEntry("LRE Check Viewer","ds","LRE Check Viewer","",""));
textBox1.AddItem(new AutoCompleteEntry("Language Browser","ds","Language Browser","",""));
textBox1.AddItem(new AutoCompleteEntry("Law","ds","Law","",""));
textBox1.AddItem(new AutoCompleteEntry("Light Distance Analysis","ds","Light Distance Analysis","",""));
textBox1.AddItem(new AutoCompleteEntry("Lighting...","ds","Lighting...","",""));
textBox1.AddItem(new AutoCompleteEntry("Line","ds","Line","",""));
textBox1.AddItem(new AutoCompleteEntry("Lineic Extrusion","ds","Lineic Extrusion","",""));
textBox1.AddItem(new AutoCompleteEntry("Link Dynamic Cameras","ds","Link Dynamic Cameras","",""));
textBox1.AddItem(new AutoCompleteEntry("Link Spreadsheet","ds","Link Spreadsheet","",""));
textBox1.AddItem(new AutoCompleteEntry("Link Static Cameras","ds","Link Static Cameras","",""));
textBox1.AddItem(new AutoCompleteEntry("Links 2 Relations...","ds","Links 2 Relations...","",""));
textBox1.AddItem(new AutoCompleteEntry("List","ds","List","",""));
textBox1.AddItem(new AutoCompleteEntry("Local Save","ds","Local Save","",""));
textBox1.AddItem(new AutoCompleteEntry("Local Update","ds","Local Update","",""));
textBox1.AddItem(new AutoCompleteEntry("Local work","ds","Local work","",""));
textBox1.AddItem(new AutoCompleteEntry("Lock Parameter","ds","Lock Parameter","",""));
textBox1.AddItem(new AutoCompleteEntry("Look At","ds","Look At","",""));
textBox1.AddItem(new AutoCompleteEntry("Macro libraries..,","ds","Macro libraries..,","",""));
textBox1.AddItem(new AutoCompleteEntry("Macros...","ds","Macros...","",""));
textBox1.AddItem(new AutoCompleteEntry("Magic Window","ds","Magic Window","",""));
textBox1.AddItem(new AutoCompleteEntry("Magnifier Overview","ds","Magnifier Overview","",""));
textBox1.AddItem(new AutoCompleteEntry("Magnifier...","ds","Magnifier...","",""));
textBox1.AddItem(new AutoCompleteEntry("Manage","ds","Manage","",""));
textBox1.AddItem(new AutoCompleteEntry("Manual","ds","Manual","",""));
textBox1.AddItem(new AutoCompleteEntry("Manual Natural Surface","ds","Manual Natural Surface","",""));
textBox1.AddItem(new AutoCompleteEntry("Manual Update mode","ds","Manual Update mode","",""));
textBox1.AddItem(new AutoCompleteEntry("Massive UnReserve...","ds","Massive UnReserve...","",""));
textBox1.AddItem(new AutoCompleteEntry("Material Browser","ds","Material Browser","",""));
textBox1.AddItem(new AutoCompleteEntry("Mean Dimensions","ds","Mean Dimensions","",""));
textBox1.AddItem(new AutoCompleteEntry("Measure Between","ds","Measure Between","",""));
textBox1.AddItem(new AutoCompleteEntry("Measure Item","ds","Measure Item","",""));
textBox1.AddItem(new AutoCompleteEntry("Mechanical Interface Attributes Display","ds","Mechanical Interface Attributes Display","",""));
textBox1.AddItem(new AutoCompleteEntry("Mechanical Interface Creation","ds","Mechanical Interface Creation","",""));
textBox1.AddItem(new AutoCompleteEntry("Mechanical Interface Instantiation","ds","Mechanical Interface Instantiation","",""));
textBox1.AddItem(new AutoCompleteEntry("Mechanical Interface Template Creation","ds","Mechanical Interface Template Creation","",""));
textBox1.AddItem(new AutoCompleteEntry("Mechanical Interfaces Compatibility Check","ds","Mechanical Interfaces Compatibility Check","",""));
textBox1.AddItem(new AutoCompleteEntry("Mechanical Interfaces Reveal","ds","Mechanical Interfaces Reveal","",""));
textBox1.AddItem(new AutoCompleteEntry("Menu Bar","ds","Menu Bar","",""));
textBox1.AddItem(new AutoCompleteEntry("Mesh Offset..","ds","Mesh Offset..","",""));
textBox1.AddItem(new AutoCompleteEntry("Message Log","ds","Message Log","",""));
textBox1.AddItem(new AutoCompleteEntry("Minimap Display","ds","Minimap Display","",""));
textBox1.AddItem(new AutoCompleteEntry("Mirror","ds","Mirror","",""));
textBox1.AddItem(new AutoCompleteEntry("MmrCheck","ds","MmrCheck","",""));
textBox1.AddItem(new AutoCompleteEntry("Morph Terrain","ds","Morph Terrain","",""));
textBox1.AddItem(new AutoCompleteEntry("Multi Select","ds","Multi Select","",""));
textBox1.AddItem(new AutoCompleteEntry("Multi-Sections Surface","ds","Multi-Sections Surface","",""));
textBox1.AddItem(new AutoCompleteEntry("Multi-Sections Volume","ds","Multi-Sections Volume","",""));
textBox1.AddItem(new AutoCompleteEntry("Multi-View","ds","Multi-View","",""));
textBox1.AddItem(new AutoCompleteEntry("Multi-View Customization...","ds","Multi-View Customization...","",""));
textBox1.AddItem(new AutoCompleteEntry("Multi-section Slice","ds","Multi-section Slice","",""));
textBox1.AddItem(new AutoCompleteEntry("Multi-sections Solid","ds","Multi-sections Solid","",""));
textBox1.AddItem(new AutoCompleteEntry("My Content","ds","My Content","",""));
textBox1.AddItem(new AutoCompleteEntry("My Profile","ds","My Profile","",""));
textBox1.AddItem(new AutoCompleteEntry("My Recent Content","ds","My Recent Content","",""));
textBox1.AddItem(new AutoCompleteEntry("My Session information","ds","My Session information","",""));
textBox1.AddItem(new AutoCompleteEntry("My Status","ds","My Status","",""));
textBox1.AddItem(new AutoCompleteEntry("Natural Shape options","ds","Natural Shape options","",""));
textBox1.AddItem(new AutoCompleteEntry("Natural Surface","ds","Natural Surface","",""));
textBox1.AddItem(new AutoCompleteEntry("Navigation...","ds","Navigation...","",""));
textBox1.AddItem(new AutoCompleteEntry("Near / Far","ds","Near / Far","",""));
textBox1.AddItem(new AutoCompleteEntry("Network Statistics","ds","Network Statistics","",""));
textBox1.AddItem(new AutoCompleteEntry("New Content Preferences...","ds","New Content Preferences...","",""));
textBox1.AddItem(new AutoCompleteEntry("New Evolution...","ds","New Evolution...","",""));
textBox1.AddItem(new AutoCompleteEntry("New Horizontal Tab Group","ds","New Horizontal Tab Group","",""));
textBox1.AddItem(new AutoCompleteEntry("New Minor Revision from equivalent Content...","ds","New Minor Revision from equivalent Content...","",""));
textBox1.AddItem(new AutoCompleteEntry("New Minor Revision...","ds","New Minor Revision...","",""));
textBox1.AddItem(new AutoCompleteEntry("New Preferences","ds","New Preferences","",""));
textBox1.AddItem(new AutoCompleteEntry("New Revision from...","ds","New Revision from...","",""));
textBox1.AddItem(new AutoCompleteEntry("New Revision...","ds","New Revision...","",""));
textBox1.AddItem(new AutoCompleteEntry("New Vertical Tab Group","ds","New Vertical Tab Group","",""));
textBox1.AddItem(new AutoCompleteEntry("New Window","ds","New Window","",""));
textBox1.AddItem(new AutoCompleteEntry("Next","ds","Next","",""));
textBox1.AddItem(new AutoCompleteEntry("Next View","ds","Next View","",""));
textBox1.AddItem(new AutoCompleteEntry("No (ink","ds","No (ink","",""));
textBox1.AddItem(new AutoCompleteEntry("No iV Stereoscopy","ds","No iV Stereoscopy","",""));
textBox1.AddItem(new AutoCompleteEntry("Normal View","ds","Normal View","",""));
textBox1.AddItem(new AutoCompleteEntry("Normals","ds","Normals","",""));
textBox1.AddItem(new AutoCompleteEntry("Notifications","ds","Notifications","",""));
textBox1.AddItem(new AutoCompleteEntry("CDT Recording","ds","CDT Recording","",""));
textBox1.AddItem(new AutoCompleteEntry("Object Extraction","ds","Object Extraction","",""));
textBox1.AddItem(new AutoCompleteEntry("Object Properties","ds","Object Properties","",""));
textBox1.AddItem(new AutoCompleteEntry("Object Repetition","ds","Object Repetition","",""));
textBox1.AddItem(new AutoCompleteEntry("Offset","ds","Offset","",""));
textBox1.AddItem(new AutoCompleteEntry("Offset Section View/Section Cut","ds","Offset Section View/Section Cut","",""));
textBox1.AddItem(new AutoCompleteEntry("OnePart Search","ds","OnePart Search","",""));
textBox1.AddItem(new AutoCompleteEntry("Online","ds","Online","",""));
textBox1.AddItem(new AutoCompleteEntry("Only Current Body","ds","Only Current Body","",""));
textBox1.AddItem(new AutoCompleteEntry("Only Current Operated Solid","ds","Only Current Operated Solid","",""));
textBox1.AddItem(new AutoCompleteEntry("Open Advanced...","ds","Open Advanced...","",""));
textBox1.AddItem(new AutoCompleteEntry("Open Concept Explorer","ds","Open Concept Explorer","",""));
textBox1.AddItem(new AutoCompleteEntry("Open OSM Map","ds","Open OSM Map","",""));
textBox1.AddItem(new AutoCompleteEntry("Open Pointed Representation","ds","Open Pointed Representation","",""));
textBox1.AddItem(new AutoCompleteEntry("Open Profile","ds","Open Profile","",""));
textBox1.AddItem(new AutoCompleteEntry("Open Relative Comparison Window","ds","Open Relative Comparison Window","",""));
textBox1.AddItem(new AutoCompleteEntry("Open for Edit","ds","Open for Edit","",""));
textBox1.AddItem(new AutoCompleteEntry("Open in Read-Only...","ds","Open in Read-Only...","",""));
textBox1.AddItem(new AutoCompleteEntry("Open...","ds","Open...","",""));
textBox1.AddItem(new AutoCompleteEntry("Ordered Geometrical Set","ds","Ordered Geometrical Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Ordered Geometrical Set..","ds","Ordered Geometrical Set..","",""));
textBox1.AddItem(new AutoCompleteEntry("Outside Intersecting Rectangle Selection Trap","ds","Outside Intersecting Rectangle Selection Trap","",""));
textBox1.AddItem(new AutoCompleteEntry("Outside Rectangle Selection Trap","ds","Outside Rectangle Selection Trap","",""));
textBox1.AddItem(new AutoCompleteEntry("PCS Statistics","ds","PCS Statistics","",""));
textBox1.AddItem(new AutoCompleteEntry("PLM Import","ds","PLM Import","",""));
textBox1.AddItem(new AutoCompleteEntry("PIM Solve","ds","PIM Solve","",""));
textBox1.AddItem(new AutoCompleteEntry("PLM Solve with Selection","ds","PLM Solve with Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Pad","ds","Pad","",""));
textBox1.AddItem(new AutoCompleteEntry("Painter","ds","Painter","",""));
textBox1.AddItem(new AutoCompleteEntry("Pan","ds","Pan","",""));
textBox1.AddItem(new AutoCompleteEntry("Parallel","ds","Parallel","",""));
textBox1.AddItem(new AutoCompleteEntry("Parallel Curve","ds","Parallel Curve","",""));
textBox1.AddItem(new AutoCompleteEntry("Parallet\\Perspective","ds","Parallet\\Perspective","",""));
textBox1.AddItem(new AutoCompleteEntry("Parameter Explorer","ds","Parameter Explorer","",""));
textBox1.AddItem(new AutoCompleteEntry("Parameter Set","ds","Parameter Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Parameterization Analysis..","ds","Parameterization Analysis..","",""));
textBox1.AddItem(new AutoCompleteEntry("Parents/Children...","ds","Parents/Children...","",""));
textBox1.AddItem(new AutoCompleteEntry("Paste","ds","Paste","",""));
textBox1.AddItem(new AutoCompleteEntry("Paste Special","ds","Paste Special","",""));
textBox1.AddItem(new AutoCompleteEntry("Pattern","ds","Pattern","",""));
textBox1.AddItem(new AutoCompleteEntry("Performance gauges","ds","Performance gauges","",""));
textBox1.AddItem(new AutoCompleteEntry("Perpendicular View","ds","Perpendicular View","",""));
textBox1.AddItem(new AutoCompleteEntry("Perspective","ds","Perspective","",""));
textBox1.AddItem(new AutoCompleteEntry("Pick materials","ds","Pick materials","",""));
textBox1.AddItem(new AutoCompleteEntry("Planar Sections","ds","Planar Sections","",""));
textBox1.AddItem(new AutoCompleteEntry("Plane","ds","Plane","",""));
textBox1.AddItem(new AutoCompleteEntry("Plane Selection","ds","Plane Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Plane System...","ds","Plane System...","",""));
textBox1.AddItem(new AutoCompleteEntry("Planes Between","ds","Planes Between","",""));
textBox1.AddItem(new AutoCompleteEntry("Pocket","ds","Pocket","",""));
textBox1.AddItem(new AutoCompleteEntry("Point","ds","Point","",""));
textBox1.AddItem(new AutoCompleteEntry("Point Filter","ds","Point Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Points and Planes Repetition","ds","Points and Planes Repetition","",""));
textBox1.AddItem(new AutoCompleteEntry("Polygon","ds","Polygon","",""));
textBox1.AddItem(new AutoCompleteEntry("Polygon Selection Trap","ds","Polygon Selection Trap","",""));
textBox1.AddItem(new AutoCompleteEntry("Polyline","ds","Polyline","",""));
textBox1.AddItem(new AutoCompleteEntry("Positioned Sketch...","ds","Positioned Sketch...","",""));
textBox1.AddItem(new AutoCompleteEntry("Power Copy","ds","Power Copy","",""));
textBox1.AddItem(new AutoCompleteEntry("PowerCopy Creation...","ds","PowerCopy Creation...","",""));
textBox1.AddItem(new AutoCompleteEntry("Preferences","ds","Preferences","",""));
textBox1.AddItem(new AutoCompleteEntry("Preferences...","ds","Preferences...","",""));
textBox1.AddItem(new AutoCompleteEntry("Preview","ds","Preview","",""));
textBox1.AddItem(new AutoCompleteEntry("Previous View","ds","Previous View","",""));
textBox1.AddItem(new AutoCompleteEntry("Primitive Recognition","ds","Primitive Recognition","",""));
textBox1.AddItem(new AutoCompleteEntry("Print","ds","Print","",""));
textBox1.AddItem(new AutoCompleteEntry("Print...","ds","Print...","",""));
textBox1.AddItem(new AutoCompleteEntry("Product Attributes","ds","Product Attributes","",""));
textBox1.AddItem(new AutoCompleteEntry("Product Table","ds","Product Table","",""));
textBox1.AddItem(new AutoCompleteEntry("Products Selection","ds","Products Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Profile","ds","Profile","",""));
textBox1.AddItem(new AutoCompleteEntry("Projection","ds","Projection","",""));
textBox1.AddItem(new AutoCompleteEntry("Properties","ds","Properties","",""));
textBox1.AddItem(new AutoCompleteEntry("Protected Feature","ds","Protected Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Publication...","ds","Publication...","",""));
textBox1.AddItem(new AutoCompleteEntry("Publications Selection","ds","Publications Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Publish","ds","Publish","",""));
textBox1.AddItem(new AutoCompleteEntry("Quality 2 Speed...","ds","Quality 2 Speed...","",""));
textBox1.AddItem(new AutoCompleteEntry("Query Object Links...","ds","Query Object Links...","",""));
textBox1.AddItem(new AutoCompleteEntry("Quick Switch","ds","Quick Switch","",""));
textBox1.AddItem(new AutoCompleteEntry("Radius Centred Circle","ds","Radius Centred Circle","",""));
textBox1.AddItem(new AutoCompleteEntry("Reaction","ds","Reaction","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar 3D Envelope","ds","Rebar 3D Envelope","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar 3D Extraction","ds","Rebar 3D Extraction","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar 3D Integration","ds","Rebar 3D Integration","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar Creation","ds","Rebar Creation","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar Excel Report","ds","Rebar Excel Report","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar Html Report","ds","Rebar Html Report","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar Interference","ds","Rebar Interference","",""));
textBox1.AddItem(new AutoCompleteEntry("Rebar Manipulation","ds","Rebar Manipulation","",""));
textBox1.AddItem(new AutoCompleteEntry("Recenter","ds","Recenter","",""));
textBox1.AddItem(new AutoCompleteEntry("Recompute Inertia","ds","Recompute Inertia","",""));
textBox1.AddItem(new AutoCompleteEntry("Record Infos","ds","Record Infos","",""));
textBox1.AddItem(new AutoCompleteEntry("Rectangle","ds","Rectangle","",""));
textBox1.AddItem(new AutoCompleteEntry("Rectangle Selection Trap","ds","Rectangle Selection Trap","",""));
textBox1.AddItem(new AutoCompleteEntry("Rectangular Pattern","ds","Rectangular Pattern","",""));
textBox1.AddItem(new AutoCompleteEntry("Rectangular Pattern...","ds","Rectangular Pattern...","",""));
textBox1.AddItem(new AutoCompleteEntry("Redo","ds","Redo","",""));
textBox1.AddItem(new AutoCompleteEntry("Refine Terrain","ds","Refine Terrain","",""));
textBox1.AddItem(new AutoCompleteEntry("Ref rame On","ds","Ref rame On","",""));
textBox1.AddItem(new AutoCompleteEntry("Reframe On Work Object","ds","Reframe On Work Object","",""));
textBox1.AddItem(new AutoCompleteEntry("Refresh","ds","Refresh","",""));
textBox1.AddItem(new AutoCompleteEntry("Reinforcement","ds","Reinforcement","",""));
textBox1.AddItem(new AutoCompleteEntry("Relation Set","ds","Relation Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Relational Explorer","ds","Relational Explorer","",""));
textBox1.AddItem(new AutoCompleteEntry("Remove Face","ds","Remove Face","",""));
textBox1.AddItem(new AutoCompleteEntry("Remove Feature","ds","Remove Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Remove Lump...","ds","Remove Lump...","",""));
textBox1.AddItem(new AutoCompleteEntry("Remove a Local Area","ds","Remove a Local Area","",""));
textBox1.AddItem(new AutoCompleteEntry("Remove presentation from active 3D Shape","ds","Remove presentation from active 3D Shape","",""));
textBox1.AddItem(new AutoCompleteEntry("Remove...","ds","Remove...","",""));
textBox1.AddItem(new AutoCompleteEntry("Removed Multi.sections Solid","ds","Removed Multi.sections Solid","",""));
textBox1.AddItem(new AutoCompleteEntry("Rename Parameter","ds","Rename Parameter","",""));
textBox1.AddItem(new AutoCompleteEntry("Rename a Publication","ds","Rename a Publication","",""));
textBox1.AddItem(new AutoCompleteEntry("Rendering Tools","ds","Rendering Tools","",""));
textBox1.AddItem(new AutoCompleteEntry("Reorder","ds","Reorder","",""));
textBox1.AddItem(new AutoCompleteEntry("Reorder Children","ds","Reorder Children","",""));
textBox1.AddItem(new AutoCompleteEntry("Reorder...","ds","Reorder...","",""));
textBox1.AddItem(new AutoCompleteEntry("Repeat","ds","Repeat","",""));
textBox1.AddItem(new AutoCompleteEntry("Replace Face","ds","Replace Face","",""));
textBox1.AddItem(new AutoCompleteEntry("Replace where used...","ds","Replace where used...","",""));
textBox1.AddItem(new AutoCompleteEntry("Replace...","ds","Replace...","",""));
textBox1.AddItem(new AutoCompleteEntry("Report","ds","Report","",""));
textBox1.AddItem(new AutoCompleteEntry("Report Definition","ds","Report Definition","",""));
textBox1.AddItem(new AutoCompleteEntry("Representations Not Selectable","ds","Representations Not Selectable","",""));
textBox1.AddItem(new AutoCompleteEntry("Representations Selection","ds","Representations Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Reserve...","ds","Reserve...","",""));
textBox1.AddItem(new AutoCompleteEntry("Reset Properties","ds","Reset Properties","",""));
textBox1.AddItem(new AutoCompleteEntry("Reset Robot","ds","Reset Robot","",""));
textBox1.AddItem(new AutoCompleteEntry("Reset Selection Filters","ds","Reset Selection Filters","",""));
textBox1.AddItem(new AutoCompleteEntry("Reset deleted Technological Results...","ds","Reset deleted Technological Results...","",""));
textBox1.AddItem(new AutoCompleteEntry("Reset surface colors to solid","ds","Reset surface colors to solid","",""));
textBox1.AddItem(new AutoCompleteEntry("Resize Infinite Elements","ds","Resize Infinite Elements","",""));
textBox1.AddItem(new AutoCompleteEntry("Resource Table","ds","Resource Table","",""));
textBox1.AddItem(new AutoCompleteEntry("Restore Iteration...","ds","Restore Iteration...","",""));
textBox1.AddItem(new AutoCompleteEntry("Reverse Normal","ds","Reverse Normal","",""));
textBox1.AddItem(new AutoCompleteEntry("Revolve","ds","Revolve","",""));
textBox1.AddItem(new AutoCompleteEntry("Rib","ds","Rib","",""));
textBox1.AddItem(new AutoCompleteEntry("Robot","ds","Robot","",""));
textBox1.AddItem(new AutoCompleteEntry("Rolling Offset","ds","Rolling Offset","",""));
textBox1.AddItem(new AutoCompleteEntry("Rotate","ds","Rotate","",""));
textBox1.AddItem(new AutoCompleteEntry("Rotate around axis","ds","Rotate around axis","",""));
textBox1.AddItem(new AutoCompleteEntry("Rotation","ds","Rotation","",""));
textBox1.AddItem(new AutoCompleteEntry("Rule","ds","Rule","",""));
textBox1.AddItem(new AutoCompleteEntry("Run","ds","Run","",""));
textBox1.AddItem(new AutoCompleteEntry("STL File...","ds","STL File...","",""));
textBox1.AddItem(new AutoCompleteEntry("Save","ds","Save","",""));
textBox1.AddItem(new AutoCompleteEntry("Save Ml...","ds","Save Ml...","",""));
textBox1.AddItem(new AutoCompleteEntry("Save with Options...","ds","Save with Options...","",""));
textBox1.AddItem(new AutoCompleteEntry("Scale Planes","ds","Scale Planes","",""));
textBox1.AddItem(new AutoCompleteEntry("Scahng","ds","Scahng","",""));
textBox1.AddItem(new AutoCompleteEntry("Scaling","ds","Scaling","",""));
textBox1.AddItem(new AutoCompleteEntry("Scan or Define In Work Object..","ds","Scan or Define In Work Object..","",""));
textBox1.AddItem(new AutoCompleteEntry("Search","ds","Search","",""));
textBox1.AddItem(new AutoCompleteEntry("Search criteria,.,","ds","Search criteria,.,","",""));
textBox1.AddItem(new AutoCompleteEntry("Section Cut /Annotation Plane","ds","Section Cut /Annotation Plane","",""));
textBox1.AddItem(new AutoCompleteEntry("Section View/Annotation Plane","ds","Section View/Annotation Plane","",""));
textBox1.AddItem(new AutoCompleteEntry("Sections with Labels","ds","Sections with Labels","",""));
textBox1.AddItem(new AutoCompleteEntry("See through","ds","See through","",""));
textBox1.AddItem(new AutoCompleteEntry("Select","ds","Select","",""));
textBox1.AddItem(new AutoCompleteEntry("Select All","ds","Select All","",""));
textBox1.AddItem(new AutoCompleteEntry("Select Views/Annotation Plane","ds","Select Views/Annotation Plane","",""));
textBox1.AddItem(new AutoCompleteEntry("Selected Elements","ds","Selected Elements","",""));
textBox1.AddItem(new AutoCompleteEntry("Selected object for impacts analysis","ds","Selected object for impacts analysis","",""));
textBox1.AddItem(new AutoCompleteEntry("Selection Sets...","ds","Selection Sets...","",""));
textBox1.AddItem(new AutoCompleteEntry("Selection Trap above Geometry","ds","Selection Trap above Geometry","",""));
textBox1.AddItem(new AutoCompleteEntry("Semantic Geometry Tagger","ds","Semantic Geometry Tagger","",""));
textBox1.AddItem(new AutoCompleteEntry("Semantic Painter","ds","Semantic Painter","",""));
textBox1.AddItem(new AutoCompleteEntry("Set As Current","ds","Set As Current","",""));
textBox1.AddItem(new AutoCompleteEntry("Set As Not Current","ds","Set As Not Current","",""));
textBox1.AddItem(new AutoCompleteEntry("Set Current","ds","Set Current","",""));
textBox1.AddItem(new AutoCompleteEntry("Set of Equations","ds","Set of Equations","",""));
textBox1.AddItem(new AutoCompleteEntry("Shading","ds","Shading","",""));
textBox1.AddItem(new AutoCompleteEntry("Shading with Edges","ds","Shading with Edges","",""));
textBox1.AddItem(new AutoCompleteEntry("Shading with Edges and Hidden Edges","ds","Shading with Edges and Hidden Edges","",""));
textBox1.AddItem(new AutoCompleteEntry("Shading with Edges without Smooth Edges","ds","Shading with Edges without Smooth Edges","",""));
textBox1.AddItem(new AutoCompleteEntry("Shading with Material","ds","Shading with Material","",""));
textBox1.AddItem(new AutoCompleteEntry("Shading with Material and Edges","ds","Shading with Material and Edges","",""));
textBox1.AddItem(new AutoCompleteEntry("Shaft","ds","Shaft","",""));
textBox1.AddItem(new AutoCompleteEntry("Shape Fillet","ds","Shape Fillet","",""));
textBox1.AddItem(new AutoCompleteEntry("Share","ds","Share","",""));
textBox1.AddItem(new AutoCompleteEntry("Sheet Editor…","ds","Sheet Editor…","",""));
textBox1.AddItem(new AutoCompleteEntry("Shell","ds","Shell","",""));
textBox1.AddItem(new AutoCompleteEntry("Shell Properties","ds","Shell Properties","",""));
textBox1.AddItem(new AutoCompleteEntry("Shell...","ds","Shell...","",""));
textBox1.AddItem(new AutoCompleteEntry("Shellable Feature","ds","Shellable Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Show 3D Shape","ds","Show 3D Shape","",""));
textBox1.AddItem(new AutoCompleteEntry("Show 3D Tag features","ds","Show 3D Tag features","",""));
textBox1.AddItem(new AutoCompleteEntry("Show All","ds","Show All","",""));
textBox1.AddItem(new AutoCompleteEntry("Show All Component Specifications","ds","Show All Component Specifications","",""));
textBox1.AddItem(new AutoCompleteEntry("Show Components","ds","Show Components","",""));
textBox1.AddItem(new AutoCompleteEntry("Show Free Component Specifications","ds","Show Free Component Specifications","",""));
textBox1.AddItem(new AutoCompleteEntry("Show More Results","ds","Show More Results","",""));
textBox1.AddItem(new AutoCompleteEntry("Show in 3D","ds","Show in 3D","",""));
textBox1.AddItem(new AutoCompleteEntry("Sign In","ds","Sign In","",""));
textBox1.AddItem(new AutoCompleteEntry("Sketch","ds","Sketch","",""));
textBox1.AddItem(new AutoCompleteEntry("Sketch Primitives","ds","Sketch Primitives","",""));
textBox1.AddItem(new AutoCompleteEntry("Slot","ds","Slot","",""));
textBox1.AddItem(new AutoCompleteEntry("Smart Open...","ds","Smart Open...","",""));
textBox1.AddItem(new AutoCompleteEntry("Snap to point","ds","Snap to point","",""));
textBox1.AddItem(new AutoCompleteEntry("Solid Combine","ds","Solid Combine","",""));
textBox1.AddItem(new AutoCompleteEntry("Solid Functional Set","ds","Solid Functional Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Solve","ds","Solve","",""));
textBox1.AddItem(new AutoCompleteEntry("Sort","ds","Sort","",""));
textBox1.AddItem(new AutoCompleteEntry("Sphere","ds","Sphere","",""));
textBox1.AddItem(new AutoCompleteEntry("Spiral","ds","Spiral","",""));
textBox1.AddItem(new AutoCompleteEntry("Spline","ds","Spline","",""));
textBox1.AddItem(new AutoCompleteEntry("Split","ds","Split","",""));
textBox1.AddItem(new AutoCompleteEntry("Standards..,","ds","Standards..,","",""));
textBox1.AddItem(new AutoCompleteEntry("Start Recording...","ds","Start Recording...","",""));
textBox1.AddItem(new AutoCompleteEntry("Status Bar","ds","Status Bar","",""));
textBox1.AddItem(new AutoCompleteEntry("Stiffener","ds","Stiffener","",""));
textBox1.AddItem(new AutoCompleteEntry("Stop","ds","Stop","",""));
textBox1.AddItem(new AutoCompleteEntry("Stop Recording","ds","Stop Recording","",""));
textBox1.AddItem(new AutoCompleteEntry("Sub-Trees","ds","Sub-Trees","",""));
textBox1.AddItem(new AutoCompleteEntry("Surface Filter","ds","Surface Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Swap view/tree","ds","Swap view/tree","",""));
textBox1.AddItem(new AutoCompleteEntry("Swap visible space","ds","Swap visible space","",""));
textBox1.AddItem(new AutoCompleteEntry("Sweep","ds","Sweep","",""));
textBox1.AddItem(new AutoCompleteEntry("Switch To Geometrical Set","ds","Switch To Geometrical Set","",""));
textBox1.AddItem(new AutoCompleteEntry("Switch to Edition...","ds","Switch to Edition...","",""));
textBox1.AddItem(new AutoCompleteEntry("Switch to Read Only...","ds","Switch to Read Only...","",""));
textBox1.AddItem(new AutoCompleteEntry("Symmetry","ds","Symmetry","",""));
textBox1.AddItem(new AutoCompleteEntry("Synchronize","ds","Synchronize","",""));
textBox1.AddItem(new AutoCompleteEntry("Synchronize All","ds","Synchronize All","",""));
textBox1.AddItem(new AutoCompleteEntry("Tangent Arc","ds","Tangent Arc","",""));
textBox1.AddItem(new AutoCompleteEntry("Template Designer","ds","Template Designer","",""));
textBox1.AddItem(new AutoCompleteEntry("Terrain File","ds","Terrain File","",""));
textBox1.AddItem(new AutoCompleteEntry("Terrain Preparation","ds","Terrain Preparation","",""));
textBox1.AddItem(new AutoCompleteEntry("Tessellate","ds","Tessellate","",""));
textBox1.AddItem(new AutoCompleteEntry("Tessellation…","ds","Tessellation…","",""));
textBox1.AddItem(new AutoCompleteEntry("Text","ds","Text","",""));
textBox1.AddItem(new AutoCompleteEntry("Text Parallel To Screen","ds","Text Parallel To Screen","",""));
textBox1.AddItem(new AutoCompleteEntry("Text with Leader","ds","Text with Leader","",""));
textBox1.AddItem(new AutoCompleteEntry("Thick Surface","ds","Thick Surface","",""));
textBox1.AddItem(new AutoCompleteEntry("Thick Surface...","ds","Thick Surface...","",""));
textBox1.AddItem(new AutoCompleteEntry("Thickness","ds","Thickness","",""));
textBox1.AddItem(new AutoCompleteEntry("Three Points Arc","ds","Three Points Arc","",""));
textBox1.AddItem(new AutoCompleteEntry("Three Points Circle","ds","Three Points Circle","",""));
textBox1.AddItem(new AutoCompleteEntry("Thumbnails View","ds","Thumbnails View","",""));
textBox1.AddItem(new AutoCompleteEntry("Tile Horizontally","ds","Tile Horizontally","",""));
textBox1.AddItem(new AutoCompleteEntry("Tile Vertically","ds","Tile Vertically","",""));
textBox1.AddItem(new AutoCompleteEntry("Tiles View","ds","Tiles View","",""));
textBox1.AddItem(new AutoCompleteEntry("Trace","ds","Trace","",""));
textBox1.AddItem(new AutoCompleteEntry("Trace Blend","ds","Trace Blend","",""));
textBox1.AddItem(new AutoCompleteEntry("Trace Over","ds","Trace Over","",""));
textBox1.AddItem(new AutoCompleteEntry("Trace Pnmrtives","ds","Trace Pnmrtives","",""));
textBox1.AddItem(new AutoCompleteEntry("Transfer Ownership...","ds","Transfer Ownership...","",""));
textBox1.AddItem(new AutoCompleteEntry("Transfer To View/Annotation Plane","ds","Transfer To View/Annotation Plane","",""));
textBox1.AddItem(new AutoCompleteEntry("Transform","ds","Transform","",""));
textBox1.AddItem(new AutoCompleteEntry("Transform Rough To Sketch","ds","Transform Rough To Sketch","",""));
textBox1.AddItem(new AutoCompleteEntry("Transformation","ds","Transformation","",""));
textBox1.AddItem(new AutoCompleteEntry("Translate","ds","Translate","",""));
textBox1.AddItem(new AutoCompleteEntry("Translation","ds","Translation","",""));
textBox1.AddItem(new AutoCompleteEntry("Tree Background","ds","Tree Background","",""));
textBox1.AddItem(new AutoCompleteEntry("Tree Display","ds","Tree Display","",""));
textBox1.AddItem(new AutoCompleteEntry("Tree ()Yerv)ew","ds","Tree ()Yerv)ew","",""));
textBox1.AddItem(new AutoCompleteEntry("Tnangles count","ds","Tnangles count","",""));
textBox1.AddItem(new AutoCompleteEntry("Triangulate Surface","ds","Triangulate Surface","",""));
textBox1.AddItem(new AutoCompleteEntry("Trim","ds","Trim","",""));
textBox1.AddItem(new AutoCompleteEntry("Trim/Split","ds","Trim/Split","",""));
textBox1.AddItem(new AutoCompleteEntry("Turn Head","ds","Turn Head","",""));
textBox1.AddItem(new AutoCompleteEntry("Turn permanent","ds","Turn permanent","",""));
textBox1.AddItem(new AutoCompleteEntry("Tutorials","ds","Tutorials","",""));
textBox1.AddItem(new AutoCompleteEntry("Two Corners Rectangle","ds","Two Corners Rectangle","",""));
textBox1.AddItem(new AutoCompleteEntry("URLs & Comment","ds","URLs & Comment","",""));
textBox1.AddItem(new AutoCompleteEntry("URLs and Comment","ds","URLs and Comment","",""));
textBox1.AddItem(new AutoCompleteEntry("UV Parameterization","ds","UV Parameterization","",""));
textBox1.AddItem(new AutoCompleteEntry("Un Reserve...","ds","Un Reserve...","",""));
textBox1.AddItem(new AutoCompleteEntry("Undo","ds","Undo","",""));
textBox1.AddItem(new AutoCompleteEntry("Undo/Redo Overview","ds","Undo/Redo Overview","",""));
textBox1.AddItem(new AutoCompleteEntry("Unfold","ds","Unfold","",""));
textBox1.AddItem(new AutoCompleteEntry("Unfreeze","ds","Unfreeze","",""));
textBox1.AddItem(new AutoCompleteEntry("Unload","ds","Unload","",""));
textBox1.AddItem(new AutoCompleteEntry("Unlock Parameters","ds","Unlock Parameters","",""));
textBox1.AddItem(new AutoCompleteEntry("Unset Current","ds","Unset Current","",""));
textBox1.AddItem(new AutoCompleteEntry("Update","ds","Update","",""));
textBox1.AddItem(new AutoCompleteEntry("Upgrade","ds","Upgrade","",""));
textBox1.AddItem(new AutoCompleteEntry("User Companion","ds","User Companion","",""));
textBox1.AddItem(new AutoCompleteEntry("User Feature","ds","User Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("User Feature Debug","ds","User Feature Debug","",""));
textBox1.AddItem(new AutoCompleteEntry("User Feature Link Manager","ds","User Feature Link Manager","",""));
textBox1.AddItem(new AutoCompleteEntry("User Pattern","ds","User Pattern","",""));
textBox1.AddItem(new AutoCompleteEntry("User Pattern...","ds","User Pattern...","",""));
textBox1.AddItem(new AutoCompleteEntry("Users Guides","ds","Users Guides","",""));
textBox1.AddItem(new AutoCompleteEntry("UserFeature Creation.,.","ds","UserFeature Creation.,.","",""));
textBox1.AddItem(new AutoCompleteEntry("Utility...","ds","Utility...","",""));
textBox1.AddItem(new AutoCompleteEntry("VR Button Customization","ds","VR Button Customization","",""));
textBox1.AddItem(new AutoCompleteEntry("VR Monitor","ds","VR Monitor","",""));
textBox1.AddItem(new AutoCompleteEntry("Vertical Alignment","ds","Vertical Alignment","",""));
textBox1.AddItem(new AutoCompleteEntry("Video...","ds","Video...","",""));
textBox1.AddItem(new AutoCompleteEntry("View Angle","ds","View Angle","",""));
textBox1.AddItem(new AutoCompleteEntry("View Feature Structure","ds","View Feature Structure","",""));
textBox1.AddItem(new AutoCompleteEntry("View From Reference","ds","View From Reference","",""));
textBox1.AddItem(new AutoCompleteEntry("View Selection","ds","View Selection","",""));
textBox1.AddItem(new AutoCompleteEntry("View Selector","ds","View Selector","",""));
textBox1.AddItem(new AutoCompleteEntry("Viewing Zone","ds","Viewing Zone","",""));
textBox1.AddItem(new AutoCompleteEntry("Viewpoint Snapping","ds","Viewpoint Snapping","",""));
textBox1.AddItem(new AutoCompleteEntry("Views…","ds","Views…","",""));
textBox1.AddItem(new AutoCompleteEntry("Visu Assistant","ds","Visu Assistant","",""));
textBox1.AddItem(new AutoCompleteEntry("Visual Basic Action","ds","Visual Basic Action","",""));
textBox1.AddItem(new AutoCompleteEntry("Visual Basic Editor...","ds","Visual Basic Editor...","",""));
textBox1.AddItem(new AutoCompleteEntry("Visual Quality...","ds","Visual Quality...","",""));
textBox1.AddItem(new AutoCompleteEntry("Visual Studio Tools for Applications","ds","Visual Studio Tools for Applications","",""));
textBox1.AddItem(new AutoCompleteEntry("Visualization Filters...","ds","Visualization Filters...","",""));
textBox1.AddItem(new AutoCompleteEntry("Visualization Sectioning","ds","Visualization Sectioning","",""));
textBox1.AddItem(new AutoCompleteEntry("Visualize 3D","ds","Visualize 3D","",""));
textBox1.AddItem(new AutoCompleteEntry("Volume Extrude","ds","Volume Extrude","",""));
textBox1.AddItem(new AutoCompleteEntry("Volume Filter","ds","Volume Filter","",""));
textBox1.AddItem(new AutoCompleteEntry("Volume Revolve","ds","Volume Revolve","",""));
textBox1.AddItem(new AutoCompleteEntry("Volume Sweep","ds","Volume Sweep","",""));
textBox1.AddItem(new AutoCompleteEntry("Walk Around","ds","Walk Around","",""));
textBox1.AddItem(new AutoCompleteEntry("Walk Through","ds","Walk Through","",""));
textBox1.AddItem(new AutoCompleteEntry("Weld Feature","ds","Weld Feature","",""));
textBox1.AddItem(new AutoCompleteEntry("Whats This?","ds","Whats This?","",""));
textBox1.AddItem(new AutoCompleteEntry("Wireframe","ds","Wireframe","",""));
textBox1.AddItem(new AutoCompleteEntry("Work Offline","ds","Work Offline","",""));
textBox1.AddItem(new AutoCompleteEntry("Work On Support selection","ds","Work On Support selection","",""));
textBox1.AddItem(new AutoCompleteEntry("Work on Support","ds","Work on Support","",""));
textBox1.AddItem(new AutoCompleteEntry("Working Supports Activity","ds","Working Supports Activity","",""));
textBox1.AddItem(new AutoCompleteEntry("XPDM...","ds","XPDM...","",""));
textBox1.AddItem(new AutoCompleteEntry("Zoom Area","ds","Zoom Area","",""));
textBox1.AddItem(new AutoCompleteEntry("Zoom In","ds","Zoom In","",""));
textBox1.AddItem(new AutoCompleteEntry("Zoom In Out","ds","Zoom In Out","",""));
textBox1.AddItem(new AutoCompleteEntry("Zoom Out","ds","Zoom Out","",""));
textBox1.AddItem(new AutoCompleteEntry("iV Active or Passive Stereoscopy","ds","iV Active or Passive Stereoscopy","",""));
textBox1.AddItem(new AutoCompleteEntry("iV Color Anaglyph Stereoscopy","ds","iV Color Anaglyph Stereoscopy","",""));
textBox1.AddItem(new AutoCompleteEntry("iV Grey Anaglyph Stereoscopy","ds","iV Grey Anaglyph Stereoscopy","",""));
textBox1.AddItem(new AutoCompleteEntry("V Half-Color Anaglyph Stereoscopy","ds","V Half-Color Anaglyph Stereoscopy","",""));
textBox1.AddItem(new AutoCompleteEntry("iV Optimized Anaglyph Stereoscopy","ds","iV Optimized Anaglyph Stereoscopy","",""));
textBox1.AddItem(new AutoCompleteEntry("iV Stereoscopy","ds","iV Stereoscopy","",""));



        }

     
     

    }
    
}
