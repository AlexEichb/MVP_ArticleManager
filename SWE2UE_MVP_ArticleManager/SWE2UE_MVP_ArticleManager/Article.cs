using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE2UE_MVP_ArticleManager
{
    public class Article
    {
        #region Deklaration
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region Init
        public Article(string articleNr, string name, string description, string category, 
                        double price, int quantity)
        {
            ArticleNumber = articleNr;
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
        public Article()
        {
            // Default
        }
        #endregion

        #region Methods
        public void generateArticleNr(int defaultArtNr)
        {
            if (defaultArtNr < 10)
            {
                string _newArticleNumber = "000";
                this.ArticleNumber = _newArticleNumber + defaultArtNr;
            }
            else if (defaultArtNr >= 10 && defaultArtNr < 100)
            {
                string _newArticleNumber = "00";
                this.ArticleNumber = _newArticleNumber + defaultArtNr;
            }
            else if (defaultArtNr >= 100 && defaultArtNr < 1000)
            {
                string _newArticleNumber = "0";
                this.ArticleNumber = _newArticleNumber + defaultArtNr;
            }
            else if (defaultArtNr >= 1000)
            {
                this.ArticleNumber = defaultArtNr.ToString();
            }
        }
        #endregion
    }
}
