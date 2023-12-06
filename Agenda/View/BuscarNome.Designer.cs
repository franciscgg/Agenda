namespace Agenda.View
{
    partial class BuscarNome
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
            btn_Buscar = new Button();
            tbx_nomebuscar = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Fone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 1;
            label1.Text = "Agenda Buscar Nome";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Buscar.Location = new Point(217, 177);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(140, 34);
            btn_Buscar.TabIndex = 43;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // tbx_nomebuscar
            // 
            tbx_nomebuscar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_nomebuscar.Location = new Point(123, 128);
            tbx_nomebuscar.Name = "tbx_nomebuscar";
            tbx_nomebuscar.Size = new Size(330, 34);
            tbx_nomebuscar.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(217, 74);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 35;
            label2.Text = "Digite o Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Fone, Email });
            dataGridView1.Location = new Point(86, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(404, 264);
            dataGridView1.TabIndex = 44;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Fone
            // 
            Fone.HeaderText = "Fone";
            Fone.Name = "Fone";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // BuscarNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(566, 618);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Buscar);
            Controls.Add(tbx_nomebuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BuscarNome";
            Text = "BuscarNome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Buscar;
        private TextBox tbx_nomebuscar;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Fone;
        private DataGridViewTextBoxColumn Email;
    }
}