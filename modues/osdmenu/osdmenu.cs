namespace HardLevel_PS2_App.modues.osdmenu
{
    public partial class osdmenu : Form
    {
        //public FlowLayoutPanel flowLayoutPanelSettings = new FlowLayoutPanel();
        private CheckBox checkBoxUseDkwDrv;
        private TextBox textBoxDkwDrvElf;

        private CheckBox checkBoxBootPayload;
        private TextBox textBoxPayloadPath;
        public osdmenu()
        {
            InitializeComponent();

            var mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                AutoSize = true
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // Linha 1: botões
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // Linha 2: conteúdo

            // Cria painel horizontal com os botões (pode já estar no designer também)
            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Recoloca os botões que estavam no formulário
            buttonPanel.Controls.Add(btnNewConfig);
            buttonPanel.Controls.Add(btnLoadConfig);
            buttonPanel.Controls.Add(btnSaveConfig);
            buttonPanel.Controls.Add(btnAddItem);

            // Painéis com settings e items lado a lado
            var contentLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                AutoSize = true
            };

            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            flowLayoutPanelSettings.Dock = DockStyle.Fill;
            flowLayoutPanelSettings.AutoScroll = true;

            flowLayoutPanelItems.Dock = DockStyle.Fill;
            flowLayoutPanelItems.AutoScroll = true;

            contentLayout.Controls.Add(flowLayoutPanelSettings, 0, 0);
            contentLayout.Controls.Add(flowLayoutPanelItems, 1, 0);

            // Limpa e reconstrói o layout
            this.Controls.Clear();
            mainLayout.Controls.Add(buttonPanel, 0, 0);
            mainLayout.Controls.Add(contentLayout, 0, 1);
            this.Controls.Add(mainLayout);
        }

        private void AddSetting(Control parent, string labelText, Control inputControl)
        {
            var panel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Width = 740,
                Height = 30,
                AutoSize = true,
                Margin = new Padding(5)
            };

            var label = new Label
            {
                Text = labelText,
                Width = 200,
                TextAlign = ContentAlignment.MiddleLeft
            };

            inputControl.Width = 500;
            panel.Controls.Add(label);
            panel.Controls.Add(inputControl);
            parent.Controls.Add(panel);
        }


        private void AddSetting(string key, string defaultValue)
        {
            var textBox = new TextBox
            {
                Name = key,
                Text = defaultValue,
                Tag = key   // muito importante setar aqui
            };
            AddSetting(flowLayoutPanelSettings, key, textBox);
        }

        private void AddSetting(string key, string selected, string[] options)
        {
            var comboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = key,
                Width = 500,
                Tag = key   // idem
            };
            comboBox.Items.AddRange(options);
            comboBox.SelectedItem = selected;
            AddSetting(flowLayoutPanelSettings, key, comboBox);
        }


        private void AddSetting(string key, bool isChecked)
        {
            var checkBox = new CheckBox
            {
                Text = key,
                Checked = isChecked,
                Width = 700,
                Tag = key   // importante para salvar corretamente
            };
            AddSetting(flowLayoutPanelSettings, key, checkBox);
        }


        private void AddMenuItem(int index, string name, string path1, string path2, string path3, string arg)
        {
            GroupBox groupBox = new GroupBox
            {
                Text = $"Item {index}",
                Width = flowLayoutPanelItems.ClientSize.Width - 25,
                AutoSize = true,
                Dock = DockStyle.Top,
                Margin = new Padding(5)
            };

            FlowLayoutPanel innerPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoSize = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(5),
            };

            int labelWidth = 150;
            int textBoxWidth = groupBox.Width - labelWidth - 40;

            Label lblName = new Label { Text = $"name_OSDSYS_ITEM_{index}", Width = labelWidth };
            TextBox txtName = new TextBox { Name = $"name_OSDSYS_ITEM_{index}", Width = textBoxWidth, Text = name };

            Label lblPath1 = new Label { Text = $"path1_OSDSYS_ITEM_{index}", Width = labelWidth };
            TextBox txtPath1 = new TextBox { Name = $"path1_OSDSYS_ITEM_{index}", Width = textBoxWidth, Text = path1 };

            Label lblPath2 = new Label { Text = $"path2_OSDSYS_ITEM_{index}", Width = labelWidth };
            TextBox txtPath2 = new TextBox { Name = $"path2_OSDSYS_ITEM_{index}", Width = textBoxWidth, Text = path2 };

            Label lblPath3 = new Label { Text = $"path3_OSDSYS_ITEM_{index}", Width = labelWidth };
            TextBox txtPath3 = new TextBox { Name = $"path3_OSDSYS_ITEM_{index}", Width = textBoxWidth, Text = path3 };

            Label lblArg = new Label { Text = $"arg_OSDSYS_ITEM_{index}", Width = labelWidth };
            TextBox txtArg = new TextBox { Name = $"arg_OSDSYS_ITEM_{index}", Width = textBoxWidth, Text = arg };

            innerPanel.Controls.Add(lblName); innerPanel.Controls.Add(txtName);
            innerPanel.Controls.Add(lblPath1); innerPanel.Controls.Add(txtPath1);
            innerPanel.Controls.Add(lblPath2); innerPanel.Controls.Add(txtPath2);
            innerPanel.Controls.Add(lblPath3); innerPanel.Controls.Add(txtPath3);
            innerPanel.Controls.Add(lblArg); innerPanel.Controls.Add(txtArg);

            Button btnRemove = new Button
            {
                Text = "Remover",
                AutoSize = true,
                Tag = groupBox
            };
            btnRemove.Click += (s, e) => flowLayoutPanelItems.Controls.Remove(groupBox);

            innerPanel.Controls.Add(btnRemove);

            groupBox.Controls.Add(innerPanel);
            flowLayoutPanelItems.Controls.Add(groupBox);
        }


        private void btnNewConfig_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel innerPanel = new FlowLayoutPanel
            {
                Width = 740,
                AutoSize = true,
                // Mude isso aqui:
                FlowDirection = FlowDirection.TopDown,  // <<< Troque para TopDown
                WrapContents = false
            };
            flowLayoutPanelSettings.Controls.Clear();
            flowLayoutPanelItems.Controls.Clear();
            itemCounter = 1;

            // Adiciona campos com valores padrão
            AddSetting("hacked_OSDSYS", true);
            AddSetting("OSDSYS_video_mode", "AUTO", new[] { "AUTO", "PAL", "NTSC", "480p", "1080i" });
            AddSetting("OSDSYS_Inner_Browser", false);
            AddSetting("OSDSYS_Browser_Launcher", true);
            AddSetting("OSDSYS_selected_color", "0x10,0x80,0xE0,0x80");
            AddSetting("OSDSYS_unselected_color", "0x33,0x33,0x33,0x80");
            AddSetting("OSDSYS_scroll_menu", true);
            AddSetting("OSDSYS_menu_x", "320");
            AddSetting("OSDSYS_menu_y", "110");
            AddSetting("OSDSYS_enter_x", "30");
            AddSetting("OSDSYS_enter_y", "-1");
            AddSetting("OSDSYS_version_x", "-1");
            AddSetting("OSDSYS_version_y", "-1");
            AddSetting("OSDSYS_cursor_max_velocity", "1500");
            AddSetting("OSDSYS_cursor_acceleration", "150");
            AddSetting("OSDSYS_left_cursor", "");
            AddSetting("OSDSYS_right_cursor", "");
            AddSetting("OSDSYS_menu_top_delimiter", "");
            AddSetting("OSDSYS_menu_bottom_delimiter", "");
            AddSetting("OSDSYS_num_displayed_items", "5");
            AddSetting("OSDSYS_Skip_MC", true);
            AddSetting("OSDSYS_Skip_HDD", true);
            AddSetting("OSDSYS_Skip_Disc", true);
            AddSetting("OSDSYS_Skip_Logo", true);
            AddSetting("cdrom_skip_ps2logo", true);
            AddSetting("cdrom_disable_gameid", false);
            AddSetting("ps1drv_enable_fast", false);
            AddSetting("ps1drv_enable_smooth", false);
            //AddSetting("cdrom_use_dkwdrv", false);
            AddSetting("ps1drv_use_ps1vn", false);
            //AddSetting("path_DKWDRV_ELF", "");
            //AddSetting("boot_custom_payload", false);
            //AddSetting("path_custom_payload", "");
            checkBoxUseDkwDrv = new CheckBox
            {
                Text = "cdrom_use_dkwdrv",
                Checked = false,
                Width = 700,
                Tag = "cdrom_use_dkwdrv"
            };
            checkBoxUseDkwDrv.CheckedChanged += (s, e) =>
            {
                if (textBoxDkwDrvElf != null)
                    textBoxDkwDrvElf.Enabled = checkBoxUseDkwDrv.Checked;
            };
            AddSetting(flowLayoutPanelSettings, "cdrom_use_dkwdrv", checkBoxUseDkwDrv);


            textBoxDkwDrvElf = new TextBox
            {
                Name = "path_DKWDRV_ELF",
                Text = "",
                Width = 500,
                Tag = "path_DKWDRV_ELF",
                Enabled = false
            };
            AddSetting(flowLayoutPanelSettings, "path_DKWDRV_ELF", textBoxDkwDrvElf);


            // ---- Payload ----
            checkBoxBootPayload = new CheckBox
            {
                Text = "boot_custom_payload",
                Checked = false,
                Width = 700,
                Tag = "boot_custom_payload"
            };
            checkBoxBootPayload.CheckedChanged += (s, e) =>
            {
                if (textBoxPayloadPath != null)
                    textBoxPayloadPath.Enabled = checkBoxBootPayload.Checked;
            };
            AddSetting(flowLayoutPanelSettings, "boot_custom_payload", checkBoxBootPayload);

            textBoxPayloadPath = new TextBox
            {
                Name = "path_custom_payload",
                Text = "",
                Width = 500,
                Tag = "path_custom_payload",
                Enabled = false
            };
            AddSetting(flowLayoutPanelSettings, "path_custom_payload", textBoxPayloadPath);


            // Adiciona campos com valores padrão (como já faz)
            //AddSetting("hacked_OSDSYS", true);
            //AddSetting("OSDSYS_video_mode", "AUTO", new[] { "AUTO", "PAL", "NTSC", "480p", "1080i" });
            // ... os outros campos omitidos aqui para brevidade
            //AddSetting("boot_custom_payload", false);            

            // Adiciona os itens padrões do menu
            AddMenuItem(1, "Launch Disc", "cdrom", "", "", "-nologo");
            AddMenuItem(2, "wLaunchELF", "mc?:/BOOT/BOOT.ELF", "mmce?:/apps/wLaunchELF.elf", "usb:/apps/wLaunchELF.elf", "");
            AddMenuItem(250, "Shutdown", "POWEROFF", "", "", "");

            //MessageBox.Show("Novo CNF com valores padrão carregado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CNF files (*.cnf)|*.cnf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();

                // Percorre os paineis dentro do flowLayoutPanelSettings
                foreach (Control panel in flowLayoutPanelSettings.Controls)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is CheckBox cb)
                        {
                            string key = cb.Tag as string ?? cb.Text;
                            lines.Add($"{key} = {(cb.Checked ? "1" : "0")}");
                        }
                        else if (control is TextBox tb)
                        {
                            string key = tb.Tag as string ?? tb.Name;

                            // Lógica condicional de comentários
                            if (tb == textBoxDkwDrvElf && !(checkBoxUseDkwDrv?.Checked ?? false))
                            {
                                lines.Add($"# {key} = {tb.Text}");
                            }
                            else if (tb == textBoxPayloadPath && !(checkBoxBootPayload?.Checked ?? false))
                            {
                                lines.Add($"# {key} = {tb.Text}");
                            }
                            else
                            {
                                lines.Add($"{key} = {tb.Text}");
                            }
                        }
                        else if (control is ComboBox combo)
                        {
                            string key = combo.Tag as string ?? combo.Name;
                            lines.Add($"{key} = {combo.SelectedItem}");
                        }
                    }
                }

                lines.Add("# --------------------------------------------------");

                // Salva itens do menu (já está correto)
                foreach (Control groupBox in flowLayoutPanelItems.Controls)
                {
                    foreach (Control subPanel in groupBox.Controls)
                    {
                        foreach (Control ctrl in subPanel.Controls)
                        {
                            if (ctrl is TextBox tb && !string.IsNullOrWhiteSpace(tb.Name))
                            {
                                if (!string.IsNullOrWhiteSpace(tb.Text))
                                {
                                    lines.Add($"{tb.Name} = {tb.Text}");
                                }
                                else
                                {
                                    lines.Add($"# {tb.Name} = ");
                                }
                            }
                        }
                    }
                    lines.Add("# --------------------------------------------------");
                }

                File.WriteAllLines(saveFileDialog.FileName, lines);
                MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private int itemCounter = 1;

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Verifica o maior número já usado para definir o índice do novo item
            int max = 0;
            foreach (Control groupBox in flowLayoutPanelItems.Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control sub in groupBox.Controls)
                    {
                        if (sub is FlowLayoutPanel innerPanel)
                        {
                            foreach (Control ctrl in innerPanel.Controls)
                            {
                                if (ctrl is TextBox tb && tb.Name.Contains("_ITEM_"))
                                {
                                    string[] parts = tb.Name.Split(new[] { "_ITEM_" }, StringSplitOptions.None);
                                    if (parts.Length == 2 && int.TryParse(parts[1], out int num))
                                    {
                                        if (num > max)
                                            max = num;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            itemCounter = max + 1;

            // Cria o novo item usando o método que cria o GroupBox com os controles
            AddMenuItem(itemCounter, "", "", "", "", "");
        }
        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CNF files (*.cnf)|*.cnf|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                flowLayoutPanelSettings.Controls.Clear();
                flowLayoutPanelItems.Controls.Clear();

                // Dicionário temporário para armazenar os campos do item do menu atual
                Dictionary<string, string> currentItemFields = new Dictionary<string, string>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string trimmed = line.Trim();

                    // Se for separador, cria o item com os dados armazenados
                    if (trimmed.StartsWith("#"))
                    {
                        if (currentItemFields.Count > 0)
                        {
                            AddMenuItemFromDict(currentItemFields);
                            currentItemFields.Clear();
                        }
                        continue;
                    }

                    var parts = line.Split(new[] { '=' }, 2);
                    if (parts.Length != 2)
                        continue;

                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    // Detecta se é campo de item do menu
                    if (key.StartsWith("name_OSDSYS_ITEM_") || key.StartsWith("path1_OSDSYS_ITEM_") ||
                        key.StartsWith("path2_OSDSYS_ITEM_") || key.StartsWith("path3_OSDSYS_ITEM_") ||
                        key.StartsWith("arg_OSDSYS_ITEM_"))
                    {
                        currentItemFields[key] = value;
                    }
                    else
                    {
                        // Campos gerais - processar normalmente
                        if (value == "0" || value == "1")
                        {
                            var checkBox = new CheckBox
                            {
                                Text = key,
                                Checked = value == "1",
                                Width = 700
                            };
                            flowLayoutPanelSettings.Controls.Add(checkBox);
                        }
                        else if (key == "OSDSYS_video_mode")
                        {
                            Label label = new Label
                            {
                                Text = key,
                                Width = 200
                            };
                            ComboBox comboBox = new ComboBox
                            {
                                Width = 200,
                                DropDownStyle = ComboBoxStyle.DropDownList,
                                Tag = key
                            };
                            comboBox.Items.AddRange(new string[] { "AUTO", "PAL", "NTSC", "480p", "1080i" });
                            comboBox.SelectedItem = value;
                            flowLayoutPanelSettings.Controls.Add(label);
                            flowLayoutPanelSettings.Controls.Add(comboBox);
                        }
                        else
                        {
                            Label label = new Label
                            {
                                Text = key,
                                Width = 200
                            };
                            TextBox textBox = new TextBox
                            {
                                Text = value,
                                Width = 500,
                                Tag = key
                            };
                            flowLayoutPanelSettings.Controls.Add(label);
                            flowLayoutPanelSettings.Controls.Add(textBox);
                        }
                    }
                }

                // Após o loop, caso tenha um item pendente
                if (currentItemFields.Count > 0)
                {
                    AddMenuItemFromDict(currentItemFields);
                    currentItemFields.Clear();
                }
            }
        }

        // Método auxiliar para criar o menu a partir do dicionário de campos
        private void AddMenuItemFromDict(Dictionary<string, string> fields)
        {
            // Tenta extrair o índice (ex: name_OSDSYS_ITEM_1 -> 1)
            int index = 0;
            foreach (var key in fields.Keys)
            {
                var parts = key.Split(new[] { "_ITEM_" }, StringSplitOptions.None);
                if (parts.Length == 2 && int.TryParse(parts[1], out int num))
                {
                    index = num;
                    break;
                }
            }
            if (index == 0) index = 1; // fallback

            // Obtem os valores, com fallback para string vazia
            string name = fields.GetValueOrDefault($"name_OSDSYS_ITEM_{index}", "");
            string path1 = fields.GetValueOrDefault($"path1_OSDSYS_ITEM_{index}", "");
            string path2 = fields.GetValueOrDefault($"path2_OSDSYS_ITEM_{index}", "");
            string path3 = fields.GetValueOrDefault($"path3_OSDSYS_ITEM_{index}", "");
            string arg = fields.GetValueOrDefault($"arg_OSDSYS_ITEM_{index}", "");

            AddMenuItem(index, name, path1, path2, path3, arg);
        }
    }
}
