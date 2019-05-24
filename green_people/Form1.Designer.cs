namespace green_people
{
    partial class frmsmallgreenman
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsmallgreenman));
            this.imgsmallgreenman = new System.Windows.Forms.ImageList(this.components);
            this.tmrsmallgreenman = new System.Windows.Forms.Timer(this.components);
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // imgsmallgreenman
            // 
            this.imgsmallgreenman.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsmallgreenman.ImageStream")));
            this.imgsmallgreenman.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsmallgreenman.Images.SetKeyName(0, "stop-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(1, "p1-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(2, "p2-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(3, "p3-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(4, "p4-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(5, "p5-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(6, "p6-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(7, "p7-945.jpg");
            this.imgsmallgreenman.Images.SetKeyName(8, "p8-945.jpg");
            // 
            // tmrsmallgreenman
            // 
            this.tmrsmallgreenman.Interval = 500;
            this.tmrsmallgreenman.Tick += new System.EventHandler(this.tmrsmallgreenman_Tick);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(109, 29);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "模擬開始";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(28, 29);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "模擬結束";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(321, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 576);
            this.groupBox1.TabIndex = 254;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "小綠人";
            // 
            // frmsmallgreenman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 736);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Name = "frmsmallgreenman";
            this.Text = "模擬紅綠燈小綠人行走";
            this.Load += new System.EventHandler(this.frmsmallgreenman_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgsmallgreenman;
        private System.Windows.Forms.Timer tmrsmallgreenman;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

