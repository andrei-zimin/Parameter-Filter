using Lab4.Fields;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public class FilterControl
    {
        Control parent;
        List<Field> fields;

        public FilterControl(Control parent, List<Field> fields)
        {
            this.parent = parent;
            this.fields = fields;
        }

        public void Build()
        {
            int y = 27;
            int yPanel = 30;

            for (int i = 0; i < fields.Count; i++)
            {

                Label label1 = new Label();
                TextBox textBox1 = new TextBox();
                CheckBox checkBox1 = new CheckBox();
                RadioButton radioButton1 = new RadioButton();
                RadioButton radioButton2 = new RadioButton();
                RadioButton radioButton3 = new RadioButton();
                RadioButton radioButton4 = new RadioButton();
                Panel panel1 = new Panel();

                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(20, y);
                label1.Name = "label" + i;
                label1.Size = new System.Drawing.Size(35, 13);
                label1.Text = fields[i].Name;
              
                textBox1.Location = new System.Drawing.Point(120, y);
                textBox1.Name = "textBox" + i;
                textBox1.Size = new System.Drawing.Size(100, 20);
              
                checkBox1.AutoSize = true;
                checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
                checkBox1.Location = new System.Drawing.Point(230, y);
                checkBox1.Name = "checkBox" + i;
                checkBox1.Size = new System.Drawing.Size(80, 17);
                checkBox1.Text = "нет";
                checkBox1.UseVisualStyleBackColor = true;
             
                radioButton1.AutoSize = true;
                radioButton1.Location = new System.Drawing.Point(279, y);
                radioButton1.Name = "radioButton" + i + "1";
                radioButton1.Size = new System.Drawing.Size(85, 17);
                radioButton1.Text = "=";
                radioButton1.Tag = LogExpEnum.Equal;
                radioButton1.UseVisualStyleBackColor = true;
               
                radioButton2.AutoSize = true;
                radioButton2.Location = new System.Drawing.Point(320, y);
                radioButton2.Name = "radioButton" + i + "2";
                radioButton2.Size = new System.Drawing.Size(85, 17);
                radioButton2.Text = "!=";
                radioButton2.Tag = LogExpEnum.NoEqual;
                radioButton2.UseVisualStyleBackColor = true;

                radioButton4.AutoSize = true;
                radioButton4.Location = new System.Drawing.Point(370, y);
                radioButton4.Name = "radioButton" + i + "4";
                radioButton4.Size = new System.Drawing.Size(85, 17);
                if (fields[i].Type == typeof(string))
                {
                    radioButton4.Text = "Содержит";
                    radioButton4.Tag = LogExpEnum.Contains;
                }
                else
                {
                    radioButton4.Text = "<";
                    radioButton4.Tag = LogExpEnum.Less;
                }
                radioButton4.UseVisualStyleBackColor = true;

                radioButton3.AutoSize = true;
                radioButton3.Location = new System.Drawing.Point(470, y);
                radioButton3.Name = "radioButton"+i+"3";
                radioButton3.Size = new System.Drawing.Size(85, 17);
                if (fields[i].Type == typeof(string))
                {
                    radioButton3.Text = "Не содержит";
                    radioButton3.Tag = LogExpEnum.NoContains;
                }
                else
                {
                    radioButton3.Text = ">";
                    radioButton3.Tag = LogExpEnum.More;
                }
                radioButton3.UseVisualStyleBackColor = true;
                
                panel1.Controls.Add(textBox1);
                panel1.Controls.Add(radioButton3);
                panel1.Controls.Add(label1);
                panel1.Controls.Add(radioButton4);
                panel1.Controls.Add(checkBox1);
                panel1.Controls.Add(radioButton2);
                panel1.Controls.Add(radioButton1);
                panel1.Location = new System.Drawing.Point(33, yPanel);
                panel1.Name = "panel" + i;
                panel1.Size = new System.Drawing.Size(675, 50);

                parent.Controls.Add(panel1);

                checkBox1.Checked = true;

                yPanel += 50;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            Panel panel = checkBox.Parent as Panel;

            foreach (Control item in panel.Controls)
            {
                if (item is CheckBox)
                    continue;

                item.Enabled = !checkBox.Checked;
            }
        }

        public List<BaseRule> ApplyFilters()
        {
            List<BaseRule> rules = new List<BaseRule>();
            LogExpFactory expFactory = new LogExpFactory();

            int index = 0;

            for (int i = 0; i < parent.Controls.Count; i++)
            {
                if (!(parent.Controls[i] is Panel))
                    continue;

                Panel panel = (Panel)parent.Controls[i];

                bool check = false;
                string text = string.Empty;

                foreach (var item in panel.Controls)
                {
                    if (item is CheckBox checkBox)
                    {
                        check = checkBox.Checked;
                        if (check)
                            break;
                    }
                    else if (item is TextBox textBox)
                        text = textBox.Text;
                }

                if (!check)
                {
                    RadioButton radioButton = panel.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked);
                    LogExpEnum logExpEnum = (LogExpEnum)radioButton.Tag;
                   
                    BaseRule rule = fields[index].CreateRule();
                    if (fields[index].Type == typeof(string))
                    {
                        rule.SetExp(expFactory.Create<string>(logExpEnum));
                        rule.SetValue(text);
                    }
                    else if (fields[index].Type == typeof(int))
                    {
                        rule.SetExp(expFactory.Create<int>(logExpEnum));
                        rule.SetValue(int.Parse(text));
                    }
                    else if (fields[index].Type == typeof(DateTime))
                    {
                        rule.SetExp(expFactory.Create<DateTime>(logExpEnum));
                        rule.SetValue(DateTime.Parse(text));
                    }
                    
                    rules.Add(rule);
                }

                index++;
            }

            return rules;
        }
    }
}
