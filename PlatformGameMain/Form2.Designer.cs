namespace PlatformGameMain
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_new = new System.Windows.Forms.PictureBox();
            this.btn_help = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::PlatformGameMain.Properties.Resources.menu;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Controls.Add(this.btn_help);
            this.menu.Controls.Add(this.btn_new);
            this.menu.Location = new System.Drawing.Point(50, 12);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(286, 287);
            this.menu.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::PlatformGameMain.Properties.Resources.exit_normal;
            this.btn_exit.Location = new System.Drawing.Point(84, 175);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 43);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // btn_new
            // 
            this.btn_new.Image = global::PlatformGameMain.Properties.Resources.new_normal;
            this.btn_new.Location = new System.Drawing.Point(84, 77);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 43);
            this.btn_new.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_new.TabIndex = 0;
            this.btn_new.TabStop = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            this.btn_new.MouseLeave += new System.EventHandler(this.btn_new_MouseLeave);
            this.btn_new.MouseHover += new System.EventHandler(this.btn_new_MouseHover);
            // 
            // btn_help
            // 
            this.btn_help.Image = global::PlatformGameMain.Properties.Resources.help_normal;
            this.btn_help.Location = new System.Drawing.Point(84, 126);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(100, 43);
            this.btn_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_help.TabIndex = 0;
            this.btn_help.TabStop = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            this.btn_help.MouseLeave += new System.EventHandler(this.btn_help_MouseLeave);
            this.btn_help.MouseHover += new System.EventHandler(this.btn_help_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.menu);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_new;
        private System.Windows.Forms.PictureBox btn_help;
    }
}