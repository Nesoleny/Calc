namespace EveryDay.Calc.AppCalc
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
            this.components = new System.ComponentModel.Container();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.boxOperations = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.boxHistory = new System.Windows.Forms.GroupBox();
            this.txtBoxHistory = new System.Windows.Forms.TextBox();
            this.CostylButton = new System.Windows.Forms.Button();
            this.boxHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(72, 7);
            this.tbInput.Margin = new System.Windows.Forms.Padding(2);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(282, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input data";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(352, 313);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.toolTip.SetToolTip(this.btnExit, "sgasio df asdo");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(72, 40);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(23, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "null";
            // 
            // boxOperations
            // 
            this.boxOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxOperations.Location = new System.Drawing.Point(9, 68);
            this.boxOperations.Margin = new System.Windows.Forms.Padding(2);
            this.boxOperations.Name = "boxOperations";
            this.boxOperations.Padding = new System.Windows.Forms.Padding(2);
            this.boxOperations.Size = new System.Drawing.Size(399, 136);
            this.boxOperations.TabIndex = 10;
            this.boxOperations.TabStop = false;
            this.boxOperations.Text = "Operations";
            this.boxOperations.Enter += new System.EventHandler(this.boxOperations_Enter);
            // 
            // boxHistory
            // 
            this.boxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxHistory.Controls.Add(this.txtBoxHistory);
            this.boxHistory.Location = new System.Drawing.Point(9, 210);
            this.boxHistory.Margin = new System.Windows.Forms.Padding(2);
            this.boxHistory.Name = "boxHistory";
            this.boxHistory.Padding = new System.Windows.Forms.Padding(2);
            this.boxHistory.Size = new System.Drawing.Size(399, 98);
            this.boxHistory.TabIndex = 11;
            this.boxHistory.TabStop = false;
            this.boxHistory.Text = "History";
            this.boxHistory.Enter += new System.EventHandler(this.boxHistory_Enter);
            // 
            // txtBoxHistory
            // 
            this.txtBoxHistory.Location = new System.Drawing.Point(0, 18);
            this.txtBoxHistory.Multiline = true;
            this.txtBoxHistory.Name = "txtBoxHistory";
            this.txtBoxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxHistory.Size = new System.Drawing.Size(399, 75);
            this.txtBoxHistory.TabIndex = 0;
            this.txtBoxHistory.TextChanged += new System.EventHandler(this.txtBoxHistory_TextChanged);
            // 
            // CostylButton
            // 
            this.CostylButton.Location = new System.Drawing.Point(272, 317);
            this.CostylButton.Name = "CostylButton";
            this.CostylButton.Size = new System.Drawing.Size(75, 23);
            this.CostylButton.TabIndex = 12;
            this.CostylButton.Text = "CostylButton";
            this.CostylButton.UseVisualStyleBackColor = true;
            this.CostylButton.Visible = false;
            this.CostylButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 352);
            this.Controls.Add(this.CostylButton);
            this.Controls.Add(this.boxHistory);
            this.Controls.Add(this.boxOperations);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(229, 259);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxHistory.ResumeLayout(false);
            this.boxHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox boxOperations;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox boxHistory;
        private System.Windows.Forms.TextBox txtBoxHistory;
        private System.Windows.Forms.Button CostylButton;
    }
}

