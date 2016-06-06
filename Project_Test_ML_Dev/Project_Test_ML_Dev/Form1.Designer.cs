namespace Project_Test_ML_Dev
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
            this.lblhourdate = new System.Windows.Forms.Label();
            this.btnincrement = new System.Windows.Forms.Button();
            this.btndecrement = new System.Windows.Forms.Button();
            this.txtminutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgood = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhourdate
            // 
            this.lblhourdate.AutoSize = true;
            this.lblhourdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhourdate.Location = new System.Drawing.Point(170, 24);
            this.lblhourdate.Name = "lblhourdate";
            this.lblhourdate.Size = new System.Drawing.Size(146, 16);
            this.lblhourdate.TabIndex = 0;
            this.lblhourdate.Text = "dd/MM/yyyy HH:mm";
            // 
            // btnincrement
            // 
            this.btnincrement.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincrement.Location = new System.Drawing.Point(42, 113);
            this.btnincrement.Name = "btnincrement";
            this.btnincrement.Size = new System.Drawing.Size(54, 43);
            this.btnincrement.TabIndex = 1;
            this.btnincrement.Text = "+";
            this.btnincrement.UseVisualStyleBackColor = true;
            this.btnincrement.Click += new System.EventHandler(this.btnincrement_Click);
            // 
            // btndecrement
            // 
            this.btndecrement.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecrement.Location = new System.Drawing.Point(208, 113);
            this.btndecrement.Name = "btndecrement";
            this.btndecrement.Size = new System.Drawing.Size(54, 43);
            this.btndecrement.TabIndex = 2;
            this.btndecrement.Text = "-";
            this.btndecrement.UseVisualStyleBackColor = true;
            this.btndecrement.Click += new System.EventHandler(this.btndecrement_Click);
            // 
            // txtminutes
            // 
            this.txtminutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminutes.Location = new System.Drawing.Point(102, 76);
            this.txtminutes.Multiline = true;
            this.txtminutes.Name = "txtminutes";
            this.txtminutes.Size = new System.Drawing.Size(100, 35);
            this.txtminutes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Today is";
            // 
            // lblgood
            // 
            this.lblgood.AutoSize = true;
            this.lblgood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgood.Location = new System.Drawing.Point(12, 24);
            this.lblgood.Name = "lblgood";
            this.lblgood.Size = new System.Drawing.Size(0, 16);
            this.lblgood.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Developed by Giovane Ramos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 206);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblgood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtminutes);
            this.Controls.Add(this.btndecrement);
            this.Controls.Add(this.btnincrement);
            this.Controls.Add(this.lblhourdate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhourdate;
        private System.Windows.Forms.Button btnincrement;
        private System.Windows.Forms.Button btndecrement;
        private System.Windows.Forms.TextBox txtminutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

