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
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TreeMetroTile
            // 
            this.TreeMetroTile.ActiveControl = null;
            this.TreeMetroTile.Location = new System.Drawing.Point(14, 14);
            this.TreeMetroTile.Name = "TreeMetroTile";
            this.TreeMetroTile.Size = new System.Drawing.Size(115, 87);
            this.TreeMetroTile.TabIndex = 0;
            this.TreeMetroTile.Text = "metroTile1";
            this.TreeMetroTile.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(135, 14);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(107, 87);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(14, 121);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(198, 84);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.TreeMetroTile);
            this.Name = "MenuView";
            this.Size = new System.Drawing.Size(355, 265);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TreeMetroTile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}
