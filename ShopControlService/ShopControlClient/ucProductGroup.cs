using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopControlClient.ServiceReference1;

namespace ShopControlClient
{
    public partial class ucProductGroup : UserControl, ISelected
    {
        private readonly ServiceClient loClient = new ServiceClient();
        private static ucProductGroup _instance;
        public static ucProductGroup Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProductGroup();
                return _instance;

            }
        }
        public ucProductGroup()
        {
            InitializeComponent();
            LoadTree();
        }
    


        public void LoadTree()
        {
            treeViewProductGroup.Nodes.Clear();
            treeViewProductGroup.Nodes.AddRange(DrawTree(loClient.ProductGroupList().ToList()));
        }


        public TreeNode[] DrawTree(List<ProductGroup> groups)
        {
            var result = new List<TreeNode>();
            var mainNodes = groups.Where(x => x.Parent == null).ToList();
            foreach (var item in mainNodes)
            {
                TreeNode node = new TreeNode(item.Name);
                RecursionNodeAdd(node, item.ID, groups);
                result.Add(node);
            }
            return result.ToArray();
        }

        private void RecursionNodeAdd(TreeNode node, int parentId, List<ProductGroup> groups)
        {
            try
            {
                foreach (var item in groups.Where(x => x.Parent?.ID == parentId))
                {
                    var currentNode = new TreeNode(item.Name);
                    if (groups.Any(x => x.Parent?.ID == item.ID))
                    {
                        RecursionNodeAdd(currentNode, item.ID, groups);
                    }
                    node.Nodes.Add(currentNode);
                }
            }
            catch(Exception ex)
            {

            }

        }

        public int _id;

        public int GetSelectedId()
        {
            foreach (var i in loClient.ProductGroupList())
            {
                if (i.Name == treeViewProductGroup.SelectedNode.Text)
                {
                    _id = i.ID;
                    return _id;
                }
            }
            return -1;
        }

        private void treeViewProductGroup_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void treeViewProductGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GetSelectedId();
        }
    }
}
