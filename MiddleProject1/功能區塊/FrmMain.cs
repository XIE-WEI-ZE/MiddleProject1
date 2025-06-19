using MiddleProject1.Properties;
using MiddleProject1.功能區塊.商品;
using MiddleProject1.功能區塊.商品.類別;
using MiddleProject1.功能區塊.商品.訂單;
using MiddleProject1.功能區塊.床位;
using MiddleProject1.功能區塊.活動;
using MiddleProject1.功能區塊.物料;
using MiddleProject1.功能區塊.社群;
using MiddleProject1.功能區塊.員工;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiddleProject1.功能區塊
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            FormViewDesigner();
        }

        private void FormViewDesigner()
        {
            this.BackColor = Color.FromArgb(208, 240, 192); // 馬卡龍薄荷綠 (整體背景)
            this.panel1.BackColor = Color.FromArgb(245, 255, 250); // 淺綠白（主Panel）
            this.treeView1.Size = new Size(250, 750);
            this.treeView1.Location = new System.Drawing.Point(10, 160);
            this.treeView1.BackColor = Color.FromArgb(191, 239, 255); // 馬卡龍天藍
            this.treeView1.ForeColor = Color.FromArgb(80, 150, 180); // 冷靜藍綠
            this.treeView1.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            this.treeView1.ItemHeight = 56;
            this.treeView1.Indent = 25;
            this.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = true;
            this.treeView1.ShowRootLines = false;
            this.treeView1.FullRowSelect = true;

            // 綁定事件
            this.treeView1.DrawNode += treeView1_DrawNode;
            this.treeView1.MouseMove += treeView1_MouseMove;
            this.treeView1.MouseLeave += treeView1_MouseLeave;
            this.treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            this.treeView1.AfterSelect += treeView1_AfterSelect;

            StyleAllButtons();
        }

        private void StyleAllButtons()
        {
            Color baseColor = Color.FromArgb(112, 168, 201);
            Color borderColor = Color.FromArgb(75, 106, 125);
            Color textColor = Color.White;

            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatAppearance.BorderColor = borderColor;
                    btn.BackColor = baseColor;
                    btn.ForeColor = textColor;
                    btn.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                    MakeButtonRounded(btn, 20);
                    btn.Paint += button1_Paint;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(132, 188, 221);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 168, 201);
                }
            }
        }

        private TreeNode hoveredNode = null;

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                int indent = treeView1.Indent;
                int level = e.Node.Level;

                int iconSize = 24;
                int iconPadding = 6;
                int paddingLeft = indent * level + 16;
                int paddingTop = 8;

                int top = e.Bounds.Top;
                int height = e.Bounds.Height;
                int width = Math.Max(0, treeView1.Width - paddingLeft - 8);

                Rectangle nodeRect = new Rectangle(paddingLeft - 12, top, width + 12, height);

                // 顏色設定（藍色系）
                Color backColor = level == 0
                    ? Color.FromArgb(200, 230, 255)
                    : Color.FromArgb(180, 210, 240);
                Color foreColor = Color.FromArgb(0, 70, 130);
                Color borderColor = Color.FromArgb(130, 170, 200);

                if (e.Node.IsSelected)
                {
                    backColor = Color.FromArgb(140, 190, 230);
                    foreColor = Color.White;
                    borderColor = Color.FromArgb(100, 140, 180);
                }
                else if (e.Node == hoveredNode)
                {
                    backColor = Color.FromArgb(170, 220, 250);
                }

                using (SolidBrush brush = new SolidBrush(backColor))
                    g.FillRectangle(brush, nodeRect);

                using (Pen pen = new Pen(borderColor, 2))
                    g.DrawRectangle(pen, nodeRect.X, nodeRect.Y, nodeRect.Width - 1, nodeRect.Height - 1);

                // 畫 icon（增加安全檢查）
                if (treeView1.ImageList != null && !string.IsNullOrEmpty(e.Node.ImageKey) && treeView1.ImageList.Images.ContainsKey(e.Node.ImageKey))
                {
                    Image icon = treeView1.ImageList.Images[e.Node.ImageKey];
                    if (icon != null)
                    {
                        g.DrawImage(icon, new Rectangle(paddingLeft, top + (height - iconSize) / 2, iconSize, iconSize));
                        paddingLeft += iconSize + iconPadding;
                    }
                }

                // 畫文字
                TextRenderer.DrawText(
                    g,
                    e.Node.Text,
                    treeView1.Font,
                    new Point(paddingLeft, top + (height - treeView1.Font.Height) / 2), // 垂直置中
                    foreColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
                );

                e.DrawDefault = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"繪製節點失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MakeButtonRounded(Button btn, int radius)
        {
            // 釋放舊的 Region
            if (btn.Region != null)
            {
                btn.Region.Dispose();
                btn.Region = null;
            }

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
            path.Dispose(); // 釋放 GraphicsPath
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = 18;
            int borderThickness = 4;
            Color borderColor = Color.FromArgb(120, 180, 220);
            Color textColor = Color.FromArgb(30, 90, 150);

            Rectangle rect = new Rectangle(borderThickness / 2, borderThickness / 2, btn.Width - borderThickness, btn.Height - borderThickness);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
            {
                using (Pen pen = new Pen(borderColor, borderThickness))
                    e.Graphics.DrawPath(pen, path);
            }

            TextRenderer.DrawText(
                e.Graphics,
                btn.Text,
                btn.Font,
                btn.ClientRectangle,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = panel1.ClientRectangle;
            using (Pen pen = new Pen(Color.FromArgb(160, 140, 110), 2))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawRectangle(pen, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView1.GetNodeAt(e.Location);

            if (node != hoveredNode)
            {
                TreeNode prevNode = hoveredNode;
                hoveredNode = node;

                if (prevNode != null)
                    treeView1.Invalidate(GetNodeBounds(prevNode), false);

                if (hoveredNode != null)
                    treeView1.Invalidate(GetNodeBounds(hoveredNode), false);
            }
        }

        private void treeView1_MouseLeave(object sender, EventArgs e)
        {
            if (hoveredNode != null)
            {
                treeView1.Invalidate(GetNodeBounds(hoveredNode), false);
                hoveredNode = null;
            }
        }

        private Rectangle GetNodeBounds(TreeNode node)
        {
            if (node == null) return Rectangle.Empty;
            Rectangle bounds = new Rectangle(0, node.Bounds.Top, treeView1.Width, node.Bounds.Height);
            return Rectangle.Intersect(bounds, new Rectangle(0, 0, treeView1.Width, treeView1.Height));
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
            }
            treeView1.SelectedNode = e.Node;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string selected = selectedNode.Text?.Trim();

            UserControl uc = null;

            try
            {
                switch (selected)
                {
                    // ======= 首頁區塊 =======
                    case "首頁":
                        uc = new UC_Home();
                        break;
                    // ======= 會員區塊 =======
                    case "會員明細管理":
                        uc = new UC_MemberManag();
                        break;
                    // ======= 員工區塊 =======
                    case "員工基本資料":
                        uc = new UC_EmployeeList();
                        break;
                    case "員工個人管理":
                        uc = new UC_EmployeeUser();
                        break;
                    // ======= 床位區塊 =======
                    case "房間總表":
                        uc = new UC_RoomTable();
                        break;
                    // ======= 活動區塊 =======
                    case "活動明細":
                        uc = new UC_EventList();
                        break;
                    case "活動批次":
                        uc = new UC_EventBatch();
                        break;
                    case "報名":
                        uc = new UC_RegistrationDetails();
                        break;
                    case "活動紀錄":
                        uc = new UC_EventRecord();
                        break;
                    // ======= 社群區塊 =======
                    case "文章清單":
                        uc = new UC_PostsManagement();
                        break;
                    case "檢舉清單":
                        uc = new UC_ReportsManagement();
                        break;
                    // ======= 商城區塊 =======
                    case "商品管理":
                        uc = new UC_Product(); // 建立 UC 控制項
                        break;
                    case "類別管理":
                        uc = new UC_Category(); // 建立 UC 控制項
                        break;
                    case "訂單管理":
                        uc = new UC_Order(); // 建立 UC 控制項
                        break;
                    // ======= 物料區塊 =======
                    case "物料":
                        uc = new UC_Stock();
                        break;
                        // ======= 客服區塊 =======
                    case "Node18":
                        break;
                    // ======= 帳號設定區塊 =======
                    case "Node19":

                        break;
                }

                if (uc != null)
                {
                    this.panel1.Controls.Clear();
                    uc.Dock = DockStyle.Fill;
                    this.panel1.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"切換模組失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}