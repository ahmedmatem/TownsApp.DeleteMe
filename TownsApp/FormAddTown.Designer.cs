namespace TownsApp
{
    partial class FormAddTown
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
            label1 = new Label();
            textBoxTownName = new TextBox();
            buttonAddTown = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Име на град:";
            // 
            // textBoxTownName
            // 
            textBoxTownName.Location = new Point(44, 40);
            textBoxTownName.Name = "textBoxTownName";
            textBoxTownName.Size = new Size(226, 23);
            textBoxTownName.TabIndex = 1;
            // 
            // buttonAddTown
            // 
            buttonAddTown.DialogResult = DialogResult.OK;
            buttonAddTown.Location = new Point(44, 69);
            buttonAddTown.Name = "buttonAddTown";
            buttonAddTown.Size = new Size(109, 27);
            buttonAddTown.TabIndex = 2;
            buttonAddTown.Text = "Добави";
            buttonAddTown.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(161, 69);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 27);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отказ";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddTown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 130);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddTown);
            Controls.Add(textBoxTownName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddTown";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавяне на град";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTownName;
        private Button buttonAddTown;
        private Button buttonCancel;
    }
}