namespace ElevatorProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_lift_down = new System.Windows.Forms.Timer(this.components);
            this.timer_lift_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            this.DATABASE = new System.Windows.Forms.ListBox();
            this.btn_displaylog = new System.Windows.Forms.Button();
            this.btn_clearlog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.door_left_up = new System.Windows.Forms.PictureBox();
            this.door_right_up = new System.Windows.Forms.PictureBox();
            this.display_bottom = new System.Windows.Forms.PictureBox();
            this.display_top = new System.Windows.Forms.PictureBox();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.picture_lift = new System.Windows.Forms.PictureBox();
            this.bg_firstfloor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.display_panel = new System.Windows.Forms.PictureBox();
            this.btn_G = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_firstfloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_lift_down
            // 
            this.timer_lift_down.Interval = 15;
            this.timer_lift_down.Tick += new System.EventHandler(this.timer_lift_down_Tick);
            // 
            // timer_lift_up
            // 
            this.timer_lift_up.Interval = 15;
            this.timer_lift_up.Tick += new System.EventHandler(this.timer_lift_up_Tick);
            // 
            // timer_door_open_down
            // 
            this.timer_door_open_down.Interval = 5;
            this.timer_door_open_down.Tick += new System.EventHandler(this.door_open_down_Tick);
            // 
            // timer_door_close_down
            // 
            this.timer_door_close_down.Interval = 5;
            this.timer_door_close_down.Tick += new System.EventHandler(this.door_close_down_Tick);
            // 
            // timer_door_open_up
            // 
            this.timer_door_open_up.Interval = 5;
            this.timer_door_open_up.Tick += new System.EventHandler(this.timer_door_open_up_Tick);
            // 
            // timer_door_close_up
            // 
            this.timer_door_close_up.Interval = 5;
            this.timer_door_close_up.Tick += new System.EventHandler(this.timer_door_close_up_Tick);
            // 
            // DATABASE
            // 
            this.DATABASE.FormattingEnabled = true;
            this.DATABASE.ItemHeight = 15;
            this.DATABASE.Location = new System.Drawing.Point(21, 59);
            this.DATABASE.Margin = new System.Windows.Forms.Padding(4);
            this.DATABASE.Name = "DATABASE";
            this.DATABASE.Size = new System.Drawing.Size(575, 634);
            this.DATABASE.TabIndex = 20;
            // 
            // btn_displaylog
            // 
            this.btn_displaylog.BackColor = System.Drawing.Color.White;
            this.btn_displaylog.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_displaylog.Location = new System.Drawing.Point(1307, 653);
            this.btn_displaylog.Margin = new System.Windows.Forms.Padding(4);
            this.btn_displaylog.Name = "btn_displaylog";
            this.btn_displaylog.Size = new System.Drawing.Size(172, 43);
            this.btn_displaylog.TabIndex = 21;
            this.btn_displaylog.Text = "button 1";
            this.btn_displaylog.UseVisualStyleBackColor = false;
            this.btn_displaylog.Click += new System.EventHandler(this.btn_displaylog_Click);
            // 
            // btn_clearlog
            // 
            this.btn_clearlog.BackColor = System.Drawing.Color.White;
            this.btn_clearlog.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearlog.Location = new System.Drawing.Point(1307, 704);
            this.btn_clearlog.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearlog.Name = "btn_clearlog";
            this.btn_clearlog.Size = new System.Drawing.Size(171, 41);
            this.btn_clearlog.TabIndex = 22;
            this.btn_clearlog.Text = "button 2";
            this.btn_clearlog.UseVisualStyleBackColor = false;
            this.btn_clearlog.Click += new System.EventHandler(this.btn_clearlog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.DATABASE);
            this.groupBox1.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(703, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(596, 711);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // door_left_up
            // 
            this.door_left_up.BackColor = System.Drawing.Color.LightGray;
            this.door_left_up.Location = new System.Drawing.Point(99, 78);
            this.door_left_up.Margin = new System.Windows.Forms.Padding(4);
            this.door_left_up.Name = "door_left_up";
            this.door_left_up.Size = new System.Drawing.Size(88, 241);
            this.door_left_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_left_up.TabIndex = 18;
            this.door_left_up.TabStop = false;
            // 
            // door_right_up
            // 
            this.door_right_up.BackColor = System.Drawing.Color.LightGray;
            this.door_right_up.Location = new System.Drawing.Point(185, 78);
            this.door_right_up.Margin = new System.Windows.Forms.Padding(4);
            this.door_right_up.Name = "door_right_up";
            this.door_right_up.Size = new System.Drawing.Size(87, 241);
            this.door_right_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_right_up.TabIndex = 19;
            this.door_right_up.TabStop = false;
            // 
            // display_bottom
            // 
            this.display_bottom.BackColor = System.Drawing.Color.White;
            this.display_bottom.Location = new System.Drawing.Point(176, 417);
            this.display_bottom.Margin = new System.Windows.Forms.Padding(4);
            this.display_bottom.Name = "display_bottom";
            this.display_bottom.Size = new System.Drawing.Size(17, 17);
            this.display_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_bottom.TabIndex = 9;
            this.display_bottom.TabStop = false;
            // 
            // display_top
            // 
            this.display_top.BackColor = System.Drawing.Color.White;
            this.display_top.Location = new System.Drawing.Point(176, 34);
            this.display_top.Margin = new System.Windows.Forms.Padding(4);
            this.display_top.Name = "display_top";
            this.display_top.Size = new System.Drawing.Size(17, 17);
            this.display_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_top.TabIndex = 8;
            this.display_top.TabStop = false;
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.BackgroundImage = global::ElevatorProject.Properties.Resources.direction_north;
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(297, 559);
            this.btn_down.Margin = new System.Windows.Forms.Padding(4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(53, 48);
            this.btn_down.TabIndex = 7;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(297, 182);
            this.btn_up.Margin = new System.Windows.Forms.Padding(4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(53, 48);
            this.btn_up.TabIndex = 6;
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // picture_lift
            // 
            this.picture_lift.BackColor = System.Drawing.Color.Transparent;
            this.picture_lift.Image = global::ElevatorProject.Properties.Resources.Inside_of_the_lift;
            this.picture_lift.Location = new System.Drawing.Point(99, 78);
            this.picture_lift.Margin = new System.Windows.Forms.Padding(4);
            this.picture_lift.Name = "picture_lift";
            this.picture_lift.Size = new System.Drawing.Size(173, 236);
            this.picture_lift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_lift.TabIndex = 3;
            this.picture_lift.TabStop = false;
            // 
            // bg_firstfloor
            // 
            this.bg_firstfloor.BackColor = System.Drawing.Color.Transparent;
            this.bg_firstfloor.Location = new System.Drawing.Point(1, 0);
            this.bg_firstfloor.Margin = new System.Windows.Forms.Padding(4);
            this.bg_firstfloor.Name = "bg_firstfloor";
            this.bg_firstfloor.Size = new System.Drawing.Size(368, 390);
            this.bg_firstfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg_firstfloor.TabIndex = 0;
            this.bg_firstfloor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1, 398);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(297, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 48);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Location = new System.Drawing.Point(99, 417);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Location = new System.Drawing.Point(185, 417);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 241);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(176, 392);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.LightGray;
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_1.Location = new System.Drawing.Point(494, 392);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 60);
            this.btn_1.TabIndex = 11;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.Color.LightGray;
            this.display_panel.Location = new System.Drawing.Point(494, 250);
            this.display_panel.Margin = new System.Windows.Forms.Padding(4);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(60, 69);
            this.display_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_panel.TabIndex = 10;
            this.display_panel.TabStop = false;
            // 
            // btn_G
            // 
            this.btn_G.BackColor = System.Drawing.Color.LightGray;
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_G.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_G.Location = new System.Drawing.Point(494, 477);
            this.btn_G.Margin = new System.Windows.Forms.Padding(4);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(60, 60);
            this.btn_G.TabIndex = 12;
            this.btn_G.UseVisualStyleBackColor = false;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(425, 212);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 395);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1496, 773);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_clearlog);
            this.Controls.Add(this.btn_displaylog);
            this.Controls.Add(this.door_left_up);
            this.Controls.Add(this.door_right_up);
            this.Controls.Add(this.display_bottom);
            this.Controls.Add(this.display_top);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.picture_lift);
            this.Controls.Add(this.bg_firstfloor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Project - Ionut Theodorescu 1722311 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_firstfloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bg_firstfloor;
        private System.Windows.Forms.PictureBox picture_lift;
        private System.Windows.Forms.Timer timer_lift_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Timer timer_lift_up;
        private System.Windows.Forms.PictureBox display_top;
        private System.Windows.Forms.PictureBox display_bottom;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.PictureBox door_left_up;
        private System.Windows.Forms.PictureBox door_right_up;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_close_up;
        private System.Windows.Forms.ListBox DATABASE;
        private System.Windows.Forms.Button btn_displaylog;
        private System.Windows.Forms.Button btn_clearlog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.PictureBox display_panel;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

