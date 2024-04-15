namespace lab_prog_1
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
      this.InputBox = new System.Windows.Forms.TextBox();
      this.ConsoleBox = new System.Windows.Forms.TextBox();
      this.InputButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // InputBox
      // 
      this.InputBox.Location = new System.Drawing.Point(12, 31);
      this.InputBox.Name = "InputBox";
      this.InputBox.Size = new System.Drawing.Size(179, 20);
      this.InputBox.TabIndex = 0;
      // 
      // ConsoleBox
      // 
      this.ConsoleBox.Location = new System.Drawing.Point(12, 88);
      this.ConsoleBox.Name = "ConsoleBox";
      this.ConsoleBox.ReadOnly = true;
      this.ConsoleBox.Size = new System.Drawing.Size(260, 20);
      this.ConsoleBox.TabIndex = 1;
      // 
      // InputButton
      // 
      this.InputButton.Location = new System.Drawing.Point(197, 31);
      this.InputButton.Name = "InputButton";
      this.InputButton.Size = new System.Drawing.Size(75, 20);
      this.InputButton.TabIndex = 2;
      this.InputButton.Text = "Ввод";
      this.InputButton.UseVisualStyleBackColor = true;
      this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Команда";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Консоль";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 120);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.InputButton);
      this.Controls.Add(this.ConsoleBox);
      this.Controls.Add(this.InputBox);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox InputBox;
    private System.Windows.Forms.TextBox ConsoleBox;
    private System.Windows.Forms.Button InputButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

