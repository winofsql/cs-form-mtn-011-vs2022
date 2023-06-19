namespace cs_form_mtn_011_vs2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ヘッド部 = new GroupBox();
            社員コード = new TextBox();
            ラベル1 = new Label();
            ラベル2 = new Label();
            確認 = new Button();
            処理区分 = new ComboBox();
            ボディ部 = new GroupBox();
            所属 = new ComboBox();
            label1 = new Label();
            更新 = new Button();
            キャンセル = new Button();
            タスクバー = new StatusStrip();
            ユーザへのメッセージ = new ToolStripStatusLabel();
            ヘッド部.SuspendLayout();
            ボディ部.SuspendLayout();
            タスクバー.SuspendLayout();
            SuspendLayout();
            // 
            // ヘッド部
            // 
            ヘッド部.Controls.Add(社員コード);
            ヘッド部.Controls.Add(ラベル1);
            ヘッド部.Controls.Add(ラベル2);
            ヘッド部.Controls.Add(確認);
            ヘッド部.Controls.Add(処理区分);
            ヘッド部.Location = new Point(35, 30);
            ヘッド部.Margin = new Padding(4);
            ヘッド部.Name = "ヘッド部";
            ヘッド部.Padding = new Padding(4);
            ヘッド部.Size = new Size(559, 139);
            ヘッド部.TabIndex = 0;
            ヘッド部.TabStop = false;
            ヘッド部.Text = "ヘッド部";
            // 
            // 社員コード
            // 
            社員コード.Location = new Point(141, 83);
            社員コード.Name = "社員コード";
            社員コード.Size = new Size(51, 23);
            社員コード.TabIndex = 3;
            社員コード.Enter += 社員コード_Enter;
            社員コード.Leave += 社員コード_Leave;
            社員コード.Validating += 社員コード_Validating;
            社員コード.Validated += 社員コード_Validated;
            // 
            // ラベル1
            // 
            ラベル1.AutoSize = true;
            ラベル1.Location = new Point(25, 39);
            ラベル1.Margin = new Padding(4, 0, 4, 0);
            ラベル1.Name = "ラベル1";
            ラベル1.Size = new Size(55, 15);
            ラベル1.TabIndex = 0;
            ラベル1.Text = "処理区分";
            // 
            // ラベル2
            // 
            ラベル2.AutoSize = true;
            ラベル2.Location = new Point(25, 87);
            ラベル2.Margin = new Padding(4, 0, 4, 0);
            ラベル2.Name = "ラベル2";
            ラベル2.Size = new Size(55, 15);
            ラベル2.TabIndex = 2;
            ラベル2.Text = "社員コード";
            // 
            // 確認
            // 
            確認.Location = new Point(404, 34);
            確認.Margin = new Padding(4);
            確認.Name = "確認";
            確認.Size = new Size(133, 26);
            確認.TabIndex = 4;
            確認.Text = "確認";
            確認.UseVisualStyleBackColor = true;
            確認.Click += 確認_Click;
            // 
            // 処理区分
            // 
            処理区分.CausesValidation = false;
            処理区分.DropDownStyle = ComboBoxStyle.DropDownList;
            処理区分.FormattingEnabled = true;
            処理区分.Items.AddRange(new object[] { "新規", "修正", "削除" });
            処理区分.Location = new Point(140, 34);
            処理区分.Margin = new Padding(4);
            処理区分.Name = "処理区分";
            処理区分.Size = new Size(148, 23);
            処理区分.TabIndex = 1;
            // 
            // ボディ部
            // 
            ボディ部.Controls.Add(所属);
            ボディ部.Controls.Add(label1);
            ボディ部.Controls.Add(更新);
            ボディ部.Controls.Add(キャンセル);
            ボディ部.Enabled = false;
            ボディ部.Location = new Point(35, 192);
            ボディ部.Margin = new Padding(4);
            ボディ部.Name = "ボディ部";
            ボディ部.Padding = new Padding(4);
            ボディ部.Size = new Size(559, 299);
            ボディ部.TabIndex = 2;
            ボディ部.TabStop = false;
            ボディ部.Text = "ボディ部";
            // 
            // 所属
            // 
            所属.DropDownStyle = ComboBoxStyle.DropDownList;
            所属.FormattingEnabled = true;
            所属.Location = new Point(142, 34);
            所属.Name = "所属";
            所属.Size = new Size(146, 23);
            所属.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "所属";
            // 
            // 更新
            // 
            更新.Location = new Point(404, 185);
            更新.Margin = new Padding(4);
            更新.Name = "更新";
            更新.Size = new Size(133, 26);
            更新.TabIndex = 7;
            更新.Text = "更新";
            更新.UseVisualStyleBackColor = true;
            更新.Click += 更新_Click;
            // 
            // キャンセル
            // 
            キャンセル.Location = new Point(405, 234);
            キャンセル.Margin = new Padding(4);
            キャンセル.Name = "キャンセル";
            キャンセル.Size = new Size(133, 26);
            キャンセル.TabIndex = 8;
            キャンセル.Text = "キャンセル";
            キャンセル.UseVisualStyleBackColor = true;
            キャンセル.Click += キャンセル_Click;
            // 
            // タスクバー
            // 
            タスクバー.Items.AddRange(new ToolStripItem[] { ユーザへのメッセージ });
            タスクバー.Location = new Point(0, 505);
            タスクバー.Name = "タスクバー";
            タスクバー.Size = new Size(704, 22);
            タスクバー.TabIndex = 0;
            タスクバー.Text = "statusStrip1";
            // 
            // ユーザへのメッセージ
            // 
            ユーザへのメッセージ.Name = "ユーザへのメッセージ";
            ユーザへのメッセージ.Size = new Size(99, 17);
            ユーザへのメッセージ.Text = "ユーザへのメッセージ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 527);
            Controls.Add(タスクバー);
            Controls.Add(ヘッド部);
            Controls.Add(ボディ部);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C# による MySQL の更新";
            Load += Form1_Load;
            Shown += Form1_Shown;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ヘッド部.ResumeLayout(false);
            ヘッド部.PerformLayout();
            ボディ部.ResumeLayout(false);
            ボディ部.PerformLayout();
            タスクバー.ResumeLayout(false);
            タスクバー.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal GroupBox ヘッド部;
        internal Label ラベル1;
        internal Label ラベル2;
        internal Button 確認;
        internal ComboBox 処理区分;
        internal GroupBox ボディ部;
        internal Button 更新;
        internal Button キャンセル;
        private StatusStrip タスクバー;
        private ToolStripStatusLabel ユーザへのメッセージ;
        internal TextBox 社員コード;
        internal Label label1;
        private ComboBox 所属;
    }
}
