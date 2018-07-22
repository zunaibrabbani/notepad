using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noteppadd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exxxitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Dock = DockStyle.Fill;
            this.newCtrlNToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.cutCtrlXToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.pasteCtrlVToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.copyCtrlToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.undoCtrlZToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            this.wordWrapToolStripMenuItem.Checked = false;
            this.textBox1.WordWrap = false;



           
           
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteCtrlDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.textBox1.Font = this.fontDialog1.Font;
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = false;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
