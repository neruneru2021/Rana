namespace Rana.Views
{
    partial class StyleView
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
            this.ColorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.ItemHeight = 23;
            this.ColorComboBox.Location = new System.Drawing.Point(172, 37);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(158, 29);
            this.ColorComboBox.TabIndex = 7;
            this.ColorComboBox.UseSelectable = true;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.ItemHeight = 23;
            this.ThemeComboBox.Location = new System.Drawing.Point(8, 37);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(158, 29);
            this.ThemeComboBox.TabIndex = 6;
            this.ThemeComboBox.UseSelectable = true;
            // 
            // StyleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.ThemeComboBox);
            this.Name = "StyleView";
            this.Size = new System.Drawing.Size(353, 119);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ColorComboBox;
        private MetroFramework.Controls.MetroComboBox ThemeComboBox;
    }
}
