namespace USB_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Tom = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.free = new System.Windows.Forms.Label();
            this.busy = new System.Windows.Forms.Label();
            this.DevisesList = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(282, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total memory :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(282, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Free memory :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(282, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Busy memory :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(359, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 13);
            this.name.TabIndex = 5;
            // 
            // Tom
            // 
            this.Tom.AutoSize = true;
            this.Tom.Location = new System.Drawing.Point(359, 41);
            this.Tom.Name = "Tom";
            this.Tom.Size = new System.Drawing.Size(0, 13);
            this.Tom.TabIndex = 6;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(359, 69);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 7;
            // 
            // free
            // 
            this.free.AutoSize = true;
            this.free.Location = new System.Drawing.Point(359, 97);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(0, 13);
            this.free.TabIndex = 8;
            // 
            // busy
            // 
            this.busy.AutoSize = true;
            this.busy.Location = new System.Drawing.Point(359, 125);
            this.busy.Name = "busy";
            this.busy.Size = new System.Drawing.Size(0, 13);
            this.busy.TabIndex = 9;
            // 
            // DevisesList
            // 
            this.DevisesList.ContextMenuStrip = this.contextMenuStrip1;
            this.DevisesList.Location = new System.Drawing.Point(12, 9);
            this.DevisesList.Name = "DevisesList";
            this.DevisesList.Size = new System.Drawing.Size(254, 133);
            this.DevisesList.TabIndex = 10;
            this.DevisesList.UseCompatibleStateImageBehavior = false;
            this.DevisesList.View = System.Windows.Forms.View.List;
            this.DevisesList.SelectedIndexChanged += new System.EventHandler(this.DevisesList_SelectedIndexChanged);
            this.DevisesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DevisesList_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // ejectToolStripMenuItem
            // 
            this.ejectToolStripMenuItem.Name = "ejectToolStripMenuItem";
            this.ejectToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.ejectToolStripMenuItem.Text = "Eject";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(462, 154);
            this.Controls.Add(this.DevisesList);
            this.Controls.Add(this.busy);
            this.Controls.Add(this.free);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Tom);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "USB Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Tom;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label free;
        private System.Windows.Forms.Label busy;
        private System.Windows.Forms.ListView DevisesList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejectToolStripMenuItem;
    }
}

