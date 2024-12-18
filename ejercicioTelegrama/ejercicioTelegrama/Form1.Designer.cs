namespace ejercicioTelegrama
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
            label1 = new Label();
            chkUrgente = new CheckBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            btncalcular = new Button();
            txtTelegrama = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 36);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(58, 197);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(73, 19);
            chkUrgente.TabIndex = 1;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(104, 240);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 243);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(280, 210);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(97, 41);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(58, 64);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(319, 96);
            txtTelegrama.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 315);
            Controls.Add(txtTelegrama);
            Controls.Add(btncalcular);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(chkUrgente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chkUrgente;
        private TextBox txtPrecio;
        private Label label2;
        private Button btncalcular;
        private TextBox txtTelegrama;
    }
}
