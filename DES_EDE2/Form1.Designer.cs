
namespace DES_EDE2
{
    partial class Form1
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textKey1 = new System.Windows.Forms.TextBox();
            this.textKey2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxDesc = new System.Windows.Forms.CheckBox();
            this.checkBoxBinout = new System.Windows.Forms.CheckBox();
            this.checkBoxBlock = new System.Windows.Forms.CheckBox();
            this.checkBoxIn = new System.Windows.Forms.CheckBox();
            this.tabControl_EDE = new System.Windows.Forms.TabControl();
            this.tabPageE1 = new System.Windows.Forms.TabPage();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.tabPageD = new System.Windows.Forms.TabPage();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.tabPageE2 = new System.Windows.Forms.TabPage();
            this.textBoxE2 = new System.Windows.Forms.TextBox();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.textBox_E2 = new System.Windows.Forms.TextBox();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.textBox_E = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_EDE.SuspendLayout();
            this.tabPageE1.SuspendLayout();
            this.tabPageD.SuspendLayout();
            this.tabPageE2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Свои ключи";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textKey1
            // 
            this.textKey1.BackColor = System.Drawing.Color.Gray;
            this.textKey1.ForeColor = System.Drawing.SystemColors.Window;
            this.textKey1.Location = new System.Drawing.Point(12, 45);
            this.textKey1.Name = "textKey1";
            this.textKey1.Size = new System.Drawing.Size(139, 20);
            this.textKey1.TabIndex = 1;
            this.textKey1.Text = "Алгоритм";
            // 
            // textKey2
            // 
            this.textKey2.BackColor = System.Drawing.Color.Gray;
            this.textKey2.ForeColor = System.Drawing.SystemColors.Window;
            this.textKey2.Location = new System.Drawing.Point(157, 45);
            this.textKey2.Name = "textKey2";
            this.textKey2.Size = new System.Drawing.Size(127, 20);
            this.textKey2.TabIndex = 2;
            this.textKey2.Text = "Десс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ключ №1";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(154, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключ №2";
            this.label2.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // textBoxIn
            // 
            this.textBoxIn.BackColor = System.Drawing.Color.Gray;
            this.textBoxIn.Enabled = false;
            this.textBoxIn.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxIn.Location = new System.Drawing.Point(12, 260);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(272, 113);
            this.textBoxIn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Исходный текст:";
            // 
            // btnLoadText
            // 
            this.btnLoadText.BackColor = System.Drawing.Color.Gray;
            this.btnLoadText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadText.Enabled = false;
            this.btnLoadText.FlatAppearance.BorderSize = 0;
            this.btnLoadText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadText.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLoadText.Location = new System.Drawing.Point(215, 209);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(69, 20);
            this.btnLoadText.TabIndex = 7;
            this.btnLoadText.Text = "Загрузить";
            this.btnLoadText.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(296, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            this.textBoxOut.BackColor = System.Drawing.Color.Gray;
            this.textBoxOut.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxOut.Location = new System.Drawing.Point(291, 29);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(561, 174);
            this.textBoxOut.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(12, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Шифровать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(12, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "Разшифровать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxDesc
            // 
            this.checkBoxDesc.AutoSize = true;
            this.checkBoxDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxDesc.Location = new System.Drawing.Point(12, 78);
            this.checkBoxDesc.Name = "checkBoxDesc";
            this.checkBoxDesc.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDesc.TabIndex = 12;
            this.checkBoxDesc.Text = "Подробнее";
            this.checkBoxDesc.UseVisualStyleBackColor = true;
            this.checkBoxDesc.CheckedChanged += new System.EventHandler(this.checkBoxDesc_CheckedChanged);
            // 
            // checkBoxBinout
            // 
            this.checkBoxBinout.AutoSize = true;
            this.checkBoxBinout.Enabled = false;
            this.checkBoxBinout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxBinout.Location = new System.Drawing.Point(157, 101);
            this.checkBoxBinout.Name = "checkBoxBinout";
            this.checkBoxBinout.Size = new System.Drawing.Size(105, 17);
            this.checkBoxBinout.TabIndex = 13;
            this.checkBoxBinout.Text = "Двоичный блок";
            this.checkBoxBinout.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlock
            // 
            this.checkBoxBlock.AutoSize = true;
            this.checkBoxBlock.Enabled = false;
            this.checkBoxBlock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxBlock.Location = new System.Drawing.Point(12, 101);
            this.checkBoxBlock.Name = "checkBoxBlock";
            this.checkBoxBlock.Size = new System.Drawing.Size(124, 17);
            this.checkBoxBlock.TabIndex = 15;
            this.checkBoxBlock.Text = "Содержимое блока";
            this.checkBoxBlock.UseVisualStyleBackColor = true;
            this.checkBoxBlock.CheckedChanged += new System.EventHandler(this.checkBoxBlock_CheckedChanged);
            // 
            // checkBoxIn
            // 
            this.checkBoxIn.AutoSize = true;
            this.checkBoxIn.Checked = true;
            this.checkBoxIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxIn.Location = new System.Drawing.Point(136, 211);
            this.checkBoxIn.Name = "checkBoxIn";
            this.checkBoxIn.Size = new System.Drawing.Size(78, 17);
            this.checkBoxIn.TabIndex = 16;
            this.checkBoxIn.Text = "Из Файла";
            this.checkBoxIn.UseVisualStyleBackColor = true;
            this.checkBoxIn.CheckedChanged += new System.EventHandler(this.checkBoxIn_CheckedChanged);
            // 
            // tabControl_EDE
            // 
            this.tabControl_EDE.Controls.Add(this.tabPageE1);
            this.tabControl_EDE.Controls.Add(this.tabPageD);
            this.tabControl_EDE.Controls.Add(this.tabPageE2);
            this.tabControl_EDE.Location = new System.Drawing.Point(291, 209);
            this.tabControl_EDE.Name = "tabControl_EDE";
            this.tabControl_EDE.SelectedIndex = 0;
            this.tabControl_EDE.Size = new System.Drawing.Size(561, 240);
            this.tabControl_EDE.TabIndex = 19;
            this.tabControl_EDE.Visible = false;
            // 
            // tabPageE1
            // 
            this.tabPageE1.Controls.Add(this.textBoxE);
            this.tabPageE1.Location = new System.Drawing.Point(4, 22);
            this.tabPageE1.Name = "tabPageE1";
            this.tabPageE1.Size = new System.Drawing.Size(553, 214);
            this.tabPageE1.TabIndex = 0;
            this.tabPageE1.Text = "E";
            this.tabPageE1.UseVisualStyleBackColor = true;
            // 
            // textBoxE
            // 
            this.textBoxE.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxE.Location = new System.Drawing.Point(0, 0);
            this.textBoxE.Multiline = true;
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxE.Size = new System.Drawing.Size(553, 214);
            this.textBoxE.TabIndex = 0;
            // 
            // tabPageD
            // 
            this.tabPageD.Controls.Add(this.textBoxD);
            this.tabPageD.Location = new System.Drawing.Point(4, 22);
            this.tabPageD.Name = "tabPageD";
            this.tabPageD.Size = new System.Drawing.Size(553, 214);
            this.tabPageD.TabIndex = 1;
            this.tabPageD.Text = "D";
            this.tabPageD.UseVisualStyleBackColor = true;
            // 
            // textBoxD
            // 
            this.textBoxD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxD.Location = new System.Drawing.Point(0, 0);
            this.textBoxD.Multiline = true;
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxD.Size = new System.Drawing.Size(553, 214);
            this.textBoxD.TabIndex = 1;
            // 
            // tabPageE2
            // 
            this.tabPageE2.Controls.Add(this.textBoxE2);
            this.tabPageE2.Location = new System.Drawing.Point(4, 22);
            this.tabPageE2.Name = "tabPageE2";
            this.tabPageE2.Size = new System.Drawing.Size(553, 214);
            this.tabPageE2.TabIndex = 2;
            this.tabPageE2.Text = "E";
            this.tabPageE2.UseVisualStyleBackColor = true;
            // 
            // textBoxE2
            // 
            this.textBoxE2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxE2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxE2.Location = new System.Drawing.Point(0, 0);
            this.textBoxE2.Multiline = true;
            this.textBoxE2.Name = "textBoxE2";
            this.textBoxE2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxE2.Size = new System.Drawing.Size(553, 214);
            this.textBoxE2.TabIndex = 1;
            // 
            // tabPage19
            // 
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage19.Size = new System.Drawing.Size(668, 396);
            this.tabPage19.TabIndex = 2;
            this.tabPage19.Text = "E";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // textBox_E2
            // 
            this.textBox_E2.Location = new System.Drawing.Point(0, 0);
            this.textBox_E2.Multiline = true;
            this.textBox_E2.Name = "textBox_E2";
            this.textBox_E2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_E2.Size = new System.Drawing.Size(668, 396);
            this.textBox_E2.TabIndex = 1;
            // 
            // tabPage18
            // 
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(668, 396);
            this.tabPage18.TabIndex = 1;
            this.tabPage18.Text = "D";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(0, 0);
            this.textBox_D.Multiline = true;
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_D.Size = new System.Drawing.Size(668, 396);
            this.textBox_D.TabIndex = 0;
            // 
            // tabPage17
            // 
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(668, 396);
            this.tabPage17.TabIndex = 0;
            this.tabPage17.Text = "E";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // textBox_E
            // 
            this.textBox_E.Location = new System.Drawing.Point(0, 0);
            this.textBox_E.Multiline = true;
            this.textBox_E.Name = "textBox_E";
            this.textBox_E.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_E.Size = new System.Drawing.Size(668, 396);
            this.textBox_E.TabIndex = 1;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox2.Location = new System.Drawing.Point(136, 236);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Из Файла";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Зашифрованный текст:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(215, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(862, 461);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl_EDE);
            this.Controls.Add(this.checkBoxIn);
            this.Controls.Add(this.checkBoxBlock);
            this.Controls.Add(this.checkBoxBinout);
            this.Controls.Add(this.checkBoxDesc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKey2);
            this.Controls.Add(this.textKey1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLoadText);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES-EDE2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_EDE.ResumeLayout(false);
            this.tabPageE1.ResumeLayout(false);
            this.tabPageE1.PerformLayout();
            this.tabPageD.ResumeLayout(false);
            this.tabPageD.PerformLayout();
            this.tabPageE2.ResumeLayout(false);
            this.tabPageE2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textKey1;
        private System.Windows.Forms.TextBox textKey2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxDesc;
        private System.Windows.Forms.CheckBox checkBoxBinout;
        private System.Windows.Forms.CheckBox checkBoxBlock;
        private System.Windows.Forms.CheckBox checkBoxIn;
        private System.Windows.Forms.TabControl tabControl_EDE;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TextBox textBox_E2;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TextBox textBox_E;
        private System.Windows.Forms.TabPage tabPageE1;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TabPage tabPageD;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TabPage tabPageE2;
        private System.Windows.Forms.TextBox textBoxE2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

