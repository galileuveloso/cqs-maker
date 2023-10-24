namespace CQSMaker.Forms
{
    partial class CQSMaker
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandNameTxt = new System.Windows.Forms.TextBox();
            this.ResultTxt = new System.Windows.Forms.RichTextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.ProjetoSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeSelect = new System.Windows.Forms.ComboBox();
            this.FeatureTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResponseListCkb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(589, 94);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(95, 23);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // CommandNameTxt
            // 
            this.CommandNameTxt.Location = new System.Drawing.Point(15, 30);
            this.CommandNameTxt.Name = "CommandNameTxt";
            this.CommandNameTxt.Size = new System.Drawing.Size(197, 22);
            this.CommandNameTxt.TabIndex = 0;
            // 
            // ResultTxt
            // 
            this.ResultTxt.Location = new System.Drawing.Point(12, 123);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(794, 490);
            this.ResultTxt.TabIndex = 3;
            this.ResultTxt.Text = "";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(15, 94);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(96, 23);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "@Galileu Frez Veloso";
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(690, 94);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(116, 23);
            this.CopyBtn.TabIndex = 3;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // ProjetoSelect
            // 
            this.ProjetoSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjetoSelect.FormattingEnabled = true;
            this.ProjetoSelect.Items.AddRange(new object[] {
            "Mps.Documento",
            "Mps.Fluxo",
            "Mps.FluxoEvento",
            "Mps.Questionario",
            "Mps.ModeloTexto",
            "Mps.Notificacao",
            "Mps.Notificacao",
            "Mps.Localizacao",
            "Mps.Usuario"});
            this.ProjetoSelect.Location = new System.Drawing.Point(424, 28);
            this.ProjetoSelect.Name = "ProjetoSelect";
            this.ProjetoSelect.Size = new System.Drawing.Size(197, 24);
            this.ProjetoSelect.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // TypeSelect
            // 
            this.TypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelect.FormattingEnabled = true;
            this.TypeSelect.Items.AddRange(new object[] {
            "Command",
            "Query"});
            this.TypeSelect.Location = new System.Drawing.Point(627, 28);
            this.TypeSelect.Name = "TypeSelect";
            this.TypeSelect.Size = new System.Drawing.Size(179, 24);
            this.TypeSelect.TabIndex = 11;
            // 
            // FeatureTxt
            // 
            this.FeatureTxt.Location = new System.Drawing.Point(218, 30);
            this.FeatureTxt.Name = "FeatureTxt";
            this.FeatureTxt.Size = new System.Drawing.Size(197, 22);
            this.FeatureTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Feature";
            // 
            // ResponseListCkb
            // 
            this.ResponseListCkb.AutoSize = true;
            this.ResponseListCkb.Location = new System.Drawing.Point(627, 58);
            this.ResponseListCkb.Name = "ResponseListCkb";
            this.ResponseListCkb.Size = new System.Drawing.Size(115, 20);
            this.ResponseListCkb.TabIndex = 15;
            this.ResponseListCkb.Text = "Response List";
            this.ResponseListCkb.UseVisualStyleBackColor = true;
            // 
            // CQSMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 641);
            this.Controls.Add(this.ResponseListCkb);
            this.Controls.Add(this.FeatureTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypeSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjetoSelect);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.CommandNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CQSMaker";
            this.Text = "CQS Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommandNameTxt;
        private System.Windows.Forms.RichTextBox ResultTxt;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.ComboBox ProjetoSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeSelect;
        private System.Windows.Forms.TextBox FeatureTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ResponseListCkb;
    }
}