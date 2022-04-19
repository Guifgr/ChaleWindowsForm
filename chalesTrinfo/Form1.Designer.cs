
namespace chalesTrinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InformationTxt = new System.Windows.Forms.RichTextBox();
            this.SC1Btn = new System.Windows.Forms.Button();
            this.SC2Btn = new System.Windows.Forms.Button();
            this.WFBtn = new System.Windows.Forms.Button();
            this.chaleBtn = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.ShortDetailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sucesslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(202, 131);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(368, 23);
            this.NameTxt.TabIndex = 1;
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(202, 173);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(368, 23);
            this.PriceTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sobre";
            // 
            // InformationTxt
            // 
            this.InformationTxt.Location = new System.Drawing.Point(202, 258);
            this.InformationTxt.Name = "InformationTxt";
            this.InformationTxt.Size = new System.Drawing.Size(368, 96);
            this.InformationTxt.TabIndex = 5;
            this.InformationTxt.Text = "";
            // 
            // SC1Btn
            // 
            this.SC1Btn.Location = new System.Drawing.Point(64, 34);
            this.SC1Btn.Name = "SC1Btn";
            this.SC1Btn.Size = new System.Drawing.Size(102, 23);
            this.SC1Btn.TabIndex = 6;
            this.SC1Btn.Text = "SmartCamp1";
            this.SC1Btn.UseVisualStyleBackColor = true;
            this.SC1Btn.Click += new System.EventHandler(this.SC1Btn_Click);
            // 
            // SC2Btn
            // 
            this.SC2Btn.Location = new System.Drawing.Point(202, 34);
            this.SC2Btn.Name = "SC2Btn";
            this.SC2Btn.Size = new System.Drawing.Size(102, 23);
            this.SC2Btn.TabIndex = 7;
            this.SC2Btn.Text = "SmartCamp2";
            this.SC2Btn.UseVisualStyleBackColor = true;
            this.SC2Btn.Click += new System.EventHandler(this.SC2Btn_Click);
            // 
            // WFBtn
            // 
            this.WFBtn.Location = new System.Drawing.Point(489, 34);
            this.WFBtn.Name = "WFBtn";
            this.WFBtn.Size = new System.Drawing.Size(102, 23);
            this.WFBtn.TabIndex = 9;
            this.WFBtn.Text = "Wood Frame";
            this.WFBtn.UseVisualStyleBackColor = true;
            this.WFBtn.Click += new System.EventHandler(this.WFBtn_Click);
            // 
            // chaleBtn
            // 
            this.chaleBtn.Location = new System.Drawing.Point(351, 34);
            this.chaleBtn.Name = "chaleBtn";
            this.chaleBtn.Size = new System.Drawing.Size(102, 23);
            this.chaleBtn.TabIndex = 8;
            this.chaleBtn.Text = "Chalé Grande";
            this.chaleBtn.UseVisualStyleBackColor = true;
            this.chaleBtn.Click += new System.EventHandler(this.chaleBtn_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(266, 377);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Salvar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ShortDetailTxt
            // 
            this.ShortDetailTxt.Location = new System.Drawing.Point(202, 216);
            this.ShortDetailTxt.Name = "ShortDetailTxt";
            this.ShortDetailTxt.Size = new System.Drawing.Size(368, 23);
            this.ShortDetailTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(100, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Detalhe";
            // 
            // sucesslbl
            // 
            this.sucesslbl.AutoSize = true;
            this.sucesslbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sucesslbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sucesslbl.Location = new System.Drawing.Point(12, 413);
            this.sucesslbl.Name = "sucesslbl";
            this.sucesslbl.Size = new System.Drawing.Size(0, 28);
            this.sucesslbl.TabIndex = 14;
            this.sucesslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.sucesslbl);
            this.Controls.Add(this.ShortDetailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.WFBtn);
            this.Controls.Add(this.chaleBtn);
            this.Controls.Add(this.SC2Btn);
            this.Controls.Add(this.SC1Btn);
            this.Controls.Add(this.InformationTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chalés Triunfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox InformationTxt;
        private System.Windows.Forms.Button SC1Btn;
        private System.Windows.Forms.Button SC2Btn;
        private System.Windows.Forms.Button WFBtn;
        private System.Windows.Forms.Button chaleBtn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox ShortDetailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sucesslbl;
    }
}

