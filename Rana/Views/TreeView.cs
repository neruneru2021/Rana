using MetroFramework.Controls;
using Rana.Area;
using Rana.Entity;
using Rana.Enums;
using Rana.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Rana.Views
{
    public partial class TreeView : MetroUserControl
    {
        private TreeViewModel _viewModel = new TreeViewModel(Dispatcher.CurrentDispatcher);

        private List<ProductBase> products = new List<ProductBase>();

        public TreeView()
        {
            InitializeComponent();
            _viewModel = new TreeViewModel(Dispatcher.CurrentDispatcher);

            treeView1.HideSelection = true;

            #region TreeViewLoading...
            var entitys = ProductEntityMaker.GetData();

            var kindGroups = from t in entitys
                             group t by t.Kind;

            foreach (var kindGroup in kindGroups)
            {
                switch (kindGroup.Key)
                {
                    case 1:
                        products.AddRange(kindGroup.Select(t => new ProductTree(t)).ToList());
                        break;
                    case 2:
                        products.AddRange(kindGroup.Select(t => new ProductLeaf(t)).ToList());
                        break;
                    default:
                        break;
                }
            }

            foreach (var product in products)
            {
                var parent = products.Find(t => t.Id == product.ParentId);

                if (parent != null)
                    parent.Add(product);
            }

            var roots = products.FindAll(t => t.ParentId == 0);
            if (!roots.Any())
            {
                throw new Exception("rootがありません");
            }

            foreach (var root in roots)
            {
                AddNode(root, null);
            }

            treeView1.ExpandAll();
            #endregion

        }

        private void AddNode(ProductBase product, TreeNode parentNode)
        {
            var node = new TreeNode(product.Name, 0, 0);
            node.Tag = product;

            if (parentNode == null)
            {
                treeView1.Nodes.Add(node);
            }
            else
            {
                parentNode.Nodes.Add(node);
            }

            foreach (var child in product.GetChildren())
                AddNode(child, node);
        }

        private void _viewModelTreeNodeAction(string node)
        {
            treeView1.Nodes.Add(node);
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            var product = treeView1.SelectedNode.Tag as ProductBase;

            if (product == null)
                return;

            product.Alarm();
            SetImage();
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            var product = treeView1.SelectedNode.Tag as ProductBase;

            if (product == null)
                return;

            product.Release();
            SetImage();
        }

        private void SetImage()
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                SetImageMethod(node);
            }
        }

        private void SetImageMethod(TreeNode node)
        {
            var product = node.Tag as ProductBase;

            if (product == null)
                return;

            if (product.GetCondition() == Condition.Alarm)
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
            else
            {
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }

            foreach (TreeNode child in node.Nodes)
            {
                SetImageMethod(child);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ProductBase _product in products)
                _product.Release();
            SetImage();

            var product = treeView1.SelectedNode.Tag as ProductBase;
            if (product == null)
                return;

            product.Alarm();
            SetImage();
        }
    }
}