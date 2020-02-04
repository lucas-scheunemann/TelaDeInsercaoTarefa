namespace TelaInsercaoTarefa
{
    partial class frmInsertTarefa
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAtendente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.cmbVersao = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtTaskOrigem = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtTrelloURL = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtUrgencia = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atendente: ";
            // 
            // lblAtendente
            // 
            this.lblAtendente.AutoSize = true;
            this.lblAtendente.Location = new System.Drawing.Point(80, 9);
            this.lblAtendente.Name = "lblAtendente";
            this.lblAtendente.Size = new System.Drawing.Size(105, 13);
            this.lblAtendente.TabIndex = 1;
            this.lblAtendente.Text = "(nome do atendente)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "urgencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "tempo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "versão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "motivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Task:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "TaskOrigem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "data:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(80, 249);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(60, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "(data atual)";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(47, 364);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(27, 13);
            this.lbl10.TabIndex = 11;
            this.lbl10.Text = "obs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Area:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "trello (URL):";
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Lime;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(619, 58);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(131, 105);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(619, 169);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 111);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(80, 181);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(121, 21);
            this.cmbMotivo.TabIndex = 32;
            // 
            // cmbVersao
            // 
            this.cmbVersao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersao.FormattingEnabled = true;
            this.cmbVersao.Location = new System.Drawing.Point(80, 147);
            this.cmbVersao.Name = "cmbVersao";
            this.cmbVersao.Size = new System.Drawing.Size(121, 21);
            this.cmbVersao.TabIndex = 31;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(80, 275);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 21);
            this.cmbArea.TabIndex = 34;
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(80, 305);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 21);
            this.cmbTime.TabIndex = 35;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(80, 58);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(121, 20);
            this.txtTask.TabIndex = 28;
            // 
            // txtTaskOrigem
            // 
            this.txtTaskOrigem.Location = new System.Drawing.Point(80, 212);
            this.txtTaskOrigem.Name = "txtTaskOrigem";
            this.txtTaskOrigem.Size = new System.Drawing.Size(121, 20);
            this.txtTaskOrigem.TabIndex = 33;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(80, 361);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(536, 77);
            this.txtObs.TabIndex = 37;
            // 
            // txtTrelloURL
            // 
            this.txtTrelloURL.Location = new System.Drawing.Point(80, 335);
            this.txtTrelloURL.Name = "txtTrelloURL";
            this.txtTrelloURL.Size = new System.Drawing.Size(536, 20);
            this.txtTrelloURL.TabIndex = 36;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(80, 115);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(121, 20);
            this.txtTempo.TabIndex = 30;
            // 
            // txtUrgencia
            // 
            this.txtUrgencia.Location = new System.Drawing.Point(80, 88);
            this.txtUrgencia.Name = "txtUrgencia";
            this.txtUrgencia.Size = new System.Drawing.Size(121, 20);
            this.txtUrgencia.TabIndex = 29;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(80, 32);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(288, 20);
            this.txtCliente.TabIndex = 27;
            // 
            // frmInsertTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtUrgencia);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtTrelloURL);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtTaskOrigem);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbVersao);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAtendente);
            this.Controls.Add(this.label1);
            this.Name = "frmInsertTarefa";
            this.Text = "Inserção de dados em Tarefa";
            this.Load += new System.EventHandler(this.frmInsertTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAtendente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.ComboBox cmbVersao;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.TextBox txtTaskOrigem;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtTrelloURL;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtUrgencia;
        private System.Windows.Forms.TextBox txtCliente;
    }
}

