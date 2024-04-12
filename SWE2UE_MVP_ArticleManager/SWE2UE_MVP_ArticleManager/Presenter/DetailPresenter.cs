using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE2UE_MVP_ArticleManager
{
    public class DetailPresenter
    {
        #region Deklaration
        private DetailView _detailView;

        public event EventHandler<Article> DataChanged;
        #endregion

        #region Init
        public DetailPresenter()
        {
            _detailView = new DetailView();
            _detailView.SubmitDataRequested += OnSubmitDetailRequested;
        }
        #endregion

        #region Events
        private void OnSubmitDetailRequested(object? sender, EventArgs e)
        {
            string newArticleNumber = _detailView.ArticleNumber;
            string newName = _detailView.InputName;
            string newDescription = _detailView.Description;
            string newCategory = _detailView.Category;
            double newPrice = _detailView.Price;
            int newQuantity = _detailView.Quantity;

            if (!string.IsNullOrWhiteSpace(newName))
            {
                Article newArticle = new Article()
                {// Kurzschreibweise damit Properties direkt ohne Konstruktor beschrieben werden können
                    ArticleNumber = newArticleNumber,
                    Name = newName,
                    Description = newDescription,
                    Category = newCategory,
                    Price = newPrice,
                    Quantity = newQuantity
                };

                DataChanged?.Invoke(this, newArticle);
                _detailView.Close();
            }
            else
            {
                MessageBox.Show("Please fill in text at all fields!", "Error", 0, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methods
        public void Show()
        {
            _detailView.ShowDialog();
        }

        public void Show(Article article)
        {
            _detailView.WriteFields(article);
            _detailView.ShowDialog();
        }
        #endregion
    }
}
