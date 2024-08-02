
namespace automation.sentinela_system
{
    partial class Form3
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
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label nivelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.automationsentinelaDataSet = new automation.sentinela_system.automationsentinelaDataSet();
            this.loginempresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginempresaTableAdapter = new automation.sentinela_system.automationsentinelaDataSetTableAdapters.loginempresaTableAdapter();
            this.tableAdapterManager = new automation.sentinela_system.automationsentinelaDataSetTableAdapters.TableAdapterManager();
            this.loginempresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nivelComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.loginempresaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            cnpjLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automationsentinelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginempresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginempresaBindingNavigator)).BeginInit();
            this.loginempresaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // automationsentinelaDataSet
            // 
            this.automationsentinelaDataSet.DataSetName = "automationsentinelaDataSet";
            this.automationsentinelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginempresaBindingSource
            // 
            this.loginempresaBindingSource.DataMember = "loginempresa";
            this.loginempresaBindingSource.DataSource = this.automationsentinelaDataSet;
            // 
            // loginempresaTableAdapter
            // 
            this.loginempresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastroempresarialTableAdapter = null;
            this.tableAdapterManager.cadastroresidencialTableAdapter = null;
            this.tableAdapterManager.loginempresaTableAdapter = this.loginempresaTableAdapter;
            this.tableAdapterManager.loginresidencialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = automation.sentinela_system.automationsentinelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loginempresaBindingNavigator
            // 
            this.loginempresaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loginempresaBindingNavigator.BindingSource = this.loginempresaBindingSource;
            this.loginempresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loginempresaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loginempresaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.loginempresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.loginempresaBindingNavigatorSaveItem});
            this.loginempresaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loginempresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loginempresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loginempresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loginempresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loginempresaBindingNavigator.Name = "loginempresaBindingNavigator";
            this.loginempresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loginempresaBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.loginempresaBindingNavigator.TabIndex = 0;
            this.loginempresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(272, 151);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(42, 20);
            cnpjLabel.TabIndex = 1;
            cnpjLabel.Text = "cnpj:";
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginempresaBindingSource, "cnpj", true));
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(335, 148);
            this.cnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(156, 26);
            this.cnpjMaskedTextBox.TabIndex = 2;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(272, 183);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(57, 20);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginempresaBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(335, 180);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(156, 26);
            this.senhaTextBox.TabIndex = 4;
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(272, 215);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(44, 20);
            nivelLabel.TabIndex = 5;
            nivelLabel.Text = "nivel:";
            // 
            // nivelComboBox
            // 
            this.nivelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginempresaBindingSource, "nivel", true));
            this.nivelComboBox.FormattingEnabled = true;
            this.nivelComboBox.Items.AddRange(new object[] {
            "Diretor Executivo",
            "Gerente",
            "Funcionário"});
            this.nivelComboBox.Location = new System.Drawing.Point(335, 212);
            this.nivelComboBox.Name = "nivelComboBox";
            this.nivelComboBox.Size = new System.Drawing.Size(156, 28);
            this.nivelComboBox.TabIndex = 6;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // loginempresaBindingNavigatorSaveItem
            // 
            this.loginempresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginempresaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginempresaBindingNavigatorSaveItem.Image")));
            this.loginempresaBindingNavigatorSaveItem.Name = "loginempresaBindingNavigatorSaveItem";
            this.loginempresaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.loginempresaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.loginempresaBindingNavigatorSaveItem.Click += new System.EventHandler(this.loginempresaBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ainda não possui cadastro?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(447, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique Aqui!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjMaskedTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nivelLabel);
            this.Controls.Add(this.nivelComboBox);
            this.Controls.Add(this.loginempresaBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationsentinelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginempresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginempresaBindingNavigator)).EndInit();
            this.loginempresaBindingNavigator.ResumeLayout(false);
            this.loginempresaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private automationsentinelaDataSet automationsentinelaDataSet;
        private System.Windows.Forms.BindingSource loginempresaBindingSource;
        private automationsentinelaDataSetTableAdapters.loginempresaTableAdapter loginempresaTableAdapter;
        private automationsentinelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginempresaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton loginempresaBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox cnpjMaskedTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox nivelComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}