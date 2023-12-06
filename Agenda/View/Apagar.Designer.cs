namespace Agenda.View
{
    partial class Apagar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbx_IdBuscar = new TextBox();
            tbx_Nome = new TextBox();
            tbx_Email = new TextBox();
            tbx_Celular = new TextBox();
            btn_Buscar = new Button();
            btn_Excluir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(199, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 37);
            label1.TabIndex = 2;
            label1.Text = "Agenda Apagar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(135, 71);
            label2.Name = "label2";
            label2.Size = new Size(326, 30);
            label2.TabIndex = 3;
            label2.Text = "Digite o Id para encontrar a pessoa";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(38, 213);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 4;
            label3.Text = "Nome";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(38, 300);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 5;
            label4.Text = "Email";
 
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label5.Location = new Point(38, 385);
            label5.Name = "label5";
            label5.Size = new Size(76, 30);
            label5.TabIndex = 6;
            label5.Text = "Celular";

            // 
            // tbx_IdBuscar
            // 
            tbx_IdBuscar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_IdBuscar.Location = new Point(135, 121);
            tbx_IdBuscar.Name = "tbx_IdBuscar";
            tbx_IdBuscar.Size = new Size(330, 34);
            tbx_IdBuscar.TabIndex = 7;

            // 
            // tbx_Nome
            // 
            tbx_Nome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Nome.Location = new Point(38, 246);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(330, 34);
            tbx_Nome.TabIndex = 8;
 
            // 
            // tbx_Email
            // 
            tbx_Email.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Email.Location = new Point(38, 333);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(330, 34);
            tbx_Email.TabIndex = 9;
            // 
            // tbx_Celular
            // 
            tbx_Celular.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Celular.Location = new Point(38, 431);
            tbx_Celular.Name = "tbx_Celular";
            tbx_Celular.Size = new Size(330, 34);
            tbx_Celular.TabIndex = 10;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Buscar.Location = new Point(229, 170);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(140, 34);
            btn_Buscar.TabIndex = 13;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Adicionar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Excluir.Location = new Point(229, 555);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(140, 44);
            btn_Excluir.TabIndex = 14;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // Apagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(585, 625);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Buscar);
            Controls.Add(tbx_Celular);
            Controls.Add(tbx_Email);
            Controls.Add(tbx_Nome);
            Controls.Add(tbx_IdBuscar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Apagar";
            Text = "Apagar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbx_IdBuscar;
        private TextBox tbx_Nome;
        private TextBox tbx_Email;
        private TextBox tbx_Celular;
        private Button btn_Buscar;
        private Button btn_Excluir;
    }
}