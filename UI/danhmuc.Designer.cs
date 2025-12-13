
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
            dataGridView1 = new DataGridView();
            butTHEM = new Button();
            butSUA = new Button();
            butXOA = new Button();
            label2 = new Label();
            label3 = new Label();
            txtmaDM = new TextBox();
            txttenDM = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(304, 288);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // butTHEM
            // 
            butTHEM.Location = new Point(288, 3);
            butTHEM.Name = "butTHEM";
            butTHEM.Size = new Size(94, 29);
            butTHEM.TabIndex = 1;
            butTHEM.Text = "THÊM\r\n";
            butTHEM.UseVisualStyleBackColor = true;
            butTHEM.Click += butTHEM_Click;
            // 
            // butSUA
            // 
            butSUA.Location = new Point(288, 38);
            butSUA.Name = "butSUA";
            butSUA.Size = new Size(94, 29);
            butSUA.TabIndex = 2;
            butSUA.Text = "SỬA";
            butSUA.UseVisualStyleBackColor = true;
            butSUA.Click += butSUA_Click;
            // 
            // butXOA
            // 
            butXOA.Location = new Point(288, 73);
            butXOA.Name = "butXOA";
            butXOA.Size = new Size(94, 29);
            butXOA.TabIndex = 3;
            butXOA.Text = "XÓA";
            butXOA.UseVisualStyleBackColor = true;
            butXOA.Click += butXOA_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã danh mục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên danh mục";
            // 
            // txtmaDM
            // 
            txtmaDM.Location = new Point(119, 12);
            txtmaDM.Name = "txtmaDM";
            txtmaDM.Size = new Size(125, 27);
            txtmaDM.TabIndex = 7;
            // 
            // txttenDM
            // 
            txttenDM.Location = new Point(119, 62);
            txttenDM.Name = "txttenDM";
            txttenDM.Size = new Size(125, 27);
            txttenDM.TabIndex = 8;
            // 
            // danhmuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txttenDM);
            Controls.Add(txtmaDM);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(butXOA);
            Controls.Add(butSUA);
            Controls.Add(butTHEM);
            Controls.Add(dataGridView1);
            Name = "danhmuc";
            Size = new Size(380, 392);
            Load += danhmuc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butTHEM;
        private Button butSUA;
        private Button butXOA;
        private Label label2;
        private Label label3;
        private TextBox txtmaDM;
        private TextBox txttenDM;
    }
}
