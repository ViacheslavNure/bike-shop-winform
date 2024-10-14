namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColumnHeader brandColumn;
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            idColumn = new ColumnHeader();
            modelColumn = new ColumnHeader();
            priceColumn = new ColumnHeader();
            tabPage2 = new TabPage();
            label6 = new Label();
            bikeTypeDescriptionTb = new TextBox();
            label5 = new Label();
            descriptionTb = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            priceTb = new TextBox();
            bikeTypeTb = new TextBox();
            modelTb = new TextBox();
            brandTb = new TextBox();
            tabPage3 = new TabPage();
            brandColumn = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // brandColumn
            // 
            brandColumn.DisplayIndex = 0;
            brandColumn.Text = "Brand";
            brandColumn.Width = 100;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1043, 672);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1035, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bike List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idColumn, brandColumn, modelColumn, priceColumn });
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(505, 639);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // idColumn
            // 
            idColumn.DisplayIndex = 3;
            idColumn.Width = 0;
            // 
            // modelColumn
            // 
            modelColumn.DisplayIndex = 1;
            modelColumn.Text = "Model";
            modelColumn.Width = 300;
            // 
            // priceColumn
            // 
            priceColumn.DisplayIndex = 2;
            priceColumn.Text = "Price";
            priceColumn.Width = 100;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(bikeTypeDescriptionTb);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(descriptionTb);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(priceTb);
            tabPage2.Controls.Add(bikeTypeTb);
            tabPage2.Controls.Add(modelTb);
            tabPage2.Controls.Add(brandTb);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1035, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Bike";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 237);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 12;
            label6.Text = "Bike Type Description";
            // 
            // bikeTypeDescriptionTb
            // 
            bikeTypeDescriptionTb.Location = new Point(49, 260);
            bikeTypeDescriptionTb.Name = "bikeTypeDescriptionTb";
            bikeTypeDescriptionTb.Size = new Size(417, 27);
            bikeTypeDescriptionTb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(563, 33);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // descriptionTb
            // 
            descriptionTb.Location = new Point(563, 56);
            descriptionTb.Multiline = true;
            descriptionTb.Name = "descriptionTb";
            descriptionTb.Size = new Size(438, 310);
            descriptionTb.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(49, 391);
            button1.Name = "button1";
            button1.Size = new Size(417, 29);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 316);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 7;
            label4.Text = "Price*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 171);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Bike Type*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Model*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Brand*";
            // 
            // priceTb
            // 
            priceTb.Location = new Point(49, 339);
            priceTb.Name = "priceTb";
            priceTb.Size = new Size(417, 27);
            priceTb.TabIndex = 3;
            // 
            // bikeTypeTb
            // 
            bikeTypeTb.Location = new Point(49, 194);
            bikeTypeTb.Name = "bikeTypeTb";
            bikeTypeTb.Size = new Size(417, 27);
            bikeTypeTb.TabIndex = 2;
            // 
            // modelTb
            // 
            modelTb.Location = new Point(49, 118);
            modelTb.Name = "modelTb";
            modelTb.Size = new Size(417, 27);
            modelTb.TabIndex = 1;
            // 
            // brandTb
            // 
            brandTb.Location = new Point(49, 56);
            brandTb.Name = "brandTb";
            brandTb.Size = new Size(417, 27);
            brandTb.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1035, 639);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Feedback";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 677);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView1;
        private ColumnHeader brandColumn;
        private ColumnHeader modelColumn;
        private ColumnHeader priceColumn;
        private TextBox priceTb;
        private TextBox bikeTypeTb;
        private TextBox modelTb;
        private TextBox brandTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label5;
        private TextBox descriptionTb;
        private TabPage tabPage3;
        private TextBox bikeTypeDescriptionTb;
        private Label label6;
        private ColumnHeader idColumn;
    }
}
