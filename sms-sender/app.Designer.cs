
namespace sms_sender
{
    partial class app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app));
            this.texttitle = new System.Windows.Forms.Label();
            this.numberinput = new System.Windows.Forms.TextBox();
            this.textinfo = new System.Windows.Forms.Label();
            this.textinfo1 = new System.Windows.Forms.Label();
            this.smsinput = new System.Windows.Forms.TextBox();
            this.sendb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texttitle
            // 
            this.texttitle.AutoSize = true;
            this.texttitle.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.texttitle.Location = new System.Drawing.Point(324, 33);
            this.texttitle.Name = "texttitle";
            this.texttitle.Size = new System.Drawing.Size(185, 35);
            this.texttitle.TabIndex = 1;
            this.texttitle.Text = "SMS Sender";
            this.texttitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // numberinput
            // 
            this.numberinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.numberinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberinput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numberinput.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberinput.ForeColor = System.Drawing.Color.Silver;
            this.numberinput.Location = new System.Drawing.Point(297, 137);
            this.numberinput.Name = "numberinput";
            this.numberinput.Size = new System.Drawing.Size(228, 21);
            this.numberinput.TabIndex = 2;
            this.numberinput.TextChanged += new System.EventHandler(this.numberinput_TextChanged);
            // 
            // textinfo
            // 
            this.textinfo.AutoSize = true;
            this.textinfo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textinfo.Location = new System.Drawing.Point(229, 105);
            this.textinfo.Name = "textinfo";
            this.textinfo.Size = new System.Drawing.Size(260, 16);
            this.textinfo.TabIndex = 3;
            this.textinfo.Text = "Input Phone Number(ex. \"+1xxxxxxxxxx\"):";
            // 
            // textinfo1
            // 
            this.textinfo1.AutoSize = true;
            this.textinfo1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textinfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textinfo1.Location = new System.Drawing.Point(229, 181);
            this.textinfo1.Name = "textinfo1";
            this.textinfo1.Size = new System.Drawing.Size(126, 16);
            this.textinfo1.TabIndex = 5;
            this.textinfo1.Text = "Input Text To Send:";
            // 
            // smsinput
            // 
            this.smsinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.smsinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smsinput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.smsinput.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsinput.ForeColor = System.Drawing.Color.Silver;
            this.smsinput.Location = new System.Drawing.Point(297, 214);
            this.smsinput.Name = "smsinput";
            this.smsinput.Size = new System.Drawing.Size(228, 21);
            this.smsinput.TabIndex = 6;
            // 
            // sendb
            // 
            this.sendb.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendb.Location = new System.Drawing.Point(371, 285);
            this.sendb.Name = "sendb";
            this.sendb.Size = new System.Drawing.Size(75, 35);
            this.sendb.TabIndex = 7;
            this.sendb.TabStop = false;
            this.sendb.Text = "send";
            this.sendb.UseVisualStyleBackColor = true;
            this.sendb.Click += new System.EventHandler(this.sendb_Click);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendb);
            this.Controls.Add(this.smsinput);
            this.Controls.Add(this.textinfo1);
            this.Controls.Add(this.textinfo);
            this.Controls.Add(this.numberinput);
            this.Controls.Add(this.texttitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "app";
            this.Text = "detective@yin.sh";
            this.Load += new System.EventHandler(this.app_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label texttitle;
        private System.Windows.Forms.TextBox numberinput;
        private System.Windows.Forms.Label textinfo;
        private System.Windows.Forms.Label textinfo1;
        private System.Windows.Forms.TextBox smsinput;
        private System.Windows.Forms.Button sendb;
    }
}

