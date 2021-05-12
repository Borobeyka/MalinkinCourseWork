namespace MalinkinCourseWork
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
      this.AddDeveloper = new System.Windows.Forms.GroupBox();
      this.AD_Submit = new System.Windows.Forms.Button();
      this.AD_LangCheckBox = new System.Windows.Forms.CheckedListBox();
      this.AD_LangLabel = new System.Windows.Forms.Label();
      this.AD_Nickname = new System.Windows.Forms.TextBox();
      this.AD_NicknameLabel = new System.Windows.Forms.Label();
      this.AddProject = new System.Windows.Forms.GroupBox();
      this.AP_Finish = new System.Windows.Forms.DateTimePicker();
      this.AP_FinishLabel = new System.Windows.Forms.Label();
      this.AP_Start = new System.Windows.Forms.DateTimePicker();
      this.AP_StartLabel = new System.Windows.Forms.Label();
      this.AP_LangCheckBox = new System.Windows.Forms.CheckedListBox();
      this.AP_LangLabel = new System.Windows.Forms.Label();
      this.AP_Description = new System.Windows.Forms.TextBox();
      this.AP_Submit = new System.Windows.Forms.Button();
      this.AP_DescriptionLabel = new System.Windows.Forms.Label();
      this.AP_Title = new System.Windows.Forms.TextBox();
      this.AP_TitleLabel = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.AllD = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label2 = new System.Windows.Forms.Label();
      this.ADtP = new System.Windows.Forms.GroupBox();
      this.ADtP_Submit = new System.Windows.Forms.Button();
      this.ADtP_pID = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.ADtP_dID = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.AllP = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.gPI_Field = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.gPI_Submit = new System.Windows.Forms.Button();
      this.AddDeveloper.SuspendLayout();
      this.AddProject.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AllD)).BeginInit();
      this.ADtP.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AllP)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // AddDeveloper
      // 
      this.AddDeveloper.BackColor = System.Drawing.SystemColors.ControlLight;
      this.AddDeveloper.Controls.Add(this.AD_Submit);
      this.AddDeveloper.Controls.Add(this.AD_LangCheckBox);
      this.AddDeveloper.Controls.Add(this.AD_LangLabel);
      this.AddDeveloper.Controls.Add(this.AD_Nickname);
      this.AddDeveloper.Controls.Add(this.AD_NicknameLabel);
      this.AddDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddDeveloper.Location = new System.Drawing.Point(12, 12);
      this.AddDeveloper.Name = "AddDeveloper";
      this.AddDeveloper.Size = new System.Drawing.Size(240, 230);
      this.AddDeveloper.TabIndex = 0;
      this.AddDeveloper.TabStop = false;
      this.AddDeveloper.Text = "Добавление разработчика";
      // 
      // AD_Submit
      // 
      this.AD_Submit.BackColor = System.Drawing.SystemColors.Control;
      this.AD_Submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AD_Submit.Location = new System.Drawing.Point(6, 190);
      this.AD_Submit.Name = "AD_Submit";
      this.AD_Submit.Size = new System.Drawing.Size(228, 33);
      this.AD_Submit.TabIndex = 3;
      this.AD_Submit.Text = "Добавить";
      this.AD_Submit.UseVisualStyleBackColor = false;
      this.AD_Submit.Click += new System.EventHandler(this.AD_Submit_Click);
      // 
      // AD_LangCheckBox
      // 
      this.AD_LangCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AD_LangCheckBox.FormattingEnabled = true;
      this.AD_LangCheckBox.Location = new System.Drawing.Point(6, 96);
      this.AD_LangCheckBox.Name = "AD_LangCheckBox";
      this.AD_LangCheckBox.Size = new System.Drawing.Size(228, 88);
      this.AD_LangCheckBox.TabIndex = 2;
      // 
      // AD_LangLabel
      // 
      this.AD_LangLabel.AutoSize = true;
      this.AD_LangLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AD_LangLabel.Location = new System.Drawing.Point(6, 74);
      this.AD_LangLabel.Name = "AD_LangLabel";
      this.AD_LangLabel.Size = new System.Drawing.Size(99, 19);
      this.AD_LangLabel.TabIndex = 2;
      this.AD_LangLabel.Text = "Знание ЯП:";
      // 
      // AD_Nickname
      // 
      this.AD_Nickname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AD_Nickname.Location = new System.Drawing.Point(6, 45);
      this.AD_Nickname.Name = "AD_Nickname";
      this.AD_Nickname.Size = new System.Drawing.Size(228, 26);
      this.AD_Nickname.TabIndex = 1;
      // 
      // AD_NicknameLabel
      // 
      this.AD_NicknameLabel.AutoSize = true;
      this.AD_NicknameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AD_NicknameLabel.Location = new System.Drawing.Point(6, 23);
      this.AD_NicknameLabel.Name = "AD_NicknameLabel";
      this.AD_NicknameLabel.Size = new System.Drawing.Size(81, 19);
      this.AD_NicknameLabel.TabIndex = 1;
      this.AD_NicknameLabel.Text = "Никнейм:";
      // 
      // AddProject
      // 
      this.AddProject.BackColor = System.Drawing.SystemColors.ControlLight;
      this.AddProject.Controls.Add(this.AP_Finish);
      this.AddProject.Controls.Add(this.AP_FinishLabel);
      this.AddProject.Controls.Add(this.AP_Start);
      this.AddProject.Controls.Add(this.AP_StartLabel);
      this.AddProject.Controls.Add(this.AP_LangCheckBox);
      this.AddProject.Controls.Add(this.AP_LangLabel);
      this.AddProject.Controls.Add(this.AP_Description);
      this.AddProject.Controls.Add(this.AP_Submit);
      this.AddProject.Controls.Add(this.AP_DescriptionLabel);
      this.AddProject.Controls.Add(this.AP_Title);
      this.AddProject.Controls.Add(this.AP_TitleLabel);
      this.AddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddProject.Location = new System.Drawing.Point(12, 248);
      this.AddProject.Name = "AddProject";
      this.AddProject.Size = new System.Drawing.Size(240, 442);
      this.AddProject.TabIndex = 3;
      this.AddProject.TabStop = false;
      this.AddProject.Text = "Создание проекта";
      // 
      // AP_Finish
      // 
      this.AP_Finish.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_Finish.Location = new System.Drawing.Point(6, 372);
      this.AP_Finish.Name = "AP_Finish";
      this.AP_Finish.Size = new System.Drawing.Size(228, 25);
      this.AP_Finish.TabIndex = 8;
      // 
      // AP_FinishLabel
      // 
      this.AP_FinishLabel.AutoSize = true;
      this.AP_FinishLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_FinishLabel.Location = new System.Drawing.Point(6, 350);
      this.AP_FinishLabel.Name = "AP_FinishLabel";
      this.AP_FinishLabel.Size = new System.Drawing.Size(108, 19);
      this.AP_FinishLabel.TabIndex = 9;
      this.AP_FinishLabel.Text = "Завершение:";
      // 
      // AP_Start
      // 
      this.AP_Start.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_Start.Location = new System.Drawing.Point(6, 322);
      this.AP_Start.Name = "AP_Start";
      this.AP_Start.Size = new System.Drawing.Size(228, 25);
      this.AP_Start.TabIndex = 7;
      // 
      // AP_StartLabel
      // 
      this.AP_StartLabel.AutoSize = true;
      this.AP_StartLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_StartLabel.Location = new System.Drawing.Point(6, 300);
      this.AP_StartLabel.Name = "AP_StartLabel";
      this.AP_StartLabel.Size = new System.Drawing.Size(72, 19);
      this.AP_StartLabel.TabIndex = 8;
      this.AP_StartLabel.Text = "Начало:";
      // 
      // AP_LangCheckBox
      // 
      this.AP_LangCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_LangCheckBox.FormattingEnabled = true;
      this.AP_LangCheckBox.Location = new System.Drawing.Point(6, 209);
      this.AP_LangCheckBox.Name = "AP_LangCheckBox";
      this.AP_LangCheckBox.Size = new System.Drawing.Size(228, 88);
      this.AP_LangCheckBox.TabIndex = 6;
      // 
      // AP_LangLabel
      // 
      this.AP_LangLabel.AutoSize = true;
      this.AP_LangLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_LangLabel.Location = new System.Drawing.Point(6, 187);
      this.AP_LangLabel.Name = "AP_LangLabel";
      this.AP_LangLabel.Size = new System.Drawing.Size(153, 19);
      this.AP_LangLabel.TabIndex = 4;
      this.AP_LangLabel.Text = "Используемые ЯП:";
      // 
      // AP_Description
      // 
      this.AP_Description.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_Description.Location = new System.Drawing.Point(6, 96);
      this.AP_Description.Multiline = true;
      this.AP_Description.Name = "AP_Description";
      this.AP_Description.Size = new System.Drawing.Size(228, 88);
      this.AP_Description.TabIndex = 5;
      // 
      // AP_Submit
      // 
      this.AP_Submit.BackColor = System.Drawing.SystemColors.Control;
      this.AP_Submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_Submit.Location = new System.Drawing.Point(6, 403);
      this.AP_Submit.Name = "AP_Submit";
      this.AP_Submit.Size = new System.Drawing.Size(228, 33);
      this.AP_Submit.TabIndex = 9;
      this.AP_Submit.Text = "Создать";
      this.AP_Submit.UseVisualStyleBackColor = false;
      this.AP_Submit.Click += new System.EventHandler(this.AP_Submit_Click);
      // 
      // AP_DescriptionLabel
      // 
      this.AP_DescriptionLabel.AutoSize = true;
      this.AP_DescriptionLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_DescriptionLabel.Location = new System.Drawing.Point(6, 74);
      this.AP_DescriptionLabel.Name = "AP_DescriptionLabel";
      this.AP_DescriptionLabel.Size = new System.Drawing.Size(90, 19);
      this.AP_DescriptionLabel.TabIndex = 2;
      this.AP_DescriptionLabel.Text = "Описание:";
      // 
      // AP_Title
      // 
      this.AP_Title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_Title.Location = new System.Drawing.Point(6, 45);
      this.AP_Title.Name = "AP_Title";
      this.AP_Title.Size = new System.Drawing.Size(228, 26);
      this.AP_Title.TabIndex = 4;
      // 
      // AP_TitleLabel
      // 
      this.AP_TitleLabel.AutoSize = true;
      this.AP_TitleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AP_TitleLabel.Location = new System.Drawing.Point(6, 23);
      this.AP_TitleLabel.Name = "AP_TitleLabel";
      this.AP_TitleLabel.Size = new System.Drawing.Size(90, 19);
      this.AP_TitleLabel.TabIndex = 1;
      this.AP_TitleLabel.Text = "Название:";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.groupBox1.Controls.Add(this.AllD);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox1.Location = new System.Drawing.Point(258, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(562, 206);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Разработчики";
      // 
      // AllD
      // 
      this.AllD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.AllD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nickname,
            this.languages});
      this.AllD.Location = new System.Drawing.Point(6, 45);
      this.AllD.Name = "AllD";
      this.AllD.ReadOnly = true;
      this.AllD.Size = new System.Drawing.Size(550, 150);
      this.AllD.TabIndex = 10;
      // 
      // id
      // 
      this.id.HeaderText = "ID";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 35;
      // 
      // nickname
      // 
      this.nickname.HeaderText = "Никнейм";
      this.nickname.Name = "nickname";
      this.nickname.ReadOnly = true;
      // 
      // languages
      // 
      this.languages.HeaderText = "Знание ЯП";
      this.languages.Name = "languages";
      this.languages.ReadOnly = true;
      this.languages.Width = 255;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(162, 19);
      this.label2.TabIndex = 1;
      this.label2.Text = "Все разработчики:";
      // 
      // ADtP
      // 
      this.ADtP.BackColor = System.Drawing.SystemColors.ControlLight;
      this.ADtP.Controls.Add(this.ADtP_Submit);
      this.ADtP.Controls.Add(this.ADtP_pID);
      this.ADtP.Controls.Add(this.label3);
      this.ADtP.Controls.Add(this.ADtP_dID);
      this.ADtP.Controls.Add(this.label1);
      this.ADtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ADtP.Location = new System.Drawing.Point(258, 438);
      this.ADtP.Name = "ADtP";
      this.ADtP.Size = new System.Drawing.Size(323, 168);
      this.ADtP.TabIndex = 11;
      this.ADtP.TabStop = false;
      this.ADtP.Text = "Добавление разработчика в проект";
      // 
      // ADtP_Submit
      // 
      this.ADtP_Submit.BackColor = System.Drawing.SystemColors.Control;
      this.ADtP_Submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ADtP_Submit.Location = new System.Drawing.Point(6, 128);
      this.ADtP_Submit.Name = "ADtP_Submit";
      this.ADtP_Submit.Size = new System.Drawing.Size(310, 33);
      this.ADtP_Submit.TabIndex = 10;
      this.ADtP_Submit.Text = "Добавить";
      this.ADtP_Submit.UseVisualStyleBackColor = false;
      this.ADtP_Submit.Click += new System.EventHandler(this.ADtP_Submit_Click);
      // 
      // ADtP_pID
      // 
      this.ADtP_pID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ADtP_pID.Location = new System.Drawing.Point(6, 96);
      this.ADtP_pID.Name = "ADtP_pID";
      this.ADtP_pID.Size = new System.Drawing.Size(310, 26);
      this.ADtP_pID.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(6, 74);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(180, 19);
      this.label3.TabIndex = 5;
      this.label3.Text = "Введите ID проекта:";
      // 
      // ADtP_dID
      // 
      this.ADtP_dID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ADtP_dID.Location = new System.Drawing.Point(6, 45);
      this.ADtP_dID.Name = "ADtP_dID";
      this.ADtP_dID.Size = new System.Drawing.Size(310, 26);
      this.ADtP_dID.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(225, 19);
      this.label1.TabIndex = 1;
      this.label1.Text = "Введите ID разработчика:";
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
      this.groupBox2.Controls.Add(this.AllP);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox2.Location = new System.Drawing.Point(258, 226);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(562, 206);
      this.groupBox2.TabIndex = 11;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Проекты";
      // 
      // AllP
      // 
      this.AllP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.AllP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column3,
            this.Column1,
            this.Column2});
      this.AllP.Location = new System.Drawing.Point(6, 45);
      this.AllP.Name = "AllP";
      this.AllP.ReadOnly = true;
      this.AllP.Size = new System.Drawing.Size(550, 150);
      this.AllP.TabIndex = 10;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "ID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 35;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Название";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "Используемые ЯП";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 255;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Разработчики";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Начало";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 110;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Завершение";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 110;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(6, 23);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 19);
      this.label4.TabIndex = 1;
      this.label4.Text = "Все проекты:";
      // 
      // groupBox3
      // 
      this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
      this.groupBox3.Controls.Add(this.gPI_Submit);
      this.groupBox3.Controls.Add(this.gPI_Field);
      this.groupBox3.Controls.Add(this.label6);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox3.Location = new System.Drawing.Point(587, 438);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(233, 115);
      this.groupBox3.TabIndex = 12;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Информация по проекту";
      // 
      // gPI_Field
      // 
      this.gPI_Field.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.gPI_Field.Location = new System.Drawing.Point(6, 45);
      this.gPI_Field.Name = "gPI_Field";
      this.gPI_Field.Size = new System.Drawing.Size(221, 26);
      this.gPI_Field.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(6, 23);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(180, 19);
      this.label6.TabIndex = 1;
      this.label6.Text = "Введите ID проекта:";
      // 
      // gPI_Submit
      // 
      this.gPI_Submit.BackColor = System.Drawing.SystemColors.Control;
      this.gPI_Submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.gPI_Submit.Location = new System.Drawing.Point(6, 77);
      this.gPI_Submit.Name = "gPI_Submit";
      this.gPI_Submit.Size = new System.Drawing.Size(221, 33);
      this.gPI_Submit.TabIndex = 10;
      this.gPI_Submit.Text = "Открыть";
      this.gPI_Submit.UseVisualStyleBackColor = false;
      this.gPI_Submit.Click += new System.EventHandler(this.gPI_Submit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(832, 720);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.ADtP);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.AddProject);
      this.Controls.Add(this.AddDeveloper);
      this.Name = "Form1";
      this.Text = "Повышение качества ПО | Малинкин ДР";
      this.AddDeveloper.ResumeLayout(false);
      this.AddDeveloper.PerformLayout();
      this.AddProject.ResumeLayout(false);
      this.AddProject.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AllD)).EndInit();
      this.ADtP.ResumeLayout(false);
      this.ADtP.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AllP)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox AddDeveloper;
    private System.Windows.Forms.Label AD_NicknameLabel;
    private System.Windows.Forms.TextBox AD_Nickname;
    private System.Windows.Forms.Label AD_LangLabel;
    private System.Windows.Forms.CheckedListBox AD_LangCheckBox;
    private System.Windows.Forms.Button AD_Submit;
    private System.Windows.Forms.GroupBox AddProject;
    private System.Windows.Forms.Button AP_Submit;
    private System.Windows.Forms.Label AP_DescriptionLabel;
    private System.Windows.Forms.TextBox AP_Title;
    private System.Windows.Forms.Label AP_TitleLabel;
    private System.Windows.Forms.TextBox AP_Description;
    private System.Windows.Forms.CheckedListBox AP_LangCheckBox;
    private System.Windows.Forms.Label AP_LangLabel;
    private System.Windows.Forms.DateTimePicker AP_Finish;
    private System.Windows.Forms.Label AP_FinishLabel;
    private System.Windows.Forms.DateTimePicker AP_Start;
    private System.Windows.Forms.Label AP_StartLabel;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView AllD;
    private System.Windows.Forms.GroupBox ADtP;
    private System.Windows.Forms.Button ADtP_Submit;
    private System.Windows.Forms.TextBox ADtP_pID;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox ADtP_dID;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
    private System.Windows.Forms.DataGridViewTextBoxColumn languages;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView AllP;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button gPI_Submit;
    private System.Windows.Forms.TextBox gPI_Field;
    private System.Windows.Forms.Label label6;
  }
}

