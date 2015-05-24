﻿namespace SOEP.StyleCopRules
{
    partial class NestedBlockDepthSettingsPageSettingsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaximumNestedBlockDepth = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumNestedBlockDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudMaximumNestedBlockDepth, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum Nested Block Depth:";
            // 
            // nudMaximumNestedBlockDepth
            // 
            this.nudMaximumNestedBlockDepth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudMaximumNestedBlockDepth.Location = new System.Drawing.Point(232, 3);
            this.nudMaximumNestedBlockDepth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaximumNestedBlockDepth.Name = "nudMaximumNestedBlockDepth";
            this.nudMaximumNestedBlockDepth.Size = new System.Drawing.Size(108, 25);
            this.nudMaximumNestedBlockDepth.TabIndex = 1;
            this.nudMaximumNestedBlockDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaximumNestedBlockDepth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMaximumNestedBlockDepth.ValueChanged += new System.EventHandler(this.nudMaximumNestedBlockDepth_ValueChanged);
            // 
            // NestedBlockDepthSettingsPageSettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NestedBlockDepthSettingsPageSettingsPage";
            this.Size = new System.Drawing.Size(343, 160);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumNestedBlockDepth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaximumNestedBlockDepth;
    }
}
