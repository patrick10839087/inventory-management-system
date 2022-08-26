namespace InventoryShopRite
{
    partial class Users
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
            this.userShow = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userShow)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 821);
            this.panel1.TabIndex = 0;
            // 
            // userShow
            // 
            this.userShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userShow.Location = new System.Drawing.Point(666, 72);
            this.userShow.Name = "userShow";
            this.userShow.ReadOnly = true;
            this.userShow.RowHeadersWidth = 51;
            this.userShow.RowTemplate.Height = 29;
            this.userShow.Size = new System.Drawing.Size(634, 673);
            this.userShow.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.surname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.firstName);
            this.panel2.Location = new System.Drawing.Point(212, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 673);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(129, 165);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(185, 27);
            this.password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(129, 123);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(185, 27);
            this.id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(129, 75);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(185, 27);
            this.surname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(129, 31);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(185, 27);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1337, 821);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userShow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView userShow;
        private Panel panel2;
        private TextBox firstName;
        private Label label1;
        private Label label4;
        private TextBox password;
        private Label label3;
        private TextBox id;
        private Label label2;
        private TextBox surname;
        private Button button1;
    }
}