namespace Biblioteca.Views
{
    partial class CadastroClienteForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClienteForm));
            lbl_TelaCadastro = new Label();
            btn_Confirmar = new Button();
            imageBtnDecisao = new ImageList(components);
            btn_Cancelar = new Button();
            lbl_Nome = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbl_Sobrenome = new Label();
            lbl_Email = new Label();
            textBox3 = new TextBox();
            lbl_DataNascimento = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbl_TelaCadastro
            // 
            lbl_TelaCadastro.BackColor = Color.CornflowerBlue;
            lbl_TelaCadastro.Enabled = false;
            lbl_TelaCadastro.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TelaCadastro.ForeColor = SystemColors.ControlLight;
            lbl_TelaCadastro.Location = new Point(0, 0);
            lbl_TelaCadastro.Name = "lbl_TelaCadastro";
            lbl_TelaCadastro.Size = new Size(800, 92);
            lbl_TelaCadastro.TabIndex = 0;
            lbl_TelaCadastro.Text = "Cadastro de cliente";
            lbl_TelaCadastro.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TelaCadastro.Click += lbl_TelaCadastro_Click;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.ImageIndex = 0;
            btn_Confirmar.ImageList = imageBtnDecisao;
            btn_Confirmar.Location = new Point(692, 354);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(96, 39);
            btn_Confirmar.TabIndex = 1;
            btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // imageBtnDecisao
            // 
            imageBtnDecisao.ColorDepth = ColorDepth.Depth8Bit;
            imageBtnDecisao.ImageStream = (ImageListStreamer)resources.GetObject("imageBtnDecisao.ImageStream");
            imageBtnDecisao.TransparentColor = Color.Transparent;
            imageBtnDecisao.Images.SetKeyName(0, "aceitar.png");
            imageBtnDecisao.Images.SetKeyName(1, "download.jpg");
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.ImageIndex = 1;
            btn_Cancelar.ImageList = imageBtnDecisao;
            btn_Cancelar.Location = new Point(692, 399);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(96, 39);
            btn_Cancelar.TabIndex = 2;
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.ForeColor = SystemColors.ActiveCaptionText;
            lbl_Nome.Location = new Point(12, 112);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(43, 15);
            lbl_Nome.TabIndex = 3;
            lbl_Nome.Text = "Nome:";
            lbl_Nome.UseMnemonic = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 6;
            // 
            // lbl_Sobrenome
            // 
            lbl_Sobrenome.AutoSize = true;
            lbl_Sobrenome.ForeColor = SystemColors.ActiveCaptionText;
            lbl_Sobrenome.Location = new Point(12, 161);
            lbl_Sobrenome.Name = "lbl_Sobrenome";
            lbl_Sobrenome.Size = new Size(71, 15);
            lbl_Sobrenome.TabIndex = 5;
            lbl_Sobrenome.Text = "Sobrenome:";
            lbl_Sobrenome.UseMnemonic = false;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.ForeColor = SystemColors.ActiveCaptionText;
            lbl_Email.Location = new Point(12, 209);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(39, 15);
            lbl_Email.TabIndex = 7;
            lbl_Email.Text = "Email:";
            lbl_Email.UseMnemonic = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 8;
            // 
            // lbl_DataNascimento
            // 
            lbl_DataNascimento.AutoSize = true;
            lbl_DataNascimento.ForeColor = SystemColors.ActiveCaptionText;
            lbl_DataNascimento.Location = new Point(12, 264);
            lbl_DataNascimento.Name = "lbl_DataNascimento";
            lbl_DataNascimento.Size = new Size(114, 15);
            lbl_DataNascimento.TabIndex = 9;
            lbl_DataNascimento.Text = "Data de Nascimento";
            lbl_DataNascimento.UseMnemonic = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 282);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(167, 23);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // CadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(lbl_DataNascimento);
            Controls.Add(textBox3);
            Controls.Add(lbl_Email);
            Controls.Add(textBox2);
            Controls.Add(lbl_Sobrenome);
            Controls.Add(textBox1);
            Controls.Add(lbl_Nome);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Confirmar);
            Controls.Add(lbl_TelaCadastro);
            ForeColor = SystemColors.ControlLightLight;
            Name = "CadastroClienteForm";
            Text = "Cadastro de cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TelaCadastro;
        private Button btn_Confirmar;
        private ImageList imageBtnDecisao;
        private Button btn_Cancelar;
        private Label lbl_Nome;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbl_Sobrenome;
        private Label lbl_Email;
        private TextBox textBox3;
        private Label lbl_DataNascimento;
        private MaskedTextBox maskedTextBox1;
    }
}