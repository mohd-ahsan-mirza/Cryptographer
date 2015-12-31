using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleAppForTranslator;
using System.Threading;
using System.Text.RegularExpressions;

namespace Cryptographer
{
    public partial class Form1 : Form
    {
        private Dictionary<String, String> TranslationGuide=null;
        private ToolTip errorMessages=new ToolTip();
        private List<String> KeysAdded = new List<String>();

        public Form1()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 0;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 0;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.remove_last, "Removes the last key and value");
            toolTip.SetToolTip(this.maxLength, "Numerics only. Min 5 and Max 52. Default is 5");
            toolTip.SetToolTip(this.encryptionChars, "Alphabets only.Any other characters or repeated letters will be ignored");
            toolTip.SetToolTip(this.keys, "Encrypted (Only letters)");
            toolTip.SetToolTip(this.values, "Decrypted (Only letters and numerics");
            toolTip.SetToolTip(this.resetAll, "Resets everything");

           
            
        }

        private void resetErrors()
        {
            label1.ForeColor = label7.ForeColor = label8.ForeColor = Color.Black;
            errorMessages.RemoveAll();
        }

        private bool originalTextLengthChecker()
        {
            
            if (original.TextLength == 0)
            {
                label1.ForeColor = Color.Red;
                errorMessages.SetToolTip(label1, "Textbox can't be empty");
                return false;
            }
            else
                return true;

        }


        private void Encrypt_Click(object sender, EventArgs e)
        {
            this.resetErrors();
            TranslationGuide = null;
            this.KeysAdded = new List<String>();
            this.encryptedString.Clear();
            this.decryptedString.Clear();
            this.keys.ReadOnly = true;
            this.values.ReadOnly = true;
            
            if(this.originalTextLengthChecker())
            {
                ConsoleAppForTranslator.Encoder encoder;

                if (encryptionChars.TextLength != 0)
                    encryptionChars.Text.Distinct().Select(c => c.ToString()).ToList()
                        .ForEach(c =>
                        {
                            while (encryptionChars.Text.Contains(c + c))
                                encryptionChars.Text = encryptionChars.Text.Replace(c + c, c);
                        }
                  );


                if (this.maxLength.TextLength != 0 && maxLength.Text.All(Char.IsDigit))
                {
                    encoder = new ConsoleAppForTranslator.Encoder(original.Text, Int32.Parse(maxLength.Text), 
                        encryptionChars.Text);
                }
                else
                    encoder = new ConsoleAppForTranslator.Encoder(original.Text, encryption: encryptionChars.Text);
            
                this.TranslationGuide = encoder.getTranslationGuide();
                this.encryptedString.Text = encoder.startEncryption();

            }
        }
        private void startDecryption_Click(object sender, EventArgs e)
        {
            this.resetErrors();
            this.decryptedString.Clear();
            this.originalTextLengthChecker();

            if (this.TranslationGuide!=null)
            {
                ConsoleAppForTranslator.Decoder decoder = new ConsoleAppForTranslator.Decoder(TranslationGuide, this.original.Text);

                this.decryptedString.Text = decoder.startDecoding();
            }
            else
                this.keyAndValuesInitialChecker();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetAll_Click(object sender, EventArgs e)
        {
            this.resetErrors();

            TranslationGuide = null;
            this.KeysAdded = new List<string>();
            this.maxLength.Clear();
            this.encryptionChars.Clear();
            this.keys.Clear();
            this.values.Clear();
            this.original.Clear();
            this.encryptedString.Clear();
            this.decryptedString.Clear();
            this.keys.ReadOnly = false;
            this.values.ReadOnly = false;
        }

        private void original_TextChanged(object sender, EventArgs e)
        {
            this.encryptedString.Clear();
            this.decryptedString.Clear();
            this.maxLength.Clear();
            this.encryptionChars.Clear();
            this.keys.ReadOnly = false;
            this.values.ReadOnly = false;
        }


        private void remove_last_Click(object sender, EventArgs e)
        {
            this.resetErrors();

            if (TranslationGuide != null)
            {
                if (TranslationGuide.Count == 0)
                {
                    TranslationGuide = null;
                    this.values.Text = "";
                    this.keys.Text = "";
                }
                else
                {
                    this.keys.Text = this.KeysAdded.ElementAt(this.KeysAdded.Count - 1);
                    String temp;
                    this.TranslationGuide.TryGetValue(keys.Text, out temp);
                    this.values.Text = temp;
                    this.TranslationGuide.Remove(this.keys.Text);
                    this.KeysAdded.RemoveAt(this.KeysAdded.Count - 1);
                }
            }

            
           
        }

        private bool keyAndValuesInitialChecker()
        {
            if (keys.TextLength == 0 || values.TextLength == 0)
            {
                if (keys.TextLength == 0)
                {
                    label7Change("Encrypted key can't be empty");
                }
                if (values.TextLength == 0)
                {
                    label8Change("Decrypted value can't be empty");
                }


                return false;
            }
            else
                return true;
        }

        private bool label7Change(String message)
        {
            keys.Clear();
            label7.ForeColor = Color.Red;
            this.errorMessages.SetToolTip(label7,message);
            return false;
        }

        private bool label8Change(String message)
        {
            values.Clear();
            label8.ForeColor = Color.Red;
            this.errorMessages.SetToolTip(label8,message);
            return false;
        }

        private bool fullKeyandValueChecker()
        {
            if (!values.Text.All(Char.IsLetterOrDigit))
                return label8Change("Decrypted value can't have any characters except alphabets and numerics");
            else
            {
                if (!keys.Text.All(Char.IsLetter))
                    return label7Change("Encrypted key can only have letters in them");
                else
                {
                    if(TranslationGuide.Values.Contains(this.values.Text))
                        return label8Change("Value already exists");
                    else
                    {
                        if(TranslationGuide.Keys.Contains(this.keys.Text))
                            return label7Change("Key already exists");
                        else
                        {
                            //if (TranslationGuide.Keys.Any(X => Regex.IsMatch(X, this.keys.Text) /*|| Regex.IsMatch(this.keys.Text, X)*/))
                                //return label7Change("Key not unique enough");
                            //else
                                return true;
                        }
                    }
                }
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            this.resetErrors();

            if (TranslationGuide != null)
            {
                if(this.keyAndValuesInitialChecker())
                {
                    if (this.fullKeyandValueChecker())
                    {
                        TranslationGuide.Add(this.keys.Text, this.values.Text);
                        this.KeysAdded.Add(this.keys.Text);
                        this.keys.Clear();
                        this.values.Clear();
                    }
                }
            }
            else
            {
                if (this.keyAndValuesInitialChecker() && values.Text.All(Char.IsLetterOrDigit) && keys.Text.All(Char.IsLetter))
                {
                    TranslationGuide = new Dictionary<string, string>();
                    TranslationGuide.Add(this.keys.Text, this.values.Text);
                    this.KeysAdded.Add(this.keys.Text);
                    this.keys.Clear();
                    this.values.Clear();
                }
                else
                {
                    if (!values.Text.All(Char.IsLetterOrDigit))
                        label8Change("Decrypted value can't have any characters except alphabets and numerics");

                    if (!keys.Text.All(Char.IsLetter))
                        label7Change("Encrypted key can only have letters in them");
                }
            }
        }
    }
}
