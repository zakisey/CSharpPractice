﻿namespace GradeCheck
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
            this.textBoxAttendanceM = new System.Windows.Forms.TextBox();
            this.textBoxScoreM = new System.Windows.Forms.TextBox();
            this.labelResultM = new System.Windows.Forms.Label();
            this.labelResultP = new System.Windows.Forms.Label();
            this.labelResultE = new System.Windows.Forms.Label();
            this.labelCompAvgM = new System.Windows.Forms.Label();
            this.buttonJudge = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxAttendanceP = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceE = new System.Windows.Forms.TextBox();
            this.textBoxScoreP = new System.Windows.Forms.TextBox();
            this.textBoxScoreE = new System.Windows.Forms.TextBox();
            this.labelCompAvgP = new System.Windows.Forms.Label();
            this.labelCompAvgE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // textBoxAttendanceM
            // 
            this.textBoxAttendanceM.Location = new System.Drawing.Point(77, 57);
            this.textBoxAttendanceM.Name = "textBoxAttendanceM";
            this.textBoxAttendanceM.Size = new System.Drawing.Size(100, 19);
            this.textBoxAttendanceM.TabIndex = 0;
            this.textBoxAttendanceM.Text = "0.0";
            this.textBoxAttendanceM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreM
            // 
            this.textBoxScoreM.Location = new System.Drawing.Point(218, 57);
            this.textBoxScoreM.Name = "textBoxScoreM";
            this.textBoxScoreM.Size = new System.Drawing.Size(100, 19);
            this.textBoxScoreM.TabIndex = 1;
            this.textBoxScoreM.Text = "0";
            this.textBoxScoreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelResultM
            // 
            this.labelResultM.AutoSize = true;
            this.labelResultM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultM.Location = new System.Drawing.Point(368, 57);
            this.labelResultM.Name = "labelResultM";
            this.labelResultM.Size = new System.Drawing.Size(42, 16);
            this.labelResultM.TabIndex = 6;
            this.labelResultM.Text = "合格";
            // 
            // labelResultP
            // 
            this.labelResultP.AutoSize = true;
            this.labelResultP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultP.Location = new System.Drawing.Point(368, 102);
            this.labelResultP.Name = "labelResultP";
            this.labelResultP.Size = new System.Drawing.Size(42, 16);
            this.labelResultP.TabIndex = 7;
            this.labelResultP.Text = "合格";
            // 
            // labelResultE
            // 
            this.labelResultE.AutoSize = true;
            this.labelResultE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultE.Location = new System.Drawing.Point(368, 148);
            this.labelResultE.Name = "labelResultE";
            this.labelResultE.Size = new System.Drawing.Size(42, 16);
            this.labelResultE.TabIndex = 8;
            this.labelResultE.Text = "合格";
            // 
            // labelCompAvgM
            // 
            this.labelCompAvgM.AutoSize = true;
            this.labelCompAvgM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgM.Location = new System.Drawing.Point(456, 57);
            this.labelCompAvgM.Name = "labelCompAvgM";
            this.labelCompAvgM.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgM.TabIndex = 9;
            this.labelCompAvgM.Text = "平均点以上";
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(207, 206);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(75, 23);
            this.buttonJudge.TabIndex = 6;
            this.buttonJudge.Text = "判定";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.buttonJudge_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(370, 206);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxAttendanceP
            // 
            this.textBoxAttendanceP.Location = new System.Drawing.Point(77, 99);
            this.textBoxAttendanceP.Name = "textBoxAttendanceP";
            this.textBoxAttendanceP.Size = new System.Drawing.Size(100, 19);
            this.textBoxAttendanceP.TabIndex = 2;
            this.textBoxAttendanceP.Text = "0.0";
            this.textBoxAttendanceP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceE
            // 
            this.textBoxAttendanceE.Location = new System.Drawing.Point(77, 145);
            this.textBoxAttendanceE.Name = "textBoxAttendanceE";
            this.textBoxAttendanceE.Size = new System.Drawing.Size(100, 19);
            this.textBoxAttendanceE.TabIndex = 4;
            this.textBoxAttendanceE.Text = "0.0";
            this.textBoxAttendanceE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreP
            // 
            this.textBoxScoreP.Location = new System.Drawing.Point(218, 99);
            this.textBoxScoreP.Name = "textBoxScoreP";
            this.textBoxScoreP.Size = new System.Drawing.Size(100, 19);
            this.textBoxScoreP.TabIndex = 3;
            this.textBoxScoreP.Text = "0";
            this.textBoxScoreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreE
            // 
            this.textBoxScoreE.Location = new System.Drawing.Point(218, 145);
            this.textBoxScoreE.Name = "textBoxScoreE";
            this.textBoxScoreE.Size = new System.Drawing.Size(100, 19);
            this.textBoxScoreE.TabIndex = 5;
            this.textBoxScoreE.Text = "0";
            this.textBoxScoreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCompAvgP
            // 
            this.labelCompAvgP.AutoSize = true;
            this.labelCompAvgP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgP.Location = new System.Drawing.Point(456, 98);
            this.labelCompAvgP.Name = "labelCompAvgP";
            this.labelCompAvgP.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgP.TabIndex = 18;
            this.labelCompAvgP.Text = "平均点以上";
            // 
            // labelCompAvgE
            // 
            this.labelCompAvgE.AutoSize = true;
            this.labelCompAvgE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgE.Location = new System.Drawing.Point(456, 144);
            this.labelCompAvgE.Name = "labelCompAvgE";
            this.labelCompAvgE.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgE.TabIndex = 19;
            this.labelCompAvgE.Text = "平均点以上";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "科目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "数学";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "物理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "英語";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "出席率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "得点";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "判定結果";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "平均点と比較";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 241);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCompAvgE);
            this.Controls.Add(this.labelCompAvgP);
            this.Controls.Add(this.textBoxScoreE);
            this.Controls.Add(this.textBoxScoreP);
            this.Controls.Add(this.textBoxAttendanceE);
            this.Controls.Add(this.textBoxAttendanceP);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonJudge);
            this.Controls.Add(this.labelCompAvgM);
            this.Controls.Add(this.labelResultE);
            this.Controls.Add(this.labelResultP);
            this.Controls.Add(this.labelResultM);
            this.Controls.Add(this.textBoxScoreM);
            this.Controls.Add(this.textBoxAttendanceM);
            this.Name = "Form1";
            this.Text = "成績判定";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAttendanceM;
        private System.Windows.Forms.TextBox textBoxScoreM;
        private System.Windows.Forms.Label labelResultM;
        private System.Windows.Forms.Label labelResultP;
        private System.Windows.Forms.Label labelResultE;
        private System.Windows.Forms.Label labelCompAvgM;
        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxAttendanceP;
        private System.Windows.Forms.TextBox textBoxAttendanceE;
        private System.Windows.Forms.TextBox textBoxScoreP;
        private System.Windows.Forms.TextBox textBoxScoreE;
        private System.Windows.Forms.Label labelCompAvgP;
        private System.Windows.Forms.Label labelCompAvgE;
        private System.Windows.Forms.Label label1;
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
    }
}

