namespace Rana.Views
{
    partial class TreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.alarmButton = new MetroFramework.Controls.MetroButton();
            this.releaseButton = new MetroFramework.Controls.MetroButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // alarmButton
            // 
            this.alarmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.alarmButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.alarmButton.Location = new System.Drawing.Point(448, 247);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(129, 42);
            this.alarmButton.TabIndex = 0;
            this.alarmButton.Text = "alarm";
            this.alarmButton.UseSelectable = true;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // releaseButton
            // 
            this.releaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.releaseButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.releaseButton.Location = new System.Drawing.Point(448, 295);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(129, 42);
            this.releaseButton.TabIndex = 1;
            this.releaseButton.Text = "release";
            this.releaseButton.UseSelectable = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(439, 334);
            this.treeView1.TabIndex = 2;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blue.png");
            this.imageList1.Images.SetKeyName(1, "pink.png");
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.releaseButton);
            this.Controls.Add(this.alarmButton);
            this.Name = "TreeView";
            this.Size = new System.Drawing.Size(580, 340);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton alarmButton;
        private MetroFramework.Controls.MetroButton releaseButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
