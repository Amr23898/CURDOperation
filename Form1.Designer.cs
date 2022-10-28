namespace _3layerCrudOperation
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
            this.dgvtop = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_ins = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_duration = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_top = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtop
            // 
            this.dgvtop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtop.Location = new System.Drawing.Point(194, 192);
            this.dgvtop.Name = "dgvtop";
            this.dgvtop.RowTemplate.Height = 25;
            this.dgvtop.Size = new System.Drawing.Size(526, 150);
            this.dgvtop.TabIndex = 0;
            this.dgvtop.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvtop_RowHeaderMouseClick);
            this.dgvtop.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvtop_RowHeaderMouseDoubleClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(615, 163);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_ins
            // 
            this.btn_ins.Location = new System.Drawing.Point(475, 163);
            this.btn_ins.Name = "btn_ins";
            this.btn_ins.Size = new System.Drawing.Size(75, 23);
            this.btn_ins.TabIndex = 2;
            this.btn_ins.Text = "Insert";
            this.btn_ins.UseVisualStyleBackColor = true;
            this.btn_ins.Click += new System.EventHandler(this.btn_ins_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(338, 163);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 3;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(208, 163);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(377, 28);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(102, 23);
            this.text_id.TabIndex = 5;
            // 
            // text_duration
            // 
            this.text_duration.Location = new System.Drawing.Point(377, 86);
            this.text_duration.Name = "text_duration";
            this.text_duration.Size = new System.Drawing.Size(102, 23);
            this.text_duration.TabIndex = 6;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(377, 57);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(102, 23);
            this.text_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "CourseID";
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(702, 75);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(0, 15);
            this.lb_state.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Topic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "CourseDuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "CourseName";
            // 
            // combo_top
            // 
            this.combo_top.FormattingEnabled = true;
            this.combo_top.Location = new System.Drawing.Point(377, 124);
            this.combo_top.Name = "combo_top";
            this.combo_top.Size = new System.Drawing.Size(123, 23);
            this.combo_top.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.combo_top);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_duration);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.btn_ins);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgvtop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvtop;
        private Button btn_search;
        private Button btn_ins;
        private Button bt_update;
        private Button btn_delete;
        private TextBox text_id;
        private TextBox text_duration;
        private TextBox text_name;
        private Label label1;
        private Label lb_state;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox combo_top;
    }
}