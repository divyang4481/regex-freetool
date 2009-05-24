//This Code is released under the full GPL license available here: http://www.gnu.org/licenses/gpl.html
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace RegEx
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ConfigurationFile configFile = ConfigurationFile.Load();
            m_ExpressionList = configFile.ExpressionList;
            expressionComboBox.DataSource = m_ExpressionList;
            dataTextBox.Text = configFile.CurrentTestData;
            expressionTextBox.Text = configFile.CurrentExpression;
            replacetextTextBox.Text = configFile.CurrentReplacementText;

            UpdateRegExDisplay();
        }
        private List<string> m_ExpressionList;

        public List<string> ExpressionList
        {
            get { return m_ExpressionList; }
            set { m_ExpressionList = value; }
        }

        private void MatchesTreeView_Click(object sender, MouseEventArgs args)
        {
            if (args.Button == MouseButtons.Right)
            {
                TreeNode node = MatchesTreeView.GetNodeAt(args.X, args.Y);
                MatchesTreeView.SelectedNode = node;
            }
        }

        private void CopyToClipboard_Command(object sender, EventArgs args)
        {
            string nodeValue = MatchesTreeView.SelectedNode.Text;
            if (nodeValue.IndexOf("[", 3) > 0 && nodeValue.LastIndexOf("]") > nodeValue.IndexOf("[", 3))
            {
                string capturedValue = nodeValue.Substring(nodeValue.IndexOf("[", 3) + 1, (nodeValue.LastIndexOf("]") - nodeValue.IndexOf("[", 3)) - 1);
                this.Text = string.Format("[{0}]", capturedValue);
                Clipboard.SetText(capturedValue);
            }
        }

        void MatchesTreeView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Control) > 0)
                if(e.KeyCode == Keys.C)
                CopyToClipboard_Command(null, null);
        }

        private void UpdateRegExDisplay()
        {

            RegexOptions options = RegexOptions.None;
            #region Assemble Options
            if (ignorecaseCheckBox.Checked)
                options = options | RegexOptions.IgnoreCase;
            if (explicitcaptureCheckBox.Checked)
                options = options | RegexOptions.ExplicitCapture;
            if (compiledCheckBox.Checked)
                options = options | RegexOptions.Compiled;
            if (cultureinvariantCheckBox.Checked)
                options = options | RegexOptions.CultureInvariant;
            if (ecmascriptCheckBox.Checked)
                options = options | RegexOptions.ECMAScript;
            if (ignorepatternwhitespaceCheckBox.Checked)
                options = options | RegexOptions.IgnorePatternWhitespace;
            if (multilineCheckBox.Checked)
                options = options | RegexOptions.Multiline;
            if (righttoleftCheckBox.Checked)
                options = options | RegexOptions.RightToLeft;
            if (singlelineCheckBox.Checked)
                options = options | RegexOptions.Singleline;

            #endregion
            Regex regEx = null;
            try
            {
                regEx = new Regex(expressionTextBox.Text, options);
            }
            catch (Exception e)
            { 
                MatchesTreeView.Nodes.Clear();
                TreeNode matchesNode = new TreeNode("Exception");
                MatchesTreeView.Nodes.Add(matchesNode);
                TreeNode matchNode;
                matchNode = new TreeNode(string.Format("Message: {0}", e.Message));
                matchesNode.Nodes.Add(matchNode);
                matchNode = new TreeNode(string.Format("Source: {0}", e.Source));
                matchesNode.Nodes.Add(matchNode);
                matchesNode.Expand();
            }
            if (regEx == null) return;
            string sData = dataTextBox.Text;
            if (regEx.IsMatch(sData) && sData.Length > 0)
            {
                //Update Match View
                MatchesTreeView.Nodes.Clear();
                TreeNode matchesNode = new TreeNode("Matches");
                MatchesTreeView.Nodes.Add(matchesNode);
                MatchCollection Matches = regEx.Matches(sData);
                //Matches
                for(int i = 0;i < Matches.Count;i++){
                    Match match = Matches[i];
                    TreeNode matchNode = new TreeNode(string.Format("[{0}] - {1}", i, match.Value));
                    matchesNode.Nodes.Add(matchNode);

                    //Captures
                    TreeNode captureesNode = new TreeNode(string.Format("Captures ({0})", match.Captures.Count));
                    matchNode.Nodes.Add(captureesNode);
                    for (int i_pos = 0; i_pos < match.Captures.Count; i_pos++)
                    {
                        Capture capture = match.Captures[i_pos];
                        TreeNode captureNode = new TreeNode(string.Format("[{0}] - [{1}] ({2} chars)", i_pos, capture.Value, capture.Value.Length));
                        captureNode.ContextMenuStrip = this.treenodeContextMenuStrip1;
                        captureesNode.Nodes.Add(captureNode);
                    }

                    //Groups
                    TreeNode groupesNode = new TreeNode(string.Format("Groups ({0})", match.Groups.Count));
                    matchNode.Nodes.Add(groupesNode);
                    for (int i_pos = 0; i_pos < match.Groups.Count; i_pos++)
                    {
                        Group group = match.Groups[i_pos];
                        string groupName = regEx.GroupNameFromNumber(i_pos);
                        if (groupName != i_pos.ToString())
                            groupName = string.Format("<{0}>", groupName);
                        else
                            groupName = string.Empty;

                        TreeNode groupNode = new TreeNode(string.Format("[{0}]{1} - [{2}] ({3} chars)", i_pos, groupName, group.Value, group.Value.Length));
                        groupNode.ContextMenuStrip = this.treenodeContextMenuStrip1;
                        groupesNode.Nodes.Add(groupNode);
                    }

                    if (expandcapturesCheckBox.Checked) captureesNode.Expand();
                    if (expandgroupsCheckBox.Checked) groupesNode.Expand();
                    matchNode.Expand();
                }
                matchesNode.Expand();

                //Update Replace View
                replaceresultsTextBox.Text = "";
                if(ReplaceDelegateTextBox.Text == "")
                {
                    replaceresultsTextBox.Text = regEx.Replace(sData, replacetextTextBox.Text);
                }
            }
            else
            {
                MatchesTreeView.Nodes.Clear();
                MatchesTreeView.Nodes.Add("No Matches");
            }
        }

        private void expressionTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }

        private void expressionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_dataBinding)
            {
                expressionTextBox.Text = expressionComboBox.SelectedValue.ToString();
                UpdateRegExDisplay();
            }
        }

        private void DataTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }

        private void ReplaceDelegateTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }

        private void expandcapturesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }

        private void expandgroupsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }

        private void clearallButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.Text = "";
            ignorecaseCheckBox.Checked = false;
            dataTextBox.Text = "";
            replacetextTextBox.Text = "";
            ReplaceDelegateTextBox.Text = "";
            //UpdateRegExDisplay();
        }

        private void replacetextTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            SaveCurrentExpressionToHistory(true);
        }

        private void expressionComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SaveCurrentExpressionToHistory(true);
            }
        }

        public void SaveCurrentExpressionToHistory(bool saveToFile)
        {
            ExpressionList.Insert(0, expressionTextBox.Text);
            m_dataBinding = true;
            expressionComboBox.DataSource = null;
            expressionComboBox.DataSource = m_ExpressionList;
            m_dataBinding = false;
        }
        private bool m_dataBinding = false;

        private void exitButton_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }

        #region Regex Option Checkbox Events
        private void ignorecaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }
        private void explicitcaptureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enforce this option's rules to avoid exceptions
            if (explicitcaptureCheckBox.Checked)
                ecmascriptCheckBox.Checked = false;
            UpdateRegExDisplay();
        }

        private void ecmascriptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enforce this option's rules to avoid exceptions
            if (ecmascriptCheckBox.Checked)
            {
                explicitcaptureCheckBox.Checked = false;
                cultureinvariantCheckBox.Checked = false;
                ignorepatternwhitespaceCheckBox.Checked = false;
                righttoleftCheckBox.Checked = false;
                singlelineCheckBox.Checked = false;
            }
        }

        private void multilineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }

        private void singlelineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enforce this option's rules to avoid exceptions
            if (singlelineCheckBox.Checked)
                ecmascriptCheckBox.Checked = false;
            UpdateRegExDisplay();
        }

        private void righttoleftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enforce this option's rules to avoid exceptions
            if (righttoleftCheckBox.Checked)
                ecmascriptCheckBox.Checked = false;
            UpdateRegExDisplay();
        }

        private void ignorepatternwhitespaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enforce this option's rules to avoid exceptions
            if (ignorepatternwhitespaceCheckBox.Checked)
                ecmascriptCheckBox.Checked = false;
            UpdateRegExDisplay();
        }

        private void cultureinvariantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enforce this option's rules to avoid exceptions
            if (cultureinvariantCheckBox.Checked)
                ecmascriptCheckBox.Checked = false;
            UpdateRegExDisplay();
        }

        private void compiledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRegExDisplay();
        }
        #endregion

        #region Letter Insertion Events
        private void caretButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = "^";
        }

        private void wordcharacterButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = "\\w";
        }

        private void nonwordcharacterButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = "\\W";
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = "\\d";
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = ".";
        }

        private void plussignButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = "+";
        }

        private void startcharacterButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = "*";
        }

        private void dollarsignButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.SelectedText = "$";
        }
        #endregion

        private void saveExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }
        private void Save()
        {
            ConfigurationFile configFile = new ConfigurationFile();
            configFile.ExpressionList = m_ExpressionList;
            configFile.CurrentExpression = expressionTextBox.Text;
            configFile.CurrentReplacementText = replacetextTextBox.Text;
            configFile.CurrentTestData = dataTextBox.Text;
            configFile.Save();
        }
        private void Exit()
        {
            Application.Exit();
        }
        private void SaveAndExit()
        {
            Save();
            Exit();
        }

        private void exitWoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software was created by Crispin Botticelli to be a free tool for testing Regular Expressions.\n", "About RegEx FreeTool", MessageBoxButtons.OK);
            
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
			//This Code is released under the full GPL license available here: http://www.gnu.org/licenses/gpl.html
            MessageBox.Show("This software is released under the full GPL license available here: http://www.gnu.org/licenses/gpl.html.\n", "Lecense for RegEx FreeTool", MessageBoxButtons.OK);

        }
    }

    [Serializable]
    public class ConfigurationFile
    {
        private List<string> m_ExpressionList;
        private string m_CurrentExpression;
        private string m_CurrentReplacementText;
        private string m_CurrentTestData;

        public List<string> ExpressionList
        {
            get { return m_ExpressionList; }
            set { m_ExpressionList = value; }
        }
        public string CurrentExpression
        {
            get { return m_CurrentExpression; }
            set { m_CurrentExpression = value; }
        }
        public string CurrentReplacementText
        {
            get { return m_CurrentReplacementText; }
            set { m_CurrentReplacementText = value; }
        }
        public string CurrentTestData
        {
            get { return m_CurrentTestData; }
            set { m_CurrentTestData = value; }
        }

        const string CFG_FILE_NAME = "RegExTester.cfg";
        public static ConfigurationFile Load()
        {
            ConfigurationFile config = null;
            if(File.Exists(CFG_FILE_NAME)){
                BinaryFormatter serializer = new BinaryFormatter();
                FileStream configStream = File.OpenRead(CFG_FILE_NAME);
                if (configStream != null)
                {
                    try
                    {
                        config = (ConfigurationFile)serializer.Deserialize(configStream);
                    }
                    catch (Exception e) { }
                    configStream.Close();
                }
            }
            if(config == null){
                config = new ConfigurationFile();
                config.ExpressionList = new List<string>();
                config.ExpressionList.Add("</?a ?href=\"(?<url>((?<protocal>[\\w]{4})://)?(?<domain>[^<>\"/]*)[/\\w]*)[^\"]+\">");
                config.CurrentExpression = "</?a ?href=\"(?<url>((?<protocal>[\\w]{4})://)?(?<domain>[^<>\"/]*)[/\\w]*)[^\"]+\">";
                config.CurrentTestData = "<a href=\"http://code.google.com/p/regex-freetool/\">Regex FreeTool</a>\r\n<a href=\"http://code.google.com/p/regex-freetool/downloads/list\">Regex FreeTool Downloads</a>\r\n<a href=\"http://code.google.com/p/regex-freetool/w/list\">Regex FreeTool Wiki</a>";
                config.CurrentReplacementText = "<a href=\"http://www.google.com\">";
            }
            return config;
        }

        public void Save()
        {
            BinaryFormatter serializer = new BinaryFormatter();
            FileStream configStream;

            if (File.Exists(CFG_FILE_NAME))
            {
                configStream = File.OpenWrite(CFG_FILE_NAME);
            }
            else
            {
                configStream = File.Create(CFG_FILE_NAME);
            }
            if (configStream != null)
            {
                serializer.Serialize(configStream, this);
                configStream.Flush();
                configStream.Close();
            }
        }

    }
}
