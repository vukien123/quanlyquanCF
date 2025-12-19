
namespace Quản_lý_Quán_Cafe.UI
{
    partial class danhmuc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhmuc));
            panelmain = new Panel();
            panelgrid = new Panel();
            dataGridView1 = new DataGridView();
            paneltop = new Panel();
            txttenDM = new TextBox();
            txtmaDM = new TextBox();
            label3 = new Label();
            label2 = new Label();
            butXOA = new Button();
            imageList1 = new ImageList(components);
            butSUA = new Button();
            butTHEM = new Button();
            panelmain.SuspendLayout();
            panelgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            paneltop.SuspendLayout();
            SuspendLayout();
            // 
            // panelmain
            // 
            panelmain.Controls.Add(panelgrid);
            panelmain.Controls.Add(paneltop);
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(538, 392);
            panelmain.TabIndex = 9;
            // 
            // panelgrid
            // 
            panelgrid.Controls.Add(dataGridView1);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(0, 167);
            panelgrid.Name = "panelgrid";
            panelgrid.Size = new Size(538, 225);
            panelgrid.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(538, 225);
            dataGridView1.TabIndex = 10;
            // 
            // paneltop
            // 
            paneltop.Controls.Add(txttenDM);
            paneltop.Controls.Add(txtmaDM);
            paneltop.Controls.Add(label3);
            paneltop.Controls.Add(label2);
            paneltop.Controls.Add(butXOA);
            paneltop.Controls.Add(butSUA);
            paneltop.Controls.Add(butTHEM);
            paneltop.Dock = DockStyle.Top;
            paneltop.Location = new Point(0, 0);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(538, 167);
            paneltop.TabIndex = 17;
            // 
            // txttenDM
            // 
            txttenDM.Location = new Point(121, 75);
            txttenDM.Name = "txttenDM";
            txttenDM.Size = new Size(268, 27);
            txttenDM.TabIndex = 23;
            // 
            // txtmaDM
            // 
            txtmaDM.Location = new Point(121, 21);
            txtmaDM.Name = "txtmaDM";
            txtmaDM.Size = new Size(268, 27);
            txtmaDM.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 78);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 21;
            label3.Text = "Tên danh mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 20);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 20;
            label2.Text = "Mã danh mục";
            // 
            // butXOA
            // 
            butXOA.ImageAlign = ContentAlignment.MiddleLeft;
            butXOA.ImageIndex = 1;
            butXOA.ImageList = imageList1;
            butXOA.Location = new Point(419, 116);
            butXOA.Name = "butXOA";
            butXOA.Padding = new Padding(10, 0, 0, 0);
            butXOA.Size = new Size(116, 29);
            butXOA.TabIndex = 19;
            butXOA.Text = "XÓA";
            butXOA.UseVisualStyleBackColor = true;
            butXOA.Click += butXOA_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-pencil-32.png");
            imageList1.Images.SetKeyName(1, "icons8-close-32.png");
            imageList1.Images.SetKeyName(2, "icons8-add-32.png");
            // 
            // butSUA
            // 
            butSUA.ImageAlign = ContentAlignment.MiddleLeft;
            butSUA.ImageIndex = 0;
            butSUA.ImageList = imageList1;
            butSUA.Location = new Point(419, 69);
            butSUA.Name = "butSUA";
            butSUA.Padding = new Padding(10, 0, 0, 0);
            butSUA.Size = new Size(116, 29);
            butSUA.TabIndex = 18;
            butSUA.Text = "SỬA";
            butSUA.UseVisualStyleBackColor = true;
            butSUA.Click += butSUA_Click;
            // 
            // butTHEM
            // 
            butTHEM.ImageAlign = ContentAlignment.MiddleLeft;
            butTHEM.ImageIndex = 2;
            butTHEM.ImageList = imageList1;
            butTHEM.Location = new Point(419, 19);
            butTHEM.Name = "butTHEM";
            butTHEM.Padding = new Padding(10, 0, 0, 0);
            butTHEM.Size = new Size(116, 29);
            butTHEM.TabIndex = 17;
            butTHEM.Text = "THÊM\r\n";
            butTHEM.UseVisualStyleBackColor = true;
            butTHEM.Click += butTHEM_Click;
            // 
            // danhmuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelmain);
            Name = "danhmuc";
            Size = new Size(538, 392);
            Load += danhmuc_Load;
            panelmain.ResumeLayout(false);
            panelgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmain;
        private Panel panelgrid;
        private DataGridView dataGridView1;
        private Panel paneltop;
        private TextBox txttenDM;
        private TextBox txtmaDM;
        private Label label3;
        private Label label2;
        private Button butXOA;
        private Button butSUA;
        private Button butTHEM;
        private ImageList imageList1;
    }
}
