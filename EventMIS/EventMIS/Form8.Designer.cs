namespace EventMIS
{
    partial class buyTicketForm
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
            buyATicket=new Label();
            label1=new Label();
            label2=new Label();
            eventnamecombo=new ComboBox();
            pricecombo=new ComboBox();
            EventGridView=new DataGridView();
            buyBtn=new Button();
            ((System.ComponentModel.ISupportInitialize)EventGridView).BeginInit();
            SuspendLayout();
            // 
            // buyATicket
            // 
            buyATicket.AutoSize=true;
            buyATicket.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buyATicket.Location=new Point(285, 56);
            buyATicket.Name="buyATicket";
            buyATicket.Size=new Size(135, 21);
            buyATicket.TabIndex=0;
            buyATicket.Text="BUY A TICKET";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(171, 161);
            label1.Name="label1";
            label1.Size=new Size(52, 21);
            label1.TabIndex=1;
            label1.Text="Price:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(171, 106);
            label2.Name="label2";
            label2.Size=new Size(104, 21);
            label2.TabIndex=2;
            label2.Text="Event Name:";
            // 
            // eventnamecombo
            // 
            eventnamecombo.FormattingEnabled=true;
            eventnamecombo.Location=new Point(299, 104);
            eventnamecombo.Name="eventnamecombo";
            eventnamecombo.Size=new Size(182, 23);
            eventnamecombo.TabIndex=3;
            eventnamecombo.SelectedIndexChanged+=eventnamecombo_SelectedIndexChanged;
            eventnamecombo.SelectedValueChanged+=eventnamecombo_SelectedIndexChanged;
            eventnamecombo.Click+=eventnamecombo_Click;
            // 
            // pricecombo
            // 
            pricecombo.FormattingEnabled=true;
            pricecombo.Items.AddRange(new object[] { "10000", "25000", "50000" });
            pricecombo.Location=new Point(299, 161);
            pricecombo.Name="pricecombo";
            pricecombo.Size=new Size(182, 23);
            pricecombo.TabIndex=4;
            pricecombo.SelectedIndexChanged+=pricecombo_SelectedIndexChanged;
            // 
            // EventGridView
            // 
            EventGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventGridView.Location=new Point(55, 263);
            EventGridView.Name="EventGridView";
            EventGridView.RowTemplate.Height=25;
            EventGridView.Size=new Size(724, 150);
            EventGridView.TabIndex=5;
            EventGridView.CellContentClick+=EventGridView_CellContentClick;
            // 
            // buyBtn
            // 
            buyBtn.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buyBtn.Location=new Point(361, 205);
            buyBtn.Name="buyBtn";
            buyBtn.Size=new Size(75, 36);
            buyBtn.TabIndex=6;
            buyBtn.Text="Buy";
            buyBtn.UseVisualStyleBackColor=true;
            buyBtn.Click+=buyBtn_Click;
            // 
            // buyTicketForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(buyBtn);
            Controls.Add(EventGridView);
            Controls.Add(pricecombo);
            Controls.Add(eventnamecombo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buyATicket);
            Name="buyTicketForm";
            Text="BUY TICKET";
            ((System.ComponentModel.ISupportInitialize)EventGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buyATicket;
        private Label label1;
        private Label label2;
        private ComboBox eventnamecombo;
        private ComboBox pricecombo;
        private DataGridView EventGridView;
        private Button buyBtn;
    }
}