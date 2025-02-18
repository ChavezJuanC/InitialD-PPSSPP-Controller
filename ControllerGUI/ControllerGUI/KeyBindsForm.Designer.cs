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
            this.KeybindLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.BrakeInputBox = new System.Windows.Forms.TextBox();
            this.BrakeLabel = new System.Windows.Forms.Label();
            this.KeybindLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftInputBox = new System.Windows.Forms.TextBox();
            this.LeftLabael = new System.Windows.Forms.Label();
            this.KeybindLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this.GasInputBox = new System.Windows.Forms.TextBox();
            this.GasLabel = new System.Windows.Forms.Label();
            this.BackHomeButton = new System.Windows.Forms.Button();
            this.KeybindLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RightLabel = new System.Windows.Forms.Label();
            this.RightInputBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.KeyBindsLayout.SuspendLayout();
            this.KeybindLayout2.SuspendLayout();
            this.KeybindLayout4.SuspendLayout();
            this.KeybindLayout3.SuspendLayout();
            this.KeybindLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyBindsLayout
            // 
            this.KeyBindsLayout.BackColor = System.Drawing.Color.Transparent;
            this.KeyBindsLayout.ColumnCount = 4;
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21811F));
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.86451F));
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.69927F));
            this.KeyBindsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21811F));
            this.KeyBindsLayout.Controls.Add(this.KeybindLayout2, 1, 2);
            this.KeyBindsLayout.Controls.Add(this.KeybindLayout4, 1, 2);
            this.KeyBindsLayout.Controls.Add(this.KeybindLayout3, 2, 1);
            this.KeyBindsLayout.Controls.Add(this.BackHomeButton, 0, 0);
            this.KeyBindsLayout.Controls.Add(this.KeybindLayout, 1, 1);
            this.KeyBindsLayout.Controls.Add(this.SaveButton, 1, 3);
            this.KeyBindsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyBindsLayout.Location = new System.Drawing.Point(0, 0);
            this.KeyBindsLayout.Name = "KeyBindsLayout";
            this.KeyBindsLayout.RowCount = 4;
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.KeyBindsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.KeyBindsLayout.Size = new System.Drawing.Size(614, 291);
            this.KeyBindsLayout.TabIndex = 0;
            // 
            // KeybindLayout2
            // 
            this.KeybindLayout2.ColumnCount = 2;
            this.KeybindLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout2.Controls.Add(this.BrakeInputBox, 1, 0);
            this.KeybindLayout2.Controls.Add(this.BrakeLabel, 0, 0);
            this.KeybindLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeybindLayout2.Location = new System.Drawing.Point(307, 147);
            this.KeybindLayout2.Name = "KeybindLayout2";
            this.KeybindLayout2.RowCount = 1;
            this.KeybindLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeybindLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.KeybindLayout2.Size = new System.Drawing.Size(203, 66);
            this.KeybindLayout2.TabIndex = 4;
            // 
            // BrakeInputBox
            // 
            this.BrakeInputBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrakeInputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BrakeInputBox.Location = new System.Drawing.Point(137, 23);
            this.BrakeInputBox.MaxLength = 1;
            this.BrakeInputBox.Name = "BrakeInputBox";
            this.BrakeInputBox.Size = new System.Drawing.Size(30, 20);
            this.BrakeInputBox.TabIndex = 4;
            this.BrakeInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BrakeLabel
            // 
            this.BrakeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BrakeLabel.AutoSize = true;
            this.BrakeLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BrakeLabel.ForeColor = System.Drawing.Color.Crimson;
            this.BrakeLabel.Location = new System.Drawing.Point(25, 22);
            this.BrakeLabel.Name = "BrakeLabel";
            this.BrakeLabel.Size = new System.Drawing.Size(73, 21);
            this.BrakeLabel.TabIndex = 3;
            this.BrakeLabel.Text = "BRAKE - ";
            // 
            // KeybindLayout4
            // 
            this.KeybindLayout4.ColumnCount = 2;
            this.KeybindLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout4.Controls.Add(this.LeftInputBox, 1, 0);
            this.KeybindLayout4.Controls.Add(this.LeftLabael, 0, 0);
            this.KeybindLayout4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeybindLayout4.Location = new System.Drawing.Point(97, 147);
            this.KeybindLayout4.Name = "KeybindLayout4";
            this.KeybindLayout4.RowCount = 1;
            this.KeybindLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeybindLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.KeybindLayout4.Size = new System.Drawing.Size(204, 66);
            this.KeybindLayout4.TabIndex = 3;
            // 
            // LeftInputBox
            // 
            this.LeftInputBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftInputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LeftInputBox.Location = new System.Drawing.Point(138, 23);
            this.LeftInputBox.MaxLength = 1;
            this.LeftInputBox.Name = "LeftInputBox";
            this.LeftInputBox.Size = new System.Drawing.Size(30, 20);
            this.LeftInputBox.TabIndex = 2;
            this.LeftInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LeftLabael
            // 
            this.LeftLabael.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LeftLabael.AutoSize = true;
            this.LeftLabael.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LeftLabael.ForeColor = System.Drawing.Color.Crimson;
            this.LeftLabael.Location = new System.Drawing.Point(42, 22);
            this.LeftLabael.Name = "LeftLabael";
            this.LeftLabael.Size = new System.Drawing.Size(57, 21);
            this.LeftLabael.TabIndex = 1;
            this.LeftLabael.Text = "LEFT - ";
            // 
            // KeybindLayout3
            // 
            this.KeybindLayout3.ColumnCount = 2;
            this.KeybindLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout3.Controls.Add(this.GasInputBox, 1, 0);
            this.KeybindLayout3.Controls.Add(this.GasLabel, 0, 0);
            this.KeybindLayout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeybindLayout3.Location = new System.Drawing.Point(307, 75);
            this.KeybindLayout3.Name = "KeybindLayout3";
            this.KeybindLayout3.RowCount = 1;
            this.KeybindLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeybindLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.KeybindLayout3.Size = new System.Drawing.Size(203, 66);
            this.KeybindLayout3.TabIndex = 2;
            // 
            // GasInputBox
            // 
            this.GasInputBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GasInputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GasInputBox.Location = new System.Drawing.Point(137, 23);
            this.GasInputBox.MaxLength = 1;
            this.GasInputBox.Name = "GasInputBox";
            this.GasInputBox.Size = new System.Drawing.Size(30, 20);
            this.GasInputBox.TabIndex = 3;
            this.GasInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GasLabel
            // 
            this.GasLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GasLabel.AutoSize = true;
            this.GasLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.GasLabel.ForeColor = System.Drawing.Color.Crimson;
            this.GasLabel.Location = new System.Drawing.Point(43, 22);
            this.GasLabel.Name = "GasLabel";
            this.GasLabel.Size = new System.Drawing.Size(55, 21);
            this.GasLabel.TabIndex = 2;
            this.GasLabel.Text = "GAS - ";
            // 
            // BackHomeButton
            // 
            this.BackHomeButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.BackHomeButton.Location = new System.Drawing.Point(10, 10);
            this.BackHomeButton.Margin = new System.Windows.Forms.Padding(15, 20, 3, 3);
            this.BackHomeButton.Name = "BackHomeButton";
            this.BackHomeButton.Size = new System.Drawing.Size(75, 23);
            this.BackHomeButton.TabIndex = 0;
            this.BackHomeButton.Text = "Back";
            this.BackHomeButton.UseVisualStyleBackColor = true;
            this.BackHomeButton.Click += new System.EventHandler(this.BackHomeButton_Click);
            // 
            // KeybindLayout
            // 
            this.KeybindLayout.ColumnCount = 2;
            this.KeybindLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KeybindLayout.Controls.Add(this.RightLabel, 0, 0);
            this.KeybindLayout.Controls.Add(this.RightInputBox, 1, 0);
            this.KeybindLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeybindLayout.Location = new System.Drawing.Point(97, 75);
            this.KeybindLayout.Name = "KeybindLayout";
            this.KeybindLayout.RowCount = 1;
            this.KeybindLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeybindLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.KeybindLayout.Size = new System.Drawing.Size(204, 66);
            this.KeybindLayout.TabIndex = 1;
            // 
            // RightLabel
            // 
            this.RightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RightLabel.AutoSize = true;
            this.RightLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.RightLabel.ForeColor = System.Drawing.Color.Crimson;
            this.RightLabel.Location = new System.Drawing.Point(28, 22);
            this.RightLabel.Name = "RightLabel";
            this.RightLabel.Size = new System.Drawing.Size(71, 21);
            this.RightLabel.TabIndex = 0;
            this.RightLabel.Text = "RIGHT - ";
            // 
            // RightInputBox
            // 
            this.RightInputBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightInputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RightInputBox.Location = new System.Drawing.Point(138, 23);
            this.RightInputBox.MaxLength = 1;
            this.RightInputBox.Name = "RightInputBox";
            this.RightInputBox.Size = new System.Drawing.Size(30, 20);
            this.RightInputBox.TabIndex = 1;
            this.RightInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeyBindsLayout.SetColumnSpan(this.SaveButton, 2);
            this.SaveButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(266, 219);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.KeybindLayout2.ResumeLayout(false);
            this.KeybindLayout2.PerformLayout();
            this.KeybindLayout4.ResumeLayout(false);
            this.KeybindLayout4.PerformLayout();
            this.KeybindLayout3.ResumeLayout(false);
            this.KeybindLayout3.PerformLayout();
            this.KeybindLayout.ResumeLayout(false);
            this.KeybindLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel KeyBindsLayout;
        private System.Windows.Forms.Button BackHomeButton;
        private System.Windows.Forms.TableLayoutPanel KeybindLayout2;
        private System.Windows.Forms.TableLayoutPanel KeybindLayout4;
        private System.Windows.Forms.TableLayoutPanel KeybindLayout3;
        private System.Windows.Forms.TableLayoutPanel KeybindLayout;
        private System.Windows.Forms.Label RightLabel;
        private System.Windows.Forms.Label LeftLabael;
        private System.Windows.Forms.Label BrakeLabel;
        private System.Windows.Forms.Label GasLabel;
        private System.Windows.Forms.TextBox LeftInputBox;
        private System.Windows.Forms.TextBox BrakeInputBox;
        private System.Windows.Forms.TextBox GasInputBox;
        private System.Windows.Forms.TextBox RightInputBox;
        private System.Windows.Forms.Button SaveButton;
    }
}