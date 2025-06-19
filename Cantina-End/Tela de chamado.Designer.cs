namespace Cantina_End
{
    partial class Tela_de_chamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_de_chamado));
            listBox1 = new ListBox();
            label1 = new Label();
            proxButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(243, 241, 238);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ColumnWidth = 900;
            listBox1.Font = new Font("Agrandir Narrow", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(131, 62);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(297, 384);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow", 20.25F, FontStyle.Bold);
            label1.Location = new Point(792, 62);
            label1.Name = "label1";
            label1.Size = new Size(82, 36);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // proxButton
            // 
            proxButton.Location = new Point(756, 409);
            proxButton.Name = "proxButton";
            proxButton.Size = new Size(161, 49);
            proxButton.TabIndex = 2;
            proxButton.Text = "Próximo";
            proxButton.UseVisualStyleBackColor = true;
            proxButton.Click += proxButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(925, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-55, -52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(672, 795);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Tela_de_chamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 526);
            Controls.Add(pictureBox1);
            Controls.Add(proxButton);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Name = "Tela_de_chamado";
            Text = "Tela_de_chamado";
            Load += Tela_de_chamado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button proxButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}