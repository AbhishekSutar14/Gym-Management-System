namespace Gym_management_system
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.button_save = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_viewEqupments = new System.Windows.Forms.Button();
            this.Equipname = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.labelmusclesused = new System.Windows.Forms.Label();
            this.label_delivery = new System.Windows.Forms.Label();
            this.textBoxEqupmentName = new System.Windows.Forms.TextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.textBox_muscleUsed = new System.Windows.Forms.TextBox();
            this.dateTimePicker_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label_cost = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_save.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(211, 634);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 33);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Red;
            this.button_reset.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(421, 634);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 33);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_viewEqupments
            // 
            this.button_viewEqupments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_viewEqupments.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewEqupments.Location = new System.Drawing.Point(614, 634);
            this.button_viewEqupments.Name = "button_viewEqupments";
            this.button_viewEqupments.Size = new System.Drawing.Size(205, 33);
            this.button_viewEqupments.TabIndex = 2;
            this.button_viewEqupments.Text = "View Equipments";
            this.button_viewEqupments.UseVisualStyleBackColor = false;
            this.button_viewEqupments.Click += new System.EventHandler(this.button_viewEqupments_Click);
            // 
            // Equipname
            // 
            this.Equipname.AutoSize = true;
            this.Equipname.BackColor = System.Drawing.Color.Transparent;
            this.Equipname.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipname.Location = new System.Drawing.Point(156, 99);
            this.Equipname.Name = "Equipname";
            this.Equipname.Size = new System.Drawing.Size(169, 25);
            this.Equipname.TabIndex = 3;
            this.Equipname.Text = "Equipment Name";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.BackColor = System.Drawing.Color.Transparent;
            this.label_description.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(156, 196);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(118, 25);
            this.label_description.TabIndex = 4;
            this.label_description.Text = "Description";
            // 
            // labelmusclesused
            // 
            this.labelmusclesused.AutoSize = true;
            this.labelmusclesused.BackColor = System.Drawing.Color.Transparent;
            this.labelmusclesused.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmusclesused.Location = new System.Drawing.Point(156, 403);
            this.labelmusclesused.Name = "labelmusclesused";
            this.labelmusclesused.Size = new System.Drawing.Size(133, 25);
            this.labelmusclesused.TabIndex = 5;
            this.labelmusclesused.Text = "Muscles Used";
            // 
            // label_delivery
            // 
            this.label_delivery.AutoSize = true;
            this.label_delivery.BackColor = System.Drawing.Color.Transparent;
            this.label_delivery.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delivery.Location = new System.Drawing.Point(156, 470);
            this.label_delivery.Name = "label_delivery";
            this.label_delivery.Size = new System.Drawing.Size(136, 25);
            this.label_delivery.TabIndex = 6;
            this.label_delivery.Text = "Delivery Date";
            // 
            // textBoxEqupmentName
            // 
            this.textBoxEqupmentName.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEqupmentName.Location = new System.Drawing.Point(331, 99);
            this.textBoxEqupmentName.Name = "textBoxEqupmentName";
            this.textBoxEqupmentName.Size = new System.Drawing.Size(285, 26);
            this.textBoxEqupmentName.TabIndex = 7;
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_description.Location = new System.Drawing.Point(327, 196);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(362, 146);
            this.richTextBox_description.TabIndex = 8;
            this.richTextBox_description.Text = "";
            // 
            // textBox_muscleUsed
            // 
            this.textBox_muscleUsed.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_muscleUsed.Location = new System.Drawing.Point(327, 400);
            this.textBox_muscleUsed.Name = "textBox_muscleUsed";
            this.textBox_muscleUsed.Size = new System.Drawing.Size(289, 26);
            this.textBox_muscleUsed.TabIndex = 9;
            // 
            // dateTimePicker_deliveryDate
            // 
            this.dateTimePicker_deliveryDate.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_deliveryDate.Location = new System.Drawing.Point(327, 470);
            this.dateTimePicker_deliveryDate.Name = "dateTimePicker_deliveryDate";
            this.dateTimePicker_deliveryDate.Size = new System.Drawing.Size(289, 26);
            this.dateTimePicker_deliveryDate.TabIndex = 10;
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.BackColor = System.Drawing.Color.Transparent;
            this.label_cost.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(156, 541);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(52, 25);
            this.label_cost.TabIndex = 11;
            this.label_cost.Text = "Cost";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cost.Location = new System.Drawing.Point(327, 538);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(289, 26);
            this.textBox_cost.TabIndex = 12;
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 700);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.dateTimePicker_deliveryDate);
            this.Controls.Add(this.textBox_muscleUsed);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.textBoxEqupmentName);
            this.Controls.Add(this.label_delivery);
            this.Controls.Add(this.labelmusclesused);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.Equipname);
            this.Controls.Add(this.button_viewEqupments);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_save);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_viewEqupments;
        private System.Windows.Forms.Label Equipname;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label labelmusclesused;
        private System.Windows.Forms.Label label_delivery;
        private System.Windows.Forms.TextBox textBoxEqupmentName;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.TextBox textBox_muscleUsed;
        private System.Windows.Forms.DateTimePicker dateTimePicker_deliveryDate;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.TextBox textBox_cost;
    }
}