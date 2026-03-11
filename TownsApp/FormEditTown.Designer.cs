namespace TownsApp
{
    partial class FormEditTown
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
            buttonEditTown = new Button();
            textBoxTownName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(154, 73);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 27);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отказ";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEditTown
            // 
            buttonEditTown.DialogResult = DialogResult.OK;
            buttonEditTown.Location = new Point(37, 73);
            buttonEditTown.Name = "buttonEditTown";
            buttonEditTown.Size = new Size(109, 27);
            buttonEditTown.TabIndex = 6;
            buttonEditTown.Text = "Редактиране";
            buttonEditTown.UseVisualStyleBackColor = true;
            // 
            // textBoxTownName
            // 
            textBoxTownName.Location = new Point(37, 44);
            textBoxTownName.Name = "textBoxTownName";
            textBoxTownName.Size = new Size(226, 23);
            textBoxTownName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 4;
            label1.Text = "Име на град:";
            // 
            // FormEditTown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 134);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEditTown);
            Controls.Add(textBoxTownName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditTown";
            Text = "Редактиране на град";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonEditTown;
        private TextBox textBoxTownName;
        private Label label1;
    }
}