using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGARA.DAO;
using QLGARA.DTO;

namespace QLGARA
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadCalendar();
        }
        #region Method
        void LoadCalendar()
        {
            List<Calendar> calendarList = CalendarDAO.Instance.LoadCalendarList();

            foreach (Calendar item in calendarList)
            {
                Button btn = new Button() { Width = CalendarDAO.CalendarWidth, Height = CalendarDAO.CalendarHeight };
                btn.Text = item.Thu + Environment.NewLine;
                flpCal.Controls.Add(btn);
            }
        }
        #endregion

        #region Events
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        #endregion
    }
}
