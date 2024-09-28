namespace Rana.Views
{
    partial class MainView
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RanaStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ColorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.TitleLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.RanaStyleManager)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RanaStyleManager
            // 
            this.RanaStyleManager.Owner = this;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.ItemHeight = 23;
            this.ThemeComboBox.Location = new System.Drawing.Point(225, 76);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(158, 29);
            this.ThemeComboBox.TabIndex = 4;
            this.ThemeComboBox.UseSelectable = true;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.ItemHeight = 23;
            this.ColorComboBox.Location = new System.Drawing.Point(389, 76);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(158, 29);
            this.ColorComboBox.TabIndex = 5;
            this.ColorComboBox.UseSelectable = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CloseButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CloseButton.Location = new System.Drawing.Point(499, 278);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 30);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseSelectable = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.ThemeComboBox);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.ColorComboBox);
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(15, 61);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(582, 336);
            this.MainPanel.TabIndex = 7;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // TitleLink
            // 
            this.TitleLink.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.TitleLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.TitleLink.Location = new System.Drawing.Point(15, 16);
            this.TitleLink.Name = "TitleLink";
            this.TitleLink.Size = new System.Drawing.Size(80, 39);
            this.TitleLink.TabIndex = 8;
            this.TitleLink.Text = "Rana";
            this.TitleLink.UseSelectable = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.TitleLink);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Shown += new System.EventHandler(this.MainView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RanaStyleManager)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox ThemeComboBox;
        private MetroFramework.Controls.MetroComboBox ColorComboBox;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroLink TitleLink;
        private MetroFramework.Components.MetroStyleManager RanaStyleManager;
    }
}

