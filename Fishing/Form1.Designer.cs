namespace Fishing
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBaitL = new System.Windows.Forms.PictureBox();
            this.pictureBoxBaitM = new System.Windows.Forms.PictureBox();
            this.pictureBoxBaitS = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitS)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxBaitL
            // 
            this.pictureBoxBaitL.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBaitL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBaitL.Image")));
            this.pictureBoxBaitL.Location = new System.Drawing.Point(518, 225);
            this.pictureBoxBaitL.Name = "pictureBoxBaitL";
            this.pictureBoxBaitL.Size = new System.Drawing.Size(42, 100);
            this.pictureBoxBaitL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBaitL.TabIndex = 0;
            this.pictureBoxBaitL.TabStop = false;
            // 
            // pictureBoxBaitM
            // 
            this.pictureBoxBaitM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBaitM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBaitM.Image")));
            this.pictureBoxBaitM.Location = new System.Drawing.Point(838, 411);
            this.pictureBoxBaitM.Name = "pictureBoxBaitM";
            this.pictureBoxBaitM.Size = new System.Drawing.Size(31, 75);
            this.pictureBoxBaitM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBaitM.TabIndex = 1;
            this.pictureBoxBaitM.TabStop = false;
            // 
            // pictureBoxBaitS
            // 
            this.pictureBoxBaitS.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBaitS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBaitS.Image")));
            this.pictureBoxBaitS.Location = new System.Drawing.Point(309, 106);
            this.pictureBoxBaitS.Name = "pictureBoxBaitS";
            this.pictureBoxBaitS.Size = new System.Drawing.Size(21, 50);
            this.pictureBoxBaitS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBaitS.TabIndex = 2;
            this.pictureBoxBaitS.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(111, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(115, 16);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "残り時間: 60秒";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(245, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(61, 16);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "得点: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(963, 526);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxBaitS);
            this.Controls.Add(this.pictureBoxBaitM);
            this.Controls.Add(this.pictureBoxBaitL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxBaitL;
        private System.Windows.Forms.PictureBox pictureBoxBaitM;
        private System.Windows.Forms.PictureBox pictureBoxBaitS;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
    }
}

