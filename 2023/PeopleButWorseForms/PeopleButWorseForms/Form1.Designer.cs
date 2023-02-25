namespace PeopleButWorseForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.updatebtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.surnametextbox = new System.Windows.Forms.TextBox();
            this.surnamelabel = new System.Windows.Forms.Label();
            this.phonetextbox = new System.Windows.Forms.TextBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.removebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatebtn.Location = new System.Drawing.Point(50, 350);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(200, 125);
            this.updatebtn.TabIndex = 0;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadbtn.Location = new System.Drawing.Point(50, 200);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(200, 125);
            this.loadbtn.TabIndex = 1;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebtn.Location = new System.Drawing.Point(50, 50);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(200, 125);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // listbox
            // 
            this.listbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 17;
            this.listbox.Location = new System.Drawing.Point(300, 295);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(450, 480);
            this.listbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.namelabel.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.namelabel.Location = new System.Drawing.Point(300, 63);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(72, 27);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "Name:";
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Cascadia Code", 27.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nametextbox.Location = new System.Drawing.Point(425, 50);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(325, 50);
            this.nametextbox.TabIndex = 6;
            // 
            // surnametextbox
            // 
            this.surnametextbox.Font = new System.Drawing.Font("Cascadia Code", 27.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnametextbox.Location = new System.Drawing.Point(425, 121);
            this.surnametextbox.Name = "surnametextbox";
            this.surnametextbox.Size = new System.Drawing.Size(325, 50);
            this.surnametextbox.TabIndex = 8;
            // 
            // surnamelabel
            // 
            this.surnamelabel.AutoSize = true;
            this.surnamelabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.surnamelabel.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.surnamelabel.Location = new System.Drawing.Point(300, 134);
            this.surnamelabel.Name = "surnamelabel";
            this.surnamelabel.Size = new System.Drawing.Size(108, 27);
            this.surnamelabel.TabIndex = 7;
            this.surnamelabel.Text = "Surname:";
            // 
            // phonetextbox
            // 
            this.phonetextbox.Font = new System.Drawing.Font("Cascadia Code", 27.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonetextbox.Location = new System.Drawing.Point(425, 200);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.Size = new System.Drawing.Size(325, 50);
            this.phonetextbox.TabIndex = 10;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.phonelabel.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phonelabel.Location = new System.Drawing.Point(300, 213);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(84, 27);
            this.phonelabel.TabIndex = 9;
            this.phonelabel.Text = "Phone:";
            // 
            // removebtn
            // 
            this.removebtn.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removebtn.Location = new System.Drawing.Point(50, 500);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(200, 125);
            this.removebtn.TabIndex = 11;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(50, 650);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(200, 125);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 825);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.phonetextbox);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.surnametextbox);
            this.Controls.Add(this.surnamelabel);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.updatebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "blues list box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updatebtn;
        private Button loadbtn;
        private Button savebtn;
        private ListBox listbox;
        private Label label1;
        private Label namelabel;
        private TextBox nametextbox;
        private TextBox surnametextbox;
        private Label surnamelabel;
        private TextBox phonetextbox;
        private Label phonelabel;
        private Button removebtn;
        private Button deletebtn;
    }
}