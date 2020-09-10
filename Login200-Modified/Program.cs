using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login200_Modified
{
    public delegate void InputHandler(State state, String args);
    public delegate void StateObserver(State state); // view implements this
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CredentialsMModified model = new CredentialsMModified();
            ControllerModified controller = new ControllerModified(model);
            LoginModifiedForm view = new LoginModifiedForm(controller.handleEvents); // Needs no () after handleEvents, as strange as that feels
            controller.registerObs(view.DisplayState); // This syntax is going to take a while to get used to

            Application.Run(view);
        }
    }
}
