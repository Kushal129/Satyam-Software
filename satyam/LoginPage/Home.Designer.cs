namespace LoginPage
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_adminname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mini = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.date_Date = new System.Windows.Forms.DateTimePicker();
            this.combo_alldata = new System.Windows.Forms.ComboBox();
            this.rb_advance = new System.Windows.Forms.RadioButton();
            this.rb_total = new System.Windows.Forms.RadioButton();
            this.rb_pending = new System.Windows.Forms.RadioButton();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.gv_alldata = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_alldata)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1256, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(58, 56);
            this.btn_close.TabIndex = 21;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_adminname
            // 
            this.txt_adminname.AutoSize = true;
            this.txt_adminname.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminname.Location = new System.Drawing.Point(7, 18);
            this.txt_adminname.Name = "txt_adminname";
            this.txt_adminname.Size = new System.Drawing.Size(105, 23);
            this.txt_adminname.TabIndex = 4;
            this.txt_adminname.Text = "Adminnmae";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.btn_mini);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.txt_adminname);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 56);
            this.panel1.TabIndex = 5;
            // 
            // btn_mini
            // 
            this.btn_mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(1198, 0);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(58, 56);
            this.btn_mini.TabIndex = 5;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(586, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(218, 40);
            this.name.TabIndex = 4;
            this.name.Text = "Satyam Xerox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Work";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Note";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(60, 117);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(233, 26);
            this.txt_name.TabIndex = 6;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phonenumber.Location = new System.Drawing.Point(353, 117);
            this.txt_phonenumber.Multiline = true;
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(233, 26);
            this.txt_phonenumber.TabIndex = 7;
            // 
            // date_Date
            // 
            this.date_Date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.date_Date.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.date_Date.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.date_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date_Date.Location = new System.Drawing.Point(637, 117);
            this.date_Date.Name = "date_Date";
            this.date_Date.Size = new System.Drawing.Size(223, 24);
            this.date_Date.TabIndex = 8;
            this.date_Date.Value = new System.DateTime(2023, 5, 30, 15, 50, 8, 0);
            // 
            // combo_alldata
            // 
            this.combo_alldata.AllowDrop = true;
            this.combo_alldata.FormattingEnabled = true;
            this.combo_alldata.ItemHeight = 16;
            this.combo_alldata.Items.AddRange(new object[] {
            "Aadhar card",
            "Pan card",
            "Ration card"});
            this.combo_alldata.Location = new System.Drawing.Point(60, 211);
            this.combo_alldata.Name = "combo_alldata";
            this.combo_alldata.Size = new System.Drawing.Size(223, 24);
            this.combo_alldata.TabIndex = 9;
            this.combo_alldata.Text = "Select Item";
            this.combo_alldata.SelectedIndexChanged += new System.EventHandler(this.combo_alldata_SelectedIndexChanged);
            // 
            // rb_advance
            // 
            this.rb_advance.AutoSize = true;
            this.rb_advance.Location = new System.Drawing.Point(362, 212);
            this.rb_advance.Name = "rb_advance";
            this.rb_advance.Size = new System.Drawing.Size(82, 20);
            this.rb_advance.TabIndex = 10;
            this.rb_advance.TabStop = true;
            this.rb_advance.Text = "Advance";
            this.rb_advance.UseVisualStyleBackColor = true;
            this.rb_advance.CheckedChanged += new System.EventHandler(this.rb_advance_CheckedChanged);
            // 
            // rb_total
            // 
            this.rb_total.AutoSize = true;
            this.rb_total.Location = new System.Drawing.Point(362, 238);
            this.rb_total.Name = "rb_total";
            this.rb_total.Size = new System.Drawing.Size(59, 20);
            this.rb_total.TabIndex = 11;
            this.rb_total.TabStop = true;
            this.rb_total.Text = "Total";
            this.rb_total.UseVisualStyleBackColor = true;
            this.rb_total.CheckedChanged += new System.EventHandler(this.rb_total_CheckedChanged);
            // 
            // rb_pending
            // 
            this.rb_pending.AutoSize = true;
            this.rb_pending.Location = new System.Drawing.Point(362, 264);
            this.rb_pending.Name = "rb_pending";
            this.rb_pending.Size = new System.Drawing.Size(78, 20);
            this.rb_pending.TabIndex = 12;
            this.rb_pending.TabStop = true;
            this.rb_pending.Text = "Pending";
            this.rb_pending.UseVisualStyleBackColor = true;
            this.rb_pending.CheckedChanged += new System.EventHandler(this.rb_pending_CheckedChanged);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_amount.Location = new System.Drawing.Point(637, 219);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(223, 26);
            this.txt_amount.TabIndex = 13;
            // 
            // txt_note
            // 
            this.txt_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_note.Location = new System.Drawing.Point(60, 320);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(426, 75);
            this.txt_note.TabIndex = 14;
            this.txt_note.TextChanged += new System.EventHandler(this.txt_note_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(923, 93);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(134, 46);
            this.btn_search.TabIndex = 16;
            this.btn_search.Tag = "Search The Reord";
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(923, 174);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(134, 46);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(923, 251);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(134, 46);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(923, 331);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(134, 46);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // gv_alldata
            // 
            this.gv_alldata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.gv_alldata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_alldata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_alldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_alldata.GridColor = System.Drawing.SystemColors.Control;
            this.gv_alldata.Location = new System.Drawing.Point(11, 459);
            this.gv_alldata.Name = "gv_alldata";
            this.gv_alldata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gv_alldata.RowTemplate.Height = 24;
            this.gv_alldata.Size = new System.Drawing.Size(1289, 332);
            this.gv_alldata.TabIndex = 26;
            this.gv_alldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_alldata_CellContentClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(1199, 423);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 29);
            this.btn_refresh.TabIndex = 20;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(721, 343);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(116, 34);
            this.btn_clr.TabIndex = 19;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 803);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gv_alldata);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.rb_pending);
            this.Controls.Add(this.rb_total);
            this.Controls.Add(this.rb_advance);
            this.Controls.Add(this.combo_alldata);
            this.Controls.Add(this.date_Date);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_alldata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label txt_adminname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.DateTimePicker date_Date;
        private System.Windows.Forms.ComboBox combo_alldata;
        private System.Windows.Forms.RadioButton rb_advance;
        private System.Windows.Forms.RadioButton rb_total;
        private System.Windows.Forms.RadioButton rb_pending;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView gv_alldata;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_clr;
    }
}