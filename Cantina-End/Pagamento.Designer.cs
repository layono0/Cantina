namespace Cantina_End
{
    partial class Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamento));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            trocofimLabel = new Label();
            totalLabel = new Label();
            panel2 = new Panel();
            recebidoLabel = new Label();
            label2 = new Label();
            panel3 = new Panel();
            trocoLabel = new Label();
            label4 = new Label();
            trocoTextBox = new TextBox();
            dinheiroButton = new Button();
            troco = new Button();
            pixButton = new Button();
            finalizarButton = new Button();
            cartaoButton = new Button();
            historicolistview = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            nomeTextbox = new TextBox();
            balcaoButton = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 25, 12);
            panel1.Controls.Add(trocofimLabel);
            panel1.Controls.Add(totalLabel);
            panel1.Location = new Point(12, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 64);
            panel1.TabIndex = 9;
            // 
            // trocofimLabel
            // 
            trocofimLabel.AutoSize = true;
            trocofimLabel.BackColor = Color.FromArgb(17, 25, 12);
            trocofimLabel.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trocofimLabel.ForeColor = Color.FromArgb(225, 255, 0);
            trocofimLabel.Location = new Point(113, 18);
            trocofimLabel.Name = "trocofimLabel";
            trocofimLabel.Size = new Size(24, 25);
            trocofimLabel.TabIndex = 1;
            trocofimLabel.Text = "0";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = Color.FromArgb(17, 25, 12);
            totalLabel.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = Color.White;
            totalLabel.Location = new Point(56, 18);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(53, 25);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "Total";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 25, 12);
            panel2.Controls.Add(recebidoLabel);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 64);
            panel2.TabIndex = 9;
            // 
            // recebidoLabel
            // 
            recebidoLabel.AutoSize = true;
            recebidoLabel.BackColor = Color.FromArgb(17, 25, 12);
            recebidoLabel.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recebidoLabel.ForeColor = Color.FromArgb(225, 255, 0);
            recebidoLabel.Location = new Point(142, 18);
            recebidoLabel.Name = "recebidoLabel";
            recebidoLabel.Size = new Size(24, 25);
            recebidoLabel.TabIndex = 1;
            recebidoLabel.Text = "0";
            recebidoLabel.Click += recebidoLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(17, 25, 12);
            label2.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 18);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 0;
            label2.Text = "Valor recebido";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 25, 12);
            panel3.Controls.Add(trocoLabel);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 64);
            panel3.TabIndex = 9;
            // 
            // trocoLabel
            // 
            trocoLabel.AutoSize = true;
            trocoLabel.BackColor = Color.FromArgb(17, 25, 12);
            trocoLabel.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trocoLabel.ForeColor = Color.FromArgb(225, 255, 0);
            trocoLabel.Location = new Point(113, 18);
            trocoLabel.Name = "trocoLabel";
            trocoLabel.Size = new Size(24, 25);
            trocoLabel.TabIndex = 1;
            trocoLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(17, 25, 12);
            label4.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 18);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 0;
            label4.Text = "Troco";
            // 
            // trocoTextBox
            // 
            trocoTextBox.Enabled = false;
            trocoTextBox.Location = new Point(241, 173);
            trocoTextBox.Name = "trocoTextBox";
            trocoTextBox.Size = new Size(143, 23);
            trocoTextBox.TabIndex = 2;
            trocoTextBox.TextChanged += trocoTextBox_TextChanged;
            // 
            // dinheiroButton
            // 
            dinheiroButton.Location = new Point(241, 113);
            dinheiroButton.Name = "dinheiroButton";
            dinheiroButton.Size = new Size(143, 44);
            dinheiroButton.TabIndex = 10;
            dinheiroButton.Text = "Dinheiro";
            dinheiroButton.UseVisualStyleBackColor = true;
            dinheiroButton.Click += button1_Click;
            // 
            // troco
            // 
            troco.Enabled = false;
            troco.Location = new Point(390, 173);
            troco.Name = "troco";
            troco.Size = new Size(57, 23);
            troco.TabIndex = 10;
            troco.Text = "Troco";
            troco.UseVisualStyleBackColor = true;
            troco.Click += troco_Click;
            // 
            // pixButton
            // 
            pixButton.Location = new Point(241, 212);
            pixButton.Name = "pixButton";
            pixButton.Size = new Size(143, 44);
            pixButton.TabIndex = 10;
            pixButton.Text = "Pix";
            pixButton.UseVisualStyleBackColor = true;
            pixButton.Click += pixButton_Click;
            // 
            // finalizarButton
            // 
            finalizarButton.Enabled = false;
            finalizarButton.Location = new Point(49, 367);
            finalizarButton.Name = "finalizarButton";
            finalizarButton.Size = new Size(143, 44);
            finalizarButton.TabIndex = 10;
            finalizarButton.Text = "Finalizar Pagamento";
            finalizarButton.UseVisualStyleBackColor = true;
            finalizarButton.Click += finalizarButton_Click;
            // 
            // cartaoButton
            // 
            cartaoButton.Location = new Point(241, 274);
            cartaoButton.Name = "cartaoButton";
            cartaoButton.Size = new Size(143, 44);
            cartaoButton.TabIndex = 10;
            cartaoButton.Text = "Cartão";
            cartaoButton.UseVisualStyleBackColor = true;
            cartaoButton.Click += cartaoButton_Click;
            // 
            // historicolistview
            // 
            historicolistview.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            historicolistview.FullRowSelect = true;
            historicolistview.Location = new Point(612, 26);
            historicolistview.Name = "historicolistview";
            historicolistview.Size = new Size(265, 355);
            historicolistview.TabIndex = 11;
            historicolistview.UseCompatibleStateImageBehavior = false;
            historicolistview.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Data";
            columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Total";
            columnHeader3.Width = 90;
            // 
            // nomeTextbox
            // 
            nomeTextbox.Enabled = false;
            nomeTextbox.Location = new Point(12, 338);
            nomeTextbox.Name = "nomeTextbox";
            nomeTextbox.Size = new Size(223, 23);
            nomeTextbox.TabIndex = 2;
            nomeTextbox.TextChanged += trocoTextBox_TextChanged;
            // 
            // balcaoButton
            // 
            balcaoButton.Location = new Point(414, 367);
            balcaoButton.Name = "balcaoButton";
            balcaoButton.Size = new Size(143, 44);
            balcaoButton.TabIndex = 12;
            balcaoButton.Text = "Balcão";
            balcaoButton.UseVisualStyleBackColor = true;
            balcaoButton.Click += balcaoButton_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(449, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(530, 417);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 479);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(balcaoButton);
            Controls.Add(historicolistview);
            Controls.Add(troco);
            Controls.Add(cartaoButton);
            Controls.Add(finalizarButton);
            Controls.Add(pixButton);
            Controls.Add(dinheiroButton);
            Controls.Add(nomeTextbox);
            Controls.Add(trocoTextBox);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Pagamento";
            Text = "Pagamento";
            Load += Pagamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label trocofimLabel;
        private Label totalLabel;
        private Panel panel2;
        private Label recebidoLabel;
        private Label label2;
        private Panel panel3;
        private Label trocoLabel;
        private Label label4;
        private TextBox trocoTextBox;
        private Button dinheiroButton;
        private Button troco;
        private Button pixButton;
        private Button finalizarButton;
        private Button cartaoButton;
        private ListView historicolistview;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox nomeTextbox;
        private Button balcaoButton;
        private Button button1;
        private Button button2;
    }
}