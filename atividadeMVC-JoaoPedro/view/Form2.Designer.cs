namespace atividadeMVC_JoaoPedro.view
{
    partial class Form2
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
            lblName = new Label();
            lblEmail = new Label();
            lblMatricula = new Label();
            txtName = new TextBox();
            txtMatricula = new TextBox();
            txtEmail = new TextBox();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(156, 203);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nome :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(156, 249);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email :";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(156, 289);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(63, 15);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Matricula :";
            // 
            // txtName
            // 
            txtName.Location = new Point(231, 200);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(231, 286);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 246);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(734, 219);
            button1.Name = "button1";
            button1.Size = new Size(145, 55);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar Funcionario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 69);
            label1.Name = "label1";
            label1.Size = new Size(397, 50);
            label1.TabIndex = 7;
            label1.Text = "Cadastrar Funcionarios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 471);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1150, 216);
            dataGridView1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 654);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtMatricula);
            Controls.Add(txtName);
            Controls.Add(lblMatricula);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblMatricula;
        private TextBox txtName;
        private TextBox txtMatricula;
        private TextBox txtEmail;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}