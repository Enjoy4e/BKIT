namespace Lab4
{
    partial class Searcher
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
        private System.Windows.Forms.Button OpenFile;
            




        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Search = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.Pattern = new System.Windows.Forms.TextBox();
            this.WordList = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(207, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(116, 47);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OpenFile.Location = new System.Drawing.Point(48, 28);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(116, 47);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "OpenFIle";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(45, 206);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(33, 13);
            this.Timer.TabIndex = 2;
            this.Timer.Text = "Timer";
            // 
            // Pattern
            // 
            this.Pattern.Location = new System.Drawing.Point(204, 143);
            this.Pattern.Multiline = true;
            this.Pattern.Name = "Pattern";
            this.Pattern.Size = new System.Drawing.Size(141, 27);
            this.Pattern.TabIndex = 3;
            // 
            // WordList
            // 
            this.WordList.FormattingEnabled = true;
            this.WordList.Location = new System.Drawing.Point(218, 176);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(116, 199);
            this.WordList.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Дамерау-Левенштейн";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(48, 143);
            this.max.Multiline = true;
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(149, 27);
            this.max.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите необходимую длину";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите необходимое слово";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.WordList);
            this.Controls.Add(this.Pattern);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Search);
            this.Name = "Searcher";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Searcher_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.TextBox Pattern;
        private System.Windows.Forms.ListBox WordList;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        // private System.Windows.Forms.Button Search;
    }
}