//This Code is released under the full GPL license available here: http://www.gnu.org/licenses/gpl.html
namespace RegEx
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.expressionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.replaceresultsTextBox = new System.Windows.Forms.TextBox();
            this.ReplaceDelegateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MatchesTreeView = new System.Windows.Forms.TreeView();
            this.caretButton = new System.Windows.Forms.Button();
            this.dollarsignButton = new System.Windows.Forms.Button();
            this.wordcharacterButton = new System.Windows.Forms.Button();
            this.nonwordcharacterButton = new System.Windows.Forms.Button();
            this.periodButton = new System.Windows.Forms.Button();
            this.plussignButton = new System.Windows.Forms.Button();
            this.startcharacterButton = new System.Windows.Forms.Button();
            this.digitButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.clearallButton = new System.Windows.Forms.Button();
            this.ignorecaseCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.replacetextTextBox = new System.Windows.Forms.TextBox();
            this.explicitcaptureCheckBox = new System.Windows.Forms.CheckBox();
            this.compiledCheckBox = new System.Windows.Forms.CheckBox();
            this.cultureinvariantCheckBox = new System.Windows.Forms.CheckBox();
            this.ecmascriptCheckBox = new System.Windows.Forms.CheckBox();
            this.ignorepatternwhitespaceCheckBox = new System.Windows.Forms.CheckBox();
            this.multilineCheckBox = new System.Windows.Forms.CheckBox();
            this.righttoleftCheckBox = new System.Windows.Forms.CheckBox();
            this.singlelineCheckBox = new System.Windows.Forms.CheckBox();
            this.generaltoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.expandcapturesCheckBox = new System.Windows.Forms.CheckBox();
            this.expandgroupsCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.expressionTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treenodeContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyvalueStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.treenodeContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expressionComboBox
            // 
            this.expressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expressionComboBox.DropDownWidth = 300;
            this.expressionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionComboBox.FormattingEnabled = true;
            this.expressionComboBox.Location = new System.Drawing.Point(701, 28);
            this.expressionComboBox.Name = "expressionComboBox";
            this.expressionComboBox.Size = new System.Drawing.Size(189, 21);
            this.expressionComboBox.TabIndex = 0;
            this.expressionComboBox.SelectedIndexChanged += new System.EventHandler(this.expressionComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expression: ->";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.Location = new System.Drawing.Point(22, 159);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(391, 166);
            this.dataTextBox.TabIndex = 2;
            this.dataTextBox.TextChanged += new System.EventHandler(this.DataTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Match Results:";
            // 
            // replaceresultsTextBox
            // 
            this.replaceresultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceresultsTextBox.Location = new System.Drawing.Point(22, 413);
            this.replaceresultsTextBox.Multiline = true;
            this.replaceresultsTextBox.Name = "replaceresultsTextBox";
            this.replaceresultsTextBox.Size = new System.Drawing.Size(391, 64);
            this.replaceresultsTextBox.TabIndex = 5;
            // 
            // ReplaceDelegateTextBox
            // 
            this.ReplaceDelegateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceDelegateTextBox.Location = new System.Drawing.Point(25, 496);
            this.ReplaceDelegateTextBox.Multiline = true;
            this.ReplaceDelegateTextBox.Name = "ReplaceDelegateTextBox";
            this.ReplaceDelegateTextBox.Size = new System.Drawing.Size(388, 70);
            this.ReplaceDelegateTextBox.TabIndex = 6;
            this.ReplaceDelegateTextBox.Visible = false;
            this.ReplaceDelegateTextBox.TextChanged += new System.EventHandler(this.ReplaceDelegateTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Replacement Text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Replacement Results:";
            // 
            // MatchesTreeView
            // 
            this.MatchesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchesTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchesTreeView.Location = new System.Drawing.Point(429, 159);
            this.MatchesTreeView.Name = "MatchesTreeView";
            this.MatchesTreeView.Size = new System.Drawing.Size(549, 407);
            this.MatchesTreeView.TabIndex = 9;
            this.MatchesTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(MatchesTreeView_Click);
            this.MatchesTreeView.KeyUp += new System.Windows.Forms.KeyEventHandler(MatchesTreeView_KeyUp);
            // 
            // caretButton
            // 
            this.caretButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caretButton.Location = new System.Drawing.Point(108, 26);
            this.caretButton.Name = "caretButton";
            this.caretButton.Size = new System.Drawing.Size(19, 23);
            this.caretButton.TabIndex = 10;
            this.caretButton.Text = "^";
            this.generaltoolTip.SetToolTip(this.caretButton, "^ Represents the start of the line or expression.");
            this.caretButton.UseVisualStyleBackColor = true;
            this.caretButton.Click += new System.EventHandler(this.caretButton_Click);
            // 
            // dollarsignButton
            // 
            this.dollarsignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarsignButton.Location = new System.Drawing.Point(336, 27);
            this.dollarsignButton.Name = "dollarsignButton";
            this.dollarsignButton.Size = new System.Drawing.Size(19, 23);
            this.dollarsignButton.TabIndex = 11;
            this.dollarsignButton.Text = "$";
            this.generaltoolTip.SetToolTip(this.dollarsignButton, "$ Represents the end of the line or expression.");
            this.dollarsignButton.UseVisualStyleBackColor = true;
            this.dollarsignButton.Click += new System.EventHandler(this.dollarsignButton_Click);
            // 
            // wordcharacterButton
            // 
            this.wordcharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordcharacterButton.Location = new System.Drawing.Point(148, 26);
            this.wordcharacterButton.Name = "wordcharacterButton";
            this.wordcharacterButton.Size = new System.Drawing.Size(33, 23);
            this.wordcharacterButton.TabIndex = 12;
            this.wordcharacterButton.Text = "\\w";
            this.generaltoolTip.SetToolTip(this.wordcharacterButton, "\\w A word character.");
            this.wordcharacterButton.UseVisualStyleBackColor = true;
            this.wordcharacterButton.Click += new System.EventHandler(this.wordcharacterButton_Click);
            // 
            // nonwordcharacterButton
            // 
            this.nonwordcharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonwordcharacterButton.Location = new System.Drawing.Point(180, 26);
            this.nonwordcharacterButton.Name = "nonwordcharacterButton";
            this.nonwordcharacterButton.Size = new System.Drawing.Size(36, 23);
            this.nonwordcharacterButton.TabIndex = 13;
            this.nonwordcharacterButton.Text = "\\W";
            this.generaltoolTip.SetToolTip(this.nonwordcharacterButton, "\\W A non-word character");
            this.nonwordcharacterButton.UseVisualStyleBackColor = true;
            this.nonwordcharacterButton.Click += new System.EventHandler(this.nonwordcharacterButton_Click);
            // 
            // periodButton
            // 
            this.periodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodButton.Location = new System.Drawing.Point(261, 26);
            this.periodButton.Name = "periodButton";
            this.periodButton.Size = new System.Drawing.Size(19, 23);
            this.periodButton.TabIndex = 14;
            this.periodButton.Text = ".";
            this.generaltoolTip.SetToolTip(this.periodButton, ". Any character except a newline.");
            this.periodButton.UseVisualStyleBackColor = true;
            this.periodButton.Click += new System.EventHandler(this.periodButton_Click);
            // 
            // plussignButton
            // 
            this.plussignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plussignButton.Location = new System.Drawing.Point(280, 26);
            this.plussignButton.Name = "plussignButton";
            this.plussignButton.Size = new System.Drawing.Size(19, 23);
            this.plussignButton.TabIndex = 15;
            this.plussignButton.Text = "+";
            this.generaltoolTip.SetToolTip(this.plussignButton, "+ one or more times.");
            this.plussignButton.UseVisualStyleBackColor = true;
            this.plussignButton.Click += new System.EventHandler(this.plussignButton_Click);
            // 
            // startcharacterButton
            // 
            this.startcharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startcharacterButton.Location = new System.Drawing.Point(299, 26);
            this.startcharacterButton.Name = "startcharacterButton";
            this.startcharacterButton.Size = new System.Drawing.Size(19, 23);
            this.startcharacterButton.TabIndex = 16;
            this.startcharacterButton.Text = "*";
            this.generaltoolTip.SetToolTip(this.startcharacterButton, "* zero or more times.");
            this.startcharacterButton.UseVisualStyleBackColor = true;
            this.startcharacterButton.Click += new System.EventHandler(this.startcharacterButton_Click);
            // 
            // digitButton
            // 
            this.digitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitButton.Location = new System.Drawing.Point(215, 26);
            this.digitButton.Name = "digitButton";
            this.digitButton.Size = new System.Drawing.Size(30, 23);
            this.digitButton.TabIndex = 17;
            this.digitButton.Text = "\\d";
            this.generaltoolTip.SetToolTip(this.digitButton, "\\d A numerical digit.");
            this.digitButton.UseVisualStyleBackColor = true;
            this.digitButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(622, 27);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(72, 23);
            this.historyButton.TabIndex = 18;
            this.historyButton.Text = "-> Hi&story";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // clearallButton
            // 
            this.clearallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearallButton.Location = new System.Drawing.Point(548, 26);
            this.clearallButton.Name = "clearallButton";
            this.clearallButton.Size = new System.Drawing.Size(68, 23);
            this.clearallButton.TabIndex = 19;
            this.clearallButton.Text = "Clear All";
            this.clearallButton.UseVisualStyleBackColor = true;
            this.clearallButton.Click += new System.EventHandler(this.clearallButton_Click);
            // 
            // ignorecaseCheckBox
            // 
            this.ignorecaseCheckBox.AccessibleDescription = "";
            this.ignorecaseCheckBox.AutoSize = true;
            this.ignorecaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignorecaseCheckBox.Location = new System.Drawing.Point(639, 60);
            this.ignorecaseCheckBox.Name = "ignorecaseCheckBox";
            this.ignorecaseCheckBox.Size = new System.Drawing.Size(80, 17);
            this.ignorecaseCheckBox.TabIndex = 20;
            this.ignorecaseCheckBox.Text = "IgnoreCase";
            this.generaltoolTip.SetToolTip(this.ignorecaseCheckBox, "Specifies case-insensitive matching.");
            this.ignorecaseCheckBox.UseVisualStyleBackColor = true;
            this.ignorecaseCheckBox.CheckedChanged += new System.EventHandler(this.ignorecaseCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Replace Delegate:";
            this.label6.Visible = false;
            // 
            // replacetextTextBox
            // 
            this.replacetextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replacetextTextBox.Location = new System.Drawing.Point(22, 344);
            this.replacetextTextBox.Multiline = true;
            this.replacetextTextBox.Name = "replacetextTextBox";
            this.replacetextTextBox.Size = new System.Drawing.Size(391, 48);
            this.replacetextTextBox.TabIndex = 22;
            this.replacetextTextBox.TextChanged += new System.EventHandler(this.replacetextTextBox_TextChanged);
            // 
            // explicitcaptureCheckBox
            // 
            this.explicitcaptureCheckBox.AutoSize = true;
            this.explicitcaptureCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicitcaptureCheckBox.Location = new System.Drawing.Point(725, 60);
            this.explicitcaptureCheckBox.Name = "explicitcaptureCheckBox";
            this.explicitcaptureCheckBox.Size = new System.Drawing.Size(96, 17);
            this.explicitcaptureCheckBox.TabIndex = 23;
            this.explicitcaptureCheckBox.Text = "ExplicitCapture";
            this.generaltoolTip.SetToolTip(this.explicitcaptureCheckBox, resources.GetString("explicitcaptureCheckBox.ToolTip"));
            this.explicitcaptureCheckBox.UseVisualStyleBackColor = true;
            this.explicitcaptureCheckBox.CheckedChanged += new System.EventHandler(this.explicitcaptureCheckBox_CheckedChanged);
            // 
            // compiledCheckBox
            // 
            this.compiledCheckBox.AutoSize = true;
            this.compiledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compiledCheckBox.Location = new System.Drawing.Point(831, 83);
            this.compiledCheckBox.Name = "compiledCheckBox";
            this.compiledCheckBox.Size = new System.Drawing.Size(69, 17);
            this.compiledCheckBox.TabIndex = 24;
            this.compiledCheckBox.Text = "Compiled";
            this.generaltoolTip.SetToolTip(this.compiledCheckBox, "Specifies that the regular expression is compiled to an assembly.\n This yields fa" +
                    "ster execution but increases startup time.");
            this.compiledCheckBox.UseVisualStyleBackColor = true;
            this.compiledCheckBox.CheckedChanged += new System.EventHandler(this.compiledCheckBox_CheckedChanged);
            // 
            // cultureinvariantCheckBox
            // 
            this.cultureinvariantCheckBox.AutoSize = true;
            this.cultureinvariantCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cultureinvariantCheckBox.Location = new System.Drawing.Point(725, 106);
            this.cultureinvariantCheckBox.Name = "cultureinvariantCheckBox";
            this.cultureinvariantCheckBox.Size = new System.Drawing.Size(100, 17);
            this.cultureinvariantCheckBox.TabIndex = 25;
            this.cultureinvariantCheckBox.Text = "CultureInvariant";
            this.generaltoolTip.SetToolTip(this.cultureinvariantCheckBox, "Specifies that cultural differences in language is ignored.\n See [<topic://cpconP" +
                    "erformingCulture-InsensitiveOperationsInRegularExpressionsNamespace>] for more i" +
                    "nformation.");
            this.cultureinvariantCheckBox.UseVisualStyleBackColor = true;
            this.cultureinvariantCheckBox.CheckedChanged += new System.EventHandler(this.cultureinvariantCheckBox_CheckedChanged);
            // 
            // ecmascriptCheckBox
            // 
            this.ecmascriptCheckBox.AutoSize = true;
            this.ecmascriptCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecmascriptCheckBox.Location = new System.Drawing.Point(725, 83);
            this.ecmascriptCheckBox.Name = "ecmascriptCheckBox";
            this.ecmascriptCheckBox.Size = new System.Drawing.Size(83, 17);
            this.ecmascriptCheckBox.TabIndex = 26;
            this.ecmascriptCheckBox.Text = "ECMAScript";
            this.generaltoolTip.SetToolTip(this.ecmascriptCheckBox, resources.GetString("ecmascriptCheckBox.ToolTip"));
            this.ecmascriptCheckBox.UseVisualStyleBackColor = true;
            this.ecmascriptCheckBox.CheckedChanged += new System.EventHandler(this.ecmascriptCheckBox_CheckedChanged);
            // 
            // ignorepatternwhitespaceCheckBox
            // 
            this.ignorepatternwhitespaceCheckBox.AutoSize = true;
            this.ignorepatternwhitespaceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignorepatternwhitespaceCheckBox.Location = new System.Drawing.Point(831, 106);
            this.ignorepatternwhitespaceCheckBox.Name = "ignorepatternwhitespaceCheckBox";
            this.ignorepatternwhitespaceCheckBox.Size = new System.Drawing.Size(147, 17);
            this.ignorepatternwhitespaceCheckBox.TabIndex = 27;
            this.ignorepatternwhitespaceCheckBox.Text = "IgnorePatternWhitespace";
            this.generaltoolTip.SetToolTip(this.ignorepatternwhitespaceCheckBox, resources.GetString("ignorepatternwhitespaceCheckBox.ToolTip"));
            this.ignorepatternwhitespaceCheckBox.UseVisualStyleBackColor = true;
            this.ignorepatternwhitespaceCheckBox.CheckedChanged += new System.EventHandler(this.ignorepatternwhitespaceCheckBox_CheckedChanged);
            // 
            // multilineCheckBox
            // 
            this.multilineCheckBox.AutoSize = true;
            this.multilineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multilineCheckBox.Location = new System.Drawing.Point(639, 106);
            this.multilineCheckBox.Name = "multilineCheckBox";
            this.multilineCheckBox.Size = new System.Drawing.Size(64, 17);
            this.multilineCheckBox.TabIndex = 28;
            this.multilineCheckBox.Text = "Multiline";
            this.generaltoolTip.SetToolTip(this.multilineCheckBox, "Multiline mode.\n Changes the meaning of ^ and $ so they match at the beginning an" +
                    "d end,\n respectively, of any line, and not just the beginning and end of the ent" +
                    "ire string.\n ");
            this.multilineCheckBox.UseVisualStyleBackColor = true;
            this.multilineCheckBox.CheckedChanged += new System.EventHandler(this.multilineCheckBox_CheckedChanged);
            // 
            // righttoleftCheckBox
            // 
            this.righttoleftCheckBox.AutoSize = true;
            this.righttoleftCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.righttoleftCheckBox.Location = new System.Drawing.Point(831, 60);
            this.righttoleftCheckBox.Name = "righttoleftCheckBox";
            this.righttoleftCheckBox.Size = new System.Drawing.Size(82, 17);
            this.righttoleftCheckBox.TabIndex = 29;
            this.righttoleftCheckBox.Text = "RightToLeft";
            this.generaltoolTip.SetToolTip(this.righttoleftCheckBox, "Specifies that the search will be from right to left instead of from left to righ" +
                    "t.");
            this.righttoleftCheckBox.UseVisualStyleBackColor = true;
            this.righttoleftCheckBox.CheckedChanged += new System.EventHandler(this.righttoleftCheckBox_CheckedChanged);
            // 
            // singlelineCheckBox
            // 
            this.singlelineCheckBox.AutoSize = true;
            this.singlelineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlelineCheckBox.Location = new System.Drawing.Point(639, 83);
            this.singlelineCheckBox.Name = "singlelineCheckBox";
            this.singlelineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.singlelineCheckBox.TabIndex = 30;
            this.singlelineCheckBox.Text = "Singleline";
            this.generaltoolTip.SetToolTip(this.singlelineCheckBox, "Specifies single-line mode.\n Changes the meaning of the dot (.) so it matches eve" +
                    "ry character\n (instead of every character except \\n).");
            this.singlelineCheckBox.UseVisualStyleBackColor = true;
            this.singlelineCheckBox.CheckedChanged += new System.EventHandler(this.singlelineCheckBox_CheckedChanged);
            // 
            // expandcapturesCheckBox
            // 
            this.expandcapturesCheckBox.AutoSize = true;
            this.expandcapturesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandcapturesCheckBox.Location = new System.Drawing.Point(552, 142);
            this.expandcapturesCheckBox.Name = "expandcapturesCheckBox";
            this.expandcapturesCheckBox.Size = new System.Drawing.Size(107, 17);
            this.expandcapturesCheckBox.TabIndex = 34;
            this.expandcapturesCheckBox.Text = "Expand Captures";
            this.generaltoolTip.SetToolTip(this.expandcapturesCheckBox, "Multiline mode.\n Changes the meaning of ^ and $ so they match at the beginning an" +
                    "d end,\n respectively, of any line, and not just the beginning and end of the ent" +
                    "ire string.\n ");
            this.expandcapturesCheckBox.UseVisualStyleBackColor = true;
            this.expandcapturesCheckBox.CheckedChanged += new System.EventHandler(this.expandcapturesCheckBox_CheckedChanged);
            // 
            // expandgroupsCheckBox
            // 
            this.expandgroupsCheckBox.AutoSize = true;
            this.expandgroupsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandgroupsCheckBox.Location = new System.Drawing.Point(665, 142);
            this.expandgroupsCheckBox.Name = "expandgroupsCheckBox";
            this.expandgroupsCheckBox.Size = new System.Drawing.Size(99, 17);
            this.expandgroupsCheckBox.TabIndex = 35;
            this.expandgroupsCheckBox.Text = "Expand Groups";
            this.generaltoolTip.SetToolTip(this.expandgroupsCheckBox, "Multiline mode.\n Changes the meaning of ^ and $ so they match at the beginning an" +
                    "d end,\n respectively, of any line, and not just the beginning and end of the ent" +
                    "ire string.\n ");
            this.expandgroupsCheckBox.UseVisualStyleBackColor = true;
            this.expandgroupsCheckBox.CheckedChanged += new System.EventHandler(this.expandgroupsCheckBox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(824, 569);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(161, 24);
            this.exitButton.TabIndex = 31;
            this.exitButton.Text = "Save and Exit (Esc)";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionTextBox.Location = new System.Drawing.Point(110, 56);
            this.expressionTextBox.Multiline = true;
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.Size = new System.Drawing.Size(506, 56);
            this.expressionTextBox.TabIndex = 32;
            this.expressionTextBox.TextChanged += new System.EventHandler(this.expressionTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveExitToolStripMenuItem,
            this.exitWoSaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveExitToolStripMenuItem
            // 
            this.saveExitToolStripMenuItem.Name = "saveExitToolStripMenuItem";
            this.saveExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.saveExitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveExitToolStripMenuItem.Text = "Save && E&xit";
            this.saveExitToolStripMenuItem.Click += new System.EventHandler(this.saveExitToolStripMenuItem_Click);
            // 
            // exitWoSaveToolStripMenuItem
            // 
            this.exitWoSaveToolStripMenuItem.Name = "exitWoSaveToolStripMenuItem";
            this.exitWoSaveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitWoSaveToolStripMenuItem.Text = "Exit w/o Save";
            this.exitWoSaveToolStripMenuItem.Click += new System.EventHandler(this.exitWoSaveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // treenodeContextMenuStrip1
            // 
            this.treenodeContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyvalueStripMenuItem});
            this.treenodeContextMenuStrip1.Name = "treenodeContextMenuStrip";
            this.treenodeContextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // copyvalueStripMenuItem
            // 
            this.copyvalueStripMenuItem.Name = "copyvalueStripMenuItem";
            this.copyvalueStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyvalueStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyvalueStripMenuItem.Text = "Copy Value";
            this.copyvalueStripMenuItem.Click += new System.EventHandler(CopyToClipboard_Command);
            // 
            // MainForm
            // 
            this.AcceptButton = this.historyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(985, 594);
            this.Controls.Add(this.expandgroupsCheckBox);
            this.Controls.Add(this.expandcapturesCheckBox);
            this.Controls.Add(this.expressionTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.singlelineCheckBox);
            this.Controls.Add(this.righttoleftCheckBox);
            this.Controls.Add(this.multilineCheckBox);
            this.Controls.Add(this.ignorepatternwhitespaceCheckBox);
            this.Controls.Add(this.ecmascriptCheckBox);
            this.Controls.Add(this.cultureinvariantCheckBox);
            this.Controls.Add(this.compiledCheckBox);
            this.Controls.Add(this.explicitcaptureCheckBox);
            this.Controls.Add(this.replacetextTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ignorecaseCheckBox);
            this.Controls.Add(this.clearallButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.digitButton);
            this.Controls.Add(this.startcharacterButton);
            this.Controls.Add(this.plussignButton);
            this.Controls.Add(this.periodButton);
            this.Controls.Add(this.nonwordcharacterButton);
            this.Controls.Add(this.wordcharacterButton);
            this.Controls.Add(this.dollarsignButton);
            this.Controls.Add(this.caretButton);
            this.Controls.Add(this.MatchesTreeView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReplaceDelegateTextBox);
            this.Controls.Add(this.replaceresultsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expressionComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Regex FreeTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.treenodeContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox expressionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox replaceresultsTextBox;
        private System.Windows.Forms.TextBox ReplaceDelegateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView MatchesTreeView;
        private System.Windows.Forms.Button caretButton;
        private System.Windows.Forms.Button dollarsignButton;
        private System.Windows.Forms.Button wordcharacterButton;
        private System.Windows.Forms.Button nonwordcharacterButton;
        private System.Windows.Forms.Button periodButton;
        private System.Windows.Forms.Button plussignButton;
        private System.Windows.Forms.Button startcharacterButton;
        private System.Windows.Forms.Button digitButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button clearallButton;
        private System.Windows.Forms.CheckBox ignorecaseCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox replacetextTextBox;
        private System.Windows.Forms.CheckBox explicitcaptureCheckBox;
        private System.Windows.Forms.CheckBox compiledCheckBox;
        private System.Windows.Forms.CheckBox cultureinvariantCheckBox;
        private System.Windows.Forms.CheckBox ecmascriptCheckBox;
        private System.Windows.Forms.CheckBox ignorepatternwhitespaceCheckBox;
        private System.Windows.Forms.CheckBox multilineCheckBox;
        private System.Windows.Forms.CheckBox righttoleftCheckBox;
        private System.Windows.Forms.CheckBox singlelineCheckBox;
        private System.Windows.Forms.ToolTip generaltoolTip;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox expressionTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWoSaveToolStripMenuItem;
        private System.Windows.Forms.CheckBox expandcapturesCheckBox;
        private System.Windows.Forms.CheckBox expandgroupsCheckBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip treenodeContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyvalueStripMenuItem;
    }
}

