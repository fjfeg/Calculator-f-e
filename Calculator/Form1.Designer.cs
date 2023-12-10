namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTNLOg = new System.Windows.Forms.Button();
            this.bPI = new System.Windows.Forms.Button();
            this.xPOWER3 = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tanh = new System.Windows.Forms.Button();
            this.prosent = new System.Windows.Forms.Button();
            this.Cosh = new System.Windows.Forms.Button();
            this.Sinh = new System.Windows.Forms.Button();
            this.Xpower2 = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.dbg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(13, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn7.Location = new System.Drawing.Point(18, 183);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 65);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn8.Location = new System.Drawing.Point(113, 183);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 65);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(308, 183);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 67);
            this.add.TabIndex = 4;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.numOpr);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn9.Location = new System.Drawing.Point(213, 183);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 65);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(307, 264);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 65);
            this.subtract.TabIndex = 6;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.numOpr);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn6.Location = new System.Drawing.Point(212, 264);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 65);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn5.Location = new System.Drawing.Point(112, 264);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 65);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn4.Location = new System.Drawing.Point(17, 264);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 65);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn2.Location = new System.Drawing.Point(113, 345);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 65);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn1.Location = new System.Drawing.Point(18, 345);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 65);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(308, 345);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 65);
            this.multiply.TabIndex = 10;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.numOpr);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn3.Location = new System.Drawing.Point(213, 345);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 65);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn0.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn0.Location = new System.Drawing.Point(113, 416);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 65);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(18, 416);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 65);
            this.point.TabIndex = 15;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(308, 416);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(75, 65);
            this.devide.TabIndex = 14;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.numOpr);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(213, 416);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 65);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(112, 109);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 65);
            this.change.TabIndex = 20;
            this.change.Text = "CE";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(17, 109);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(75, 65);
            this.deleteAll.TabIndex = 19;
            this.deleteAll.Text = "C";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(307, 109);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 65);
            this.delete.TabIndex = 18;
            this.delete.Text = "BACKSPACE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(212, 109);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 65);
            this.button20.TabIndex = 17;
            this.button20.Text = "±";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bTNLOg
            // 
            this.bTNLOg.Location = new System.Drawing.Point(513, 109);
            this.bTNLOg.Name = "bTNLOg";
            this.bTNLOg.Size = new System.Drawing.Size(75, 65);
            this.bTNLOg.TabIndex = 25;
            this.bTNLOg.Text = "Log";
            this.bTNLOg.UseVisualStyleBackColor = true;
            this.bTNLOg.Click += new System.EventHandler(this.bTNLOg_Click);
            // 
            // bPI
            // 
            this.bPI.Location = new System.Drawing.Point(416, 109);
            this.bPI.Name = "bPI";
            this.bPI.Size = new System.Drawing.Size(75, 65);
            this.bPI.TabIndex = 24;
            this.bPI.Text = "π";
            this.bPI.UseVisualStyleBackColor = true;
            this.bPI.Click += new System.EventHandler(this.bPI_Click);
            // 
            // xPOWER3
            // 
            this.xPOWER3.Location = new System.Drawing.Point(611, 109);
            this.xPOWER3.Name = "xPOWER3";
            this.xPOWER3.Size = new System.Drawing.Size(75, 65);
            this.xPOWER3.TabIndex = 22;
            this.xPOWER3.Text = "X^3";
            this.xPOWER3.UseVisualStyleBackColor = true;
            this.xPOWER3.Click += new System.EventHandler(this.xPOWER3_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(513, 183);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 65);
            this.tan.TabIndex = 29;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(416, 188);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 65);
            this.btnE.TabIndex = 28;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(611, 418);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 65);
            this.sin.TabIndex = 27;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(611, 188);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 65);
            this.cos.TabIndex = 26;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // tanh
            // 
            this.tanh.Location = new System.Drawing.Point(513, 264);
            this.tanh.Name = "tanh";
            this.tanh.Size = new System.Drawing.Size(75, 65);
            this.tanh.TabIndex = 33;
            this.tanh.Text = "Tanh";
            this.tanh.UseVisualStyleBackColor = true;
            this.tanh.Click += new System.EventHandler(this.tanh_Click);
            // 
            // prosent
            // 
            this.prosent.Location = new System.Drawing.Point(416, 264);
            this.prosent.Name = "prosent";
            this.prosent.Size = new System.Drawing.Size(75, 65);
            this.prosent.TabIndex = 32;
            this.prosent.Text = "%";
            this.prosent.UseVisualStyleBackColor = true;
            this.prosent.Click += new System.EventHandler(this.prosent_Click);
            // 
            // Cosh
            // 
            this.Cosh.Location = new System.Drawing.Point(513, 418);
            this.Cosh.Name = "Cosh";
            this.Cosh.Size = new System.Drawing.Size(75, 65);
            this.Cosh.TabIndex = 31;
            this.Cosh.Text = "Cosh";
            this.Cosh.UseVisualStyleBackColor = true;
            this.Cosh.Click += new System.EventHandler(this.Cosh_Click);
            // 
            // Sinh
            // 
            this.Sinh.Location = new System.Drawing.Point(611, 264);
            this.Sinh.Name = "Sinh";
            this.Sinh.Size = new System.Drawing.Size(75, 65);
            this.Sinh.TabIndex = 30;
            this.Sinh.Text = "Sinh";
            this.Sinh.UseVisualStyleBackColor = true;
            this.Sinh.Click += new System.EventHandler(this.Sinh_Click);
            // 
            // Xpower2
            // 
            this.Xpower2.Location = new System.Drawing.Point(513, 345);
            this.Xpower2.Name = "Xpower2";
            this.Xpower2.Size = new System.Drawing.Size(75, 65);
            this.Xpower2.TabIndex = 37;
            this.Xpower2.Text = "X^2";
            this.Xpower2.UseVisualStyleBackColor = true;
            this.Xpower2.Click += new System.EventHandler(this.Xpower2_Click);
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(416, 345);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(75, 65);
            this.In.TabIndex = 36;
            this.In.Text = "!";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(416, 416);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 65);
            this.root.TabIndex = 35;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // dbg
            // 
            this.dbg.Location = new System.Drawing.Point(611, 345);
            this.dbg.Name = "dbg";
            this.dbg.Size = new System.Drawing.Size(75, 65);
            this.dbg.TabIndex = 34;
            this.dbg.Text = "1/x";
            this.dbg.UseVisualStyleBackColor = true;
            this.dbg.Click += new System.EventHandler(this.dbg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(785, 495);
            this.Controls.Add(this.Xpower2);
            this.Controls.Add(this.In);
            this.Controls.Add(this.root);
            this.Controls.Add(this.dbg);
            this.Controls.Add(this.tanh);
            this.Controls.Add(this.prosent);
            this.Controls.Add(this.Cosh);
            this.Controls.Add(this.Sinh);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.bTNLOg);
            this.Controls.Add(this.bPI);
            this.Controls.Add(this.xPOWER3);
            this.Controls.Add(this.change);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.point);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.add);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button bTNLOg;
        private System.Windows.Forms.Button bPI;
        private System.Windows.Forms.Button xPOWER3;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tanh;
        private System.Windows.Forms.Button prosent;
        private System.Windows.Forms.Button Cosh;
        private System.Windows.Forms.Button Sinh;
        private System.Windows.Forms.Button Xpower2;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button dbg;
    }
}

