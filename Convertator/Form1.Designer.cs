﻿namespace Convertator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Done_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Unput_TBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TwoCBox = new System.Windows.Forms.ComboBox();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstCBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Done_Button
            // 
            this.Done_Button.Location = new System.Drawing.Point(436, 43);
            this.Done_Button.Name = "Done_Button";
            this.Done_Button.Size = new System.Drawing.Size(75, 23);
            this.Done_Button.TabIndex = 0;
            this.Done_Button.Text = "Готово";
            this.Done_Button.UseVisualStyleBackColor = true;
            this.Done_Button.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Я хочу перевести";
            // 
            // Unput_TBox
            // 
            this.Unput_TBox.Location = new System.Drawing.Point(113, 6);
            this.Unput_TBox.Name = "Unput_TBox";
            this.Unput_TBox.Size = new System.Drawing.Size(100, 20);
            this.Unput_TBox.TabIndex = 3;
            this.Unput_TBox.TextChanged += new System.EventHandler(this.UnputTBox_TextChanged);
            this.Unput_TBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnputTBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "в";
            // 
            // TwoCBox
            // 
            this.TwoCBox.FormattingEnabled = true;
            this.TwoCBox.Items.AddRange(new object[] {
            "Квадратные милиметры",
            "Квадратные сантиметры",
            "Квадратные метры",
            "Квадратные километры"});
            this.TwoCBox.Location = new System.Drawing.Point(390, 6);
            this.TwoCBox.Name = "TwoCBox";
            this.TwoCBox.Size = new System.Drawing.Size(121, 21);
            this.TwoCBox.TabIndex = 7;
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(12, 48);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(10, 13);
            this.FinalLabel.TabIndex = 8;
            this.FinalLabel.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "из";
            // 
            // FirstCBox
            // 
            this.FirstCBox.FormattingEnabled = true;
            this.FirstCBox.Items.AddRange(new object[] {
            "Квадратные милиметры",
            "Квадратные сантиметры",
            "Квадратные метры",
            "Квадратные километры"});
            this.FirstCBox.Location = new System.Drawing.Point(244, 7);
            this.FirstCBox.Name = "FirstCBox";
            this.FirstCBox.Size = new System.Drawing.Size(121, 21);
            this.FirstCBox.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(355, 43);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(527, 72);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FirstCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.TwoCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Unput_TBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Done_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Unput_TBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TwoCBox;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FirstCBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

