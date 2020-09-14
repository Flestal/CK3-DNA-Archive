using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ckdnasave
{
    public partial class Form1 : Form
    {
        RegistryKey reg = Registry.CurrentUser;
        string val;
        DirectoryInfo dir;
        //string[,] list;
        Dictionary<string, string> dic = new Dictionary<string, string>();
        Dictionary<string, string> dic_img = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            reg = reg.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders",false);
            val = Convert.ToString(reg.GetValue("Personal"));
            val += "\\CK_DNA";
            dir = new DirectoryInfo(val);
            if (!dir.Exists)
            {
                dir.Create();
            }
            try 
            {
                StreamReader SR = new StreamReader(val + "\\CK_DNA.csv");
                string line;
                char sp = ',';
                short i = 0;
                while ((line = SR.ReadLine()) != null)
                {
                    string[] namecode = line.Split(sp);
                    dic.Add(namecode[0],namecode[1]);
                    if (namecode[2] != null) dic_img.Add(namecode[0], namecode[2]);
                    //dna_list.Items.Add(namecode[0]);
                }
                SR.Close();
                list_refresh();
            }
            catch
            {
                StreamWriter SW = File.CreateText(val+"\\CK_DNA.csv");
                SW.Write("");
                SW.Close();
            }
        }

        private void dna_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = Convert.ToString(dna_list.SelectedItem);
            if (key != "")
            {
                DNA_CODE.Text = dic[key];
                copy_clipboard(DNA_CODE.Text);
                if (dic_img[key]!="") btn_image.Enabled = true;
                else btn_image.Enabled = false;
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            list_refresh(true);
        }

        void list_refresh(bool isSearch=false)
        {
            dna_list.Items.Clear();
            foreach(string key in dic.Keys)
            {
                if (isSearch&&(search.Text != "" && !key.Contains(search.Text))) continue;
                dna_list.Items.Add(key);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }
        void save()
        {
            
            string str = "";
            foreach (KeyValuePair<string, string> item in dic)
            {
                str += item.Key + "," + item.Value + ",";
                if (dic_img.ContainsKey(item.Key))
                {
                    str += dic_img[item.Key];
                }
                if (!(item.Key == dic.Last().Key))
                {
                    str += "\n";
                }
            }
            
            DirectoryInfo[] Cinfo = dir.GetDirectories();
            foreach (DirectoryInfo Cdir in Cinfo)
            {
                if (!(dic_img.ContainsKey(Cdir.Name) && dic_img[Cdir.Name] != ""))
                {
                    Cdir.Delete(true);
                }
            }
            File.WriteAllText(val + "\\CK_DNA.csv", str,Encoding.UTF8);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dic.Clear();
            dic_img.Clear();
            StreamReader SR = new StreamReader(val + "\\CK_DNA.csv");
            string line;
            char sp = ',';
            short i = 0;
            while ((line = SR.ReadLine()) != null)
            {
                string[] namecode = line.Split(sp);
                dic.Add(namecode[0], namecode[1]);
                if (namecode[2] != null) dic_img.Add(namecode[0], namecode[2]);
            }
            SR.Close();
            list_refresh();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            copy_clipboard(DNA_CODE.Text);
        }
        void copy_clipboard(string str)
        {
            Clipboard.SetText(str);
        }
        string paste_clipboard()
        {
            return Clipboard.GetText();
        }

        private void btn_dnaRmv_Click(object sender, EventArgs e)
        {
            dic.Remove(Convert.ToString(dna_list.SelectedItem));
            dic_img.Remove(Convert.ToString(dna_list.SelectedItem));
            list_refresh();
        }

        private void btn_dnaAdd_Click(object sender, EventArgs e)
        {
            dna_add_log.Text = "";
            if (dna_name_edit.Text!=""&&DNA_CODE_EDIT.Text!="")
            {
                bool isOnly = true;
                foreach(string key in dic.Keys)
                {
                    if (key == dna_name_edit.Text) isOnly = false;
                }
                if (isOnly)
                {
                    if (!(dna_name_edit.Text.Contains(",")||DNA_CODE_EDIT.Text.Contains(",")))
                    {
                        dic.Add(dna_name_edit.Text, DNA_CODE_EDIT.Text);
                        dna_add_log.Text = "DNA 목록에 추가되었습니다.";
                        
                        if (dna_add_img.Text!="")
                        {
                            string src = val + "\\" +dna_name_edit.Text;
                            //dna_add_log.Text += src;
                            DirectoryInfo di = new DirectoryInfo(src);
                            if (!di.Exists)
                            {
                                di.Create();
                            }
                            dna_img_preview.Image.Save(src + "\\image.jpg");
                            dic_img.Add(dna_name_edit.Text,src+"\\image.jpg");
                            dna_add_img.Text = "";
                            dna_img_preview.Image = null;
                            //dna_add_log.Text += dic_img[dna_name_edit.Text];
                        }
                        else
                        {
                            dic_img.Add(dna_name_edit.Text, "");
                        }
                        dna_name_edit.Text = "";
                        DNA_CODE_EDIT.Text = "";
                    }
                    else
                    {
                        dna_add_log.Text = "쉼표는 입력할 수 없습니다.";
                    }
                }
                else
                {
                    dna_add_log.Text = "중복되는 이름이 있습니다.";
                    dna_name_edit.Text = "";
                }
            }
            else
            {
                dna_add_log.Text = "이름이나 코드가 비어 있습니다.";
            }
            save();
            list_refresh();
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            DNA_CODE_EDIT.Text = paste_clipboard();
        }

        private void DNA_CODE_EDIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                list_refresh(true);
            }
        }

        private void btn_img_add_Click(object sender, EventArgs e)
        {
            dna_add_img.Text = "";
            string initial = Convert.ToString(reg.GetValue("Desktop"));
            openFileDialog1.InitialDirectory = initial;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dna_add_img.Text = openFileDialog1.FileName;
                dna_img_preview.Load(dna_add_img.Text);
            }
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            string key = Convert.ToString(dna_list.SelectedItem);
            Form_ImagePopup img = new Form_ImagePopup(dic_img[key]);
            img.Owner = this;
            img.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gall.dcinside.com/mgallery/board/view/?id=crusaderkings&no=44759");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gall.dcinside.com/mgallery/board/lists/?id=crusaderkings&search_head=100");
        }

        private void btn_saveFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Convert.ToString(reg.GetValue("Personal"))+ "\\Paradox Interactive\\Crusader Kings III\\save games");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(val);
        }
    }
}
