namespace ckdnasave
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dna_list = new System.Windows.Forms.ListBox();
            this.DNA_CODE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.DNA_CODE_EDIT = new System.Windows.Forms.TextBox();
            this.dna_name_edit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_dnaRmv = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dna_img_preview = new System.Windows.Forms.PictureBox();
            this.btn_img_add = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_dnaAdd = new System.Windows.Forms.Button();
            this.dna_add_log = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dna_add_img = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_saveFolder = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dna_img_preview)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dna_list
            // 
            this.dna_list.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dna_list.FormattingEnabled = true;
            this.dna_list.ItemHeight = 20;
            this.dna_list.Location = new System.Drawing.Point(16, 51);
            this.dna_list.Name = "dna_list";
            this.dna_list.Size = new System.Drawing.Size(150, 384);
            this.dna_list.TabIndex = 0;
            this.dna_list.SelectedIndexChanged += new System.EventHandler(this.dna_list_SelectedIndexChanged);
            // 
            // DNA_CODE
            // 
            this.DNA_CODE.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DNA_CODE.Location = new System.Drawing.Point(178, 51);
            this.DNA_CODE.Multiline = true;
            this.DNA_CODE.Name = "DNA_CODE";
            this.DNA_CODE.ReadOnly = true;
            this.DNA_CODE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DNA_CODE.Size = new System.Drawing.Size(611, 171);
            this.DNA_CODE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(352, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNA 코드 - 이름을 선택하면 자동으로 코드가 복사됨";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search.Location = new System.Drawing.Point(16, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(150, 25);
            this.search.TabIndex = 3;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.Location = new System.Drawing.Point(172, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 24);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // DNA_CODE_EDIT
            // 
            this.DNA_CODE_EDIT.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DNA_CODE_EDIT.Location = new System.Drawing.Point(6, 92);
            this.DNA_CODE_EDIT.Multiline = true;
            this.DNA_CODE_EDIT.Name = "DNA_CODE_EDIT";
            this.DNA_CODE_EDIT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DNA_CODE_EDIT.Size = new System.Drawing.Size(455, 120);
            this.DNA_CODE_EDIT.TabIndex = 1;
            this.DNA_CODE_EDIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DNA_CODE_EDIT_KeyPress);
            // 
            // dna_name_edit
            // 
            this.dna_name_edit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dna_name_edit.Location = new System.Drawing.Point(6, 37);
            this.dna_name_edit.Name = "dna_name_edit";
            this.dna_name_edit.Size = new System.Drawing.Size(150, 25);
            this.dna_name_edit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNA 코드";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 480);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btn_image);
            this.tabPage1.Controls.Add(this.btn_dnaRmv);
            this.tabPage1.Controls.Add(this.dna_list);
            this.tabPage1.Controls.Add(this.btn_copy);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.search);
            this.tabPage1.Controls.Add(this.DNA_CODE);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DNA 목록 보기";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ckdnasave.Properties.Resources._47b81ad8240423400380cd13ac511dae;
            this.pictureBox1.Location = new System.Drawing.Point(725, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_image
            // 
            this.btn_image.Enabled = false;
            this.btn_image.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_image.Location = new System.Drawing.Point(178, 228);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(88, 46);
            this.btn_image.TabIndex = 5;
            this.btn_image.Text = "이미지";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // btn_dnaRmv
            // 
            this.btn_dnaRmv.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dnaRmv.Location = new System.Drawing.Point(178, 389);
            this.btn_dnaRmv.Name = "btn_dnaRmv";
            this.btn_dnaRmv.Size = new System.Drawing.Size(88, 46);
            this.btn_dnaRmv.TabIndex = 5;
            this.btn_dnaRmv.Text = "제거";
            this.btn_dnaRmv.UseVisualStyleBackColor = true;
            this.btn_dnaRmv.Click += new System.EventHandler(this.btn_dnaRmv_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_copy.Location = new System.Drawing.Point(725, 17);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(64, 28);
            this.btn_copy.TabIndex = 4;
            this.btn_copy.Text = "복사";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(174, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "실수로 잘못 제거한 경우 오른쪽 새로고침 이미지를 클릭해 복구해주세요.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(174, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNA 목록은 프로그램을 종료할 때 저장됩니다.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dna_img_preview);
            this.tabPage2.Controls.Add(this.btn_img_add);
            this.tabPage2.Controls.Add(this.btn_paste);
            this.tabPage2.Controls.Add(this.btn_dnaAdd);
            this.tabPage2.Controls.Add(this.dna_add_log);
            this.tabPage2.Controls.Add(this.DNA_CODE_EDIT);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dna_add_img);
            this.tabPage2.Controls.Add(this.dna_name_edit);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DNA 목록 추가";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dna_img_preview
            // 
            this.dna_img_preview.ErrorImage = null;
            this.dna_img_preview.InitialImage = null;
            this.dna_img_preview.Location = new System.Drawing.Point(489, 92);
            this.dna_img_preview.Name = "dna_img_preview";
            this.dna_img_preview.Size = new System.Drawing.Size(284, 195);
            this.dna_img_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dna_img_preview.TabIndex = 5;
            this.dna_img_preview.TabStop = false;
            // 
            // btn_img_add
            // 
            this.btn_img_add.Location = new System.Drawing.Point(679, 37);
            this.btn_img_add.Name = "btn_img_add";
            this.btn_img_add.Size = new System.Drawing.Size(94, 49);
            this.btn_img_add.TabIndex = 4;
            this.btn_img_add.Text = "찾아보기";
            this.btn_img_add.UseVisualStyleBackColor = true;
            this.btn_img_add.Click += new System.EventHandler(this.btn_img_add_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.Location = new System.Drawing.Point(367, 37);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(94, 49);
            this.btn_paste.TabIndex = 4;
            this.btn_paste.Text = "붙여넣기";
            this.btn_paste.UseVisualStyleBackColor = true;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_dnaAdd
            // 
            this.btn_dnaAdd.Location = new System.Drawing.Point(6, 228);
            this.btn_dnaAdd.Name = "btn_dnaAdd";
            this.btn_dnaAdd.Size = new System.Drawing.Size(455, 59);
            this.btn_dnaAdd.TabIndex = 4;
            this.btn_dnaAdd.Text = "추가";
            this.btn_dnaAdd.UseVisualStyleBackColor = true;
            this.btn_dnaAdd.Click += new System.EventHandler(this.btn_dnaAdd_Click);
            // 
            // dna_add_log
            // 
            this.dna_add_log.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dna_add_log.Location = new System.Drawing.Point(6, 304);
            this.dna_add_log.Multiline = true;
            this.dna_add_log.Name = "dna_add_log";
            this.dna_add_log.ReadOnly = true;
            this.dna_add_log.Size = new System.Drawing.Size(455, 120);
            this.dna_add_log.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(485, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "이미지(선택)";
            // 
            // dna_add_img
            // 
            this.dna_add_img.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dna_add_img.Location = new System.Drawing.Point(489, 61);
            this.dna_add_img.Name = "dna_add_img";
            this.dna_add_img.ReadOnly = true;
            this.dna_add_img.Size = new System.Drawing.Size(184, 25);
            this.dna_add_img.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(805, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "도움말";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 96);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "디씨 크킹갤 DNA";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel1.Location = new System.Drawing.Point(6, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 21);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "디씨 크킹갤 DNA";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_saveFolder);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DNA 적용 방법";
            // 
            // btn_saveFolder
            // 
            this.btn_saveFolder.Location = new System.Drawing.Point(663, 38);
            this.btn_saveFolder.Name = "btn_saveFolder";
            this.btn_saveFolder.Size = new System.Drawing.Size(124, 35);
            this.btn_saveFolder.TabIndex = 1;
            this.btn_saveFolder.Text = "세이브 위치";
            this.btn_saveFolder.UseVisualStyleBackColor = true;
            this.btn_saveFolder.Click += new System.EventHandler(this.btn_saveFolder_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel2.Location = new System.Drawing.Point(6, 44);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(120, 21);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "DNA 적용 방법";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "이미지 파일|*jpg;*png;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 507);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DNA 저장소";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dna_img_preview)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dna_list;
        private System.Windows.Forms.TextBox DNA_CODE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox DNA_CODE_EDIT;
        private System.Windows.Forms.TextBox dna_name_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dnaRmv;
        private System.Windows.Forms.Button btn_dnaAdd;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dna_add_log;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.PictureBox dna_img_preview;
        private System.Windows.Forms.Button btn_img_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dna_add_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_saveFolder;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

