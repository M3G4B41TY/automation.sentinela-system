
namespace automation.sentinela_system
{
    partial class Form6
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
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label nivelLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label denascLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label numeroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.automationsentinelaDataSet = new automation.sentinela_system.automationsentinelaDataSet();
            this.cadastroresidencialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroresidencialTableAdapter = new automation.sentinela_system.automationsentinelaDataSetTableAdapters.cadastroresidencialTableAdapter();
            this.tableAdapterManager = new automation.sentinela_system.automationsentinelaDataSetTableAdapters.TableAdapterManager();
            this.cadastroresidencialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nivelComboBox = new System.Windows.Forms.ComboBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.denascMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.cadastroresidencialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            cpfLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            denascLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automationsentinelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroresidencialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroresidencialBindingNavigator)).BeginInit();
            this.cadastroresidencialBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // automationsentinelaDataSet
            // 
            this.automationsentinelaDataSet.DataSetName = "automationsentinelaDataSet";
            this.automationsentinelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroresidencialBindingSource
            // 
            this.cadastroresidencialBindingSource.DataMember = "cadastroresidencial";
            this.cadastroresidencialBindingSource.DataSource = this.automationsentinelaDataSet;
            // 
            // cadastroresidencialTableAdapter
            // 
            this.cadastroresidencialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastroempresarialTableAdapter = null;
            this.tableAdapterManager.cadastroresidencialTableAdapter = this.cadastroresidencialTableAdapter;
            this.tableAdapterManager.loginempresaTableAdapter = null;
            this.tableAdapterManager.loginresidencialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = automation.sentinela_system.automationsentinelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroresidencialBindingNavigator
            // 
            this.cadastroresidencialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroresidencialBindingNavigator.BindingSource = this.cadastroresidencialBindingSource;
            this.cadastroresidencialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroresidencialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroresidencialBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cadastroresidencialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadastroresidencialBindingNavigatorSaveItem});
            this.cadastroresidencialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroresidencialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroresidencialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroresidencialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroresidencialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroresidencialBindingNavigator.Name = "cadastroresidencialBindingNavigator";
            this.cadastroresidencialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastroresidencialBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.cadastroresidencialBindingNavigator.TabIndex = 0;
            this.cadastroresidencialBindingNavigator.Text = "bindingNavigator1";
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
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(86, 33);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(35, 20);
            cpfLabel.TabIndex = 1;
            cpfLabel.Text = "cpf:";
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(181, 30);
            this.cpfMaskedTextBox.Mask = "000,000,000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.cpfMaskedTextBox.TabIndex = 2;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(86, 65);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(57, 20);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(181, 62);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(121, 26);
            this.senhaTextBox.TabIndex = 4;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(86, 97);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 20);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(181, 94);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 26);
            this.nomeTextBox.TabIndex = 6;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(86, 129);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(39, 20);
            cepLabel.TabIndex = 7;
            cepLabel.Text = "cep:";
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(181, 126);
            this.cepMaskedTextBox.Mask = "00000-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.cepMaskedTextBox.TabIndex = 8;
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(86, 161);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(44, 20);
            nivelLabel.TabIndex = 9;
            nivelLabel.Text = "nivel:";
            // 
            // nivelComboBox
            // 
            this.nivelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "nivel", true));
            this.nivelComboBox.FormattingEnabled = true;
            this.nivelComboBox.Items.AddRange(new object[] {
            "Não requerido",
            "Sala de Trabalho",
            "Oficina",
            "Garagem"});
            this.nivelComboBox.Location = new System.Drawing.Point(181, 158);
            this.nivelComboBox.Name = "nivelComboBox";
            this.nivelComboBox.Size = new System.Drawing.Size(121, 28);
            this.nivelComboBox.TabIndex = 10;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(86, 195);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(71, 20);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(181, 192);
            this.telefoneMaskedTextBox.Mask = "(00) 00000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.telefoneMaskedTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(86, 227);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 20);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(181, 224);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 26);
            this.emailTextBox.TabIndex = 14;
            // 
            // denascLabel
            // 
            denascLabel.AutoSize = true;
            denascLabel.Location = new System.Drawing.Point(86, 259);
            denascLabel.Name = "denascLabel";
            denascLabel.Size = new System.Drawing.Size(65, 20);
            denascLabel.TabIndex = 15;
            denascLabel.Text = "denasc:";
            // 
            // denascMaskedTextBox
            // 
            this.denascMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "denasc", true));
            this.denascMaskedTextBox.Location = new System.Drawing.Point(181, 256);
            this.denascMaskedTextBox.Mask = "00/00/0000";
            this.denascMaskedTextBox.Name = "denascMaskedTextBox";
            this.denascMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.denascMaskedTextBox.TabIndex = 16;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(86, 291);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(62, 20);
            estadoLabel.TabIndex = 17;
            estadoLabel.Text = "estado:";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG",
            "ES",
            "SC",
            "PR",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.estadoComboBox.Location = new System.Drawing.Point(181, 288);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 28);
            this.estadoComboBox.TabIndex = 18;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(86, 325);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(60, 20);
            cidadeLabel.TabIndex = 19;
            cidadeLabel.Text = "cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(181, 322);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(121, 26);
            this.cidadeTextBox.TabIndex = 20;
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(86, 357);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(53, 20);
            bairroLabel.TabIndex = 21;
            bairroLabel.Text = "bairro:";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(181, 354);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(121, 26);
            this.bairroTextBox.TabIndex = 22;
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(86, 389);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(89, 20);
            logradouroLabel.TabIndex = 23;
            logradouroLabel.Text = "logradouro:";
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "logradouro", true));
            this.logradouroTextBox.Location = new System.Drawing.Point(181, 386);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(121, 26);
            this.logradouroTextBox.TabIndex = 24;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(86, 421);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(67, 20);
            numeroLabel.TabIndex = 25;
            numeroLabel.Text = "numero:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroresidencialBindingSource, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(181, 418);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(121, 26);
            this.numeroTextBox.TabIndex = 26;
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
            // cadastroresidencialBindingNavigatorSaveItem
            // 
            this.cadastroresidencialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroresidencialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroresidencialBindingNavigatorSaveItem.Image")));
            this.cadastroresidencialBindingNavigatorSaveItem.Name = "cadastroresidencialBindingNavigatorSaveItem";
            this.cadastroresidencialBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.cadastroresidencialBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadastroresidencialBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroresidencialBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 28;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfMaskedTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepMaskedTextBox);
            this.Controls.Add(nivelLabel);
            this.Controls.Add(this.nivelComboBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(denascLabel);
            this.Controls.Add(this.denascMaskedTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(logradouroLabel);
            this.Controls.Add(this.logradouroTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.cadastroresidencialBindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationsentinelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroresidencialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroresidencialBindingNavigator)).EndInit();
            this.cadastroresidencialBindingNavigator.ResumeLayout(false);
            this.cadastroresidencialBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private automationsentinelaDataSet automationsentinelaDataSet;
        private System.Windows.Forms.BindingSource cadastroresidencialBindingSource;
        private automationsentinelaDataSetTableAdapters.cadastroresidencialTableAdapter cadastroresidencialTableAdapter;
        private automationsentinelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroresidencialBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadastroresidencialBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.ComboBox nivelComboBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox denascMaskedTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}