namespace Cantina_End
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            numeral = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numeral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(358, 563);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantidade Atual";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 114;
            // 
            // numeral
            // 
            numeral.Location = new Point(456, 207);
            numeral.Name = "numeral";
            numeral.Size = new Size(156, 23);
            numeral.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(441, 240);
            button1.Name = "button1";
            button1.Size = new Size(90, 42);
            button1.TabIndex = 2;
            button1.Text = "Cozinhar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 240);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 2;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(782, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 587);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numeral);
            Controls.Add(listView1);
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)numeral).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private NumericUpDown numeral;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}