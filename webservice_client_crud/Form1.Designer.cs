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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_completed = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
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
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(137, 97);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "id";
            // 
            // lbl_userId
            // 
            this.lbl_userId.AutoSize = true;
            this.lbl_userId.Location = new System.Drawing.Point(127, 145);
            this.lbl_userId.Name = "lbl_userId";
            this.lbl_userId.Size = new System.Drawing.Size(36, 13);
            this.lbl_userId.TabIndex = 13;
            this.lbl_userId.Text = "userId";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(133, 192);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(23, 13);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "title";
            // 
            // lbl_completed
            // 
            this.lbl_completed.AutoSize = true;
            this.lbl_completed.Location = new System.Drawing.Point(116, 239);
            this.lbl_completed.Name = "lbl_completed";
            this.lbl_completed.Size = new System.Drawing.Size(57, 17);
            this.lbl_completed.TabIndex = 15;
            this.lbl_completed.Text = "completed";
            this.lbl_completed.UseCompatibleTextRendering = true;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(12, 9);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(32, 17);
            this.lbl_result.TabIndex = 16;
            this.lbl_result.Text = "result";
            this.lbl_result.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_completed);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_userId);
            this.Controls.Add(this.lbl_id);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_completed;
        private System.Windows.Forms.Label lbl_result;
    }
}

