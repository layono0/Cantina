namespace Cantina_End
{
    partial class Balcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcao));
            pictureBox1 = new PictureBox();
            pedidosAtuaisView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            historicoDePedidosView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            itensView = new ListBox();
            finalizarButton = new Button();
            cancelarButton = new Button();
            verificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pedidosAtuaisView
            // 
            pedidosAtuaisView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            pedidosAtuaisView.FullRowSelect = true;
            pedidosAtuaisView.Location = new Point(12, 90);
            pedidosAtuaisView.Name = "pedidosAtuaisView";
            pedidosAtuaisView.Size = new Size(306, 322);
            pedidosAtuaisView.TabIndex = 10;
            pedidosAtuaisView.UseCompatibleStateImageBehavior = false;
            pedidosAtuaisView.View = View.Details;
            pedidosAtuaisView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 161;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Total";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 80;
            // 
            // historicoDePedidosView
            // 
            historicoDePedidosView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            historicoDePedidosView.FullRowSelect = true;
            historicoDePedidosView.Location = new Point(661, 90);
            historicoDePedidosView.Name = "historicoDePedidosView";
            historicoDePedidosView.Size = new Size(238, 322);
            historicoDePedidosView.TabIndex = 11;
            historicoDePedidosView.UseCompatibleStateImageBehavior = false;
            historicoDePedidosView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nome";
            columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Data";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 80;
            // 
            // itensView
            // 
            itensView.FormattingEnabled = true;
            itensView.ItemHeight = 15;
            itensView.Location = new Point(383, 93);
            itensView.Name = "itensView";
            itensView.Size = new Size(226, 319);
            itensView.TabIndex = 12;
            // 
            // finalizarButton
            // 
            finalizarButton.Location = new Point(12, 418);
            finalizarButton.Name = "finalizarButton";
            finalizarButton.Size = new Size(108, 37);
            finalizarButton.TabIndex = 13;
            finalizarButton.Text = "Finalizar";
            finalizarButton.UseVisualStyleBackColor = true;
            finalizarButton.Click += finalizarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(210, 418);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(108, 37);
            cancelarButton.TabIndex = 13;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // verificarButton
            // 
            verificarButton.Location = new Point(430, 418);
            verificarButton.Name = "verificarButton";
            verificarButton.Size = new Size(124, 37);
            verificarButton.TabIndex = 14;
            verificarButton.Text = "Verificar Pedidos";
            verificarButton.UseVisualStyleBackColor = true;
            verificarButton.Click += verificarButton_Click;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 467);
            Controls.Add(verificarButton);
            Controls.Add(cancelarButton);
            Controls.Add(finalizarButton);
            Controls.Add(itensView);
            Controls.Add(historicoDePedidosView);
            Controls.Add(pedidosAtuaisView);
            Controls.Add(pictureBox1);
            Name = "Balcao";
            Text = "Balcao";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ListView pedidosAtuaisView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView historicoDePedidosView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListBox itensView;
        private Button finalizarButton;
        private Button cancelarButton;
        private Button verificarButton;
    }
}