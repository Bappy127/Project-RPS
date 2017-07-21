using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResultProcessingSystem
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void অনষদToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new faculty_class()).Show();
        }

        private void labelJstu_Click(object sender, EventArgs e)
        {

        }

        private void বভগToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new departmentFolder.FormDepartment()).Show();
        }

        private void পরগরমToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new programfolder.viewPrgForm()).Show();
        }

        private void সমসটরToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new semesterFolder.semShow().Show();
        }

        private void গরডসকলToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new gradeFolder.showGrd().Show();
        }

        private void সশনসকরনতToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new sessionsFolder.editSess().Show();
        }

        private void রজষটরশনসশনপরবরতনToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new sessionsFolder.editSess().Show();
        }

        private void রজষটরশনসশনপরবরতনToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new sessionsFolder.UpdateSess().Show();
        }
    }
}
