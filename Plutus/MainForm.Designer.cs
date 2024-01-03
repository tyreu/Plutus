namespace Plutus
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainPanel = new Telerik.WinControls.UI.RadPanel();
            MenuPanel = new Telerik.WinControls.UI.RadPanel();
            MenuTreePanel = new Telerik.WinControls.UI.RadPanel();
            SettingsPanel = new Telerik.WinControls.UI.RadPanel();
            LogoPanel = new Telerik.WinControls.UI.RadPanel();
            ContentPanel = new Telerik.WinControls.UI.RadPanel();
            CenterContentPanel = new Telerik.WinControls.UI.RadPanel();
            radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            SearchPanel = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)MainPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MenuPanel).BeginInit();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuTreePanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingsPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContentPanel).BeginInit();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CenterContentPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radCollapsiblePanel1).BeginInit();
            radCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainPanel.Location = new System.Drawing.Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new System.Drawing.Size(1200, 500);
            MainPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(MenuTreePanel);
            MenuPanel.Controls.Add(SettingsPanel);
            MenuPanel.Controls.Add(LogoPanel);
            MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            MenuPanel.Location = new System.Drawing.Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new System.Drawing.Size(200, 500);
            MenuPanel.TabIndex = 1;
            // 
            // MenuTreePanel
            // 
            MenuTreePanel.BackColor = System.Drawing.Color.FromArgb(24, 33, 34);
            MenuTreePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MenuTreePanel.Location = new System.Drawing.Point(0, 60);
            MenuTreePanel.Name = "MenuTreePanel";
            MenuTreePanel.Size = new System.Drawing.Size(200, 340);
            MenuTreePanel.TabIndex = 3;
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = System.Drawing.Color.FromArgb(24, 33, 34);
            SettingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            SettingsPanel.Location = new System.Drawing.Point(0, 400);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new System.Drawing.Size(200, 100);
            SettingsPanel.TabIndex = 3;
            // 
            // LogoPanel
            // 
            LogoPanel.BackColor = System.Drawing.Color.FromArgb(24, 33, 34);
            LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            LogoPanel.Location = new System.Drawing.Point(0, 0);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new System.Drawing.Size(200, 60);
            LogoPanel.TabIndex = 3;
            ((Telerik.WinControls.Primitives.BorderPrimitive)LogoPanel.GetChildAt(0).GetChildAt(1)).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)LogoPanel.GetChildAt(0).GetChildAt(1)).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = System.Drawing.Color.RosyBrown;
            ContentPanel.Controls.Add(CenterContentPanel);
            ContentPanel.Controls.Add(radCollapsiblePanel1);
            ContentPanel.Controls.Add(SearchPanel);
            ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ContentPanel.Location = new System.Drawing.Point(200, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new System.Drawing.Size(1000, 500);
            ContentPanel.TabIndex = 2;
            // 
            // CenterContentPanel
            // 
            CenterContentPanel.BackColor = System.Drawing.Color.FromArgb(24, 33, 34);
            CenterContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            CenterContentPanel.Location = new System.Drawing.Point(0, 60);
            CenterContentPanel.Name = "CenterContentPanel";
            CenterContentPanel.Size = new System.Drawing.Size(977, 440);
            CenterContentPanel.TabIndex = 3;
            // 
            // radCollapsiblePanel1
            // 
            radCollapsiblePanel1.BackColor = System.Drawing.Color.FromArgb(24, 33, 34);
            radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            radCollapsiblePanel1.ExpandDirection = Telerik.WinControls.UI.RadDirection.Left;
            radCollapsiblePanel1.HorizontalHeaderAlignment = Telerik.WinControls.UI.RadHorizontalAlignment.Center;
            radCollapsiblePanel1.IsExpanded = false;
            radCollapsiblePanel1.Location = new System.Drawing.Point(977, 60);
            radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(977, 60, 200, 440);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(0, 0);
            radCollapsiblePanel1.Size = new System.Drawing.Size(23, 440);
            radCollapsiblePanel1.TabIndex = 4;
            radCollapsiblePanel1.VerticalHeaderAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)radCollapsiblePanel1.GetChildAt(0)).ExpandDirection = Telerik.WinControls.UI.RadDirection.Left;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)radCollapsiblePanel1.GetChildAt(0)).IsExpanded = false;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)radCollapsiblePanel1.GetChildAt(0)).BackColor = System.Drawing.Color.FromArgb(24, 32, 33);
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = System.Drawing.Color.FromArgb(24, 33, 34);
            SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            SearchPanel.Location = new System.Drawing.Point(0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new System.Drawing.Size(1000, 60);
            SearchPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 33, 34);
            ClientSize = new System.Drawing.Size(1200, 500);
            Controls.Add(ContentPanel);
            Controls.Add(MenuPanel);
            Controls.Add(MainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(1200, 500);
            MinimumSize = new System.Drawing.Size(1200, 500);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Plutus";
            TransparencyKey = System.Drawing.Color.Red;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)MainPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)MenuPanel).EndInit();
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuTreePanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingsPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContentPanel).EndInit();
            ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CenterContentPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)radCollapsiblePanel1).EndInit();
            radCollapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private Telerik.WinControls.UI.RadPanel MainPanel;
        private Telerik.WinControls.UI.RadPanel MenuPanel;
        private Telerik.WinControls.UI.RadPanel LogoPanel;
        private Telerik.WinControls.UI.RadPanel SettingsPanel;
        private Telerik.WinControls.UI.RadPanel ContentPanel;
        private Telerik.WinControls.UI.RadPanel CenterContentPanel;
        private Telerik.WinControls.UI.RadPanel SearchPanel;
        private Telerik.WinControls.UI.RadPanel MenuTreePanel;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel4;
    }
}