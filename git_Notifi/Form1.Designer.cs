namespace NotifierPopUp18._09._20
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
            this.button1 = new System.Windows.Forms.Button();
            this.IncomList = new System.Windows.Forms.ListBox();
            this.conBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "PopUp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IncomList
            // 
            this.IncomList.FormattingEnabled = true;
            this.IncomList.Location = new System.Drawing.Point(12, 317);
            this.IncomList.Name = "IncomList";
            this.IncomList.Size = new System.Drawing.Size(232, 121);
            this.IncomList.TabIndex = 1;
            // 
            // conBut
            // 
            this.conBut.Location = new System.Drawing.Point(663, 394);
            this.conBut.Name = "conBut";
            this.conBut.Size = new System.Drawing.Size(75, 23);
            this.conBut.TabIndex = 2;
            this.conBut.Text = "Connect";
            this.conBut.UseVisualStyleBackColor = true;
            this.conBut.Click += new System.EventHandler(this.conBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conBut);
            this.Controls.Add(this.IncomList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox IncomList;
        private System.Windows.Forms.Button conBut;
    }
}

