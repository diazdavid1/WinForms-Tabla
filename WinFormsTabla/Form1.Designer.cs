
namespace WinFormsTabla
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
            panelprincipal = new Panel();
            richTextBoxResultado = new RichTextBox();
            buttonVerTabla = new Button();
            textBoxNum = new TextBox();
            labelnum = new Label();
            labeltitulo = new Label();
            labelnombre = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = SystemColors.ControlLight;
            panelprincipal.Controls.Add(labelnombre);
            panelprincipal.Controls.Add(richTextBoxResultado);
            panelprincipal.Controls.Add(buttonVerTabla);
            panelprincipal.Controls.Add(textBoxNum);
            panelprincipal.Controls.Add(labelnum);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(10, 7);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(615, 411);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.BackColor = SystemColors.HotTrack;
            richTextBoxResultado.Location = new Point(291, 59);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.Size = new Size(225, 238);
            richTextBoxResultado.TabIndex = 4;
            richTextBoxResultado.Text = "";
            // 
            // buttonVerTabla
            // 
            buttonVerTabla.BackColor = Color.Fuchsia;
            buttonVerTabla.Cursor = Cursors.AppStarting;
            buttonVerTabla.Location = new Point(93, 173);
            buttonVerTabla.Name = "buttonVerTabla";
            buttonVerTabla.RightToLeft = RightToLeft.No;
            buttonVerTabla.Size = new Size(100, 39);
            buttonVerTabla.TabIndex = 3;
            buttonVerTabla.Text = "Ver tabla";
            buttonVerTabla.UseVisualStyleBackColor = false;
            buttonVerTabla.Click += buttonVerTabla_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(93, 90);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(100, 23);
            textBoxNum.TabIndex = 2;
            // 
            // labelnum
            // 
            labelnum.AutoSize = true;
            labelnum.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnum.Location = new Point(59, 54);
            labelnum.Name = "labelnum";
            labelnum.Size = new Size(171, 24);
            labelnum.TabIndex = 1;
            labelnum.Text = "Cual tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AccessibleDescription = "";
            labeltitulo.AutoSize = true;
            labeltitulo.BackColor = Color.Lime;
            labeltitulo.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(4, 2);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(214, 27);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.BackColor = Color.Yellow;
            labelnombre.Location = new Point(59, 324);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(216, 15);
            labelnombre.TabIndex = 5;
            labelnombre.Text = "David Alejandro Diaz de Leon Anguiano";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 427);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        private void labeltitulo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelprincipal;
        private Label labelnum;
        private Label labeltitulo;
        private Button buttonVerTabla;
        private TextBox textBoxNum;
        private RichTextBox richTextBoxResultado;
        private Label labelnombre;
    }
}
