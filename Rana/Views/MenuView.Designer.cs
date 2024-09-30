namespace Rana.Views
{
    partial class MenuView
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
            this.TreeMetroTile = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.StyleMetroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TreeMetroTile
            // 
            this.TreeMetroTile.ActiveControl = null;
            this.TreeMetroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeMetroTile.Location = new System.Drawing.Point(30, 102);
            this.TreeMetroTile.Name = "TreeMetroTile";
            this.TreeMetroTile.Size = new System.Drawing.Size(115, 87);
            this.TreeMetroTile.TabIndex = 0;
            this.TreeMetroTile.Text = "Tree";
            this.TreeMetroTile.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTile2.Location = new System.Drawing.Point(151, 102);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(107, 87);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // StyleMetroTile
            // 
            this.StyleMetroTile.ActiveControl = null;
            this.StyleMetroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StyleMetroTile.Location = new System.Drawing.Point(30, 195);
            this.StyleMetroTile.Name = "StyleMetroTile";
            this.StyleMetroTile.Size = new System.Drawing.Size(228, 84);
            this.StyleMetroTile.TabIndex = 2;
            this.StyleMetroTile.Text = "Style";
            this.StyleMetroTile.UseSelectable = true;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StyleMetroTile);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.TreeMetroTile);
            this.Name = "MenuView";
            this.Size = new System.Drawing.Size(580, 340);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TreeMetroTile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile StyleMetroTile;
    }
}
