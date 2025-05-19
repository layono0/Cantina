namespace Cantina_End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pedidoList = new ListView();
            codHeader = new ColumnHeader();
            nomeHeader = new ColumnHeader();
            precoHeader = new ColumnHeader();
            quantHeader = new ColumnHeader();
            estoqueList = new ListView();
            nomeHeader1 = new ColumnHeader();
            quantHeader1 = new ColumnHeader();
            removCarrinho = new Button();
            pagarButton = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            numLabel = new Label();
            totalLabel = new Label();
            addCarrinho = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pedidoList
            // 
            pedidoList.BackColor = Color.FromArgb(243, 241, 238);
            pedidoList.Columns.AddRange(new ColumnHeader[] { codHeader, nomeHeader, precoHeader, quantHeader });
            pedidoList.FullRowSelect = true;
            pedidoList.Location = new Point(799, 12);
            pedidoList.Name = "pedidoList";
            pedidoList.Size = new Size(494, 345);
            pedidoList.TabIndex = 0;
            pedidoList.UseCompatibleStateImageBehavior = false;
            pedidoList.View = View.Details;
            pedidoList.SelectedIndexChanged += pedidoList_SelectedIndexChanged;
            // 
            // codHeader
            // 
            codHeader.Text = "Código";
            codHeader.Width = 90;
            // 
            // nomeHeader
            // 
            nomeHeader.Text = "Nome";
            nomeHeader.Width = 218;
            // 
            // precoHeader
            // 
            precoHeader.Text = "Preço";
            precoHeader.Width = 90;
            // 
            // quantHeader
            // 
            quantHeader.Text = "Quantidade";
            quantHeader.Width = 90;
            // 
            // estoqueList
            // 
            estoqueList.BackColor = Color.FromArgb(243, 241, 238);
            estoqueList.Columns.AddRange(new ColumnHeader[] { nomeHeader1, quantHeader1 });
            estoqueList.FullRowSelect = true;
            estoqueList.Location = new Point(12, 117);
            estoqueList.Name = "estoqueList";
            estoqueList.Size = new Size(494, 287);
            estoqueList.TabIndex = 1;
            estoqueList.UseCompatibleStateImageBehavior = false;
            estoqueList.View = View.Details;
            // 
            // nomeHeader1
            // 
            nomeHeader1.Text = "Nome";
            nomeHeader1.Width = 350;
            // 
            // quantHeader1
            // 
            quantHeader1.Text = "Quantidade";
            quantHeader1.Width = 136;
            // 
            // removCarrinho
            // 
            removCarrinho.BackColor = Color.FromArgb(202, 196, 183);
            removCarrinho.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removCarrinho.ForeColor = Color.FromArgb(17, 25, 12);
            removCarrinho.Location = new Point(801, 445);
            removCarrinho.Name = "removCarrinho";
            removCarrinho.Size = new Size(147, 44);
            removCarrinho.TabIndex = 3;
            removCarrinho.Text = "Remover do Carrinho";
            removCarrinho.UseVisualStyleBackColor = false;
            removCarrinho.Click += removCarrinho_Click;
            // 
            // pagarButton
            // 
            pagarButton.BackColor = Color.FromArgb(202, 196, 183);
            pagarButton.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pagarButton.ForeColor = Color.FromArgb(17, 25, 12);
            pagarButton.Location = new Point(1146, 445);
            pagarButton.Name = "pagarButton";
            pagarButton.Size = new Size(147, 44);
            pagarButton.TabIndex = 5;
            pagarButton.Text = "Realizar Pagamento";
            pagarButton.UseVisualStyleBackColor = false;
            pagarButton.Click += pagarButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 25, 12);
            panel1.Controls.Add(numLabel);
            panel1.Controls.Add(totalLabel);
            panel1.Location = new Point(799, 359);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 80);
            panel1.TabIndex = 8;
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.BackColor = Color.FromArgb(17, 25, 12);
            numLabel.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numLabel.ForeColor = Color.FromArgb(225, 255, 0);
            numLabel.Location = new Point(322, 24);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(24, 25);
            numLabel.TabIndex = 1;
            numLabel.Text = "0";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = Color.FromArgb(17, 25, 12);
            totalLabel.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = Color.White;
            totalLabel.Location = new Point(263, 24);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(53, 25);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "Total";
            // 
            // addCarrinho
            // 
            addCarrinho.BackColor = Color.FromArgb(202, 196, 183);
            addCarrinho.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCarrinho.ForeColor = Color.FromArgb(17, 25, 12);
            addCarrinho.Location = new Point(185, 410);
            addCarrinho.Name = "addCarrinho";
            addCarrinho.Size = new Size(147, 44);
            addCarrinho.TabIndex = 6;
            addCarrinho.Text = "Adicionar ao Carrinho";
            addCarrinho.UseVisualStyleBackColor = false;
            addCarrinho.Click += addCarrinho_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1305, 683);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(addCarrinho);
            Controls.Add(pagarButton);
            Controls.Add(removCarrinho);
            Controls.Add(estoqueList);
            Controls.Add(pedidoList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView pedidoList;
        private ColumnHeader codHeader;
        private ColumnHeader nomeHeader;
        private ColumnHeader precoHeader;
        private ColumnHeader quantHeader;
        private ListView estoqueList;
        private ColumnHeader nomeHeader1;
        private ColumnHeader quantHeader1;
        private Button removCarrinho;
        private Button button3;
        private Button pagarButton;
        private Button button5;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label totalLabel;
        private Label numLabel;
        private Button addCarrinho;
    }
}
