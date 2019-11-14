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
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(180, 38);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(93, 30);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OpenFile.Location = new System.Drawing.Point(23, 89);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 27);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Открыть файл";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(40, 21);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(33, 13);
            this.Timer.TabIndex = 2;
            this.Timer.Text = "Timer";
            // 
            // Pattern
            // 
            this.Pattern.Location = new System.Drawing.Point(154, 89);
            this.Pattern.Multiline = true;
            this.Pattern.Name = "Pattern";
            this.Pattern.Size = new System.Drawing.Size(141, 27);
            this.Pattern.TabIndex = 3;
            // 
            // WordList
            // 
            this.WordList.FormattingEnabled = true;
            this.WordList.Location = new System.Drawing.Point(-4, 244);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(323, 147);
            this.WordList.TabIndex = 4;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 432);
            this.Controls.Add(this.WordList);
            this.Controls.Add(this.Pattern);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Search);
            this.Name = "Searcher";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.Searcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.TextBox Pattern;
        private System.Windows.Forms.ListBox WordList;
        // private System.Windows.Forms.Button Search;
    }
}