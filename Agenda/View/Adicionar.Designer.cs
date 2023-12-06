namespace Agenda.View
{
    partial class Adicionar
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
            txb_Nome = new TextBox();
            txb_Email = new TextBox();
            mtxb_Celular = new MaskedTextBox();
            btn_Adicionar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(182, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 1;
            label1.Text = "Agenda Adicionar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(54, 99);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(54, 184);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(54, 289);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 4;
            label4.Text = "Celular";
            // 
            // txb_Nome
            // 
            txb_Nome.Location = new Point(54, 132);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(330, 35);
            txb_Nome.TabIndex = 5;
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(54, 228);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(330, 35);
            txb_Email.TabIndex = 6;
            // 
            // mtxb_Celular
            // 
            mtxb_Celular.Location = new Point(54, 339);
            mtxb_Celular.Mask = "(99) 00000-0000";
            mtxb_Celular.Name = "mtxb_Celular";
            mtxb_Celular.Size = new Size(179, 35);
            mtxb_Celular.TabIndex = 7;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Adicionar.Location = new Point(244, 424);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(140, 44);
            btn_Adicionar.TabIndex = 9;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // Adicionar
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(607, 519);
            Controls.Add(btn_Adicionar);
            Controls.Add(mtxb_Celular);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Adicionar";
            Text = "Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_Nome;
        private TextBox txb_Email;
        private MaskedTextBox mtxb_Celular;
        private Button btn_Adicionar;
    }
}