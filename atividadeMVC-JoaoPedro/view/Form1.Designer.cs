namespace atividadeMVC_JoaoPedro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Tarefa = new TextBox();
            dateTime = new DateTimePicker();
            status = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1197, 353);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 148);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Tarefa";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 148);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Tag = "lblData";
            label2.Text = "Data";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 148);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Tag = "status";
            label3.Text = "status";
            label3.UseWaitCursor = true;
            // 
            // Tarefa
            // 
            Tarefa.Location = new Point(123, 145);
            Tarefa.Name = "Tarefa";
            Tarefa.Size = new Size(100, 23);
            Tarefa.TabIndex = 4;
            Tarefa.Tag = "Tarefa";
            // 
            // dateTime
            // 
            dateTime.Location = new Point(349, 145);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(200, 23);
            dateTime.TabIndex = 5;
            dateTime.Tag = "dateTime";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Location = new Point(637, 145);
            status.Name = "status";
            status.Size = new Size(121, 23);
            status.TabIndex = 6;
            status.Tag = "status";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(788, 136);
            button1.Name = "button1";
            button1.Size = new Size(145, 44);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar Tarefa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(393, 55);
            label4.Name = "label4";
            label4.Size = new Size(344, 45);
            label4.TabIndex = 8;
            label4.Text = "Gerenciador de Tarefas";
            label4.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1208, 678);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(status);
            Controls.Add(dateTime);
            Controls.Add(Tarefa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Tarefa;
        private DateTimePicker dateTime;
        private ComboBox status;
        private Button button1;
        private Label label4;
    }
}
