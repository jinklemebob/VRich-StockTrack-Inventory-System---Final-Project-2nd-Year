using System;
using System.Windows.Forms;

namespace SubmenuVisibility
{
    internal class Submenus
    {
        private Panel masterDataSubmenu;
        private Panel transactionsSubmenu;
        private Panel administratorSubmenu;

        public Submenus(Panel masterDataSubmenu, Panel transactionsSubmenu, Panel administratorSubmenu)
        {
            this.masterDataSubmenu = masterDataSubmenu;
            this.transactionsSubmenu = transactionsSubmenu;
            this.administratorSubmenu = administratorSubmenu;
        }

        public void hideSubmenus()
        {
            masterDataSubmenu.Visible = false;
            transactionsSubmenu.Visible = false;
            administratorSubmenu.Visible = false;
        }

        public void autoHideSubmenus()
        {
            if (masterDataSubmenu?.Visible == true) masterDataSubmenu.Visible = false;
            if (transactionsSubmenu?.Visible == true) transactionsSubmenu.Visible = false;
            if (administratorSubmenu?.Visible == true) administratorSubmenu.Visible = false;
        }

        public void showSubmenus(Panel submenu)
        {
            

            if (submenu.Visible == false)
            {
                autoHideSubmenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
    }
}
