namespace GPAxCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxinputName = new System.Windows.Forms.TextBox();
            this.textBoxinputGPA = new System.Windows.Forms.TextBox();
            this.textBoxallData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA INPUT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(702, 58);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(112, 42);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(440, 78);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(156, 39);
            this.textBoxGPA.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxGPA);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(69, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 312);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Location = new System.Drawing.Point(440, 202);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.Size = new System.Drawing.Size(156, 39);
            this.textBoxMinGPA.TabIndex = 12;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Location = new System.Drawing.Point(440, 138);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.Size = new System.Drawing.Size(156, 39);
            this.textBoxMaxGPA.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Location = new System.Drawing.Point(171, 205);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.Size = new System.Drawing.Size(257, 39);
            this.textBoxMinName.TabIndex = 9;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Location = new System.Drawing.Point(171, 138);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(257, 39);
            this.textBoxMaxName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "MIN GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "MAX GPA\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "GPAX";
            // 
            // textBoxinputName
            // 
            this.textBoxinputName.Location = new System.Drawing.Point(240, 56);
            this.textBoxinputName.Multiline = true;
            this.textBoxinputName.Name = "textBoxinputName";
            this.textBoxinputName.Size = new System.Drawing.Size(257, 39);
            this.textBoxinputName.TabIndex = 13;
            this.textBoxinputName.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBoxinputGPA
            // 
            this.textBoxinputGPA.Location = new System.Drawing.Point(509, 55);
            this.textBoxinputGPA.Multiline = true;
            this.textBoxinputGPA.Name = "textBoxinputGPA";
            this.textBoxinputGPA.Size = new System.Drawing.Size(156, 39);
            this.textBoxinputGPA.TabIndex = 14;
            // 
            // textBoxallData
            // 
            this.textBoxallData.Location = new System.Drawing.Point(93, 458);
            this.textBoxallData.Multiline = true;
            this.textBoxallData.Name = "textBoxallData";
            this.textBoxallData.Size = new System.Drawing.Size(721, 229);
            this.textBoxallData.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 776);
            this.Controls.Add(this.textBoxallData);
            this.Controls.Add(this.textBoxinputGPA);
            this.Controls.Add(this.textBoxinputName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button ADD;
        private TextBox textBoxGPA;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBoxMinName;
        private TextBox textBoxMaxName;
        private Label label4;
        private Label label3;
        private Button button2;
        private TextBox textBoxMinGPA;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxinputName;
        private TextBox textBoxinputGPA;
        private TextBox textBoxallData;
    }
}