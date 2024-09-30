namespace Rana.Views
{
    partial class LoginView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(223, 77);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "LoginID";
            // 
            // LoginTextBox
            // 
            // 
            // 
            // 
            this.LoginTextBox.CustomButton.Image = null;
            this.LoginTextBox.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.LoginTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.CustomButton.Name = "";
            this.LoginTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.LoginTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginTextBox.CustomButton.TabIndex = 1;
            this.LoginTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginTextBox.CustomButton.UseSelectable = true;
            this.LoginTextBox.CustomButton.Visible = false;
            this.LoginTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LoginTextBox.Lines = new string[] {
        "guest User"};
            this.LoginTextBox.Location = new System.Drawing.Point(284, 77);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.MaxLength = 32767;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginTextBox.SelectedText = "";
            this.LoginTextBox.SelectionLength = 0;
            this.LoginTextBox.SelectionStart = 0;
            this.LoginTextBox.ShortcutsEnabled = true;
            this.LoginTextBox.Size = new System.Drawing.Size(158, 34);
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.Text = "guest User";
            this.LoginTextBox.UseSelectable = true;
            this.LoginTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.PasswordTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(284, 119);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(158, 34);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(213, 119);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(381, 160);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(61, 30);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseSelectable = true;
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginPictureBox.Image = global::Rana.Properties.Resources._61841_lock_locked_login_icon;
            this.LoginPictureBox.Location = new System.Drawing.Point(72, 60);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(119, 113);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPictureBox.TabIndex = 5;
            this.LoginPictureBox.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(580, 340);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox LoginTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton LoginButton;
        private System.Windows.Forms.PictureBox LoginPictureBox;
    }
}
