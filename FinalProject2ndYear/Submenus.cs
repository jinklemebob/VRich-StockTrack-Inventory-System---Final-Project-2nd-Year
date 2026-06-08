using System;
using System.Windows.Forms;

namespace SubmenuVisibility
{
    internal class Submenus
    {
        private Panel masterDataSubmenu;
        private Panel transactionsSubmenu;

        public Submenus(Panel masterDataSubmenu, Panel transactionsSubmenu)
        {
            this.masterDataSubmenu = masterDataSubmenu;
            this.transactionsSubmenu = transactionsSubmenu;
        }

        public void hideSubmenus()
        {
            masterDataSubmenu.Visible = false;
            transactionsSubmenu.Visible = false;
        }

        public void autoHideSubmenus()
        {
            if (masterDataSubmenu?.Visible == true) masterDataSubmenu.Visible = false;
            if (transactionsSubmenu?.Visible == true) transactionsSubmenu.Visible = false;
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
