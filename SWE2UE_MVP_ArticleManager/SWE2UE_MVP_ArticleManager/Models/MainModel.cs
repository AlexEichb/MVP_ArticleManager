using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE2UE_MVP_ArticleManager
{
    public class MainModel
    {
        #region Deklaration
        // Members
        private List<Article> _listOfArticles;
        int _defaultArtNr;
        // Properties
        public List<Article> Articles => _listOfArticles;
        // Events
        public event EventHandler ModelChanged;
        #endregion

        #region Init
        public MainModel()
        {
            _listOfArticles = new List<Article>();
            _defaultArtNr = 0000;
        }
        #endregion

        #region Methods
        public void AddArticle(Article article)
        {
            // Add Article
            if(article.ArticleNumber == "")
            {
                article.generateArticleNr(_defaultArtNr);
                _defaultArtNr++;

                _listOfArticles.Add(article);

                ModelChanged?.Invoke(this, EventArgs.Empty);
            }
            // Edit Article
            else
            {
                try
                {
                    int actualArticle = -1;
                    bool success = false;

                    // search article
                    for (int i = 0; i < _listOfArticles.Count; i++)
                    {
                        actualArticle = i;
                        int comparisionResult = string.Compare(_listOfArticles[i].ArticleNumber, article.ArticleNumber, StringComparison.OrdinalIgnoreCase);
                        if (comparisionResult == 0)
                        {
                            success = true;
                            break;
                        }
                    }
                    if (success)
                    {
                        _listOfArticles[actualArticle].Name = article.Name;
                        _listOfArticles[actualArticle].Description = article.Description;
                        _listOfArticles[actualArticle].Category = article.Category;
                        _listOfArticles[actualArticle].Price = article.Price;
                        _listOfArticles[actualArticle].Quantity = article.Quantity;

                        ModelChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Article not found!", "Error", 0, MessageBoxIcon.Error);
                }
            }
        }

        public Article SearchArticle (string artNr)
        {
            try
            {
                int actualArticle = -1;
                bool success = false;

                // search article
                for (int i = 0; i < _listOfArticles.Count; i++)
                {
                    actualArticle = i;
                    int comparisionResult = string.Compare(_listOfArticles[i].ArticleNumber, artNr, StringComparison.OrdinalIgnoreCase);
                    if (comparisionResult == 0)
                    {
                        success = true;
                        break;
                    }
                }

                // clone Article
                if (success)
                {
                    Article articleToClone = _listOfArticles[actualArticle];
                    Article clonedArticle = new Article(articleToClone.ArticleNumber, articleToClone.Name,
                                                articleToClone.Description, articleToClone.Category,
                                                articleToClone.Price, articleToClone.Quantity);
                    return clonedArticle;
                } 
            }
            catch(Exception e)
            {
                MessageBox.Show("Article not found!", "Error", 0, MessageBoxIcon.Error);
            }

            return null;
        }

        public void DeleteArticle(string artNr)
        {
            try
            {
                int actualArticle = -1;
                bool success = false;

                // search article
                for (int i = 0; i < _listOfArticles.Count; i++)
                {
                    actualArticle = i;
                    int comparisionResult = string.Compare(_listOfArticles[i].ArticleNumber, artNr, StringComparison.OrdinalIgnoreCase);
                    if (comparisionResult == 0)
                    {
                        success = true;
                        break;
                    }
                }
                if (success)
                {
                    _listOfArticles.RemoveAt(actualArticle);
                    ModelChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Article not found!", "Error", 0, MessageBoxIcon.Error);
            }
        }
            #endregion
    }
}
