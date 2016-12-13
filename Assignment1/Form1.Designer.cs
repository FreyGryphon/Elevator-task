namespace Assignment1
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
            this.components = new System.ComponentModel.Container();
            this.downbtn = new System.Windows.Forms.Button();
            this.upbtn = new System.Windows.Forms.Button();
            this.lift = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liftBox = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downbtn
            // 
            this.downbtn.Location = new System.Drawing.Point(189, 214);
            this.downbtn.Name = "downbtn";
            this.downbtn.Size = new System.Drawing.Size(75, 23);
            this.downbtn.TabIndex = 0;
            this.downbtn.Text = "Ground floor";
            this.downbtn.UseVisualStyleBackColor = true;
            this.downbtn.Click += new System.EventHandler(this.downbtn_Click);
            // 
            // upbtn
            // 
            this.upbtn.Location = new System.Drawing.Point(189, 80);
            this.upbtn.Name = "upbtn";
            this.upbtn.Size = new System.Drawing.Size(75, 23);
            this.upbtn.TabIndex = 1;
            this.upbtn.Text = "First floor";
            this.upbtn.UseVisualStyleBackColor = true;
            this.upbtn.Click += new System.EventHandler(this.upbtn_Click);
            // 
            // lift
            // 
            this.lift.Location = new System.Drawing.Point(105, 199);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(75, 135);
            this.lift.TabIndex = 2;
            this.lift.UseVisualStyleBackColor = true;
            this.lift.Click += new System.EventHandler(this.lift_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(270, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 264);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Events";
            // 
            // liftBox
            // 
            this.liftBox.Location = new System.Drawing.Point(189, 145);
            this.liftBox.Name = "liftBox";
            this.liftBox.ReadOnly = true;
            this.liftBox.RejectInputOnFirstFailure = true;
            this.liftBox.Size = new System.Drawing.Size(74, 20);
            this.liftBox.TabIndex = 5;
            this.liftBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.liftBox_MaskInputRejected);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(189, 338);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 393);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.liftBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.upbtn);
            this.Controls.Add(this.downbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downbtn;
        private System.Windows.Forms.Button upbtn;
        private System.Windows.Forms.Button lift;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox liftBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_load;
    }
}

