namespace Firkin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkTableNames = new System.Windows.Forms.CheckedListBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.CheckAllButton = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.button1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.AccessButton = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.txtAccessPath = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.SuspendLayout();
            // 
            // checkTableNames
            // 
            this.checkTableNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTableNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkTableNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkTableNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkTableNames.FormattingEnabled = true;
            this.checkTableNames.Location = new System.Drawing.Point(13, 69);
            this.checkTableNames.Name = "checkTableNames";
            this.checkTableNames.Size = new System.Drawing.Size(154, 176);
            this.checkTableNames.TabIndex = 2;
            this.checkTableNames.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnCheckTableNamesItemChecked);
            // 
            // lblstatus
            // 
            this.lblstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(182, 156);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(66, 24);
            this.lblstatus.TabIndex = 6;
            this.lblstatus.Text = "status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Export Tables";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConvert.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConvert.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConvert.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.btnConvert.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConvert.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConvert.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.btnConvert.Border.HoverVisible = true;
            this.btnConvert.Border.Rounding = 6;
            this.btnConvert.Border.Thickness = 1;
            this.btnConvert.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.btnConvert.Border.Visible = true;
            this.btnConvert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConvert.ForeColor = System.Drawing.Color.Gray;
            this.btnConvert.Image = null;
            this.btnConvert.Location = new System.Drawing.Point(283, 69);
            this.btnConvert.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(140, 33);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnConvert.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnConvert.TextStyle.Enabled = System.Drawing.Color.Gray;
            this.btnConvert.TextStyle.Hover = System.Drawing.Color.White;
            this.btnConvert.TextStyle.Pressed = System.Drawing.Color.White;
            this.btnConvert.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnConvert.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.btnConvert.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvertClick);
            // 
            // CheckAllButton
            // 
            this.CheckAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CheckAllButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CheckAllButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CheckAllButton.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.CheckAllButton.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CheckAllButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CheckAllButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.CheckAllButton.Border.HoverVisible = true;
            this.CheckAllButton.Border.Rounding = 6;
            this.CheckAllButton.Border.Thickness = 1;
            this.CheckAllButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CheckAllButton.Border.Visible = true;
            this.CheckAllButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CheckAllButton.ForeColor = System.Drawing.Color.Gray;
            this.CheckAllButton.Image = null;
            this.CheckAllButton.Location = new System.Drawing.Point(173, 69);
            this.CheckAllButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CheckAllButton.Name = "CheckAllButton";
            this.CheckAllButton.Size = new System.Drawing.Size(75, 23);
            this.CheckAllButton.TabIndex = 9;
            this.CheckAllButton.Text = "Select All";
            this.CheckAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.CheckAllButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CheckAllButton.TextStyle.Enabled = System.Drawing.Color.Gray;
            this.CheckAllButton.TextStyle.Hover = System.Drawing.Color.White;
            this.CheckAllButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.CheckAllButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CheckAllButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CheckAllButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.button1.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.button1.Border.HoverVisible = true;
            this.button1.Border.Rounding = 6;
            this.button1.Border.Thickness = 1;
            this.button1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.button1.Border.Visible = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Image = null;
            this.button1.Location = new System.Drawing.Point(173, 98);
            this.button1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Un-Select ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.button1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.TextStyle.Enabled = System.Drawing.Color.Gray;
            this.button1.TextStyle.Hover = System.Drawing.Color.White;
            this.button1.TextStyle.Pressed = System.Drawing.Color.White;
            this.button1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.button1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // AccessButton
            // 
            this.AccessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AccessButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AccessButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AccessButton.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.AccessButton.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AccessButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AccessButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AccessButton.Border.HoverVisible = true;
            this.AccessButton.Border.Rounding = 6;
            this.AccessButton.Border.Thickness = 1;
            this.AccessButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.AccessButton.Border.Visible = true;
            this.AccessButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AccessButton.ForeColor = System.Drawing.Color.Gray;
            this.AccessButton.Image = null;
            this.AccessButton.Location = new System.Drawing.Point(283, 11);
            this.AccessButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AccessButton.Name = "AccessButton";
            this.AccessButton.Size = new System.Drawing.Size(140, 34);
            this.AccessButton.TabIndex = 11;
            this.AccessButton.Text = "Access Database";
            this.AccessButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.AccessButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AccessButton.TextStyle.Enabled = System.Drawing.Color.Gray;
            this.AccessButton.TextStyle.Hover = System.Drawing.Color.White;
            this.AccessButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.AccessButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AccessButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AccessButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AccessButton.Click += new System.EventHandler(this.OnSelectAccessButtonClicked);
            // 
            // txtAccessPath
            // 
            this.txtAccessPath.AlphaNumeric = false;
            this.txtAccessPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAccessPath.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAccessPath.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAccessPath.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAccessPath.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.txtAccessPath.Border.HoverVisible = true;
            this.txtAccessPath.Border.Rounding = 6;
            this.txtAccessPath.Border.Thickness = 1;
            this.txtAccessPath.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.txtAccessPath.Border.Visible = true;
            this.txtAccessPath.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAccessPath.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.txtAccessPath.ButtonBorder.HoverVisible = true;
            this.txtAccessPath.ButtonBorder.Rounding = 6;
            this.txtAccessPath.ButtonBorder.Thickness = 1;
            this.txtAccessPath.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.txtAccessPath.ButtonBorder.Visible = true;
            this.txtAccessPath.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccessPath.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtAccessPath.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccessPath.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAccessPath.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessPath.ButtonIndent = 3;
            this.txtAccessPath.ButtonText = "visualButton";
            this.txtAccessPath.ButtonVisible = false;
            this.txtAccessPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccessPath.Image = null;
            this.txtAccessPath.ImageSize = new System.Drawing.Size(16, 16);
            this.txtAccessPath.ImageVisible = false;
            this.txtAccessPath.ImageWidth = 35;
            this.txtAccessPath.Location = new System.Drawing.Point(15, 11);
            this.txtAccessPath.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.txtAccessPath.Name = "txtAccessPath";
            this.txtAccessPath.PasswordChar = '\0';
            this.txtAccessPath.ReadOnly = false;
            this.txtAccessPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccessPath.Size = new System.Drawing.Size(233, 23);
            this.txtAccessPath.TabIndex = 12;
            this.txtAccessPath.TextBoxWidth = 223;
            this.txtAccessPath.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.txtAccessPath.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAccessPath.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAccessPath.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAccessPath.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txtAccessPath.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.txtAccessPath.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtAccessPath.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtAccessPath.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessPath.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.txtAccessPath.Watermark.Text = "Watermark text";
            this.txtAccessPath.Watermark.Visible = false;
            this.txtAccessPath.WordWrap = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.txtAccessPath);
            this.Controls.Add(this.AccessButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckAllButton);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.checkTableNames);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkTableNames;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label label1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnConvert;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton CheckAllButton;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton button1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton AccessButton;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox txtAccessPath;
    }
}

