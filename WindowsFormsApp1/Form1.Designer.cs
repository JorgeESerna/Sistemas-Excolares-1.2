namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.tb_ap1 = new System.Windows.Forms.TextBox();
            this.tb_ap2 = new System.Windows.Forms.TextBox();
            this.pdf = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Url";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Id.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_Id.Location = new System.Drawing.Point(19, 76);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(83, 21);
            this.lb_Id.TabIndex = 2;
            this.lb_Id.Text = "Matricula";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_matricula.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_matricula.Location = new System.Drawing.Point(108, 73);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(167, 28);
            this.tb_matricula.TabIndex = 3;
            this.tb_matricula.Text = "81004";
            // 
            // tb_ap1
            // 
            this.tb_ap1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ap1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_ap1.Location = new System.Drawing.Point(119, 122);
            this.tb_ap1.Name = "tb_ap1";
            this.tb_ap1.Size = new System.Drawing.Size(156, 28);
            this.tb_ap1.TabIndex = 5;
            this.tb_ap1.Text = "Serna";
            // 
            // tb_ap2
            // 
            this.tb_ap2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ap2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_ap2.Location = new System.Drawing.Point(393, 122);
            this.tb_ap2.Name = "tb_ap2";
            this.tb_ap2.Size = new System.Drawing.Size(170, 28);
            this.tb_ap2.TabIndex = 7;
            this.tb_ap2.Text = "Navarro";
            // 
            // pdf
            // 
            this.pdf.Location = new System.Drawing.Point(147, 272);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(75, 23);
            this.pdf.TabIndex = 18;
            this.pdf.Text = "button3";
            this.pdf.UseVisualStyleBackColor = true;
            this.pdf.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_name.Location = new System.Drawing.Point(662, 122);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(134, 28);
            this.tb_name.TabIndex = 19;
            this.tb_name.Text = "Jorge";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 28);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // tb_correo
            // 
            this.tb_correo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_correo.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_correo.Location = new System.Drawing.Point(91, 173);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(185, 28);
            this.tb_correo.TabIndex = 21;
            this.tb_correo.Text = "jserna@gmail.com";
            // 
            // tb_tel
            // 
            this.tb_tel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tel.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_tel.Location = new System.Drawing.Point(427, 173);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(137, 28);
            this.tb_tel.TabIndex = 22;
            this.tb_tel.Text = "6621481478";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(19, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(298, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Apellido P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(583, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(20, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Correo ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(299, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "No. Telefonico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(19, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Guardar como:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(19, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(697, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label10.Location = new System.Drawing.Point(180, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(697, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label11.Location = new System.Drawing.Point(0, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(697, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label12.Location = new System.Drawing.Point(193, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(697, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label13.Location = new System.Drawing.Point(193, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(697, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label14.Location = new System.Drawing.Point(0, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(697, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label15.Location = new System.Drawing.Point(180, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(697, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label16.Location = new System.Drawing.Point(0, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(697, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label17.Location = new System.Drawing.Point(193, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(697, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label18.Location = new System.Drawing.Point(0, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(697, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label19.Location = new System.Drawing.Point(180, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(697, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label20.Location = new System.Drawing.Point(0, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(697, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label21.Location = new System.Drawing.Point(193, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(697, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = resources.GetString("label21.Text");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label22.Location = new System.Drawing.Point(0, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(697, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label23.Location = new System.Drawing.Point(180, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(697, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = resources.GetString("label23.Text");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label24.Location = new System.Drawing.Point(0, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(697, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = resources.GetString("label24.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(41, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sql;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 40);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(874, 777);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_correo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.tb_ap2);
            this.Controls.Add(this.tb_ap1);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.TextBox tb_ap1;
        private System.Windows.Forms.TextBox tb_ap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

