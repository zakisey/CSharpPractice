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
            this.pictureBoxIwashi = new System.Windows.Forms.PictureBox();
            this.pictureBoxUtsubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnkou = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtsubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxBaitL
            // 
            this.pictureBoxBaitL.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBaitL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBaitL.Image")));
            this.pictureBoxBaitL.Location = new System.Drawing.Point(591, 234);
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
            this.pictureBoxBaitM.Location = new System.Drawing.Point(845, 473);
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
            this.pictureBoxBaitS.Location = new System.Drawing.Point(442, 86);
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
            // pictureBoxIwashi
            // 
            this.pictureBoxIwashi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIwashi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIwashi.Image")));
            this.pictureBoxIwashi.Location = new System.Drawing.Point(40, 86);
            this.pictureBoxIwashi.Name = "pictureBoxIwashi";
            this.pictureBoxIwashi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxIwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIwashi.TabIndex = 5;
            this.pictureBoxIwashi.TabStop = false;
            // 
            // pictureBoxUtsubo
            // 
            this.pictureBoxUtsubo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUtsubo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtsubo.Image")));
            this.pictureBoxUtsubo.Location = new System.Drawing.Point(94, 222);
            this.pictureBoxUtsubo.Name = "pictureBoxUtsubo";
            this.pictureBoxUtsubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxUtsubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUtsubo.TabIndex = 6;
            this.pictureBoxUtsubo.TabStop = false;
            // 
            // pictureBoxAnkou
            // 
            this.pictureBoxAnkou.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAnkou.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnkou.Image")));
            this.pictureBoxAnkou.Location = new System.Drawing.Point(297, 450);
            this.pictureBoxAnkou.Name = "pictureBoxAnkou";
            this.pictureBoxAnkou.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxAnkou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAnkou.TabIndex = 7;
            this.pictureBoxAnkou.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(21, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1034, 659);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxAnkou);
            this.Controls.Add(this.pictureBoxUtsubo);
            this.Controls.Add(this.pictureBoxIwashi);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxBaitS);
            this.Controls.Add(this.pictureBoxBaitM);
            this.Controls.Add(this.pictureBoxBaitL);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "釣りゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaitS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtsubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxIwashi;
        private System.Windows.Forms.PictureBox pictureBoxUtsubo;
        private System.Windows.Forms.PictureBox pictureBoxAnkou;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonStart;
    }
}

