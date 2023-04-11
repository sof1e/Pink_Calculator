namespace Pink_Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button_division = new System.Windows.Forms.Button();
            this.button_multi = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.button_sinus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_degree = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.CurrentOperation = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_division
            // 
            this.button_division.BackColor = System.Drawing.Color.SeaShell;
            this.button_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_division.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_division.ForeColor = System.Drawing.Color.IndianRed;
            this.button_division.Location = new System.Drawing.Point(161, 118);
            this.button_division.Margin = new System.Windows.Forms.Padding(4);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(45, 45);
            this.button_division.TabIndex = 0;
            this.button_division.Text = "/";
            this.button_division.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_division.UseVisualStyleBackColor = false;
            this.button_division.Click += new System.EventHandler(this.operator_click);
            this.button_division.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_multi
            // 
            this.button_multi.BackColor = System.Drawing.Color.SeaShell;
            this.button_multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multi.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multi.ForeColor = System.Drawing.Color.IndianRed;
            this.button_multi.Location = new System.Drawing.Point(161, 167);
            this.button_multi.Margin = new System.Windows.Forms.Padding(4);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(45, 45);
            this.button_multi.TabIndex = 1;
            this.button_multi.Text = "×";
            this.button_multi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_multi.UseVisualStyleBackColor = false;
            this.button_multi.Click += new System.EventHandler(this.operator_click);
            this.button_multi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_subtract
            // 
            this.button_subtract.BackColor = System.Drawing.Color.SeaShell;
            this.button_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subtract.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtract.ForeColor = System.Drawing.Color.IndianRed;
            this.button_subtract.Location = new System.Drawing.Point(161, 269);
            this.button_subtract.Margin = new System.Windows.Forms.Padding(4);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(45, 45);
            this.button_subtract.TabIndex = 2;
            this.button_subtract.Text = "-";
            this.button_subtract.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_subtract.UseVisualStyleBackColor = false;
            this.button_subtract.Click += new System.EventHandler(this.operator_click);
            this.button_subtract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.SeaShell;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.IndianRed;
            this.button_add.Location = new System.Drawing.Point(161, 218);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(45, 45);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "+";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.operator_click);
            this.button_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.Snow;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.ForeColor = System.Drawing.Color.IndianRed;
            this.button_7.Location = new System.Drawing.Point(2, 167);
            this.button_7.Margin = new System.Windows.Forms.Padding(4);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(45, 45);
            this.button_7.TabIndex = 5;
            this.button_7.Text = "7";
            this.button_7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_Click);
            this.button_7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.Snow;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.ForeColor = System.Drawing.Color.IndianRed;
            this.button_8.Location = new System.Drawing.Point(55, 167);
            this.button_8.Margin = new System.Windows.Forms.Padding(4);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(45, 45);
            this.button_8.TabIndex = 6;
            this.button_8.Text = "8";
            this.button_8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_Click);
            this.button_8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.Snow;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.ForeColor = System.Drawing.Color.IndianRed;
            this.button_9.Location = new System.Drawing.Point(108, 167);
            this.button_9.Margin = new System.Windows.Forms.Padding(4);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(45, 45);
            this.button_9.TabIndex = 7;
            this.button_9.Text = "9";
            this.button_9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_Click);
            this.button_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_root
            // 
            this.button_root.BackColor = System.Drawing.Color.SeaShell;
            this.button_root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_root.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_root.ForeColor = System.Drawing.Color.IndianRed;
            this.button_root.Location = new System.Drawing.Point(108, 118);
            this.button_root.Margin = new System.Windows.Forms.Padding(4);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(45, 45);
            this.button_root.TabIndex = 8;
            this.button_root.Text = "√";
            this.button_root.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_root.UseVisualStyleBackColor = false;
            this.button_root.Click += new System.EventHandler(this.operator_click);
            this.button_root.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_sinus
            // 
            this.button_sinus.BackColor = System.Drawing.Color.SeaShell;
            this.button_sinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sinus.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sinus.ForeColor = System.Drawing.Color.IndianRed;
            this.button_sinus.Location = new System.Drawing.Point(2, 118);
            this.button_sinus.Margin = new System.Windows.Forms.Padding(4);
            this.button_sinus.Name = "button_sinus";
            this.button_sinus.Size = new System.Drawing.Size(45, 45);
            this.button_sinus.TabIndex = 18;
            this.button_sinus.Text = "sin";
            this.button_sinus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_sinus.UseVisualStyleBackColor = false;
            this.button_sinus.Click += new System.EventHandler(this.operator_click);
            this.button_sinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.Snow;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.ForeColor = System.Drawing.Color.IndianRed;
            this.button_3.Location = new System.Drawing.Point(108, 269);
            this.button_3.Margin = new System.Windows.Forms.Padding(4);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(45, 45);
            this.button_3.TabIndex = 17;
            this.button_3.Text = "3";
            this.button_3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_Click);
            this.button_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.Snow;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.ForeColor = System.Drawing.Color.IndianRed;
            this.button_2.Location = new System.Drawing.Point(55, 269);
            this.button_2.Margin = new System.Windows.Forms.Padding(4);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(45, 45);
            this.button_2.TabIndex = 16;
            this.button_2.Text = "2";
            this.button_2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_Click);
            this.button_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.Snow;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.ForeColor = System.Drawing.Color.IndianRed;
            this.button_1.Location = new System.Drawing.Point(2, 269);
            this.button_1.Margin = new System.Windows.Forms.Padding(4);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(45, 45);
            this.button_1.TabIndex = 15;
            this.button_1.Text = "1";
            this.button_1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_Click);
            this.button_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_degree
            // 
            this.button_degree.BackColor = System.Drawing.Color.SeaShell;
            this.button_degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_degree.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_degree.ForeColor = System.Drawing.Color.IndianRed;
            this.button_degree.Location = new System.Drawing.Point(55, 118);
            this.button_degree.Margin = new System.Windows.Forms.Padding(4);
            this.button_degree.Name = "button_degree";
            this.button_degree.Size = new System.Drawing.Size(45, 45);
            this.button_degree.TabIndex = 13;
            this.button_degree.Text = "x²";
            this.button_degree.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_degree.UseVisualStyleBackColor = false;
            this.button_degree.Click += new System.EventHandler(this.operator_click);
            this.button_degree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.Snow;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.ForeColor = System.Drawing.Color.IndianRed;
            this.button_6.Location = new System.Drawing.Point(108, 218);
            this.button_6.Margin = new System.Windows.Forms.Padding(4);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(45, 45);
            this.button_6.TabIndex = 12;
            this.button_6.Text = "6";
            this.button_6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_Click);
            this.button_6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.Snow;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.ForeColor = System.Drawing.Color.IndianRed;
            this.button_5.Location = new System.Drawing.Point(55, 218);
            this.button_5.Margin = new System.Windows.Forms.Padding(4);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(45, 45);
            this.button_5.TabIndex = 11;
            this.button_5.Text = "5";
            this.button_5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_Click);
            this.button_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.Snow;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.ForeColor = System.Drawing.Color.IndianRed;
            this.button_4.Location = new System.Drawing.Point(2, 218);
            this.button_4.Margin = new System.Windows.Forms.Padding(4);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(45, 45);
            this.button_4.TabIndex = 10;
            this.button_4.Text = "4";
            this.button_4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_Click);
            this.button_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.Color.SeaShell;
            this.button_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equal.Font = new System.Drawing.Font("Courgette", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.ForeColor = System.Drawing.Color.IndianRed;
            this.button_equal.Location = new System.Drawing.Point(211, 218);
            this.button_equal.Margin = new System.Windows.Forms.Padding(4);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(45, 147);
            this.button_equal.TabIndex = 22;
            this.button_equal.Text = "=";
            this.button_equal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            this.button_equal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.IndianRed;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.Snow;
            this.button_reset.Location = new System.Drawing.Point(211, 167);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(45, 45);
            this.button_reset.TabIndex = 21;
            this.button_reset.Text = "C";
            this.button_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            this.button_reset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.Snow;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.ForeColor = System.Drawing.Color.IndianRed;
            this.button_0.Location = new System.Drawing.Point(2, 320);
            this.button_0.Margin = new System.Windows.Forms.Padding(4);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(151, 45);
            this.button_0.TabIndex = 20;
            this.button_0.Text = "0";
            this.button_0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_Click);
            this.button_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.SeaShell;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.ForeColor = System.Drawing.Color.IndianRed;
            this.button_minus.Location = new System.Drawing.Point(161, 320);
            this.button_minus.Margin = new System.Windows.Forms.Padding(4);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(45, 45);
            this.button_minus.TabIndex = 19;
            this.button_minus.Text = "+/-";
            this.button_minus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.minus_Click);
            this.button_minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.Color.Snow;
            this.textBox_result.Font = new System.Drawing.Font("Courgette", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.ForeColor = System.Drawing.Color.LightCoral;
            this.textBox_result.Location = new System.Drawing.Point(2, 60);
            this.textBox_result.MaxLength = 7;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(254, 51);
            this.textBox_result.TabIndex = 23;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_range);
            this.textBox_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // CurrentOperation
            // 
            this.CurrentOperation.AutoSize = true;
            this.CurrentOperation.BackColor = System.Drawing.Color.Snow;
            this.CurrentOperation.Font = new System.Drawing.Font("Courgette", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentOperation.ForeColor = System.Drawing.Color.LightCoral;
            this.CurrentOperation.Location = new System.Drawing.Point(4, 9);
            this.CurrentOperation.Name = "CurrentOperation";
            this.CurrentOperation.Size = new System.Drawing.Size(0, 27);
            this.CurrentOperation.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(211, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 26;
            this.button2.Text = "<--";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_result_KeyPress);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::Pink_Calculator.Properties.Resources._123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(259, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CurrentOperation);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_sinus);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_degree);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_root);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_multi);
            this.Controls.Add(this.button_division);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MistyRose;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pink Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_multi;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_sinus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_degree;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label CurrentOperation;
        private System.Windows.Forms.Button button2;
    }
}

