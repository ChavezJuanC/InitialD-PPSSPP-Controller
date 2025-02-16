namespace ControllerGUI
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
            this.HomeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SetKeybindsButton = new System.Windows.Forms.Button();
            this.JoyStickPictureBox = new System.Windows.Forms.PictureBox();
            this.HomeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JoyStickPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeLayout
            // 
            this.HomeLayout.BackColor = System.Drawing.Color.Transparent;
            this.HomeLayout.ColumnCount = 3;
            this.HomeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.HomeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.HomeLayout.Controls.Add(this.SetKeybindsButton, 1, 2);
            this.HomeLayout.Controls.Add(this.JoyStickPictureBox, 0, 1);
            this.HomeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeLayout.Location = new System.Drawing.Point(0, 0);
            this.HomeLayout.Name = "HomeLayout";
            this.HomeLayout.RowCount = 3;
            this.HomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HomeLayout.Size = new System.Drawing.Size(614, 291);
            this.HomeLayout.TabIndex = 0;
            // 
            // SetKeybindsButton
            // 
            this.SetKeybindsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SetKeybindsButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetKeybindsButton.Location = new System.Drawing.Point(259, 220);
            this.SetKeybindsButton.Name = "SetKeybindsButton";
            this.SetKeybindsButton.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.SetKeybindsButton.Size = new System.Drawing.Size(94, 28);
            this.SetKeybindsButton.TabIndex = 0;
            this.SetKeybindsButton.Text = "Keybinds";
            this.SetKeybindsButton.UseVisualStyleBackColor = true;
            // 
            // JoyStickPictureBox
            // 
            this.JoyStickPictureBox.BackgroundImage = global::ControllerGUI.Properties.Resources.Analog_M;
            this.JoyStickPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JoyStickPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JoyStickPictureBox.Location = new System.Drawing.Point(3, 75);
            this.JoyStickPictureBox.Name = "JoyStickPictureBox";
            this.JoyStickPictureBox.Size = new System.Drawing.Size(239, 139);
            this.JoyStickPictureBox.TabIndex = 1;
            this.JoyStickPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(614, 291);
            this.Controls.Add(this.HomeLayout);
            this.MaximumSize = new System.Drawing.Size(630, 330);
            this.MinimumSize = new System.Drawing.Size(630, 330);
            this.Name = "MainForm";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.HomeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JoyStickPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HomeLayout;
        private System.Windows.Forms.Button SetKeybindsButton;
        private System.Windows.Forms.PictureBox JoyStickPictureBox;
    }
}

