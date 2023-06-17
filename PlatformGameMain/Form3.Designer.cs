namespace PlatformGameMain
{
    partial class Form3
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
            this.menu2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_help = new System.Windows.Forms.PictureBox();
            this.btn_new = new System.Windows.Forms.PictureBox();
            this.btn_continue = new System.Windows.Forms.PictureBox();
            this.menu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continue)).BeginInit();
            this.SuspendLayout();
            // 
            // menu2
            // 
            this.menu2.BackgroundImage = global::PlatformGameMain.Properties.Resources.menu;
            this.menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu2.Controls.Add(this.btn_exit);
            this.menu2.Controls.Add(this.btn_help);
            this.menu2.Controls.Add(this.btn_new);
            this.menu2.Controls.Add(this.btn_continue);
            this.menu2.Location = new System.Drawing.Point(43, 12);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(286, 287);
            this.menu2.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::PlatformGameMain.Properties.Resources.exit_normal;
            this.btn_exit.Location = new System.Drawing.Point(89, 212);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 43);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // btn_help
            // 
            this.btn_help.Image = global::PlatformGameMain.Properties.Resources.help_normal;
            this.btn_help.Location = new System.Drawing.Point(89, 163);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(100, 43);
            this.btn_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_help.TabIndex = 0;
            this.btn_help.TabStop = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            this.btn_help.MouseLeave += new System.EventHandler(this.btn_help_MouseLeave);
            this.btn_help.MouseHover += new System.EventHandler(this.btn_help_MouseHover);
            // 
            // btn_new
            // 
            this.btn_new.Image = global::PlatformGameMain.Properties.Resources.new_normal;
            this.btn_new.Location = new System.Drawing.Point(89, 114);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 43);
            this.btn_new.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_new.TabIndex = 0;
            this.btn_new.TabStop = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            this.btn_new.MouseLeave += new System.EventHandler(this.btn_new_MouseLeave);
            this.btn_new.MouseHover += new System.EventHandler(this.btn_new_MouseHover);
            // 
            // btn_continue
            // 
            this.btn_continue.Image = global::PlatformGameMain.Properties.Resources.continue_normal;
            this.btn_continue.Location = new System.Drawing.Point(89, 65);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(100, 43);
            this.btn_continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_continue.TabIndex = 0;
            this.btn_continue.TabStop = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            this.btn_continue.MouseLeave += new System.EventHandler(this.btn_continue_MouseLeave);
            this.btn_continue.MouseHover += new System.EventHandler(this.btn_continue_MouseHover);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.menu2);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.menu2.ResumeLayout(false);
            this.menu2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu2;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_help;
        private System.Windows.Forms.PictureBox btn_new;
        private System.Windows.Forms.PictureBox btn_continue;
    }
}