namespace Test
{
    partial class FilterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterScreen));
            this.taskbarAssistant1 = new DevExpress.Utils.Taskbar.TaskbarAssistant();
            this.dataGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtBitisTarihi = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.TxtBaslangicTarihi = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMalKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBitisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslangicTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMalKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // taskbarAssistant1
            // 
            this.taskbarAssistant1.ParentControl = this;
            // 
            // dataGrid
            // 
            this.dataGrid.Location = new System.Drawing.Point(448, 2);
            this.dataGrid.MainView = this.gridView1;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(707, 406);
            this.dataGrid.TabIndex = 11;
            this.dataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtBitisTarihi);
            this.groupControl1.Controls.Add(this.TxtBaslangicTarihi);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtMalKodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(436, 406);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Filtreleme";
            // 
            // TxtBitisTarihi
            // 
            this.TxtBitisTarihi.EditValue = null;
            this.TxtBitisTarihi.Location = new System.Drawing.Point(148, 71);
            this.TxtBitisTarihi.Name = "TxtBitisTarihi";
            this.TxtBitisTarihi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBitisTarihi.Properties.Appearance.Options.UseFont = true;
            this.TxtBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtBitisTarihi.Size = new System.Drawing.Size(253, 26);
            this.TxtBitisTarihi.TabIndex = 10;
            // 
            // TxtBaslangicTarihi
            // 
            this.TxtBaslangicTarihi.EditValue = null;
            this.TxtBaslangicTarihi.Location = new System.Drawing.Point(148, 40);
            this.TxtBaslangicTarihi.Name = "TxtBaslangicTarihi";
            this.TxtBaslangicTarihi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBaslangicTarihi.Properties.Appearance.Options.UseFont = true;
            this.TxtBaslangicTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtBaslangicTarihi.Size = new System.Drawing.Size(253, 26);
            this.TxtBaslangicTarihi.TabIndex = 9;
            this.TxtBaslangicTarihi.EditValueChanged += new System.EventHandler(this.TxtBaslangicTarihi_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(212, 144);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 35);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Filtrele";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "STK.MalKodu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Başlangıç Tarihi:";
            // 
            // TxtMalKodu
            // 
            this.TxtMalKodu.Location = new System.Drawing.Point(148, 101);
            this.TxtMalKodu.Name = "TxtMalKodu";
            this.TxtMalKodu.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMalKodu.Properties.Appearance.Options.UseFont = true;
            this.TxtMalKodu.Size = new System.Drawing.Size(253, 26);
            this.TxtMalKodu.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Bitiş Tarihi:";
            // 
            // FilterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 419);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBitisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslangicTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMalKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Taskbar.TaskbarAssistant taskbarAssistant1;
        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit TxtBitisTarihi;
        private DevExpress.XtraEditors.DateTimeOffsetEdit TxtBaslangicTarihi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtMalKodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}