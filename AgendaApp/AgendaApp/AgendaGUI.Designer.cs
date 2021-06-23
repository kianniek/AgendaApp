namespace AgendaApp
{
    partial class AgendaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaGUI));
            this.CollectivePannel = new System.Windows.Forms.Panel();
            this.ElementPanel = new System.Windows.Forms.Panel();
            this.DagMaandJaar = new System.Windows.Forms.ComboBox();
            this.calendartypeTextBox = new System.Windows.Forms.TextBox();
            this.AgendaPanelShow = new System.Windows.Forms.Panel();
            this.roundedButton1 = new AgendaApp.RoundedButton();
            this.CollectivePannel.SuspendLayout();
            this.ElementPanel.SuspendLayout();
            this.AgendaPanelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // CollectivePannel
            // 
            this.CollectivePannel.BackColor = System.Drawing.Color.Gainsboro;
            this.CollectivePannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CollectivePannel.Controls.Add(this.AgendaPanelShow);
            this.CollectivePannel.Controls.Add(this.ElementPanel);
            this.CollectivePannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectivePannel.Location = new System.Drawing.Point(0, 0);
            this.CollectivePannel.Name = "CollectivePannel";
            this.CollectivePannel.Size = new System.Drawing.Size(1000, 500);
            this.CollectivePannel.TabIndex = 0;
            // 
            // ElementPanel
            // 
            this.ElementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementPanel.AutoSize = true;
            this.ElementPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ElementPanel.BackColor = System.Drawing.Color.Firebrick;
            this.ElementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElementPanel.Controls.Add(this.DagMaandJaar);
            this.ElementPanel.Controls.Add(this.calendartypeTextBox);
            this.ElementPanel.Location = new System.Drawing.Point(795, 5);
            this.ElementPanel.MinimumSize = new System.Drawing.Size(200, 490);
            this.ElementPanel.Name = "ElementPanel";
            this.ElementPanel.Size = new System.Drawing.Size(200, 490);
            this.ElementPanel.TabIndex = 1;
            // 
            // DagMaandJaar
            // 
            this.DagMaandJaar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DagMaandJaar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DagMaandJaar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DagMaandJaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DagMaandJaar.ForeColor = System.Drawing.Color.Black;
            this.DagMaandJaar.FormattingEnabled = true;
            this.DagMaandJaar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DagMaandJaar.Location = new System.Drawing.Point(47, 24);
            this.DagMaandJaar.Margin = new System.Windows.Forms.Padding(30);
            this.DagMaandJaar.Name = "DagMaandJaar";
            this.DagMaandJaar.Size = new System.Drawing.Size(121, 21);
            this.DagMaandJaar.TabIndex = 0;
            // 
            // calendartypeTextBox
            // 
            this.calendartypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendartypeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calendartypeTextBox.Location = new System.Drawing.Point(48, 3);
            this.calendartypeTextBox.Name = "calendartypeTextBox";
            this.calendartypeTextBox.ReadOnly = true;
            this.calendartypeTextBox.Size = new System.Drawing.Size(120, 20);
            this.calendartypeTextBox.TabIndex = 1;
            this.calendartypeTextBox.Text = "Calender Style";
            this.calendartypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgendaPanelShow
            // 
            this.AgendaPanelShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgendaPanelShow.AutoSize = true;
            this.AgendaPanelShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgendaPanelShow.BackColor = System.Drawing.Color.ForestGreen;
            this.AgendaPanelShow.Controls.Add(this.roundedButton1);
            this.AgendaPanelShow.Location = new System.Drawing.Point(5, 5);
            this.AgendaPanelShow.Margin = new System.Windows.Forms.Padding(5);
            this.AgendaPanelShow.MinimumSize = new System.Drawing.Size(780, 490);
            this.AgendaPanelShow.Name = "AgendaPanelShow";
            this.AgendaPanelShow.Size = new System.Drawing.Size(780, 490);
            this.AgendaPanelShow.TabIndex = 2;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton1.Location = new System.Drawing.Point(50, 50);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(80, 80);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Button1";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // AgendaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.CollectivePannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 539);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 539);
            this.Name = "AgendaGUI";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CollectivePannel.ResumeLayout(false);
            this.CollectivePannel.PerformLayout();
            this.ElementPanel.ResumeLayout(false);
            this.ElementPanel.PerformLayout();
            this.AgendaPanelShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CollectivePannel;
        private System.Windows.Forms.ComboBox DagMaandJaar;
        private System.Windows.Forms.Panel ElementPanel;
        private System.Windows.Forms.TextBox calendartypeTextBox;
        private System.Windows.Forms.Panel AgendaPanelShow;
        private RoundedButton roundedButton1;
    }
}

