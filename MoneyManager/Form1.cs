using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Threading;

namespace MoneyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.WordWrap = false;
        }

        //some variables
        bool clickedFirst = false;
        double amount = 0;
        double allAmount = 0;
        double monthCount = 0;
        bool isLoaded = false;
        double lastPosAmount;
        double lastNegAmount;
        double amountBox;
        double numNeg;
        double numPos;
        bool curLoaded = false;
        string allowedChars = "-0123456789,";
        bool loadedMonthAmount = true;
      
        
        //add button
        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (isLoaded == false)
            {
                txtAllamount.Clear();
                txtMonth.Clear();
                combobxCurr.Hide();
                txtCurrency.Visible = true;
                txtCurrency.Text = combobxCurr.SelectedItem.ToString();

                if ((txtAmount.TextLength <= 0 || txtWhat.TextLength <= 0) && (combobxCurr.SelectedItem == null && isLoaded == false))
                {
                    MessageBox.Show("Insert all valid data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    addData();
                }
                analyzeNumber();
            }
            else
            {
                txtAllamount.Clear();
                txtMonth.Clear();

                if (loadedMonthAmount == true)
                {
                    allAmount = allAmount + double.Parse(txtPos.Text);
                    monthCount = monthCount + double.Parse(txtPos.Text);
                    loadedMonthAmount = false;
                }
               
                if ((txtAmount.TextLength <= 0 || txtWhat.TextLength <= 0) && (combobxCurr.SelectedItem == null && isLoaded == false))
                {
                    MessageBox.Show("Insert all valid data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    addData();
                }
                analyzeNumber();
            }            
        }
       
        //button for saving
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.TextLength <= 0 || txtWhat.TextLength <= 0 || (combobxCurr.SelectedItem == null && isLoaded == false) || txtResult.Text == "")
            {
                MessageBox.Show("Insert all data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save data ?", "MoneyManager 2019", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    writeFiles();
                    currencySave();
                }
                else { }
            }
        }
        
        //button for loading
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if ((File.ReadAllText(@"C:\Users\Public\moneymanagerData\money_data.txt") == "") || (File.ReadAllText(@"C:\Users\Public\moneymanagerData\money2_data.txt") == ""))
            {
                MessageBox.Show("No data saved", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to load files ?", "MoneyManager 2019", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {                  
                    isLoaded = true;
                    readFiles();                   
                    currencyLoad();        
                }
                else { }
                analyzeNumber();
            }
        }

        //Month button
        public void btnMonth_Click(object sender, EventArgs e)
        {
            txtMonth.Clear();
            monthCount = 0;
        }

        //other load & save buttons
        public void btnSave1_Click(object sender, EventArgs e)
        {
            if (txtAmount.TextLength <= 0 || txtWhat.TextLength <= 0 || (combobxCurr.SelectedItem == null && isLoaded == false) || txtResult.Text == "")
            {
                MessageBox.Show("Insert all data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                       
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save data ?", "MoneyManager 2019", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    writeFiles1();
                    currencySave1();
                }
                else { }
            }
        }

        public void btnLoad1_Click(object sender, EventArgs e)
        {
            if ((File.ReadAllText(@"C:\Users\Public\moneymanagerData\money_data1.txt") == "") || (File.ReadAllText(@"C:\Users\Public\moneymanagerData\money2_data1.txt") == ""))
            {
                MessageBox.Show("No data saved", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to load files ?", "MoneyManager 2019", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {                  
                    isLoaded = true;                  
                    readFiles1();                     
                    currencyLoad1();                  
                }
                else { }
                analyzeNumber();
            }                    
        }

        public void btnSave2_Click(object sender, EventArgs e)
        {
            if (txtAmount.TextLength <= 0 || txtWhat.TextLength <= 0 || (combobxCurr.SelectedItem == null && isLoaded == false) || txtResult.Text == "")
            {
                MessageBox.Show("Insert all data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save data ?", "MoneyManager 2019", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    writeFiles2();
                    currencySave2();
                }
                else { }
            }
        }

        public void btnLoad2_Click(object sender, EventArgs e)
        {
            if ((File.ReadAllText(@"C:\Users\Public\moneymanagerData\money_data2.txt") == "") || (File.ReadAllText(@"C:\Users\Public\moneymanagerData\money2_data2.txt") == ""))
            {
                MessageBox.Show("No data saved", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to load files ?", "MoneyManager 2019", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {        
                    isLoaded = true;
                    readFiles2();                   
                    currencyLoad2();                   
                }
                else { }
                analyzeNumber();
            }                   
        }

        //↓↓↓FUNCTIONS↓↓↓

        public void analyzeNumber()
        {          
            if (allAmount < 0) { txtAllamount.ForeColor = Color.Red; }
            else if (allAmount == 0) { txtAllamount.ForeColor = Color.Black; }
            else { txtAllamount.ForeColor = Color.Green; }           
        }

        public void writeFiles()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\money_data.txt"))
            {
                file.WriteLine(txtResult.Text);
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\money2_data.txt"))
            {
                file.WriteLine(txtAllamount.Text); file.WriteLine(txtMonth.Text);
                file.WriteLine(txtPos.Text); file.WriteLine(txtNeg.Text);
            }      
        }

        public void writeFiles1()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\money_data1.txt"))
            {
                file.WriteLine(txtResult.Text);
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\money2_data1.txt"))
            {
                file.WriteLine(txtAllamount.Text); file.WriteLine(txtMonth.Text);
                file.WriteLine(txtPos.Text); file.WriteLine(txtNeg.Text);
            }
        }

        public void writeFiles2()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\money_data2.txt"))
            {
                file.WriteLine(txtResult.Text);
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\money2_data2.txt"))
            {
                file.WriteLine(txtAllamount.Text); file.WriteLine(txtMonth.Text);
                file.WriteLine(txtPos.Text); file.WriteLine(txtNeg.Text);
            }
        }

        public void readFiles()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\Public\moneymanagerData\money_data.txt"))
            {
                string textLoad = file.ReadToEnd();
                txtResult.Text = textLoad;
            }

            using (StreamReader file = new StreamReader(@"C:\Users\Public\moneymanagerData\money2_data.txt"))
            {    
                txtAllamount.Text = file.ReadLine(); txtMonth.Text = file.ReadLine();
                txtPos.Text = file.ReadLine(); txtNeg.Text = file.ReadLine();
            }         
            isLoaded = true;
        }

        public void readFiles1()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\Public\moneymanagerData\money_data1.txt"))
            {
                string textLoad = file.ReadToEnd();
                txtResult.Text = textLoad;
            }

            using (StreamReader file = new StreamReader(@"C:\Users\Public\moneymanagerData\money2_data1.txt"))
            {
                txtAllamount.Text = file.ReadLine(); txtMonth.Text = file.ReadLine();
                txtPos.Text = file.ReadLine(); txtNeg.Text = file.ReadLine();
            }
            isLoaded = true;
        }

        public void readFiles2()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\Public\moneymanagerData\money_data2.txt"))
            {
                string textLoad = file.ReadToEnd();
                txtResult.Text = textLoad;
            }

            using (StreamReader file = new StreamReader(@"C:\Users\Public\moneymanagerData\money2_data2.txt"))
            {
                txtAllamount.Text = file.ReadLine(); txtMonth.Text = file.ReadLine();
                txtPos.Text = file.ReadLine(); txtNeg.Text = file.ReadLine();
            }
            isLoaded = true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        public void currencySave()
        {
            if (curLoaded == true)
            {
            using (System.IO.StreamWriter fileCurr =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\currency.txt"))
                {
                    fileCurr.WriteLine(txtCurrency.Text);
                }
            }
            else if (curLoaded == false)
            {
            using (System.IO.StreamWriter fileCurr =
            new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\currency.txt"))
                {
                    fileCurr.WriteLine(combobxCurr.SelectedItem.ToString());
                }
            }           
        }

        public void currencyLoad()
        {
            using (StreamReader readCurr = new StreamReader(@"C:\Users\Public\moneymanagerData\currency.txt"))
            {
                string currencyLoaded = readCurr.ReadToEnd();
                txtCurrency.Text = currencyLoaded;
                combobxCurr.Hide();
                curLoaded = true;
            }
        }

        public void currencySave1()
        {
            if (curLoaded == true)
            {
                using (System.IO.StreamWriter fileCurr =
                new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\currency1.txt"))
                {
                    fileCurr.WriteLine(txtCurrency.Text);
                }
            }
            else if (curLoaded == false)
            {
                using (System.IO.StreamWriter fileCurr =
                new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\currency1.txt"))
                {
                    fileCurr.WriteLine(combobxCurr.SelectedItem.ToString());
                }
            }
        }

        public void currencyLoad1()
        {
            using (StreamReader readCurr = new StreamReader(@"C:\Users\Public\moneymanagerData\currency1.txt"))
            {
                string currencyLoaded = readCurr.ReadToEnd();
                txtCurrency.Text = currencyLoaded;
                combobxCurr.Hide();
                curLoaded = true;
            }
        }

        public void currencySave2()
        {
            if (curLoaded == true)
            {
                using (System.IO.StreamWriter fileCurr =
                new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\currency2.txt"))
                {
                    fileCurr.WriteLine(txtCurrency.Text);
                }
            }
            else if (curLoaded == false)
            {
                using (System.IO.StreamWriter fileCurr =
                new System.IO.StreamWriter(@"C:\Users\Public\moneymanagerData\currency2.txt"))
                {
                    fileCurr.WriteLine(combobxCurr.SelectedItem.ToString());
                }
            }
        }

        public void currencyLoad2()
        {
            using (StreamReader readCurr = new StreamReader(@"C:\Users\Public\moneymanagerData\currency2.txt"))
            {
                string currencyLoaded = readCurr.ReadToEnd();
                txtCurrency.Text = currencyLoaded;
                combobxCurr.Hide();
                curLoaded = true;
            }
        }

        public void addData()
        {
            string what = txtWhat.Text;

            if (isLoaded == false)
            {
                if (clickedFirst == false)
                { 
                    clickedFirst = true;

                    if (combobxCurr.SelectedItem == null)
                    {
                        MessageBox.Show("Insert all data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        amount = double.Parse(txtAmount.Text);
                        allAmount = amount;
                        monthCount = allAmount;

                        txtAllamount.AppendText(allAmount.ToString());
                        txtMonth.AppendText(monthCount.ToString());
                        checkNum();

                        string currency = combobxCurr.SelectedItem.ToString();
                         
                        if (amount.ToString().Length > 13)
                        {
                            MessageBox.Show("Price is too long or short", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtResult.AppendText(amount.ToString() + currency + " " + what + "   //" + System.DateTime.Now + " " + Environment.NewLine);
                        }
                    }                                    
                }

                else if (clickedFirst == true)
                {                    
                    if (combobxCurr.SelectedItem == null)
                    {
                        MessageBox.Show("Insert all data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string currency = combobxCurr.SelectedItem.ToString();
 
                        amount = double.Parse(txtAmount.Text);
                        monthCount = monthCount + amount;
                        allAmount = allAmount + amount;

                        txtAllamount.AppendText(allAmount.ToString());
                        txtMonth.AppendText(monthCount.ToString());
                        checkNum();

                        if (amount.ToString().Length > 13)
                        {
                            MessageBox.Show("Price is too long or short", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtResult.AppendText(amount.ToString() + currency + " " + what + "   //" + System.DateTime.Now + " " + Environment.NewLine);
                        }
                    }   
                }
                    else if (amount.ToString().Length > 13)
                    {
                        MessageBox.Show("Price is too long or short", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else if (isLoaded == true)
            {                 
                if (clickedFirst == false)
                {   
                    amount = double.Parse(txtAmount.Text);
                    allAmount = allAmount + amount;
                    txtAllamount.AppendText(allAmount.ToString());

                    monthCount = monthCount + amount;
                    txtMonth.AppendText(monthCount.ToString());
                    checkNum();

                    clickedFirst = true;
                   
                    if (amount.ToString().Length > 13)
                    {
                        MessageBox.Show("Price is too long or short", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (StreamReader readCurr = new StreamReader(@"C:\Users\Public\moneymanagerData\currency.txt"))
                        {
                            string currencyLoaded = readCurr.ReadLine();
                            txtResult.AppendText(amount.ToString() + currencyLoaded + " " + what + "   //" + System.DateTime.Now + " " + Environment.NewLine);
                        }       
                    }
                }
                else if (clickedFirst == true)
                {
                    amount = double.Parse(txtAmount.Text);
                    monthCount = monthCount + amount;
                    allAmount = allAmount + amount;

                    txtAllamount.AppendText(allAmount.ToString());
                    txtMonth.AppendText(monthCount.ToString());
                    checkNum();

                    if (amount.ToString().Length > 13)
                    {
                        MessageBox.Show("Price is too long or short", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (StreamReader readCurr = new StreamReader(@"C:\Users\Public\moneymanagerData\currency.txt"))
                        {
                            string currencyLoaded = readCurr.ReadLine();
                            txtResult.AppendText(amount.ToString() + currencyLoaded + " " + what + "   //" + System.DateTime.Now + " " + Environment.NewLine);
                        }
                    }
                }
                else if (amount.ToString().Length > 13)
                {
                    MessageBox.Show("Price is too long or short", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
         }

        public void checkNum()
        {
            lastPosAmount = double.Parse(txtPos.Text);
            lastNegAmount = double.Parse(txtNeg.Text);
            amountBox = double.Parse(txtAmount.Text);
            numNeg = lastNegAmount + amountBox;
            numPos = lastPosAmount + amountBox;

            if (amountBox < 0)
            {
                txtNeg.Clear();
                txtNeg.AppendText(numNeg.ToString());
            }

            else
            {
                txtPos.Clear();
                txtPos.AppendText(numPos.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dirMain = @"C:\Users\Public\moneymanagerData";
            int dirCount = Directory.GetFiles(dirMain).Length;
            if (!Directory.Exists(dirMain) || dirCount < 9)
            {
                Directory.CreateDirectory(@"C:\Users\Public\moneymanagerData");
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money_data.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money_data.txt").Close(); }              
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money_data1.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money_data1.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money_data2.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money_data2.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money2_data.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money2_data.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money2_data1.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money2_data1.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money2_data2.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money2_data2.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\currency.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\currency.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\currency1.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\currency1.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\currency2.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\currency2.txt").Close(); }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtAmount.Text)
            {
                if (allowedChars.Contains(c)) { }
                else
                {
                    txtAmount.Clear();
                    MessageBox.Show("Insert all valid data or choose valid currency", "MoneyManager 2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }  
}

