using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.ImageProcessorFactory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilterWinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var imageProcessorFactory = new ImageProcessorFactory();
            var stack = new Stack<IBitmapEffectCommand>();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ImageFilterView(stack, imageProcessorFactory));
        }
    }
}
