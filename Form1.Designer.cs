namespace GeometryFigure
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
            this.circle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.rotate = new System.Windows.Forms.Button();
            this.txtCircleY = new System.Windows.Forms.TextBox();
            this.txtCircleX = new System.Windows.Forms.TextBox();
            this.txtCircleRadius = new System.Windows.Forms.TextBox();
            this.txtSquareY = new System.Windows.Forms.TextBox();
            this.txtSquareX = new System.Windows.Forms.TextBox();
            this.txtSquareSideLength = new System.Windows.Forms.TextBox();
            this.txtRectangleY = new System.Windows.Forms.TextBox();
            this.txtRectangleX = new System.Windows.Forms.TextBox();
            this.txtRectangleHeight = new System.Windows.Forms.TextBox();
            this.txtRectangleWidth = new System.Windows.Forms.TextBox();
            this.txtMoveY = new System.Windows.Forms.TextBox();
            this.txtMoveX = new System.Windows.Forms.TextBox();
            this.txtResizeHeight = new System.Windows.Forms.TextBox();
            this.txtResizeWidth = new System.Windows.Forms.TextBox();
            this.txtRotateAngle = new System.Windows.Forms.TextBox();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(57, 326);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(75, 23);
            this.circle.TabIndex = 0;
            this.circle.Text = "circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(152, 326);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 23);
            this.square.TabIndex = 1;
            this.square.Text = "square";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(254, 326);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(75, 23);
            this.rectangle.TabIndex = 2;
            this.rectangle.Text = "rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(364, 326);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(75, 23);
            this.move.TabIndex = 3;
            this.move.Text = "move";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // resize
            // 
            this.resize.Location = new System.Drawing.Point(467, 326);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(75, 23);
            this.resize.TabIndex = 4;
            this.resize.Text = "resize";
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(573, 326);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 23);
            this.rotate.TabIndex = 5;
            this.rotate.Text = "rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // txtCircleY
            // 
            this.txtCircleY.Location = new System.Drawing.Point(57, 265);
            this.txtCircleY.Name = "txtCircleY";
            this.txtCircleY.Size = new System.Drawing.Size(75, 22);
            this.txtCircleY.TabIndex = 6;
            // 
            // txtCircleX
            // 
            this.txtCircleX.Location = new System.Drawing.Point(57, 224);
            this.txtCircleX.Name = "txtCircleX";
            this.txtCircleX.Size = new System.Drawing.Size(75, 22);
            this.txtCircleX.TabIndex = 7;
            // 
            // txtCircleRadius
            // 
            this.txtCircleRadius.Location = new System.Drawing.Point(57, 181);
            this.txtCircleRadius.Name = "txtCircleRadius";
            this.txtCircleRadius.Size = new System.Drawing.Size(75, 22);
            this.txtCircleRadius.TabIndex = 8;
            // 
            // txtSquareY
            // 
            this.txtSquareY.Location = new System.Drawing.Point(152, 265);
            this.txtSquareY.Name = "txtSquareY";
            this.txtSquareY.Size = new System.Drawing.Size(75, 22);
            this.txtSquareY.TabIndex = 9;
            // 
            // txtSquareX
            // 
            this.txtSquareX.Location = new System.Drawing.Point(152, 224);
            this.txtSquareX.Name = "txtSquareX";
            this.txtSquareX.Size = new System.Drawing.Size(75, 22);
            this.txtSquareX.TabIndex = 10;
            // 
            // txtSquareSideLength
            // 
            this.txtSquareSideLength.Location = new System.Drawing.Point(152, 181);
            this.txtSquareSideLength.Name = "txtSquareSideLength";
            this.txtSquareSideLength.Size = new System.Drawing.Size(75, 22);
            this.txtSquareSideLength.TabIndex = 11;
            // 
            // txtRectangleY
            // 
            this.txtRectangleY.Location = new System.Drawing.Point(254, 265);
            this.txtRectangleY.Name = "txtRectangleY";
            this.txtRectangleY.Size = new System.Drawing.Size(75, 22);
            this.txtRectangleY.TabIndex = 12;
            // 
            // txtRectangleX
            // 
            this.txtRectangleX.Location = new System.Drawing.Point(254, 224);
            this.txtRectangleX.Name = "txtRectangleX";
            this.txtRectangleX.Size = new System.Drawing.Size(75, 22);
            this.txtRectangleX.TabIndex = 13;
            // 
            // txtRectangleHeight
            // 
            this.txtRectangleHeight.Location = new System.Drawing.Point(254, 181);
            this.txtRectangleHeight.Name = "txtRectangleHeight";
            this.txtRectangleHeight.Size = new System.Drawing.Size(75, 22);
            this.txtRectangleHeight.TabIndex = 14;
            // 
            // txtRectangleWidth
            // 
            this.txtRectangleWidth.Location = new System.Drawing.Point(254, 143);
            this.txtRectangleWidth.Name = "txtRectangleWidth";
            this.txtRectangleWidth.Size = new System.Drawing.Size(75, 22);
            this.txtRectangleWidth.TabIndex = 15;
            // 
            // txtMoveY
            // 
            this.txtMoveY.Location = new System.Drawing.Point(364, 265);
            this.txtMoveY.Name = "txtMoveY";
            this.txtMoveY.Size = new System.Drawing.Size(75, 22);
            this.txtMoveY.TabIndex = 16;
            // 
            // txtMoveX
            // 
            this.txtMoveX.Location = new System.Drawing.Point(364, 224);
            this.txtMoveX.Name = "txtMoveX";
            this.txtMoveX.Size = new System.Drawing.Size(75, 22);
            this.txtMoveX.TabIndex = 17;
            // 
            // txtResizeHeight
            // 
            this.txtResizeHeight.Location = new System.Drawing.Point(467, 265);
            this.txtResizeHeight.Name = "txtResizeHeight";
            this.txtResizeHeight.Size = new System.Drawing.Size(75, 22);
            this.txtResizeHeight.TabIndex = 18;
            // 
            // txtResizeWidth
            // 
            this.txtResizeWidth.Location = new System.Drawing.Point(467, 224);
            this.txtResizeWidth.Name = "txtResizeWidth";
            this.txtResizeWidth.Size = new System.Drawing.Size(75, 22);
            this.txtResizeWidth.TabIndex = 19;
            // 
            // txtRotateAngle
            // 
            this.txtRotateAngle.Location = new System.Drawing.Point(573, 265);
            this.txtRotateAngle.Name = "txtRotateAngle";
            this.txtRotateAngle.Size = new System.Drawing.Size(75, 22);
            this.txtRotateAngle.TabIndex = 20;
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(539, 105);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(200, 100);
            this.drawingPanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 39);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(3, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 39);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(3, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 381);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(763, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 381);
            this.panel4.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.txtRotateAngle);
            this.Controls.Add(this.txtResizeWidth);
            this.Controls.Add(this.txtResizeHeight);
            this.Controls.Add(this.txtMoveX);
            this.Controls.Add(this.txtMoveY);
            this.Controls.Add(this.txtRectangleWidth);
            this.Controls.Add(this.txtRectangleHeight);
            this.Controls.Add(this.txtRectangleX);
            this.Controls.Add(this.txtRectangleY);
            this.Controls.Add(this.txtSquareSideLength);
            this.Controls.Add(this.txtSquareX);
            this.Controls.Add(this.txtSquareY);
            this.Controls.Add(this.txtCircleRadius);
            this.Controls.Add(this.txtCircleX);
            this.Controls.Add(this.txtCircleY);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.resize);
            this.Controls.Add(this.move);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.square);
            this.Controls.Add(this.circle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.TextBox txtCircleY;
        private System.Windows.Forms.TextBox txtCircleX;
        private System.Windows.Forms.TextBox txtCircleRadius;
        private System.Windows.Forms.TextBox txtSquareY;
        private System.Windows.Forms.TextBox txtSquareX;
        private System.Windows.Forms.TextBox txtSquareSideLength;
        private System.Windows.Forms.TextBox txtRectangleY;
        private System.Windows.Forms.TextBox txtRectangleX;
        private System.Windows.Forms.TextBox txtRectangleHeight;
        private System.Windows.Forms.TextBox txtRectangleWidth;
        private System.Windows.Forms.TextBox txtMoveY;
        private System.Windows.Forms.TextBox txtMoveX;
        private System.Windows.Forms.TextBox txtResizeHeight;
        private System.Windows.Forms.TextBox txtResizeWidth;
        private System.Windows.Forms.TextBox txtRotateAngle;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

