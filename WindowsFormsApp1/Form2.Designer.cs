namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKm = new System.Windows.Forms.Button();
            this.btnPound = new System.Windows.Forms.Button();
            this.btnkg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(480, 402);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "R&eturn";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // txtInput
            // 
            this.txtInput.AcceptsTab = true;
            this.txtInput.Location = new System.Drawing.Point(73, 86);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(207, 65);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select your required metric converter: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "km to miles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnKm
            // 
            this.btnKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKm.Location = new System.Drawing.Point(272, 226);
            this.btnKm.Name = "btnKm";
            this.btnKm.Size = new System.Drawing.Size(139, 64);
            this.btnKm.TabIndex = 5;
            this.btnKm.Text = "miles to km";
            this.btnKm.UseVisualStyleBackColor = true;
            this.btnKm.Click += new System.EventHandler(this.BtnKm_Click);
            // 
            // btnPound
            // 
            this.btnPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPound.Location = new System.Drawing.Point(77, 296);
            this.btnPound.Name = "btnPound";
            this.btnPound.Size = new System.Drawing.Size(139, 64);
            this.btnPound.TabIndex = 6;
            this.btnPound.Text = "kg to lb";
            this.btnPound.UseVisualStyleBackColor = true;
            this.btnPound.Click += new System.EventHandler(this.BtnPound_Click);
            // 
            // btnkg
            // 
            this.btnkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkg.Location = new System.Drawing.Point(272, 296);
            this.btnkg.Name = "btnkg";
            this.btnkg.Size = new System.Drawing.Size(139, 64);
            this.btnkg.TabIndex = 7;
            this.btnkg.Text = "lb to kg";
            this.btnkg.UseVisualStyleBackColor = true;
            this.btnkg.Click += new System.EventHandler(this.Btnkg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 8;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(70, 60);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(141, 20);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "Enter the number: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "C&lear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(312, 86);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(213, 65);
            this.txtOutput.TabIndex = 11;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(314, 60);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(66, 20);
            this.lblAnswer.TabIndex = 12;
            this.lblAnswer.Text = "Answer:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnkg);
            this.Controls.Add(this.btnPound);
            this.Controls.Add(this.btnKm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnReturn);
            this.Name = "Form2";
            this.Text = "Conversion Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKm;
        private System.Windows.Forms.Button btnPound;
        private System.Windows.Forms.Button btnkg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblAnswer;
    }
}