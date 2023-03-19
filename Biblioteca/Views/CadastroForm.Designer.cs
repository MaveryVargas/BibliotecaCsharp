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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClienteForm));
            this.lbl_TelaCadastro = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.imageBtnDecisao = new System.Windows.Forms.ImageList(this.components);
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TelaCadastro
            // 
            this.lbl_TelaCadastro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_TelaCadastro.Enabled = false;
            this.lbl_TelaCadastro.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TelaCadastro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TelaCadastro.Location = new System.Drawing.Point(0, 0);
            this.lbl_TelaCadastro.Name = "lbl_TelaCadastro";
            this.lbl_TelaCadastro.Size = new System.Drawing.Size(800, 92);
            this.lbl_TelaCadastro.TabIndex = 0;
            this.lbl_TelaCadastro.Text = "Cadastro de cliente";
            this.lbl_TelaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TelaCadastro.Click += new System.EventHandler(this.lbl_TelaCadastro_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.ImageIndex = 0;
            this.btn_Confirmar.ImageList = this.imageBtnDecisao;
            this.btn_Confirmar.Location = new System.Drawing.Point(12, 370);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(96, 39);
            this.btn_Confirmar.TabIndex = 1;
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // imageBtnDecisao
            // 
            this.imageBtnDecisao.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageBtnDecisao.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageBtnDecisao.ImageStream")));
            this.imageBtnDecisao.TransparentColor = System.Drawing.Color.Transparent;
            this.imageBtnDecisao.Images.SetKeyName(0, "aceitar.png");
            this.imageBtnDecisao.Images.SetKeyName(1, "download.jpg");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ImageIndex = 1;
            this.btn_Cancelar.ImageList = this.imageBtnDecisao;
            this.btn_Cancelar.Location = new System.Drawing.Point(692, 370);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(96, 39);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.lbl_TelaCadastro);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CadastroClienteForm";
            this.Text = "Cadastro de cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_TelaCadastro;
        private Button btn_Confirmar;
        private ImageList imageBtnDecisao;
        private Button btn_Cancelar;
    }
}