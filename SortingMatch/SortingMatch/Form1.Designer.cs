namespace SortingMatch
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Сортировка пузырьком");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Шейкерная сортировка");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Сортировка расческой");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("100");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("1000");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("10000");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("100000");
            this.NumOfCellsCHoosingLabel = new System.Windows.Forms.Label();
            this.ChoosingOfSortsLabel = new System.Windows.Forms.Label();
            this.SortingMatchGraphicsPB = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ListOfSorts = new System.Windows.Forms.ListView();
            this.ListNumOfCells = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.SortingMatchGraphicsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // NumOfCellsCHoosingLabel
            // 
            this.NumOfCellsCHoosingLabel.AutoSize = true;
            this.NumOfCellsCHoosingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfCellsCHoosingLabel.Location = new System.Drawing.Point(12, 454);
            this.NumOfCellsCHoosingLabel.Name = "NumOfCellsCHoosingLabel";
            this.NumOfCellsCHoosingLabel.Size = new System.Drawing.Size(420, 40);
            this.NumOfCellsCHoosingLabel.TabIndex = 4;
            this.NumOfCellsCHoosingLabel.Text = "Выберите кол-во элемнтов в массиве(массивах)\r\n для сравнения:";
            // 
            // ChoosingOfSortsLabel
            // 
            this.ChoosingOfSortsLabel.AutoSize = true;
            this.ChoosingOfSortsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosingOfSortsLabel.Location = new System.Drawing.Point(641, 9);
            this.ChoosingOfSortsLabel.Name = "ChoosingOfSortsLabel";
            this.ChoosingOfSortsLabel.Size = new System.Drawing.Size(250, 20);
            this.ChoosingOfSortsLabel.TabIndex = 5;
            this.ChoosingOfSortsLabel.Text = "Выберите виды сортировок:";
            // 
            // SortingMatchGraphicsPB
            // 
            this.SortingMatchGraphicsPB.BackColor = System.Drawing.SystemColors.Window;
            this.SortingMatchGraphicsPB.Location = new System.Drawing.Point(12, 12);
            this.SortingMatchGraphicsPB.Name = "SortingMatchGraphicsPB";
            this.SortingMatchGraphicsPB.Size = new System.Drawing.Size(623, 439);
            this.SortingMatchGraphicsPB.TabIndex = 6;
            this.SortingMatchGraphicsPB.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(724, 476);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(135, 38);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ListOfSorts
            // 
            this.ListOfSorts.BackColor = System.Drawing.SystemColors.Control;
            this.ListOfSorts.CheckBoxes = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.ListOfSorts.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.ListOfSorts.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.ListOfSorts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.ListOfSorts.Location = new System.Drawing.Point(641, 32);
            this.ListOfSorts.Name = "ListOfSorts";
            this.ListOfSorts.Size = new System.Drawing.Size(264, 419);
            this.ListOfSorts.TabIndex = 13;
            this.ListOfSorts.UseCompatibleStateImageBehavior = false;
            this.ListOfSorts.View = System.Windows.Forms.View.List;
            // 
            // ListNumOfCells
            // 
            this.ListNumOfCells.BackColor = System.Drawing.SystemColors.Control;
            this.ListNumOfCells.CheckBoxes = true;
            this.ListNumOfCells.HideSelection = false;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            this.ListNumOfCells.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.ListNumOfCells.Location = new System.Drawing.Point(16, 497);
            this.ListNumOfCells.Name = "ListNumOfCells";
            this.ListNumOfCells.Size = new System.Drawing.Size(619, 25);
            this.ListNumOfCells.TabIndex = 14;
            this.ListNumOfCells.UseCompatibleStateImageBehavior = false;
            this.ListNumOfCells.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 528);
            this.Controls.Add(this.ListNumOfCells);
            this.Controls.Add(this.ListOfSorts);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SortingMatchGraphicsPB);
            this.Controls.Add(this.ChoosingOfSortsLabel);
            this.Controls.Add(this.NumOfCellsCHoosingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SortingMatchGraphicsPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NumOfCellsCHoosingLabel;
        private System.Windows.Forms.Label ChoosingOfSortsLabel;
        private System.Windows.Forms.PictureBox SortingMatchGraphicsPB;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListView ListOfSorts;
        private System.Windows.Forms.ListView ListNumOfCells;
    }
}

