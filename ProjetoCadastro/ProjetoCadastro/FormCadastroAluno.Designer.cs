namespace ProjetoCadastro
{
    partial class FormCadastroAluno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            TabControlCadastroConsulta = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            mlvAlunos = new ReaLTaiizor.Controls.MaterialListView();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabPage1 = new TabPage();
            materialMaskedTextBox1 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox2 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialComboBox2 = new ReaLTaiizor.Controls.MaterialComboBox();
            materialComboBox3 = new ReaLTaiizor.Controls.MaterialComboBox();
            TabControlCadastroConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastroConsulta
            // 
            TabControlCadastroConsulta.Controls.Add(tabPage1);
            TabControlCadastroConsulta.Controls.Add(tabPageCadastro);
            TabControlCadastroConsulta.Controls.Add(tabPageConsulta);
            TabControlCadastroConsulta.Depth = 0;
            TabControlCadastroConsulta.Dock = DockStyle.Fill;
            TabControlCadastroConsulta.ImageList = imageList1;
            TabControlCadastroConsulta.Location = new Point(3, 64);
            TabControlCadastroConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastroConsulta.Multiline = true;
            TabControlCadastroConsulta.Name = "TabControlCadastroConsulta";
            TabControlCadastroConsulta.SelectedIndex = 0;
            TabControlCadastroConsulta.Size = new Size(668, 490);
            TabControlCadastroConsulta.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtEstado);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtDataNascimento);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(660, 455);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(6, 216);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(648, 48);
            txtBairro.TabIndex = 16;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(578, 411);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(462, 411);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = (Image)resources.GetObject("txtSenha.LeadingIcon");
            txtSenha.Location = new Point(6, 338);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(648, 48);
            txtSenha.TabIndex = 13;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEstado
            // 
            txtEstado.AutoResize = false;
            txtEstado.BackColor = Color.FromArgb(255, 255, 255);
            txtEstado.Depth = 0;
            txtEstado.DrawMode = DrawMode.OwnerDrawVariable;
            txtEstado.DropDownHeight = 174;
            txtEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.DropDownWidth = 121;
            txtEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtEstado.FormattingEnabled = true;
            txtEstado.Hint = "Estado";
            txtEstado.IntegralHeight = false;
            txtEstado.ItemHeight = 43;
            txtEstado.Items.AddRange(new object[] { "AC", "", "AL", "", "AP", "", "AM", "", "BA", "", "CE", "", "DF", "", "ES", "", "GO", "", "MA", "", "MT", "", "MS", "", "MG", "", "PA", "", "PB", "", "PR", "", "PE", "", "PI", "", "RJ", "", "RN", "", "RS", "", "RO", "", "RR", "", "SC", "", "SP", "", "SE", "", "TO" });
            txtEstado.Location = new Point(546, 270);
            txtEstado.MaxDropDownItems = 4;
            txtEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(108, 49);
            txtEstado.StartIndex = 0;
            txtEstado.TabIndex = 12;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(6, 270);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(497, 48);
            txtCidade.TabIndex = 11;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(6, 162);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(648, 48);
            txtEndereco.TabIndex = 10;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 97);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(648, 48);
            txtNome.TabIndex = 9;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AllowPromptAsInput = true;
            txtDataNascimento.AnimateReadOnly = false;
            txtDataNascimento.AsciiOnly = false;
            txtDataNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataNascimento.BeepOnError = false;
            txtDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.Depth = 0;
            txtDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNascimento.HidePromptOnLeave = false;
            txtDataNascimento.HideSelection = true;
            txtDataNascimento.Hint = "Data de Nascimento";
            txtDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtDataNascimento.LeadingIcon = null;
            txtDataNascimento.Location = new Point(342, 19);
            txtDataNascimento.Mask = "99/99/9999";
            txtDataNascimento.MaxLength = 32767;
            txtDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PasswordChar = '\0';
            txtDataNascimento.PrefixSuffixText = null;
            txtDataNascimento.PromptChar = '_';
            txtDataNascimento.ReadOnly = false;
            txtDataNascimento.RejectInputOnFirstFailure = false;
            txtDataNascimento.ResetOnPrompt = true;
            txtDataNascimento.ResetOnSpace = true;
            txtDataNascimento.RightToLeft = RightToLeft.No;
            txtDataNascimento.SelectedText = "";
            txtDataNascimento.SelectionLength = 0;
            txtDataNascimento.SelectionStart = 0;
            txtDataNascimento.ShortcutsEnabled = true;
            txtDataNascimento.Size = new Size(312, 48);
            txtDataNascimento.SkipLiterals = true;
            txtDataNascimento.TabIndex = 8;
            txtDataNascimento.TabStop = false;
            txtDataNascimento.Text = "  /  /";
            txtDataNascimento.TextAlign = HorizontalAlignment.Left;
            txtDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.TrailingIcon = null;
            txtDataNascimento.UseSystemPasswordChar = false;
            txtDataNascimento.ValidatingType = null;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matrícula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(6, 19);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(312, 48);
            txtMatricula.TabIndex = 7;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(mlvAlunos);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(660, 455);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Click += tabPageConsulta_Click;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // mlvAlunos
            // 
            mlvAlunos.AutoSizeTable = false;
            mlvAlunos.BackColor = Color.FromArgb(255, 255, 255);
            mlvAlunos.BorderStyle = BorderStyle.None;
            mlvAlunos.Depth = 0;
            mlvAlunos.FullRowSelect = true;
            mlvAlunos.Location = new Point(-1, 0);
            mlvAlunos.MinimumSize = new Size(200, 100);
            mlvAlunos.MouseLocation = new Point(-1, -1);
            mlvAlunos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mlvAlunos.Name = "mlvAlunos";
            mlvAlunos.OwnerDraw = true;
            mlvAlunos.Size = new Size(661, 404);
            mlvAlunos.TabIndex = 4;
            mlvAlunos.UseCompatibleStateImageBehavior = false;
            mlvAlunos.View = View.Details;
            mlvAlunos.MouseDoubleClick += mlvAlunos_MouseDoubleClick;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(576, 413);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(497, 413);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.MouseClick += btnEditar_MouseClick;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(425, 413);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialComboBox3);
            tabPage1.Controls.Add(materialComboBox2);
            tabPage1.Controls.Add(materialMaskedTextBox2);
            tabPage1.Controls.Add(materialMaskedTextBox1);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(660, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro de Curso";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Codigo do Curso";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(16, 25);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(621, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 0;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialMaskedTextBox2
            // 
            materialMaskedTextBox2.AllowPromptAsInput = true;
            materialMaskedTextBox2.AnimateReadOnly = false;
            materialMaskedTextBox2.AsciiOnly = false;
            materialMaskedTextBox2.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox2.BeepOnError = false;
            materialMaskedTextBox2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.Depth = 0;
            materialMaskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox2.HidePromptOnLeave = false;
            materialMaskedTextBox2.HideSelection = true;
            materialMaskedTextBox2.Hint = "Nome";
            materialMaskedTextBox2.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox2.LeadingIcon = null;
            materialMaskedTextBox2.Location = new Point(16, 94);
            materialMaskedTextBox2.Mask = "";
            materialMaskedTextBox2.MaxLength = 32767;
            materialMaskedTextBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            materialMaskedTextBox2.PasswordChar = '\0';
            materialMaskedTextBox2.PrefixSuffixText = null;
            materialMaskedTextBox2.PromptChar = '_';
            materialMaskedTextBox2.ReadOnly = false;
            materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            materialMaskedTextBox2.ResetOnPrompt = true;
            materialMaskedTextBox2.ResetOnSpace = true;
            materialMaskedTextBox2.RightToLeft = RightToLeft.No;
            materialMaskedTextBox2.SelectedText = "";
            materialMaskedTextBox2.SelectionLength = 0;
            materialMaskedTextBox2.SelectionStart = 0;
            materialMaskedTextBox2.ShortcutsEnabled = true;
            materialMaskedTextBox2.Size = new Size(621, 48);
            materialMaskedTextBox2.SkipLiterals = true;
            materialMaskedTextBox2.TabIndex = 1;
            materialMaskedTextBox2.TabStop = false;
            materialMaskedTextBox2.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.TrailingIcon = null;
            materialMaskedTextBox2.UseSystemPasswordChar = false;
            materialMaskedTextBox2.ValidatingType = null;
            // 
            // materialComboBox2
            // 
            materialComboBox2.AutoResize = false;
            materialComboBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox2.Depth = 0;
            materialComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox2.DropDownHeight = 174;
            materialComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox2.DropDownWidth = 121;
            materialComboBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox2.FormattingEnabled = true;
            materialComboBox2.Hint = "Duração em semestres";
            materialComboBox2.IntegralHeight = false;
            materialComboBox2.ItemHeight = 43;
            materialComboBox2.Items.AddRange(new object[] { "1 Semestre", "", "2 Semestre", "", "3 Semestre", "", "4 Semestre", "", "5 Semestre", "", "6 Semestre", "", "7 Semestre", "", "8 Semestre", "", "9 Semestre", "", "10 Semestre", "" });
            materialComboBox2.Location = new Point(16, 231);
            materialComboBox2.MaxDropDownItems = 4;
            materialComboBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox2.Name = "materialComboBox2";
            materialComboBox2.Size = new Size(209, 49);
            materialComboBox2.StartIndex = 0;
            materialComboBox2.TabIndex = 14;
            // 
            // materialComboBox3
            // 
            materialComboBox3.AutoResize = false;
            materialComboBox3.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox3.Depth = 0;
            materialComboBox3.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox3.DropDownHeight = 174;
            materialComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox3.DropDownWidth = 121;
            materialComboBox3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox3.FormattingEnabled = true;
            materialComboBox3.Hint = "Nivel";
            materialComboBox3.IntegralHeight = false;
            materialComboBox3.ItemHeight = 43;
            materialComboBox3.Items.AddRange(new object[] { "Técnico", "", "Superior" });
            materialComboBox3.Location = new Point(16, 165);
            materialComboBox3.MaxDropDownItems = 4;
            materialComboBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox3.Name = "materialComboBox3";
            materialComboBox3.Size = new Size(209, 49);
            materialComboBox3.StartIndex = 0;
            materialComboBox3.TabIndex = 15;
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 557);
            Controls.Add(TabControlCadastroConsulta);
            DrawerTabControl = TabControlCadastroConsulta;
            Name = "FormCadastroAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            Load += FormCadastroAluno_Load;
            TabControlCadastroConsulta.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastroConsulta;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialComboBox txtEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialListView mlvAlunos;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox2;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox3;
    }
}