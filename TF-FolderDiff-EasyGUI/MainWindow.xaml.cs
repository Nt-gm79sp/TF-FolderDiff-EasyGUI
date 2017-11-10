using System.Windows;
using System.Windows.Forms;

namespace TF_FolderDiff_EasyGUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isRecursive = true;
        string strRecursive = " /recursive";
        bool isFiltered = true;
        string strFiltered = @" /filter:!bin\;!bld\;!ClientBin\;!Debug\;!obj\;!AppPackages\;!Release\;!TestResults\;!*.*~;!*.appx;!*.appxrecipe;!*.cache;!*.cer;!*.dbmdl;!*.dll;!*.docstates;!*.docstates.suo;!*.err;!*.exe;!*.ilk;!*.ipch;!*.lastbuildstate;!*.lce;!*.ldf;!*.lib;!*.log;!*.mdf;!*.msscci;!*.ncb;!*.obj;!*.opensdf;!*.pch;!*.pdb;!*.pri;!*.res;!*.resources;!*.sdf;!*.suo;!*.swp;!*.temp;!*.tfOrig*;!*.tlog;!*.tmp;!*.trx;!*.user;!*.unsuccessfulbuild;!*.v11.suo;!*.vcxproj.user;!*.vsix;!*.vsmdi;!*.vspscc;!*.vssettings;!*.vssscc;!*.wrn;!*.xap;!.metadata\";
        bool isShowSame = false;
        string strShowSame = " /view:same,different,sourceOnly,targetOnly";
        string strDontShowSame = " /view:different,sourceOnly,targetOnly";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(textBox0.Text, textBoxLine.Text);
        }

        private void buttonGetLine_Click(object sender, RoutedEventArgs e)
        {
            textBoxLine.Text = "folderdiff" +
                                " \"" + textBox1.Text + "\"" +
                                " \"" + textBox2.Text + "\"" +
                                (isRecursive ? strRecursive : "") +
                                (isFiltered ? strFiltered : "") +
                                (isShowSame ? strShowSame : strDontShowSame);
        }

        private void buttonOpen1_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = folderDialog.SelectedPath;
            }
        }

        private void buttonOpen2_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = folderDialog.SelectedPath;
            }
        }

        private void buttonOpen0_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox0.Text = folderDialog.SelectedPath + "\\TF.exe";
            }
        }

        private void checkBox_Recursive_Checked(object sender, RoutedEventArgs e)
        {
            isRecursive = true;
        }

        private void checkBox_Recursive_Unchecked(object sender, RoutedEventArgs e)
        {
            isRecursive = false;
        }

        private void checkBox_IsFiltered_Checked(object sender, RoutedEventArgs e)
        {
            isFiltered = true;
        }

        private void checkBox_IsFiltered_Unchecked(object sender, RoutedEventArgs e)
        {
            isFiltered = false;
        }

        private void checkBox_IsShowSame_Checked(object sender, RoutedEventArgs e)
        {
            isShowSame = true;
        }

        private void checkBox_IsShowSame_Unchecked(object sender, RoutedEventArgs e)
        {
            isShowSame = false;
        }
    }
}
