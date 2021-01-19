/* TODO ERROR: Skipped IfDirectiveTrivia */
using System.Diagnostics;
using System.Web;
using Microsoft.VisualBasic;

namespace T_Train_Front_office.My
{
    /// <summary>
    /// Module used to define the properties that are available in the My Namespace for Web projects.
    /// </summary>
    /// <remarks></remarks>
    [HideModuleName()]
    static class MyWebExtension
    {
        private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Devices.ServerComputer> s_Computer = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Devices.ServerComputer>();
        private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.WebUser> s_User = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.WebUser>();
        private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Logging.AspLog> s_Log = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Logging.AspLog>();
        /// <summary>
        /// Returns information about the host computer.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal static Microsoft.VisualBasic.Devices.ServerComputer Computer
        {
            get
            {
                return s_Computer.GetInstance;
            }
        }
        /// <summary>
        /// Returns information for the current Web user.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal static Microsoft.VisualBasic.ApplicationServices.WebUser User
        {
            get
            {
                return s_User.GetInstance;
            }
        }
        /// <summary>
        /// Returns Request object.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [System.ComponentModel.Design.HelpKeyword("My.Request")]
        internal static HttpRequest Request
        {
            [DebuggerHidden()]
            get
            {
                var CurrentContext = HttpContext.Current;
                if (CurrentContext is object)
                {
                    return CurrentContext.Request;
                }

                return null;
            }
        }
        /// <summary>
        /// Returns Response object.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [System.ComponentModel.Design.HelpKeyword("My.Response")]
        internal static HttpResponse Response
        {
            [DebuggerHidden()]
            get
            {
                var CurrentContext = HttpContext.Current;
                if (CurrentContext is object)
                {
                    return CurrentContext.Response;
                }

                return null;
            }
        }
        /// <summary>
        /// Returns the Asp log object.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal static Microsoft.VisualBasic.Logging.AspLog Log
        {
            get
            {
                return s_Log.GetInstance;
            }
        }
    }
}

/* TODO ERROR: Skipped EndIfDirectiveTrivia */