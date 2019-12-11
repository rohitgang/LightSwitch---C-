using System;
using System.Windows.Forms;
namespace LightSwitch{
    public partial class LightSwitch : Form
    {
        public LightSwitch()
        {
            InitializeComponent();
        }
        static void Main(){
    	     Application.EnableVisualStyles();
    	     Application.SetCompatibleTextRenderingDefault(false);
	     Application.Run(new LightSwitch());
        }
     }
}

