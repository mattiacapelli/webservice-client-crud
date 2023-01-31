namespace webservice_client_crud
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_request = new System.Windows.Forms.Button();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_completed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(151, 394);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(48, 44);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "U";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(43, 394);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(48, 44);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "C";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(97, 394);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(48, 44);
            this.btn_read.TabIndex = 4;
            this.btn_read.Text = "R";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(205, 394);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(48, 44);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "D";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleziona una modalità";
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(43, 346);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(210, 42);
            this.btn_request.TabIndex = 7;
            this.btn_request.Text = "Request";
            this.btn_request.UseVisualStyleBackColor = true;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // txt_userId
            // 
            this.txt_userId.Location = new System.Drawing.Point(43, 161);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(210, 20);
            this.txt_userId.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(43, 113);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(210, 20);
            this.txt_id.TabIndex = 9;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(43, 208);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(210, 20);
            this.txt_title.TabIndex = 10;
            // 
            // txt_completed
            // 
            this.txt_completed.Location = new System.Drawing.Point(43, 255);
            this.txt_completed.Name = "txt_completed";
            this.txt_completed.Size = new System.Drawing.Size(210, 20);
            this.txt_completed.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "userId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "completed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_completed);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_update);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_completed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

