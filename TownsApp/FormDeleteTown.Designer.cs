namespace TownsApp
{
    partial class FormDeleteTown
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
            buttonCancel = new Button();
            buttonDeleteTown = new Button();
            textBoxTownName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(154, 76);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 27);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отказ";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTown
            // 
            buttonDeleteTown.DialogResult = DialogResult.OK;
            buttonDeleteTown.Location = new Point(37, 76);
            buttonDeleteTown.Name = "buttonDeleteTown";
            buttonDeleteTown.Size = new Size(109, 27);
            buttonDeleteTown.TabIndex = 10;
            buttonDeleteTown.Text = "Изтриване";
            buttonDeleteTown.UseVisualStyleBackColor = true;
            // 
            // textBoxTownName
            // 
            textBoxTownName.Enabled = false;
            textBoxTownName.Location = new Point(37, 47);
            textBoxTownName.Name = "textBoxTownName";
            textBoxTownName.Size = new Size(226, 23);
            textBoxTownName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 8;
            label1.Text = "Име на град:";
            // 
            // FormDeleteTown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 145);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDeleteTown);
            Controls.Add(textBoxTownName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDeleteTown";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Изтриване на град";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonDeleteTown;
        private TextBox textBoxTownName;
        private Label label1;
    }
}