namespace Cantina_End
{
    partial class Gestão_de_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestão_de_Produto));
            cardapioList = new ListView();
            nomeHeader1 = new ColumnHeader();
            quantHeader1 = new ColumnHeader();
            estoqueList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            codigoProduto = new TextBox();
            quantEstoque = new NumericUpDown();
            addbutton = new Button();
            nomeProduto = new TextBox();
            valorProduto = new TextBox();
            isChapa = new CheckBox();
            removerbutton = new Button();
            nomeEstoque = new TextBox();
            addestoque = new Button();
            removestoq = new Button();
            quantProduto = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)quantEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cardapioList
            // 
            cardapioList.BackColor = Color.FromArgb(243, 241, 238);
            cardapioList.Columns.AddRange(new ColumnHeader[] { nomeHeader1, quantHeader1 });
            cardapioList.FullRowSelect = true;
            cardapioList.Location = new Point(316, 12);
            cardapioList.Name = "cardapioList";
            cardapioList.Size = new Size(491, 250);
            cardapioList.TabIndex = 2;
            cardapioList.UseCompatibleStateImageBehavior = false;
            cardapioList.View = View.Details;
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
            // estoqueList
            // 
            estoqueList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            estoqueList.FullRowSelect = true;
            estoqueList.Location = new Point(316, 268);
            estoqueList.Name = "estoqueList";
            estoqueList.Size = new Size(491, 269);
            estoqueList.TabIndex = 3;
            estoqueList.UseCompatibleStateImageBehavior = false;
            estoqueList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantidade Atual";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 136;
            // 
            // codigoProduto
            // 
            codigoProduto.Location = new Point(64, 73);
            codigoProduto.Name = "codigoProduto";
            codigoProduto.Size = new Size(158, 23);
            codigoProduto.TabIndex = 4;
            // 
            // quantEstoque
            // 
            quantEstoque.Location = new Point(79, 347);
            quantEstoque.Name = "quantEstoque";
            quantEstoque.Size = new Size(158, 23);
            quantEstoque.TabIndex = 5;
            quantEstoque.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(12, 213);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(120, 32);
            addbutton.TabIndex = 6;
            addbutton.Text = "adicionar";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // nomeProduto
            // 
            nomeProduto.Location = new Point(64, 44);
            nomeProduto.Name = "nomeProduto";
            nomeProduto.Size = new Size(158, 23);
            nomeProduto.TabIndex = 4;
            // 
            // valorProduto
            // 
            valorProduto.Location = new Point(64, 131);
            valorProduto.Name = "valorProduto";
            valorProduto.Size = new Size(158, 23);
            valorProduto.TabIndex = 4;
            // 
            // isChapa
            // 
            isChapa.AutoSize = true;
            isChapa.Location = new Point(79, 160);
            isChapa.Name = "isChapa";
            isChapa.Size = new Size(128, 19);
            isChapa.TabIndex = 7;
            isChapa.Text = "Precisa de preparo?";
            isChapa.UseVisualStyleBackColor = true;
            // 
            // removerbutton
            // 
            removerbutton.Location = new Point(163, 213);
            removerbutton.Name = "removerbutton";
            removerbutton.Size = new Size(120, 32);
            removerbutton.TabIndex = 6;
            removerbutton.Text = "remover";
            removerbutton.UseVisualStyleBackColor = true;
            removerbutton.Click += removerbutton_Click;
            // 
            // nomeEstoque
            // 
            nomeEstoque.Location = new Point(79, 316);
            nomeEstoque.Name = "nomeEstoque";
            nomeEstoque.Size = new Size(158, 23);
            nomeEstoque.TabIndex = 4;
            // 
            // addestoque
            // 
            addestoque.Location = new Point(12, 390);
            addestoque.Name = "addestoque";
            addestoque.Size = new Size(120, 32);
            addestoque.TabIndex = 6;
            addestoque.Text = "adicionar";
            addestoque.UseVisualStyleBackColor = true;
            addestoque.Click += addestoque_Click;
            // 
            // removestoq
            // 
            removestoq.Location = new Point(163, 390);
            removestoq.Name = "removestoq";
            removestoq.Size = new Size(120, 32);
            removestoq.TabIndex = 6;
            removestoq.Text = "remover";
            removestoq.UseVisualStyleBackColor = true;
            removestoq.Click += removestoq_Click;
            // 
            // quantProduto
            // 
            quantProduto.Location = new Point(94, 102);
            quantProduto.Name = "quantProduto";
            quantProduto.Size = new Size(128, 23);
            quantProduto.TabIndex = 5;
            quantProduto.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 47);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 8;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Quantidade";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 134);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 319);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Nome";
            label5.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 347);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 8;
            label6.Text = "Quantidade";
            label6.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Gestão_de_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 549);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(isChapa);
            Controls.Add(removestoq);
            Controls.Add(addestoque);
            Controls.Add(removerbutton);
            Controls.Add(addbutton);
            Controls.Add(quantProduto);
            Controls.Add(quantEstoque);
            Controls.Add(nomeEstoque);
            Controls.Add(nomeProduto);
            Controls.Add(valorProduto);
            Controls.Add(codigoProduto);
            Controls.Add(estoqueList);
            Controls.Add(cardapioList);
            Name = "Gestão_de_Produto";
            Text = "Gestão_de_Produto";
            Load += Gestão_de_Produto_Load;
            ((System.ComponentModel.ISupportInitialize)quantEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView cardapioList;
        private ColumnHeader nomeHeader1;
        private ColumnHeader quantHeader1;
        private ListView estoqueList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox codigoProduto;
        private NumericUpDown quantEstoque;
        private Button addbutton;
        private TextBox nomeProduto;
        private TextBox valorProduto;
        private CheckBox isChapa;
        private Button removerbutton;
        private TextBox nomeEstoque;
        private Button addestoque;
        private Button removestoq;
        private NumericUpDown quantProduto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}