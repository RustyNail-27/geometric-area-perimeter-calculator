namespace Seminar8
{
    partial class Form1
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
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.drimLabel = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.dimensionOutputLabel = new System.Windows.Forms.Label();
            this.areaOutputLabel = new System.Windows.Forms.Label();
            this.perimierOutputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeListBox
            // 
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.Location = new System.Drawing.Point(12, 25);
            this.shapeListBox.Name = "shapeListBox";
            this.shapeListBox.Size = new System.Drawing.Size(120, 108);
            this.shapeListBox.TabIndex = 0;
            this.shapeListBox.SelectedIndexChanged += new System.EventHandler(this.shapeListBox_SelectedIndexChanged);
            // 
            // perimeterLabel
            // 
            this.perimeterLabel.AutoSize = true;
            this.perimeterLabel.Location = new System.Drawing.Point(145, 103);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(50, 13);
            this.perimeterLabel.TabIndex = 1;
            this.perimeterLabel.Text = "Perimiter:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(145, 63);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(32, 13);
            this.areaLabel.TabIndex = 2;
            this.areaLabel.Text = "Area:";
            // 
            // drimLabel
            // 
            this.drimLabel.AutoSize = true;
            this.drimLabel.Location = new System.Drawing.Point(145, 25);
            this.drimLabel.Name = "drimLabel";
            this.drimLabel.Size = new System.Drawing.Size(64, 13);
            this.drimLabel.TabIndex = 3;
            this.drimLabel.Text = "Dimensions:";
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(9, 9);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(81, 13);
            this.selectLabel.TabIndex = 4;
            this.selectLabel.Text = "Select a shape:";
            // 
            // dimensionOutputLabel
            // 
            this.dimensionOutputLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dimensionOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dimensionOutputLabel.Location = new System.Drawing.Point(148, 38);
            this.dimensionOutputLabel.Name = "dimensionOutputLabel";
            this.dimensionOutputLabel.Size = new System.Drawing.Size(166, 17);
            this.dimensionOutputLabel.TabIndex = 5;
            // 
            // areaOutputLabel
            // 
            this.areaOutputLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.areaOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaOutputLabel.Location = new System.Drawing.Point(148, 76);
            this.areaOutputLabel.Name = "areaOutputLabel";
            this.areaOutputLabel.Size = new System.Drawing.Size(166, 18);
            this.areaOutputLabel.TabIndex = 6;
            // 
            // perimierOutputLabel
            // 
            this.perimierOutputLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.perimierOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perimierOutputLabel.Location = new System.Drawing.Point(148, 116);
            this.perimierOutputLabel.Name = "perimierOutputLabel";
            this.perimierOutputLabel.Size = new System.Drawing.Size(166, 17);
            this.perimierOutputLabel.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(134, 144);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 179);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.perimierOutputLabel);
            this.Controls.Add(this.areaOutputLabel);
            this.Controls.Add(this.dimensionOutputLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.drimLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.perimeterLabel);
            this.Controls.Add(this.shapeListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shapeListBox;
        private System.Windows.Forms.Label perimeterLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label drimLabel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label dimensionOutputLabel;
        private System.Windows.Forms.Label areaOutputLabel;
        private System.Windows.Forms.Label perimierOutputLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

