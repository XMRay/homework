namespace YTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b1 = new System.Windows.Forms.Button();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.bc = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(567, 385);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(519, 205);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(82, 15);
            this.l3.TabIndex = 9;
            this.l3.Text = "左分支长度";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(519, 160);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(82, 15);
            this.l4.TabIndex = 8;
            this.l4.Text = "右分支长度";
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(615, 200);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(100, 25);
            this.t4.TabIndex = 7;
            this.t4.Text = "0.7";
            this.t4.TextChanged += new System.EventHandler(this.t4_TextChanged);
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(615, 155);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 25);
            this.t3.TabIndex = 6;
            this.t3.Text = "0.6";
            this.t3.TextChanged += new System.EventHandler(this.t3_TextChanged);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(527, 115);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(67, 15);
            this.l2.TabIndex = 13;
            this.l2.Text = "主干长度";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(542, 70);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(37, 15);
            this.l1.TabIndex = 12;
            this.l1.Text = "层数";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(615, 110);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 25);
            this.t2.TabIndex = 11;
            this.t2.Text = "100";
            this.t2.TextChanged += new System.EventHandler(this.t2_TextChanged_1);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(615, 65);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 25);
            this.t1.TabIndex = 10;
            this.t1.Text = "10";
            this.t1.TextChanged += new System.EventHandler(this.t1_TextChanged_1);
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(519, 295);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(82, 15);
            this.l6.TabIndex = 17;
            this.l6.Text = "左分支角度";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(519, 250);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(82, 15);
            this.l5.TabIndex = 16;
            this.l5.Text = "右分支角度";
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(615, 290);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(100, 25);
            this.t6.TabIndex = 15;
            this.t6.Text = "20";
            this.t6.TextChanged += new System.EventHandler(this.t6_TextChanged);
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(615, 245);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(100, 25);
            this.t5.TabIndex = 14;
            this.t5.Text = "30";
            this.t5.TextChanged += new System.EventHandler(this.t5_TextChanged);
            // 
            // colorDialog4
            // 
            this.colorDialog4.Color = System.Drawing.Color.Maroon;
            // 
            // bc
            // 
            this.bc.Location = new System.Drawing.Point(567, 332);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(91, 23);
            this.bc.TabIndex = 18;
            this.bc.Text = "选择颜色";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

