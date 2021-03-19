
namespace I002
{
    partial class ChangeAndAddCounteragent
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.TxtInn = new System.Windows.Forms.MaskedTextBox();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LabName = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LabSurname = new System.Windows.Forms.Label();
            this.BtnForAction = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnClose);
            this.MainPanel.Controls.Add(this.TxtInn);
            this.MainPanel.Controls.Add(this.TxtPhone);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.TxtAdress);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.TxtMiddleName);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.TxtName);
            this.MainPanel.Controls.Add(this.LabName);
            this.MainPanel.Controls.Add(this.TxtSurname);
            this.MainPanel.Controls.Add(this.LabSurname);
            this.MainPanel.Controls.Add(this.BtnForAction);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(549, 513);
            this.MainPanel.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(442, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 29);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // TxtInn
            // 
            this.TxtInn.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtInn.Location = new System.Drawing.Point(151, 263);
            this.TxtInn.Mask = "000000000000";
            this.TxtInn.Name = "TxtInn";
            this.TxtInn.Size = new System.Drawing.Size(318, 28);
            this.TxtInn.TabIndex = 19;
            this.TxtInn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPhone.Location = new System.Drawing.Point(151, 387);
            this.TxtPhone.Mask = "0 (999) 000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(318, 28);
            this.TxtPhone.TabIndex = 18;
            this.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(46, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Телефон:";
            // 
            // TxtAdress
            // 
            this.TxtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdress.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtAdress.Location = new System.Drawing.Point(151, 325);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(318, 28);
            this.TxtAdress.TabIndex = 16;
            this.TxtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(66, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(78, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "ИНН:";
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMiddleName.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtMiddleName.Location = new System.Drawing.Point(151, 198);
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.Size = new System.Drawing.Size(318, 28);
            this.TxtMiddleName.TabIndex = 12;
            this.TxtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Отчество:";
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtName.Location = new System.Drawing.Point(151, 138);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(318, 28);
            this.TxtName.TabIndex = 10;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabName.Location = new System.Drawing.Point(82, 140);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(56, 23);
            this.LabName.TabIndex = 9;
            this.LabName.Text = "Имя:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSurname.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSurname.Location = new System.Drawing.Point(151, 76);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(318, 28);
            this.TxtSurname.TabIndex = 8;
            this.TxtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabSurname
            // 
            this.LabSurname.AutoSize = true;
            this.LabSurname.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabSurname.Location = new System.Drawing.Point(46, 78);
            this.LabSurname.Name = "LabSurname";
            this.LabSurname.Size = new System.Drawing.Size(101, 23);
            this.LabSurname.TabIndex = 7;
            this.LabSurname.Text = "Фамилия:";
            // 
            // BtnForAction
            // 
            this.BtnForAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnForAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnForAction.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnForAction.ForeColor = System.Drawing.Color.Black;
            this.BtnForAction.Location = new System.Drawing.Point(203, 450);
            this.BtnForAction.Name = "BtnForAction";
            this.BtnForAction.Size = new System.Drawing.Size(157, 39);
            this.BtnForAction.TabIndex = 0;
            this.BtnForAction.Text = "Добавить";
            this.BtnForAction.UseVisualStyleBackColor = true;
            this.BtnForAction.Click += new System.EventHandler(this.BtnForAction_Click);
            // 
            // ChangeAndAddCounteragent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 513);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeAndAddCounteragent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование пользователя";
            this.Load += new System.EventHandler(this.ChangeAndAddCounteragent_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LabSurname;
        private System.Windows.Forms.Button BtnForAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.MaskedTextBox TxtInn;
        private System.Windows.Forms.Button btnClose;
    }
}