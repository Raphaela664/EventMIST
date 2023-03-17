namespace EventMIS
{
    partial class bookTicketForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            eventGridView=new DataGridView();
            label2=new Label();
            eventnamecombo=new ComboBox();
            label3=new Label();
            buyBtn=new Button();
            pricecombobox=new ComboBox();
            comboBox1=new ComboBox();
            ((System.ComponentModel.ISupportInitialize)eventGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(231, 9);
            label1.Name="label1";
            label1.Size=new Size(284, 55);
            label1.TabIndex=0;
            label1.Text="Buy A Ticket!";
            // 
            // eventGridView
            // 
            eventGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventGridView.Location=new Point(67, 252);
            eventGridView.Name="eventGridView";
            eventGridView.RowTemplate.Height=25;
            eventGridView.Size=new Size(695, 186);
            eventGridView.TabIndex=1;
            eventGridView.CellContentClick+=eventGridView_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(140, 120);
            label2.Name="label2";
            label2.Size=new Size(100, 21);
            label2.TabIndex=2;
            label2.Text="Event Name";
            label2.Click+=label2_Click;
            // 
            // eventnamecombo
            // 
            eventnamecombo.FormattingEnabled=true;
            eventnamecombo.Location=new Point(266, 120);
            eventnamecombo.Name="eventnamecombo";
            eventnamecombo.Size=new Size(209, 23);
            eventnamecombo.TabIndex=4;
            eventnamecombo.SelectedIndexChanged+=comboBox2_SelectedIndexChanged;
            eventnamecombo.DisplayMemberChanged+=eventnamecombo_SelectedIndexChanged;
            eventnamecombo.Click+=comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(140, 172);
            label3.Name="label3";
            label3.Size=new Size(48, 21);
            label3.TabIndex=5;
            label3.Text="Price";
            // 
            // buyBtn
            // 
            buyBtn.Location=new Point(322, 223);
            buyBtn.Name="buyBtn";
            buyBtn.Size=new Size(75, 23);
            buyBtn.TabIndex=7;
            buyBtn.Text="Buy";
            buyBtn.UseVisualStyleBackColor=true;
            // 
            // pricecombobox
            // 
            pricecombobox.FormattingEnabled=true;
            pricecombobox.Items.AddRange(new object[] { "NORMAL", "VIP", "VVIP" });
            pricecombobox.Location=new Point(266, 173);
            pricecombobox.Name="pricecombobox";
            pricecombobox.Size=new Size(209, 23);
            pricecombobox.TabIndex=6;
            pricecombobox.SelectedIndexChanged+=comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(539, 121);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(121, 23);
            comboBox1.TabIndex=8;
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged;
            // 
            // bookTicketForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(buyBtn);
            Controls.Add(pricecombobox);
            Controls.Add(label3);
            Controls.Add(eventnamecombo);
            Controls.Add(label2);
            Controls.Add(eventGridView);
            Controls.Add(label1);
            Name="bookTicketForm";
            Text="Book Ticket";
            ((System.ComponentModel.ISupportInitialize)eventGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView eventGridView;
        private Label label2;
        private ComboBox eventnamecombo;
        private Label label3;
        private Button buyBtn;
        private ComboBox pricecombobox;
        private ComboBox comboBox1;
    }
}