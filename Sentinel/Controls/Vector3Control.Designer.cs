﻿namespace Sentinel.Controls
{
    partial class Vector3Control
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
            this.zValueBox = new System.Windows.Forms.TextBox();
            this.yValueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xValueBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zValueBox, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.yValueBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.xValueBox, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // zValueBox
            // 
            this.zValueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zValueBox.Location = new System.Drawing.Point(650, 3);
            this.zValueBox.Name = "zValueBox";
            this.zValueBox.Size = new System.Drawing.Size(100, 22);
            this.zValueBox.TabIndex = 8;
            this.zValueBox.TextChanged += new System.EventHandler(this.zValueBox_TextChanged);
            // 
            // yValueBox
            // 
            this.yValueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yValueBox.Location = new System.Drawing.Point(517, 3);
            this.yValueBox.Name = "yValueBox";
            this.yValueBox.Size = new System.Drawing.Size(100, 22);
            this.yValueBox.TabIndex = 7;
            this.yValueBox.TextChanged += new System.EventHandler(this.yValueBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(623, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Z:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(490, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xValueBox
            // 
            this.xValueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xValueBox.Location = new System.Drawing.Point(384, 3);
            this.xValueBox.Name = "xValueBox";
            this.xValueBox.Size = new System.Drawing.Size(100, 22);
            this.xValueBox.TabIndex = 6;
            this.xValueBox.TextChanged += new System.EventHandler(this.xValueBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 3);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.MinimumSize = new System.Drawing.Size(375, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(375, 22);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name X:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Vector3Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Vector3Control";
            this.Size = new System.Drawing.Size(756, 31);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox zValueBox;
        private System.Windows.Forms.TextBox yValueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xValueBox;
        private System.Windows.Forms.Label nameLabel;
    }
}