namespace TownsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewTowns = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            townBindingSource = new BindingSource(components);
            buttonAddTown = new Button();
            buttonEditTown = new Button();
            buttonDeleteTown = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTowns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)townBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTowns
            // 
            dataGridViewTowns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewTowns.AutoGenerateColumns = false;
            dataGridViewTowns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTowns.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewTowns.DataSource = townBindingSource;
            dataGridViewTowns.Location = new Point(1, -1);
            dataGridViewTowns.Name = "dataGridViewTowns";
            dataGridViewTowns.Size = new Size(314, 450);
            dataGridViewTowns.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Име";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // townBindingSource
            // 
            townBindingSource.DataSource = typeof(Data.Models.Town);
            // 
            // buttonAddTown
            // 
            buttonAddTown.Font = new Font("Segoe UI", 9F);
            buttonAddTown.Location = new Point(321, 292);
            buttonAddTown.Name = "buttonAddTown";
            buttonAddTown.Size = new Size(217, 41);
            buttonAddTown.TabIndex = 1;
            buttonAddTown.Text = "Добавяне на град";
            buttonAddTown.UseVisualStyleBackColor = true;
            buttonAddTown.Click += buttonAddTown_Click;
            // 
            // buttonEditTown
            // 
            buttonEditTown.Font = new Font("Segoe UI", 9F);
            buttonEditTown.Location = new Point(321, 339);
            buttonEditTown.Name = "buttonEditTown";
            buttonEditTown.Size = new Size(217, 41);
            buttonEditTown.TabIndex = 2;
            buttonEditTown.Text = "Редактиране на град";
            buttonEditTown.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTown
            // 
            buttonDeleteTown.Font = new Font("Segoe UI", 9F);
            buttonDeleteTown.Location = new Point(321, 386);
            buttonDeleteTown.Name = "buttonDeleteTown";
            buttonDeleteTown.Size = new Size(217, 41);
            buttonDeleteTown.TabIndex = 3;
            buttonDeleteTown.Text = "Изтриване на град";
            buttonDeleteTown.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
            Controls.Add(buttonDeleteTown);
            Controls.Add(buttonEditTown);
            Controls.Add(buttonAddTown);
            Controls.Add(dataGridViewTowns);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTowns).EndInit();
            ((System.ComponentModel.ISupportInitialize)townBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTowns;
        private BindingSource townBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Button buttonAddTown;
        private Button buttonEditTown;
        private Button buttonDeleteTown;
    }
}
