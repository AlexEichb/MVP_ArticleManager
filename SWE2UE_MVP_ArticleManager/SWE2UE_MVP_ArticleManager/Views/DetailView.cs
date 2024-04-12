using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE2UE_MVP_ArticleManager
{
    public partial class DetailView : Form
    {
        #region Deklaration
        public string ArticleNumber => tbx_ArticleNr.Text;
        public string InputName => tbx_Name.Text; //Kurze Schreibweise für Properties
        //public string Name { get { return tbx_Name.Text; } };
        public string Description => tbx_Description.Text;
        public string Category => tbx_Category.Text;
        public double Price 
        {
            get
            { try
                {
                    return double.Parse(tbx_Price.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a floating point number", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
            set { }
        }
        public int Quantity
        {
            get
            {
                try
                {
                    return int.Parse(tbx_Quantity.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter an integer ", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
            set { }
        }
    
        public event EventHandler SubmitDataRequested;
        #endregion

        #region Init
        public DetailView()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            CheckInputDataTypes();
            SubmitDataRequested?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Methods
        private void CheckInputDataTypes()
        {
            try
            {
                // Datentypen Prüfen
                double.Parse(tbx_Price.Text);
                int.Parse(tbx_Quantity.Text);
            }
            catch
            {
                // Fehlermeldung
                MessageBox.Show("Check Datatype!", "Error", 0, MessageBoxIcon.Error);
            }
        }

        public void WriteFields(Article article)
        {
            tbx_ArticleNr.Text = article.ArticleNumber;
            tbx_Name.Text = article.Name;
            tbx_Description.Text = article.Description;
            tbx_Category.Text = article.Category;
            tbx_Price.Text = article.Price.ToString();
            tbx_Quantity.Text = article.Quantity.ToString();
        }
        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
