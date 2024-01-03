using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using ApplicationContext = Plutus.Database.ApplicationContext;

namespace Plutus
{
    public partial class MainForm : RadForm
    {
        readonly ApplicationContext db = new();
        public const int HT_CAPTION = 0x2;
        private const int WM_NCHITTEST = 0x84;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = $"Plutus v.{Application.ProductVersion}";
            db.Database.EnsureCreated();
            db.Accounts.Load();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = HT_CAPTION;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using LinearGradientBrush brush = new(ClientRectangle, Color.FromArgb(24, 33, 34), Color.FromArgb(12, 16, 17), 90F);
            e.Graphics.FillRectangle(brush, ClientRectangle);
        }
    }
}
