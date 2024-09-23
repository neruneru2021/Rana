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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.RanaStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ColorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.RanaStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(26, 116);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(116, 98);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(148, 116);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(116, 98);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(26, 220);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(238, 105);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile3.UseSelectable = true;
            // 
            // RanaStyleManager
            // 
            this.RanaStyleManager.Owner = this;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(270, 116);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(393, 209);
            this.treeView1.TabIndex = 3;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.ItemHeight = 23;
            this.ThemeComboBox.Location = new System.Drawing.Point(26, 37);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(158, 29);
            this.ThemeComboBox.TabIndex = 4;
            this.ThemeComboBox.UseSelectable = true;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.ItemHeight = 23;
            this.ColorComboBox.Location = new System.Drawing.Point(190, 37);
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
            this.CloseButton.Location = new System.Drawing.Point(580, 365);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(83, 44);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseSelectable = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 437);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.ThemeComboBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Shown += new System.EventHandler(this.MainView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RanaStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Components.MetroStyleManager RanaStyleManager;
        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroComboBox ThemeComboBox;
        private MetroFramework.Controls.MetroComboBox ColorComboBox;
        private MetroFramework.Controls.MetroButton CloseButton;
    }
}

