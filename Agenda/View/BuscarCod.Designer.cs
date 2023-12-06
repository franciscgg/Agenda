namespace Agenda.View
{
    partial class BuscarCod
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
            bnt_Buscar = new Button();
            txb_Celular = new TextBox();
            txb_Email = new TextBox();
            txb_Nome = new TextBox();
            txb_IdBuscar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 37);
            label1.TabIndex = 1;
            label1.Text = "Agenda Buscar Codigo";
            // 
            // bnt_Buscar
            // 
            bnt_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            bnt_Buscar.Location = new Point(227, 181);
            bnt_Buscar.Name = "bnt_Buscar";
            bnt_Buscar.Size = new Size(140, 34);
            bnt_Buscar.TabIndex = 33;
            bnt_Buscar.Text = "Buscar";
            bnt_Buscar.UseVisualStyleBackColor = true;
            bnt_Buscar.Click += bnt_Buscar_Click;
            // 
            // txb_Celular
            // 
            txb_Celular.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Celular.Location = new Point(129, 443);
            txb_Celular.Name = "txb_Celular";
            txb_Celular.Size = new Size(330, 34);
            txb_Celular.TabIndex = 32;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Email.Location = new Point(129, 345);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(330, 34);
            txb_Email.TabIndex = 31;
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Nome.Location = new Point(129, 258);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(330, 34);
            txb_Nome.TabIndex = 30;
            // 
            // txb_IdBuscar
            // 
            txb_IdBuscar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_IdBuscar.Location = new Point(133, 132);
            txb_IdBuscar.Name = "txb_IdBuscar";
            txb_IdBuscar.Size = new Size(330, 34);
            txb_IdBuscar.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label5.Location = new Point(129, 397);
            label5.Name = "label5";
            label5.Size = new Size(76, 30);
            label5.TabIndex = 28;
            label5.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(129, 312);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 27;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(129, 225);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 26;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(227, 78);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 25;
            label2.Text = "Digite o Código";
            // 
            // BuscarCod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(591, 587);
            Controls.Add(bnt_Buscar);
            Controls.Add(txb_Celular);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(txb_IdBuscar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BuscarCod";
            Text = "BuscarCod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bnt_Buscar;
        private TextBox txb_Celular;
        private TextBox txb_Email;
        private TextBox txb_Nome;
        private TextBox txb_IdBuscar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}