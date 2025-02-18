namespace ControllerGUI
{
    partial class KeyBindsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyBindsForm));
            this.KeyBindsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BackHomeButton = new System.Windows.Forms.Button();
            this.KeyBindsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyBindsLayout
            // 
            this.KeyBindsLayout.BackColor = System.Drawing.Color.Transparent;
            this.KeyBindsLayout.ColumnCount = 4;
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.Controls.Add(this.BackHomeButton, 0, 0);
            this.KeyBindsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyBindsLayout.Location = new System.Drawing.Point(0, 0);
            this.KeyBindsLayout.Name = "KeyBindsLayout";
            this.KeyBindsLayout.RowCount = 4;
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyBindsLayout.Size = new System.Drawing.Size(614, 291);
            this.KeyBindsLayout.TabIndex = 0;
            // 
            // BackHomeButton
            // 
            this.BackHomeButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.BackHomeButton.Location = new System.Drawing.Point(10, 10);
            this.BackHomeButton.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.BackHomeButton.Name = "BackHomeButton";
            this.BackHomeButton.Size = new System.Drawing.Size(75, 23);
            this.BackHomeButton.TabIndex = 0;
            this.BackHomeButton.Text = "Back";
            this.BackHomeButton.UseVisualStyleBackColor = true;
            this.BackHomeButton.Click += new System.EventHandler(this.BackHomeButton_Click);
            // 
            // KeyBindsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllerGUI.Properties.Resources.anime_initial_d_final_stage_toyo;
            this.ClientSize = new System.Drawing.Size(614, 291);
            this.Controls.Add(this.KeyBindsLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(630, 330);
            this.MinimumSize = new System.Drawing.Size(630, 330);
            this.Name = "KeyBindsForm";
            this.Text = "Key Mapping";
            this.KeyBindsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel KeyBindsLayout;
        private System.Windows.Forms.Button BackHomeButton;
    }
}