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
            ColumnHeader columnHeader2;
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            deleteBikeButton = new Button();
            bikeTypeDescriptionUpdateLab = new Label();
            bikeTypeNameUpdateCb = new ComboBox();
            priceUpdateTb = new TextBox();
            updateBikeButton = new Button();
            label12 = new Label();
            descriptionUpdateTb = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            modelUpdateTb = new TextBox();
            brandUpdateTb = new TextBox();
            bikesListView = new ListView();
            idColumn = new ColumnHeader();
            modelColumn = new ColumnHeader();
            priceColumn = new ColumnHeader();
            tabPage2 = new TabPage();
            label13 = new Label();
            bikeTypeDeleteButton = new Button();
            bikeTypeDeleteCb = new ComboBox();
            addBikeTypeButton = new Button();
            label10 = new Label();
            label6 = new Label();
            bikeTypeDescriptionAddTb = new TextBox();
            bikeTypeNameAddTb = new TextBox();
            bikeTypeDescriprionLab = new Label();
            bikeTypeNameCb = new ComboBox();
            label5 = new Label();
            descriptionTb = new TextBox();
            addBikeButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            priceTb = new TextBox();
            modelTb = new TextBox();
            brandTb = new TextBox();
            tabPage3 = new TabPage();
            descriptionFeedbackTb = new TextBox();
            sendFeedbackButton = new Button();
            feedbackContentTb = new TextBox();
            modelFeedbackLab = new Label();
            brandFeedbackLab = new Label();
            feedbacksListView = new ListView();
            creationDateTimeColumnHeader = new ColumnHeader();
            contentColumnHeader = new ColumnHeader();
            bikesFeedbackListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            id = new ColumnHeader();
            brandColumn = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // brandColumn
            // 
            brandColumn.DisplayIndex = 0;
            brandColumn.Text = "Brand";
            brandColumn.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 0;
            columnHeader2.Text = "Brand";
            columnHeader2.Width = 100;
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
            tabControl1.Size = new Size(1049, 809);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(deleteBikeButton);
            tabPage1.Controls.Add(bikeTypeDescriptionUpdateLab);
            tabPage1.Controls.Add(bikeTypeNameUpdateCb);
            tabPage1.Controls.Add(priceUpdateTb);
            tabPage1.Controls.Add(updateBikeButton);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(descriptionUpdateTb);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(modelUpdateTb);
            tabPage1.Controls.Add(brandUpdateTb);
            tabPage1.Controls.Add(bikesListView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1041, 776);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bike List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteBikeButton
            // 
            deleteBikeButton.Location = new Point(773, 457);
            deleteBikeButton.Name = "deleteBikeButton";
            deleteBikeButton.Size = new Size(256, 29);
            deleteBikeButton.TabIndex = 18;
            deleteBikeButton.Text = "Delete";
            deleteBikeButton.UseVisualStyleBackColor = true;
            deleteBikeButton.Click += deleteBikeButton_Click;
            // 
            // bikeTypeDescriptionUpdateLab
            // 
            bikeTypeDescriptionUpdateLab.AutoSize = true;
            bikeTypeDescriptionUpdateLab.Location = new Point(511, 164);
            bikeTypeDescriptionUpdateLab.Name = "bikeTypeDescriptionUpdateLab";
            bikeTypeDescriptionUpdateLab.Size = new Size(0, 20);
            bikeTypeDescriptionUpdateLab.TabIndex = 17;
            // 
            // bikeTypeNameUpdateCb
            // 
            bikeTypeNameUpdateCb.FormattingEnabled = true;
            bikeTypeNameUpdateCb.Location = new Point(511, 133);
            bikeTypeNameUpdateCb.Name = "bikeTypeNameUpdateCb";
            bikeTypeNameUpdateCb.Size = new Size(517, 28);
            bikeTypeNameUpdateCb.TabIndex = 16;
            bikeTypeNameUpdateCb.SelectedIndexChanged += bikeTypeNameUpdateCb_SelectedIndexChanged;
            // 
            // priceUpdateTb
            // 
            priceUpdateTb.Location = new Point(511, 225);
            priceUpdateTb.Name = "priceUpdateTb";
            priceUpdateTb.Size = new Size(517, 27);
            priceUpdateTb.TabIndex = 15;
            // 
            // updateBikeButton
            // 
            updateBikeButton.Location = new Point(511, 457);
            updateBikeButton.Name = "updateBikeButton";
            updateBikeButton.Size = new Size(256, 29);
            updateBikeButton.TabIndex = 14;
            updateBikeButton.Text = "Save changes";
            updateBikeButton.UseVisualStyleBackColor = true;
            updateBikeButton.Click += updateButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(511, 255);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 12;
            label12.Text = "Description";
            // 
            // descriptionUpdateTb
            // 
            descriptionUpdateTb.Location = new Point(511, 278);
            descriptionUpdateTb.Multiline = true;
            descriptionUpdateTb.Name = "descriptionUpdateTb";
            descriptionUpdateTb.ScrollBars = ScrollBars.Vertical;
            descriptionUpdateTb.Size = new Size(517, 173);
            descriptionUpdateTb.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(511, 202);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 10;
            label11.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 109);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 8;
            label9.Text = "Bike Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(511, 56);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 7;
            label8.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 6);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 6;
            label7.Text = "Brand";
            // 
            // modelUpdateTb
            // 
            modelUpdateTb.Location = new Point(511, 79);
            modelUpdateTb.Name = "modelUpdateTb";
            modelUpdateTb.Size = new Size(517, 27);
            modelUpdateTb.TabIndex = 2;
            // 
            // brandUpdateTb
            // 
            brandUpdateTb.Location = new Point(511, 29);
            brandUpdateTb.Name = "brandUpdateTb";
            brandUpdateTb.Size = new Size(517, 27);
            brandUpdateTb.TabIndex = 1;
            // 
            // bikesListView
            // 
            bikesListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bikesListView.Columns.AddRange(new ColumnHeader[] { idColumn, brandColumn, modelColumn, priceColumn });
            bikesListView.Location = new Point(0, 0);
            bikesListView.Name = "bikesListView";
            bikesListView.Size = new Size(505, 770);
            bikesListView.TabIndex = 0;
            bikesListView.UseCompatibleStateImageBehavior = false;
            bikesListView.View = View.Details;
            bikesListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(bikeTypeDeleteButton);
            tabPage2.Controls.Add(bikeTypeDeleteCb);
            tabPage2.Controls.Add(addBikeTypeButton);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(bikeTypeDescriptionAddTb);
            tabPage2.Controls.Add(bikeTypeNameAddTb);
            tabPage2.Controls.Add(bikeTypeDescriprionLab);
            tabPage2.Controls.Add(bikeTypeNameCb);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(descriptionTb);
            tabPage2.Controls.Add(addBikeButton);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(priceTb);
            tabPage2.Controls.Add(modelTb);
            tabPage2.Controls.Add(brandTb);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1041, 776);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Bike";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(577, 256);
            label13.Name = "label13";
            label13.Size = new Size(120, 20);
            label13.TabIndex = 26;
            label13.Text = "Delete Bike Type";
            // 
            // bikeTypeDeleteButton
            // 
            bikeTypeDeleteButton.Location = new Point(577, 324);
            bikeTypeDeleteButton.Name = "bikeTypeDeleteButton";
            bikeTypeDeleteButton.Size = new Size(417, 29);
            bikeTypeDeleteButton.TabIndex = 25;
            bikeTypeDeleteButton.Text = "Delete";
            bikeTypeDeleteButton.UseVisualStyleBackColor = true;
            bikeTypeDeleteButton.Click += bikeTypeDeleteButton_Click;
            // 
            // bikeTypeDeleteCb
            // 
            bikeTypeDeleteCb.FormattingEnabled = true;
            bikeTypeDeleteCb.Location = new Point(577, 279);
            bikeTypeDeleteCb.Name = "bikeTypeDeleteCb";
            bikeTypeDeleteCb.Size = new Size(417, 28);
            bikeTypeDeleteCb.TabIndex = 24;
            // 
            // addBikeTypeButton
            // 
            addBikeTypeButton.Location = new Point(577, 167);
            addBikeTypeButton.Name = "addBikeTypeButton";
            addBikeTypeButton.Size = new Size(417, 29);
            addBikeTypeButton.TabIndex = 23;
            addBikeTypeButton.Text = "Add";
            addBikeTypeButton.UseVisualStyleBackColor = true;
            addBikeTypeButton.Click += addBikeTypeButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(577, 95);
            label10.Name = "label10";
            label10.Size = new Size(152, 20);
            label10.TabIndex = 22;
            label10.Text = "Bike Type Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(577, 33);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 21;
            label6.Text = "Bike Type Name*";
            // 
            // bikeTypeDescriptionAddTb
            // 
            bikeTypeDescriptionAddTb.Location = new Point(577, 118);
            bikeTypeDescriptionAddTb.Name = "bikeTypeDescriptionAddTb";
            bikeTypeDescriptionAddTb.Size = new Size(417, 27);
            bikeTypeDescriptionAddTb.TabIndex = 20;
            // 
            // bikeTypeNameAddTb
            // 
            bikeTypeNameAddTb.Location = new Point(577, 56);
            bikeTypeNameAddTb.Name = "bikeTypeNameAddTb";
            bikeTypeNameAddTb.Size = new Size(417, 27);
            bikeTypeNameAddTb.TabIndex = 19;
            // 
            // bikeTypeDescriprionLab
            // 
            bikeTypeDescriprionLab.AutoSize = true;
            bikeTypeDescriprionLab.Location = new Point(49, 225);
            bikeTypeDescriprionLab.Name = "bikeTypeDescriprionLab";
            bikeTypeDescriprionLab.Size = new Size(0, 20);
            bikeTypeDescriprionLab.TabIndex = 18;
            // 
            // bikeTypeNameCb
            // 
            bikeTypeNameCb.FormattingEnabled = true;
            bikeTypeNameCb.Location = new Point(49, 194);
            bikeTypeNameCb.Name = "bikeTypeNameCb";
            bikeTypeNameCb.Size = new Size(417, 28);
            bikeTypeNameCb.TabIndex = 17;
            bikeTypeNameCb.SelectedIndexChanged += bikeTypeNameCb_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 324);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // descriptionTb
            // 
            descriptionTb.Location = new Point(49, 347);
            descriptionTb.Multiline = true;
            descriptionTb.Name = "descriptionTb";
            descriptionTb.Size = new Size(417, 99);
            descriptionTb.TabIndex = 9;
            // 
            // addBikeButton
            // 
            addBikeButton.Location = new Point(49, 465);
            addBikeButton.Name = "addBikeButton";
            addBikeButton.Size = new Size(417, 29);
            addBikeButton.TabIndex = 8;
            addBikeButton.Text = "Add";
            addBikeButton.UseVisualStyleBackColor = true;
            addBikeButton.Click += addButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 257);
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
            priceTb.Location = new Point(49, 280);
            priceTb.Name = "priceTb";
            priceTb.Size = new Size(417, 27);
            priceTb.TabIndex = 3;
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
            tabPage3.Controls.Add(descriptionFeedbackTb);
            tabPage3.Controls.Add(sendFeedbackButton);
            tabPage3.Controls.Add(feedbackContentTb);
            tabPage3.Controls.Add(modelFeedbackLab);
            tabPage3.Controls.Add(brandFeedbackLab);
            tabPage3.Controls.Add(feedbacksListView);
            tabPage3.Controls.Add(bikesFeedbackListView);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1041, 776);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Feedback";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // descriptionFeedbackTb
            // 
            descriptionFeedbackTb.Location = new Point(510, 113);
            descriptionFeedbackTb.Multiline = true;
            descriptionFeedbackTb.Name = "descriptionFeedbackTb";
            descriptionFeedbackTb.ReadOnly = true;
            descriptionFeedbackTb.ScrollBars = ScrollBars.Vertical;
            descriptionFeedbackTb.Size = new Size(519, 136);
            descriptionFeedbackTb.TabIndex = 20;
            // 
            // button1
            // 
            sendFeedbackButton.Location = new Point(510, 388);
            sendFeedbackButton.Name = "sendFeedbackButton";
            sendFeedbackButton.Size = new Size(519, 29);
            sendFeedbackButton.TabIndex = 19;
            sendFeedbackButton.Text = "Send";
            sendFeedbackButton.UseVisualStyleBackColor = true;
            sendFeedbackButton.Click += sendFeedbackButton_Click;
            // 
            // feedbackContentTb
            // 
            feedbackContentTb.Location = new Point(510, 255);
            feedbackContentTb.Multiline = true;
            feedbackContentTb.Name = "feedbackContentTb";
            feedbackContentTb.Size = new Size(519, 127);
            feedbackContentTb.TabIndex = 18;
            // 
            // modelFeedbackLab
            // 
            modelFeedbackLab.AutoSize = true;
            modelFeedbackLab.Font = new Font("Segoe UI", 12F);
            modelFeedbackLab.Location = new Point(510, 63);
            modelFeedbackLab.Name = "modelFeedbackLab";
            modelFeedbackLab.Size = new Size(0, 28);
            modelFeedbackLab.TabIndex = 16;
            // 
            // brandFeedbackLab
            // 
            brandFeedbackLab.AutoSize = true;
            brandFeedbackLab.Font = new Font("Segoe UI", 16F);
            brandFeedbackLab.Location = new Point(510, 12);
            brandFeedbackLab.Name = "brandFeedbackLab";
            brandFeedbackLab.Size = new Size(0, 37);
            brandFeedbackLab.TabIndex = 15;
            // 
            // feedbacksListView
            // 
            feedbacksListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feedbacksListView.Columns.AddRange(new ColumnHeader[] { id, creationDateTimeColumnHeader, contentColumnHeader });
            feedbacksListView.Location = new Point(510, 454);
            feedbacksListView.Name = "feedbacksListView";
            feedbacksListView.Size = new Size(519, 316);
            feedbacksListView.TabIndex = 14;
            feedbacksListView.UseCompatibleStateImageBehavior = false;
            feedbacksListView.View = View.List;
            // 
            // creationDateTimeColumnHeader
            // 
            creationDateTimeColumnHeader.DisplayIndex = 0;
            creationDateTimeColumnHeader.Text = "Created On";
            creationDateTimeColumnHeader.Width = 120;
            // 
            // contentColumnHeader
            // 
            contentColumnHeader.DisplayIndex = 1;
            contentColumnHeader.Text = "Content";
            contentColumnHeader.TextAlign = HorizontalAlignment.Center;
            contentColumnHeader.Width = 395;
            // 
            // bikesFeedbackListView
            // 
            bikesFeedbackListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bikesFeedbackListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            bikesFeedbackListView.Location = new Point(0, 0);
            bikesFeedbackListView.Name = "bikesFeedbackListView";
            bikesFeedbackListView.Size = new Size(504, 770);
            bikesFeedbackListView.TabIndex = 1;
            bikesFeedbackListView.UseCompatibleStateImageBehavior = false;
            bikesFeedbackListView.View = View.Details;
            bikesFeedbackListView.SelectedIndexChanged += bikesFeedbackListView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 3;
            columnHeader1.Width = 0;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Model";
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 2;
            columnHeader4.Text = "Price";
            columnHeader4.Width = 100;
            // 
            // id
            // 
            id.DisplayIndex = 2;
            id.Width = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 814);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView bikesListView;
        private ColumnHeader brandColumn;
        private ColumnHeader modelColumn;
        private ColumnHeader priceColumn;
        private TextBox priceTb;
        private TextBox modelTb;
        private TextBox brandTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button addBikeButton;
        private Label label5;
        private TextBox descriptionTb;
        private TabPage tabPage3;
        private ColumnHeader idColumn;
        private Label label12;
        private TextBox descriptionUpdateTb;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox modelUpdateTb;
        private TextBox brandUpdateTb;
        private Button updateBikeButton;
        private TextBox priceUpdateTb;
        private ComboBox bikeTypeNameUpdateCb;
        private Label bikeTypeDescriptionUpdateLab;
        private Label bikeTypeDescriprionLab;
        private ComboBox bikeTypeNameCb;
        private Label label6;
        private TextBox bikeTypeDescriptionAddTb;
        private TextBox bikeTypeNameAddTb;
        private Button addBikeTypeButton;
        private Label label10;
        private Button deleteBikeButton;
        private Label label13;
        private Button bikeTypeDeleteButton;
        private ComboBox bikeTypeDeleteCb;
        private Button sendFeedbackButton;
        private TextBox feedbackContentTb;
        private Label brandFeedbackLab;
        private ListView feedbacksListView;
        private TextBox descriptionFeedbackTb;
        private Label modelFeedbackLab;
        private ListView bikesFeedbackListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader creationDateTimeColumnHeader;
        private ColumnHeader contentColumnHeader;
        private ColumnHeader id;
    }
}
