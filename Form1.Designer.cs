namespace RenamerPro_S
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BTND = new Button();
            TBO = new TextBox();
            TBN = new TextBox();
            BTNR = new Button();
            LB1 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BTND
            // 
            BTND.BackColor = SystemColors.GradientActiveCaption;
            BTND.Font = new Font("Segoe UI", 11.25F);
            BTND.Location = new Point(47, 21);
            BTND.Name = "BTND";
            BTND.Size = new Size(100, 49);
            BTND.TabIndex = 0;
            BTND.Text = "Выбор директории";
            BTND.UseVisualStyleBackColor = false;
            BTND.Click += BTND_Click;
            // 
            // TBO
            // 
            TBO.BackColor = SystemColors.GradientActiveCaption;
            TBO.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            TBO.Location = new Point(26, 109);
            TBO.Name = "TBO";
            TBO.Size = new Size(141, 27);
            TBO.TabIndex = 1;
            // 
            // TBN
            // 
            TBN.BackColor = SystemColors.GradientActiveCaption;
            TBN.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            TBN.Location = new Point(26, 162);
            TBN.Name = "TBN";
            TBN.Size = new Size(141, 27);
            TBN.TabIndex = 2;
            // 
            // BTNR
            // 
            BTNR.BackColor = SystemColors.GradientActiveCaption;
            BTNR.Font = new Font("Segoe UI", 11.25F);
            BTNR.Location = new Point(26, 204);
            BTNR.Name = "BTNR";
            BTNR.Size = new Size(141, 53);
            BTNR.TabIndex = 3;
            BTNR.Text = "Произвести переименование";
            BTNR.UseVisualStyleBackColor = false;
            BTNR.Click += BTNR_Click;
            // 
            // LB1
            // 
            LB1.AutoSize = true;
            LB1.BackColor = SystemColors.Info;
            LB1.Font = new Font("Segoe UI", 11.25F);
            LB1.Location = new Point(26, 86);
            LB1.Name = "LB1";
            LB1.Size = new Size(141, 20);
            LB1.TabIndex = 4;
            LB1.Text = "Заменить эту часть";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(33, 139);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 5;
            label1.Text = "Заменить на это ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(185, 281);
            Controls.Add(label1);
            Controls.Add(LB1);
            Controls.Add(BTNR);
            Controls.Add(TBN);
            Controls.Add(TBO);
            Controls.Add(BTND);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Имынёр";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTND;
        private TextBox TBO;
        private TextBox TBN;
        private Button BTNR;
        private Label LB1;
        private Label label1;
    }
}
