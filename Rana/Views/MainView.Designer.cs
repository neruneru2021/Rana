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
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CloseButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CloseButton.Location = new System.Drawing.Point(0, 310);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(580, 30);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseSelectable = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(20, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(580, 340);
            this.MainPanel.TabIndex = 7;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // TitleLink
            // 
            this.TitleLink.DisplayFocus = true;
            this.TitleLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLink.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.TitleLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.TitleLink.Location = new System.Drawing.Point(20, 60);
            this.TitleLink.Name = "TitleLink";
            this.TitleLink.Size = new System.Drawing.Size(580, 25);
            this.TitleLink.TabIndex = 8;
            this.TitleLink.Text = "Rana";
            this.TitleLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.RanaStyleManager)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroLink TitleLink;
        private MetroFramework.Components.MetroStyleManager RanaStyleManager;
    }
}

