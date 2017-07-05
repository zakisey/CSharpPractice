namespace GradeCheck2
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxScoreM = new System.Windows.Forms.TextBox();
            this.textBoxScoreE = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceM = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceP = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalM = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelPassScoreM = new System.Windows.Forms.Label();
            this.labelTotalP = new System.Windows.Forms.Label();
            this.labelTotalE = new System.Windows.Forms.Label();
            this.labelPassScoreP = new System.Windows.Forms.Label();
            this.labelPassScoreE = new System.Windows.Forms.Label();
            this.labelAverageM = new System.Windows.Forms.Label();
            this.labelAverageP = new System.Windows.Forms.Label();
            this.labelAverageE = new System.Windows.Forms.Label();
            this.labelResultM = new System.Windows.Forms.Label();
            this.labelResultP = new System.Windows.Forms.Label();
            this.labelResultE = new System.Windows.Forms.Label();
            this.labelCompAvgM = new System.Windows.Forms.Label();
            this.labelCompAvgP = new System.Windows.Forms.Label();
            this.labelCompAvgE = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxScoreP = new System.Windows.Forms.TextBox();
            this.buttonJudge = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 19);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxScoreM
            // 
            this.textBoxScoreM.Location = new System.Drawing.Point(80, 78);
            this.textBoxScoreM.Name = "textBoxScoreM";
            this.textBoxScoreM.Size = new System.Drawing.Size(69, 19);
            this.textBoxScoreM.TabIndex = 1;
            this.textBoxScoreM.Leave += new System.EventHandler(this.textBoxScoreM_Leave);
            // 
            // textBoxScoreE
            // 
            this.textBoxScoreE.Location = new System.Drawing.Point(80, 158);
            this.textBoxScoreE.Name = "textBoxScoreE";
            this.textBoxScoreE.Size = new System.Drawing.Size(69, 19);
            this.textBoxScoreE.TabIndex = 5;
            this.textBoxScoreE.Leave += new System.EventHandler(this.textBoxScoreE_Leave);
            // 
            // textBoxAttendanceM
            // 
            this.textBoxAttendanceM.Location = new System.Drawing.Point(166, 78);
            this.textBoxAttendanceM.Name = "textBoxAttendanceM";
            this.textBoxAttendanceM.Size = new System.Drawing.Size(59, 19);
            this.textBoxAttendanceM.TabIndex = 2;
            this.textBoxAttendanceM.Leave += new System.EventHandler(this.textBoxAttendanceM_Leave);
            // 
            // textBoxAttendanceP
            // 
            this.textBoxAttendanceP.Location = new System.Drawing.Point(166, 117);
            this.textBoxAttendanceP.Name = "textBoxAttendanceP";
            this.textBoxAttendanceP.Size = new System.Drawing.Size(59, 19);
            this.textBoxAttendanceP.TabIndex = 4;
            this.textBoxAttendanceP.Leave += new System.EventHandler(this.textBoxAttendanceP_Leave);
            // 
            // textBoxAttendanceE
            // 
            this.textBoxAttendanceE.Location = new System.Drawing.Point(166, 158);
            this.textBoxAttendanceE.Name = "textBoxAttendanceE";
            this.textBoxAttendanceE.Size = new System.Drawing.Size(59, 19);
            this.textBoxAttendanceE.TabIndex = 6;
            this.textBoxAttendanceE.Leave += new System.EventHandler(this.textBoxAttendanceE_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "数学";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "物理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "英語";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "科目";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "得点";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "出席時数";
            // 
            // labelTotalM
            // 
            this.labelTotalM.AutoSize = true;
            this.labelTotalM.Location = new System.Drawing.Point(231, 81);
            this.labelTotalM.Name = "labelTotalM";
            this.labelTotalM.Size = new System.Drawing.Size(33, 12);
            this.labelTotalM.TabIndex = 14;
            this.labelTotalM.Text = "/ 100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "合格点";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "平均点";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(448, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "合否判定";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(534, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "平均点と比較";
            // 
            // labelPassScoreM
            // 
            this.labelPassScoreM.AutoSize = true;
            this.labelPassScoreM.Location = new System.Drawing.Point(311, 81);
            this.labelPassScoreM.Name = "labelPassScoreM";
            this.labelPassScoreM.Size = new System.Drawing.Size(23, 12);
            this.labelPassScoreM.TabIndex = 21;
            this.labelPassScoreM.Text = "100";
            // 
            // labelTotalP
            // 
            this.labelTotalP.AutoSize = true;
            this.labelTotalP.Location = new System.Drawing.Point(231, 120);
            this.labelTotalP.Name = "labelTotalP";
            this.labelTotalP.Size = new System.Drawing.Size(33, 12);
            this.labelTotalP.TabIndex = 22;
            this.labelTotalP.Text = "/ 100";
            // 
            // labelTotalE
            // 
            this.labelTotalE.AutoSize = true;
            this.labelTotalE.Location = new System.Drawing.Point(231, 161);
            this.labelTotalE.Name = "labelTotalE";
            this.labelTotalE.Size = new System.Drawing.Size(33, 12);
            this.labelTotalE.TabIndex = 23;
            this.labelTotalE.Text = "/ 100";
            // 
            // labelPassScoreP
            // 
            this.labelPassScoreP.AutoSize = true;
            this.labelPassScoreP.Location = new System.Drawing.Point(311, 120);
            this.labelPassScoreP.Name = "labelPassScoreP";
            this.labelPassScoreP.Size = new System.Drawing.Size(23, 12);
            this.labelPassScoreP.TabIndex = 24;
            this.labelPassScoreP.Text = "100";
            // 
            // labelPassScoreE
            // 
            this.labelPassScoreE.AutoSize = true;
            this.labelPassScoreE.Location = new System.Drawing.Point(311, 161);
            this.labelPassScoreE.Name = "labelPassScoreE";
            this.labelPassScoreE.Size = new System.Drawing.Size(23, 12);
            this.labelPassScoreE.TabIndex = 25;
            this.labelPassScoreE.Text = "100";
            // 
            // labelAverageM
            // 
            this.labelAverageM.AutoSize = true;
            this.labelAverageM.Location = new System.Drawing.Point(363, 81);
            this.labelAverageM.Name = "labelAverageM";
            this.labelAverageM.Size = new System.Drawing.Size(23, 12);
            this.labelAverageM.TabIndex = 26;
            this.labelAverageM.Text = "100";
            // 
            // labelAverageP
            // 
            this.labelAverageP.AutoSize = true;
            this.labelAverageP.Location = new System.Drawing.Point(363, 120);
            this.labelAverageP.Name = "labelAverageP";
            this.labelAverageP.Size = new System.Drawing.Size(23, 12);
            this.labelAverageP.TabIndex = 27;
            this.labelAverageP.Text = "100";
            // 
            // labelAverageE
            // 
            this.labelAverageE.AutoSize = true;
            this.labelAverageE.Location = new System.Drawing.Point(363, 161);
            this.labelAverageE.Name = "labelAverageE";
            this.labelAverageE.Size = new System.Drawing.Size(23, 12);
            this.labelAverageE.TabIndex = 28;
            this.labelAverageE.Text = "100";
            // 
            // labelResultM
            // 
            this.labelResultM.AutoSize = true;
            this.labelResultM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultM.Location = new System.Drawing.Point(447, 78);
            this.labelResultM.Name = "labelResultM";
            this.labelResultM.Size = new System.Drawing.Size(42, 16);
            this.labelResultM.TabIndex = 29;
            this.labelResultM.Text = "合格";
            // 
            // labelResultP
            // 
            this.labelResultP.AutoSize = true;
            this.labelResultP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultP.Location = new System.Drawing.Point(447, 120);
            this.labelResultP.Name = "labelResultP";
            this.labelResultP.Size = new System.Drawing.Size(42, 16);
            this.labelResultP.TabIndex = 30;
            this.labelResultP.Text = "合格";
            // 
            // labelResultE
            // 
            this.labelResultE.AutoSize = true;
            this.labelResultE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultE.Location = new System.Drawing.Point(447, 158);
            this.labelResultE.Name = "labelResultE";
            this.labelResultE.Size = new System.Drawing.Size(42, 16);
            this.labelResultE.TabIndex = 31;
            this.labelResultE.Text = "合格";
            // 
            // labelCompAvgM
            // 
            this.labelCompAvgM.AutoSize = true;
            this.labelCompAvgM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgM.Location = new System.Drawing.Point(531, 77);
            this.labelCompAvgM.Name = "labelCompAvgM";
            this.labelCompAvgM.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgM.TabIndex = 32;
            this.labelCompAvgM.Text = "平均点以上";
            // 
            // labelCompAvgP
            // 
            this.labelCompAvgP.AutoSize = true;
            this.labelCompAvgP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgP.Location = new System.Drawing.Point(531, 120);
            this.labelCompAvgP.Name = "labelCompAvgP";
            this.labelCompAvgP.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgP.TabIndex = 33;
            this.labelCompAvgP.Text = "平均点以上";
            // 
            // labelCompAvgE
            // 
            this.labelCompAvgE.AutoSize = true;
            this.labelCompAvgE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgE.Location = new System.Drawing.Point(531, 157);
            this.labelCompAvgE.Name = "labelCompAvgE";
            this.labelCompAvgE.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgE.TabIndex = 34;
            this.labelCompAvgE.Text = "平均点以上";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(447, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(116, 16);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "○○さんの成績";
            // 
            // textBoxScoreP
            // 
            this.textBoxScoreP.Location = new System.Drawing.Point(80, 118);
            this.textBoxScoreP.Name = "textBoxScoreP";
            this.textBoxScoreP.Size = new System.Drawing.Size(69, 19);
            this.textBoxScoreP.TabIndex = 3;
            this.textBoxScoreP.Leave += new System.EventHandler(this.textBoxScoreP_Leave);
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(150, 209);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(75, 23);
            this.buttonJudge.TabIndex = 7;
            this.buttonJudge.Text = "判定";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.buttonJudge_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(245, 209);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 251);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonJudge);
            this.Controls.Add(this.textBoxScoreP);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCompAvgE);
            this.Controls.Add(this.labelCompAvgP);
            this.Controls.Add(this.labelCompAvgM);
            this.Controls.Add(this.labelResultE);
            this.Controls.Add(this.labelResultP);
            this.Controls.Add(this.labelResultM);
            this.Controls.Add(this.labelAverageE);
            this.Controls.Add(this.labelAverageP);
            this.Controls.Add(this.labelAverageM);
            this.Controls.Add(this.labelPassScoreE);
            this.Controls.Add(this.labelPassScoreP);
            this.Controls.Add(this.labelTotalE);
            this.Controls.Add(this.labelTotalP);
            this.Controls.Add(this.labelPassScoreM);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTotalM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAttendanceE);
            this.Controls.Add(this.textBoxAttendanceP);
            this.Controls.Add(this.textBoxAttendanceM);
            this.Controls.Add(this.textBoxScoreE);
            this.Controls.Add(this.textBoxScoreM);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxScoreM;
        private System.Windows.Forms.TextBox textBoxScoreE;
        private System.Windows.Forms.TextBox textBoxAttendanceM;
        private System.Windows.Forms.TextBox textBoxAttendanceP;
        private System.Windows.Forms.TextBox textBoxAttendanceE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelPassScoreM;
        private System.Windows.Forms.Label labelTotalP;
        private System.Windows.Forms.Label labelTotalE;
        private System.Windows.Forms.Label labelPassScoreP;
        private System.Windows.Forms.Label labelPassScoreE;
        private System.Windows.Forms.Label labelAverageM;
        private System.Windows.Forms.Label labelAverageP;
        private System.Windows.Forms.Label labelAverageE;
        private System.Windows.Forms.Label labelResultM;
        private System.Windows.Forms.Label labelResultP;
        private System.Windows.Forms.Label labelResultE;
        private System.Windows.Forms.Label labelCompAvgM;
        private System.Windows.Forms.Label labelCompAvgP;
        private System.Windows.Forms.Label labelCompAvgE;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxScoreP;
        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.Button buttonReset;
    }
}

