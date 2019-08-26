namespace ConvexHull
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxXCoor = new System.Windows.Forms.TextBox();
            this.txtBoxYCoor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnDrawHull = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.lstBoxAddedPoints = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnDrawHull);
            this.panel1.Controls.Add(this.btnAddPoint);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxYCoor);
            this.panel1.Controls.Add(this.txtBoxXCoor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 618);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "XCoor";
            // 
            // txtBoxXCoor
            // 
            this.txtBoxXCoor.Location = new System.Drawing.Point(23, 143);
            this.txtBoxXCoor.Name = "txtBoxXCoor";
            this.txtBoxXCoor.Size = new System.Drawing.Size(100, 22);
            this.txtBoxXCoor.TabIndex = 1;
            // 
            // txtBoxYCoor
            // 
            this.txtBoxYCoor.Location = new System.Drawing.Point(20, 206);
            this.txtBoxYCoor.Name = "txtBoxYCoor";
            this.txtBoxYCoor.Size = new System.Drawing.Size(100, 22);
            this.txtBoxYCoor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "YCoor";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(33, 248);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPoint.TabIndex = 4;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            // 
            // btnDrawHull
            // 
            this.btnDrawHull.Location = new System.Drawing.Point(0, 316);
            this.btnDrawHull.Name = "btnDrawHull";
            this.btnDrawHull.Size = new System.Drawing.Size(197, 54);
            this.btnDrawHull.TabIndex = 5;
            this.btnDrawHull.Text = "Draw Convex Hull";
            this.btnDrawHull.UseVisualStyleBackColor = true;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(215, 1);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(567, 618);
            this.canvas.TabIndex = 1;
            // 
            // lstBoxAddedPoints
            // 
            this.lstBoxAddedPoints.FormattingEnabled = true;
            this.lstBoxAddedPoints.ItemHeight = 16;
            this.lstBoxAddedPoints.Location = new System.Drawing.Point(788, 3);
            this.lstBoxAddedPoints.Name = "lstBoxAddedPoints";
            this.lstBoxAddedPoints.Size = new System.Drawing.Size(151, 628);
            this.lstBoxAddedPoints.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 631);
            this.Controls.Add(this.lstBoxAddedPoints);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDrawHull;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxYCoor;
        private System.Windows.Forms.TextBox txtBoxXCoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.ListBox lstBoxAddedPoints;
    }
}

