
namespace automation.sentinela_system
{
    partial class Form5
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label nivelLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.automationsentinelaDataSet = new automation.sentinela_system.automationsentinelaDataSet();
            this.cadastroempresarialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroempresarialTableAdapter = new automation.sentinela_system.automationsentinelaDataSetTableAdapters.cadastroempresarialTableAdapter();
            this.tableAdapterManager = new automation.sentinela_system.automationsentinelaDataSetTableAdapters.TableAdapterManager();
            this.cadastroempresarialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroempresarialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nivelComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            cnpjLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automationsentinelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroempresarialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroempresarialBindingNavigator)).BeginInit();
            this.cadastroempresarialBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(77, 59);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(42, 20);
            cnpjLabel.TabIndex = 1;
            cnpjLabel.Text = "cnpj:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(77, 91);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(57, 20);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "senha:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(77, 123);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 20);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "nome:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(77, 155);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(39, 20);
            cepLabel.TabIndex = 7;
            cepLabel.Text = "cep:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(77, 187);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(62, 20);
            estadoLabel.TabIndex = 9;
            estadoLabel.Text = "estado:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(77, 221);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(60, 20);
            cidadeLabel.TabIndex = 11;
            cidadeLabel.Text = "cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(77, 253);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(53, 20);
            bairroLabel.TabIndex = 13;
            bairroLabel.Text = "bairro:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(77, 285);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(89, 20);
            logradouroLabel.TabIndex = 15;
            logradouroLabel.Text = "logradouro:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(77, 317);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(67, 20);
            numeroLabel.TabIndex = 17;
            numeroLabel.Text = "numero:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(77, 349);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(71, 20);
            telefoneLabel.TabIndex = 19;
            telefoneLabel.Text = "telefone:";
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(77, 381);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(44, 20);
            nivelLabel.TabIndex = 21;
            nivelLabel.Text = "nivel:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(77, 415);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 20);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "email:";
            // 
            // automationsentinelaDataSet
            // 
            this.automationsentinelaDataSet.DataSetName = "automationsentinelaDataSet";
            this.automationsentinelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroempresarialBindingSource
            // 
            this.cadastroempresarialBindingSource.DataMember = "cadastroempresarial";
            this.cadastroempresarialBindingSource.DataSource = this.automationsentinelaDataSet;
            // 
            // cadastroempresarialTableAdapter
            // 
            this.cadastroempresarialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastroempresarialTableAdapter = this.cadastroempresarialTableAdapter;
            this.tableAdapterManager.cadastroresidencialTableAdapter = null;
            this.tableAdapterManager.loginempresaTableAdapter = null;
            this.tableAdapterManager.loginresidencialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = automation.sentinela_system.automationsentinelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroempresarialBindingNavigator
            // 
            this.cadastroempresarialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroempresarialBindingNavigator.BindingSource = this.cadastroempresarialBindingSource;
            this.cadastroempresarialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroempresarialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroempresarialBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cadastroempresarialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadastroempresarialBindingNavigatorSaveItem});
            this.cadastroempresarialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroempresarialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroempresarialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroempresarialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroempresarialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroempresarialBindingNavigator.Name = "cadastroempresarialBindingNavigator";
            this.cadastroempresarialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastroempresarialBindingNavigator.Size = new System.Drawing.Size(800, 38);
            this.cadastroempresarialBindingNavigator.TabIndex = 0;
            this.cadastroempresarialBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 33);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // cadastroempresarialBindingNavigatorSaveItem
            // 
            this.cadastroempresarialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroempresarialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroempresarialBindingNavigatorSaveItem.Image")));
            this.cadastroempresarialBindingNavigatorSaveItem.Name = "cadastroempresarialBindingNavigatorSaveItem";
            this.cadastroempresarialBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.cadastroempresarialBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadastroempresarialBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroempresarialBindingNavigatorSaveItem_Click);
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "cnpj", true));
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(172, 56);
            this.cnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.cnpjMaskedTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(172, 88);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(121, 26);
            this.senhaTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(172, 120);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 26);
            this.nomeTextBox.TabIndex = 6;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(172, 152);
            this.cepMaskedTextBox.Mask = "00000-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.cepMaskedTextBox.TabIndex = 8;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG",
            "ES",
            "PR",
            "SC",
            "RS",
            "MS",
            "GO",
            "MT",
            "DF"});
            this.estadoComboBox.Location = new System.Drawing.Point(172, 184);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 28);
            this.estadoComboBox.TabIndex = 10;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(172, 218);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(121, 26);
            this.cidadeTextBox.TabIndex = 12;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(172, 250);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(121, 26);
            this.bairroTextBox.TabIndex = 14;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "logradouro", true));
            this.logradouroTextBox.Location = new System.Drawing.Point(172, 282);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(121, 26);
            this.logradouroTextBox.TabIndex = 16;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(172, 314);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(121, 26);
            this.numeroTextBox.TabIndex = 18;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(172, 346);
            this.telefoneMaskedTextBox.Mask = "(00) 00000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.telefoneMaskedTextBox.TabIndex = 20;
            // 
            // nivelComboBox
            // 
            this.nivelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "nivel", true));
            this.nivelComboBox.FormattingEnabled = true;
            this.nivelComboBox.Items.AddRange(new object[] {
            "Diretor Executivo",
            "Gerente",
            "Funcionário"});
            this.nivelComboBox.Location = new System.Drawing.Point(172, 378);
            this.nivelComboBox.Name = "nivelComboBox";
            this.nivelComboBox.Size = new System.Drawing.Size(121, 28);
            this.nivelComboBox.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroempresarialBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(172, 412);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 26);
            this.emailTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 25;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjMaskedTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepMaskedTextBox);
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
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(nivelLabel);
            this.Controls.Add(this.nivelComboBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.cadastroempresarialBindingNavigator);
            this.Name = "Form5";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationsentinelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroempresarialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroempresarialBindingNavigator)).EndInit();
            this.cadastroempresarialBindingNavigator.ResumeLayout(false);
            this.cadastroempresarialBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private automationsentinelaDataSet automationsentinelaDataSet;
        private System.Windows.Forms.BindingSource cadastroempresarialBindingSource;
        private automationsentinelaDataSetTableAdapters.cadastroempresarialTableAdapter cadastroempresarialTableAdapter;
        private automationsentinelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroempresarialBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadastroempresarialBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox cnpjMaskedTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.ComboBox nivelComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}