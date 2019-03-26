namespace Laura_Magic_Ecurrency_Xchanger
{
    partial class layer1
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
            this.welcome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.convertfrom = new System.Windows.Forms.Label();
            this.convertto = new System.Windows.Forms.Label();
            this.combofrom = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.butconvert = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.textresults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(176, 58);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(497, 55);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to Xchanger";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(465, 287);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 42);
            this.textBox1.TabIndex = 1;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(112, 304);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(307, 25);
            this.amount.TabIndex = 2;
            this.amount.Text = "Enter any amount to Exchange";
            // 
            // convertfrom
            // 
            this.convertfrom.AutoSize = true;
            this.convertfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertfrom.Location = new System.Drawing.Point(55, 165);
            this.convertfrom.Name = "convertfrom";
            this.convertfrom.Size = new System.Drawing.Size(364, 25);
            this.convertfrom.TabIndex = 3;
            this.convertfrom.Text = "Choose the Currency to convert from";
            // 
            // convertto
            // 
            this.convertto.AutoSize = true;
            this.convertto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertto.Location = new System.Drawing.Point(73, 232);
            this.convertto.Name = "convertto";
            this.convertto.Size = new System.Drawing.Size(346, 25);
            this.convertto.TabIndex = 4;
            this.convertto.Text = "Choose the Currency to convert to:";
            // 
            // combofrom
            // 
            this.combofrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combofrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combofrom.FormattingEnabled = true;
            this.combofrom.Items.AddRange(new object[] {
            "Euros",
            "Pounds Sterling",
            "US Dollar"});
            this.combofrom.Location = new System.Drawing.Point(465, 162);
            this.combofrom.Name = "combofrom";
            this.combofrom.Size = new System.Drawing.Size(208, 41);
            this.combofrom.TabIndex = 5;
            this.combofrom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Euros",
            "Pounds Sterling",
            "US Dollar"});
            this.comboBox2.Location = new System.Drawing.Point(465, 232);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 41);
            this.comboBox2.TabIndex = 6;
            // 
            // butconvert
            // 
            this.butconvert.BackColor = System.Drawing.Color.OliveDrab;
            this.butconvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butconvert.Location = new System.Drawing.Point(312, 370);
            this.butconvert.Name = "butconvert";
            this.butconvert.Size = new System.Drawing.Size(253, 57);
            this.butconvert.TabIndex = 7;
            this.butconvert.Text = "Convert";
            this.butconvert.UseVisualStyleBackColor = false;
            this.butconvert.Click += new System.EventHandler(this.butconvert_Click);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(198, 464);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(143, 42);
            this.results.TabIndex = 8;
            this.results.Text = "Results";
            this.results.Click += new System.EventHandler(this.label1_Click);
            // 
            // textresults
            // 
            this.textresults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textresults.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresults.Location = new System.Drawing.Point(369, 462);
            this.textresults.Multiline = true;
            this.textresults.Name = "textresults";
            this.textresults.Size = new System.Drawing.Size(208, 42);
            this.textresults.TabIndex = 9;
            // 
            // layer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(909, 535);
            this.Controls.Add(this.textresults);
            this.Controls.Add(this.results);
            this.Controls.Add(this.butconvert);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.combofrom);
            this.Controls.Add(this.convertto);
            this.Controls.Add(this.convertfrom);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.welcome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "layer1";
            this.Text = "Laura Magic Ecurrency Xchanger";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label convertfrom;
        private System.Windows.Forms.Label convertto;
        private System.Windows.Forms.ComboBox combofrom;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button butconvert;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.TextBox textresults;
    }
}

