﻿namespace uchet_studentov
{
    partial class New_St
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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.open_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.button_gen = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(196, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 22);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Иванов Иван Иванович";
            this.toolTip1.SetToolTip(this.textBoxName, "Фамилия Имя Отчество, 3 слова через пробел!");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ФИО студента";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавьте файл с заданиями";
            // 
            // open_button
            // 
            this.open_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.open_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_button.Location = new System.Drawing.Point(281, 162);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(165, 26);
            this.open_button.TabIndex = 3;
            this.open_button.Text = "Добавить файл";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.docx)|*.docx|(*.doc)|*.doc";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сколько всего заданий?";
            // 
            // textBoxKol
            // 
            this.textBoxKol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKol.Location = new System.Drawing.Point(281, 92);
            this.textBoxKol.Name = "textBoxKol";
            this.textBoxKol.Size = new System.Drawing.Size(165, 22);
            this.textBoxKol.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сколько вариантов заданий?";
            // 
            // textBoxVar
            // 
            this.textBoxVar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVar.Location = new System.Drawing.Point(281, 127);
            this.textBoxVar.Name = "textBoxVar";
            this.textBoxVar.Size = new System.Drawing.Size(165, 22);
            this.textBoxVar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите № группы студента";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroup.Location = new System.Drawing.Point(281, 57);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(165, 22);
            this.textBoxGroup.TabIndex = 9;
            // 
            // button_gen
            // 
            this.button_gen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_gen.Location = new System.Drawing.Point(28, 197);
            this.button_gen.Name = "button_gen";
            this.button_gen.Size = new System.Drawing.Size(418, 36);
            this.button_gen.TabIndex = 10;
            this.button_gen.Text = "Добавить студента";
            this.button_gen.UseVisualStyleBackColor = true;
            this.button_gen.Click += new System.EventHandler(this.button_gen_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Внимание!";
            // 
            // New_St
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.button_gen);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "New_St";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый студент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Button button_gen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}