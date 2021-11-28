#nullable enable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Lab_8_Ex_1_var_23
{
    public class Values
    {
        public Values(string name, double rate)
        {
            Name = name;
            Rate = rate;
        }
        public string Name { get; }

        public double Rate { get; }
    }
    
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, Values> _exchange = new Dictionary<string, Values>();

        private bool _buttonReplacePush = false;
        //private double ValueBox1 = 0, ValueBox2 = 0;
        void AddToCombobox(string cc, string txt)
        {
            var comboboxItem = cc/* + ' ' + txt*/;
            ValueCC1.Items.Add(comboboxItem!);
            ValueCC2.Items.Add(comboboxItem!);
        }
        public Form1()
        {
            InitializeComponent();
            const string urlString = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchangenew";
            const string file = "exchanger.xml";
            

            var reader = new XmlTextReader(urlString);
            if (reader.HasValue)
            {
                StreamWriter sw = new StreamWriter(file);
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            sw.Write("<" + reader.Name);
                            while (reader.MoveToNextAttribute())
                                sw.Write(" " + reader.Name + "='" + reader.Value + "-");
                            //sw.Write(">");
                            sw.Write(">");
                            break;
                        case XmlNodeType.Text:
                            sw.Write(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            sw.Write("</" + reader.Name);
                            sw.Write(">");
                            break;
                    }
                }

                sw.Close();
            }
            
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(file);
            var xRoot = xmlDocument.DocumentElement;
            if (xRoot != null)
            {
                string cc = "null", txt = "null";
                double rate = 0;
                foreach (XmlElement xNode in xRoot)
                {
                    foreach (XmlNode childNode in xNode.ChildNodes)
                    {
                        if (childNode.Name == "cc") cc = childNode.InnerText;
                        else if (childNode.Name == "txt") txt = childNode.InnerText;
                        else if (childNode.Name == "rate") 
                            rate = double.Parse(childNode.InnerText, NumberStyles.Any, CultureInfo.InvariantCulture);
                    }
                    //MessageBox.Show($"cc: {cc} \ttxt: {txt} \trate: {rate}");
                    _exchange?.Add(cc, new Values(txt, rate));
                    AddToCombobox(cc,txt);
                }
            }

            _exchange?.Add("UAH",new Values("Українська гривня" , 1));
            AddToCombobox("UAH","Українська гривня");
            ValueCC1.Size = ValueCC2.Size = Value1_text.Size = Value2_text.Size = new Size(130, 40);
            Value1_text.Enabled = ReplaceButton.Enabled = false;
            label5.Text = label6.Text = "";
        }
        
        private new void KeyPress(object sender, KeyPressEventArgs e, Control textBox)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar is ',' or '.' || e.KeyChar == 8)
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if ((textBox.Text.Length <= 0 && e.KeyChar == ',') || textBox.Text.Contains(",") && e.KeyChar == ',') e.Handled = true;
                 else e.Handled = false;
            }
            else e.Handled = true;
        }

        private void Value1_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(sender, e, Value1_text);
        }


        private void Value2_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(sender, e, Value2_text);
        }

        private void SelectedIndexChanged(ComboBox comboBox, Label label, object sender, EventArgs e)
        {
            if (ValueCC1.SelectedIndex != -1 && ValueCC2.SelectedIndex != -1) {
                Value1_text.Enabled = true;
                ReplaceButton.Enabled = true;
            }
            label.Text = _exchange[comboBox.SelectedItem.ToString()].Name;
            
            if (ValueCC1.SelectedIndex != CC1_previous && ValueCC1.SelectedIndex != CC2_previous)
            {
                Value1_text_TextChanged(sender,e);
            }
        }

        private int CC1_previous = -1, CC2_previous = -1;
        private void ValueCC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(ValueCC1, label5, sender, e);
            
        }

        private void ValueCC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(ValueCC2, label6, sender, e);
           
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            CC1_previous = ValueCC1.SelectedIndex;
            CC2_previous = ValueCC2.SelectedIndex;
            (ValueCC1.SelectedIndex, ValueCC2.SelectedIndex) = (ValueCC2.SelectedIndex, ValueCC1.SelectedIndex);
            Value1_text.Text = Value2_text.Text;
            
            Value1_text_TextChanged(sender, e);
        }

        private void Value1_text_TextChanged(object sender, EventArgs e)
        {
            if (Value1_text.Text.Length != decimal.Zero)
            {
                try
                {
                    var value1Double = double.Parse(Value1_text.Text);
                    double toUAH = value1Double * _exchange[ValueCC1.SelectedItem.ToString()].Rate;
                    double toOtherValue = toUAH / _exchange[ValueCC2.SelectedItem.ToString()].Rate;
                    Value2_text.Text = String.Format("{0:f}",toOtherValue);
                    //MessageBox.Show(toOtherValue.ToString());
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}