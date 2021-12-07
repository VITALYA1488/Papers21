
namespace Газета
{
    partial class Dobavlenie
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            addressLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            addressLabel.Location = new System.Drawing.Point(223, 199);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(115, 25);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Юр. Адрес:";
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            agentTypeIDLabel.Location = new System.Drawing.Point(223, 163);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(122, 25);
            agentTypeIDLabel.TabIndex = 3;
            agentTypeIDLabel.Text = "Тип Агента:";
            agentTypeIDLabel.Click += new System.EventHandler(this.agentTypeIDLabel_Click);
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            iNNLabel.Location = new System.Drawing.Point(223, 238);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(58, 25);
            iNNLabel.TabIndex = 11;
            iNNLabel.Text = "ИНН:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            kPPLabel.Location = new System.Drawing.Point(223, 275);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(58, 25);
            kPPLabel.TabIndex = 13;
            kPPLabel.Text = "КПП:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            priorityLabel.Location = new System.Drawing.Point(223, 311);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(122, 25);
            priorityLabel.TabIndex = 19;
            priorityLabel.Text = "Приоритет:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            titleLabel.Location = new System.Drawing.Point(223, 127);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(155, 25);
            titleLabel.TabIndex = 21;
            titleLabel.Text = "Наименование:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addressTextBox.Location = new System.Drawing.Point(384, 199);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(215, 30);
            this.addressTextBox.TabIndex = 2;
            // 
            // agentTypeIDTextBox
            // 
            this.agentTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgentTypeID", true));
            this.agentTypeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.agentTypeIDTextBox.Location = new System.Drawing.Point(384, 163);
            this.agentTypeIDTextBox.Name = "agentTypeIDTextBox";
            this.agentTypeIDTextBox.Size = new System.Drawing.Size(215, 30);
            this.agentTypeIDTextBox.TabIndex = 4;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.iNNTextBox.Location = new System.Drawing.Point(384, 235);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(215, 30);
            this.iNNTextBox.TabIndex = 12;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.kPPTextBox.Location = new System.Drawing.Point(384, 272);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(215, 30);
            this.kPPTextBox.TabIndex = 14;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.priorityTextBox.Location = new System.Drawing.Point(384, 308);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(215, 30);
            this.priorityTextBox.TabIndex = 20;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.titleTextBox.Location = new System.Drawing.Point(384, 127);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(215, 30);
            this.titleTextBox.TabIndex = 22;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(685, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 74);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавление агента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Газета.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(Газета.Agent);
            // 
            // Dobavlenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(agentTypeIDLabel);
            this.Controls.Add(this.agentTypeIDTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Dobavlenie";
            this.Text = "Добавление данных";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox agentTypeIDTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}