using System.Windows.Forms;
using System;

namespace MusicStatus
{
    public class MusicStatusAppContext : ApplicationContext
    {
        #region Private Members
        private System.ComponentModel.IContainer mComponents;
        public NotifyIcon mNotifyIcon;
        private ContextMenuStrip mContextMenu;
        private ToolStripMenuItem mDisplayForm;
        private ToolStripMenuItem mExitApplication;
        #endregion

        public MusicStatusAppContext()
        {
            //Instantiate the component Module to hold everything
            mComponents = new System.ComponentModel.Container();

            //Instantiate the NotifyIcon attaching it to the components container and 
            //provide it an icon, note, you can imbed this resource 
            mNotifyIcon = new NotifyIcon(this.mComponents);
            mNotifyIcon.Icon = new System.Drawing.Icon("MusicStatus.ico");
            mNotifyIcon.Text = "Music Status v1.0";
            mNotifyIcon.Visible = true;

            //Instantiate the context menu and items
            mContextMenu = new ContextMenuStrip();
            mDisplayForm = new ToolStripMenuItem();
            mExitApplication = new ToolStripMenuItem();

            //Attach the menu to the notify icon
            mNotifyIcon.ContextMenuStrip = mContextMenu;

            //Setup the items and add them to the menu strip, adding handlers to be created later
            mDisplayForm.Text = "Options";
            mDisplayForm.Click += new EventHandler(mDisplayForm_Click);
            mContextMenu.Items.Add(mDisplayForm);

            mExitApplication.Text = "Exit";
            mExitApplication.Click += new EventHandler(mExitApplication_Click);
            mContextMenu.Items.Add(mExitApplication);
        }

        protected override void ExitThreadCore()
        {
            //Clean up any references needed
            //At this time we do not have any
            mNotifyIcon.Visible = false;

            //Call the base method to exit the application
            base.ExitThreadCore();
        }

        void mExitApplication_Click(object sender, EventArgs e)
        {
            //Call our overridden exit thread core method!
            ExitThreadCore();
        }

        void mDisplayForm_Click(object sender, EventArgs e)
        {
            new OptionsForm().Visible = true;
        }
    }
}
