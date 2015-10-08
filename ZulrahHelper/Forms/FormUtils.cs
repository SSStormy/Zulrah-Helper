using System.Windows.Forms;

namespace ZulrahHelper.Forms
{
    public class FormUtils
    {
        /// <summary>
        /// Disables resizing of given form.
        /// </summary>
        /// <param name="fm">The form that wont be able to be resized.</param>
        public static void DisableResizing(Form fm)
        {
            fm.FormBorderStyle = FormBorderStyle.FixedSingle;
            fm.MaximizeBox = false;
            fm.MinimizeBox = false;
        }
    }
}
