namespace SWE2UE_MVP_ArticleManager
{
    public partial class MainView : Form
    {
        #region Deklaration
        public event EventHandler AddDataRequested;
        public event EventHandler <string> DeleteDataRequested;
        public event EventHandler <string> EditDataRequested;
        #endregion

        #region Init
        public MainView()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void Add_Click(object sender, EventArgs e)
        {
            AddDataRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = listView1.SelectedItems[0].Text;
                EditDataRequested?.Invoke(this, selectedRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please choose a row in the list", "Error", 0, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = listView1.SelectedItems[0].Text;
                DeleteDataRequested?.Invoke(this, selectedRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose a row in the list", "Error", 0, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methoden
        public void UpdateView(List<Article> articles)
        {
            //clear list
            listView1.Items.Clear();

            //data
            for (int i = 0; i < articles.Count; i++)
            {
                Article actualArticle = articles[i];
                string[] newRow = {actualArticle.ArticleNumber, actualArticle.Name, actualArticle.Description,
                                    actualArticle.Category ,actualArticle.Price.ToString(), actualArticle.Quantity.ToString()};
                ListViewItem newListViewItem = new ListViewItem(newRow);
                listView1.Items.Add(newListViewItem);
            }
        }
        #endregion
    }
}