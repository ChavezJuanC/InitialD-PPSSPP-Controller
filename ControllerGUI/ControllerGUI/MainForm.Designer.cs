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
            this.Pedals_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Gas_Picture_Box = new System.Windows.Forms.PictureBox();
            this.Brake_Picture_Box = new System.Windows.Forms.PictureBox();
            this.JoyStickPictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeLayout.SuspendLayout();
            this.Pedals_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gas_Picture_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brake_Picture_Box)).BeginInit();
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
            this.HomeLayout.Controls.Add(this.Pedals_Layout, 2, 1);
            this.HomeLayout.Controls.Add(this.JoyStickPictureBox, 0, 1);
            this.HomeLayout.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.HomeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeLayout.Location = new System.Drawing.Point(0, 0);
            this.HomeLayout.Name = "HomeLayout";
            this.HomeLayout.RowCount = 3;
            this.HomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.77663F));
            this.HomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.35739F));
            this.HomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.HomeLayout.Size = new System.Drawing.Size(614, 291);
            this.HomeLayout.TabIndex = 0;
            // 
            // SetKeybindsButton
            // 
            this.SetKeybindsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetKeybindsButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetKeybindsButton.Location = new System.Drawing.Point(259, 235);
            this.SetKeybindsButton.Name = "SetKeybindsButton";
            this.SetKeybindsButton.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.SetKeybindsButton.Size = new System.Drawing.Size(94, 28);
            this.SetKeybindsButton.TabIndex = 0;
            this.SetKeybindsButton.Text = "Keybinds";
            this.SetKeybindsButton.UseVisualStyleBackColor = true;
            this.SetKeybindsButton.Click += new System.EventHandler(this.SetKeybindsButton_Click);
            // 
            // Pedals_Layout
            // 
            this.Pedals_Layout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pedals_Layout.ColumnCount = 2;
            this.Pedals_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Pedals_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Pedals_Layout.Controls.Add(this.Gas_Picture_Box, 1, 0);
            this.Pedals_Layout.Controls.Add(this.Brake_Picture_Box, 0, 0);
            this.Pedals_Layout.Location = new System.Drawing.Point(390, 46);
            this.Pedals_Layout.Name = "Pedals_Layout";
            this.Pedals_Layout.RowCount = 1;
            this.Pedals_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Pedals_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.Pedals_Layout.Size = new System.Drawing.Size(200, 139);
            this.Pedals_Layout.TabIndex = 2;
            // 
            // Gas_Picture_Box
            // 
            this.Gas_Picture_Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gas_Picture_Box.BackgroundImage")));
            this.Gas_Picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gas_Picture_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gas_Picture_Box.Location = new System.Drawing.Point(103, 3);
            this.Gas_Picture_Box.Name = "Gas_Picture_Box";
            this.Gas_Picture_Box.Size = new System.Drawing.Size(94, 133);
            this.Gas_Picture_Box.TabIndex = 1;
            this.Gas_Picture_Box.TabStop = false;
            // 
            // Brake_Picture_Box
            // 
            this.Brake_Picture_Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Brake_Picture_Box.BackgroundImage")));
            this.Brake_Picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Brake_Picture_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Brake_Picture_Box.Location = new System.Drawing.Point(3, 3);
            this.Brake_Picture_Box.Name = "Brake_Picture_Box";
            this.Brake_Picture_Box.Size = new System.Drawing.Size(94, 133);
            this.Brake_Picture_Box.TabIndex = 0;
            this.Brake_Picture_Box.TabStop = false;
            // 
            // JoyStickPictureBox
            // 
            this.JoyStickPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.JoyStickPictureBox.BackgroundImage = global::ControllerGUI.Properties.Resources.Analog_M;
            this.JoyStickPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JoyStickPictureBox.Location = new System.Drawing.Point(3, 55);
            this.JoyStickPictureBox.Name = "JoyStickPictureBox";
            this.JoyStickPictureBox.Size = new System.Drawing.Size(239, 139);
            this.JoyStickPictureBox.TabIndex = 1;
            this.JoyStickPictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(248, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 158);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(614, 291);
            this.Controls.Add(this.HomeLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(630, 330);
            this.MinimumSize = new System.Drawing.Size(630, 330);
            this.Name = "MainForm";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.HomeLayout.ResumeLayout(false);
            this.Pedals_Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gas_Picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brake_Picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JoyStickPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HomeLayout;
        private System.Windows.Forms.Button SetKeybindsButton;
        private System.Windows.Forms.PictureBox JoyStickPictureBox;
        private System.Windows.Forms.TableLayoutPanel Pedals_Layout;
        private System.Windows.Forms.PictureBox Gas_Picture_Box;
        private System.Windows.Forms.PictureBox Brake_Picture_Box;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

