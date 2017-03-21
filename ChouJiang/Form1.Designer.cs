namespace ChouJiang
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.DepComBox = new System.Windows.Forms.ComboBox();
            this.DepLabel = new System.Windows.Forms.Label();
            this.RewardStaffLabel = new System.Windows.Forms.Label();
            this.AllLabel = new System.Windows.Forms.Label();
            this.CurrentStaffLabel = new System.Windows.Forms.Label();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.ThirdLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(35, 212);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "开始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(159, 212);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "停止";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // DepComBox
            // 
            this.DepComBox.FormattingEnabled = true;
            this.DepComBox.Location = new System.Drawing.Point(95, 17);
            this.DepComBox.Name = "DepComBox";
            this.DepComBox.Size = new System.Drawing.Size(200, 20);
            this.DepComBox.TabIndex = 3;
            this.DepComBox.SelectedIndexChanged += new System.EventHandler(this.DepComBox_SelectedIndexChanged);
            this.DepComBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepComBox_KeyPress);
            // 
            // DepLabel
            // 
            this.DepLabel.AutoSize = true;
            this.DepLabel.BackColor = System.Drawing.Color.Transparent;
            this.DepLabel.Location = new System.Drawing.Point(12, 17);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(65, 12);
            this.DepLabel.TabIndex = 4;
            this.DepLabel.Text = "请选择部门";
            // 
            // RewardStaffLabel
            // 
            this.RewardStaffLabel.AutoSize = true;
            this.RewardStaffLabel.BackColor = System.Drawing.Color.Transparent;
            this.RewardStaffLabel.Location = new System.Drawing.Point(12, 89);
            this.RewardStaffLabel.Name = "RewardStaffLabel";
            this.RewardStaffLabel.Size = new System.Drawing.Size(77, 12);
            this.RewardStaffLabel.TabIndex = 8;
            this.RewardStaffLabel.Text = "被抽到的员工";
            // 
            // AllLabel
            // 
            this.AllLabel.AutoSize = true;
            this.AllLabel.BackColor = System.Drawing.Color.Transparent;
            this.AllLabel.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Bold);
            this.AllLabel.Location = new System.Drawing.Point(95, 53);
            this.AllLabel.Name = "AllLabel";
            this.AllLabel.Size = new System.Drawing.Size(0, 80);
            this.AllLabel.TabIndex = 9;
            // 
            // CurrentStaffLabel
            // 
            this.CurrentStaffLabel.AutoSize = true;
            this.CurrentStaffLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentStaffLabel.Location = new System.Drawing.Point(12, 53);
            this.CurrentStaffLabel.Name = "CurrentStaffLabel";
            this.CurrentStaffLabel.Size = new System.Drawing.Size(53, 12);
            this.CurrentStaffLabel.TabIndex = 10;
            this.CurrentStaffLabel.Text = "当前员工";
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstLabel.Location = new System.Drawing.Point(96, 88);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(0, 12);
            this.FirstLabel.TabIndex = 11;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondLabel.Location = new System.Drawing.Point(102, 120);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(0, 12);
            this.SecondLabel.TabIndex = 12;
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.AutoSize = true;
            this.ThirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdLabel.Location = new System.Drawing.Point(98, 163);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Size = new System.Drawing.Size(0, 12);
            this.ThirdLabel.TabIndex = 13;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Location = new System.Drawing.Point(192, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(143, 12);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "IEMS SEDA嘉年华竞赛活动";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ThirdLabel);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.CurrentStaffLabel);
            this.Controls.Add(this.AllLabel);
            this.Controls.Add(this.RewardStaffLabel);
            this.Controls.Add(this.DepLabel);
            this.Controls.Add(this.DepComBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Text = "抽奖";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ComboBox DepComBox;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.Label RewardStaffLabel;
        private System.Windows.Forms.Label AllLabel;
        private System.Windows.Forms.Label CurrentStaffLabel;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label ThirdLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}

