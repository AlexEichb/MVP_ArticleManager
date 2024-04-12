using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE2UE_MVP_ArticleManager
{
    public class MainPresenter
    {
        #region Deklaration
        private MainView _mainView;
        private MainModel _mainModel;
        #endregion

        #region Init
        public MainPresenter()
        {
            // ToDo: add View & Model
            _mainView = new MainView();
            _mainModel = new MainModel();

            // ToDo: subscribe to events
            _mainView.AddDataRequested += OnAddDataRequested;
            _mainView.EditDataRequested += OnEditDataRequested;
            _mainView.DeleteDataRequested += OnDeleteDataRequested;
            _mainModel.ModelChanged += OnModelChanged;
        }
        #endregion

        #region Events
        private void OnDeleteDataRequested(object? sender, string e)
        {
            _mainModel.DeleteArticle(e);
        }

        private void OnEditDataRequested(object? sender, string e)
        {
            Article clonedArticle = _mainModel.SearchArticle(e);
            if(clonedArticle != null)
            {
                DetailPresenter detailPresenter = new DetailPresenter();
                detailPresenter.DataChanged += OnDetailDataChanged;
                detailPresenter.Show(clonedArticle);
                detailPresenter.DataChanged -= OnDetailDataChanged;
            }
        }

        private void OnModelChanged(object? sender, EventArgs e)
        {
            _mainView.UpdateView(_mainModel.Articles);
        }

        private void OnAddDataRequested(object? sender, EventArgs e)
        {
            DetailPresenter detailPresenter = new DetailPresenter();
            detailPresenter.DataChanged += OnDetailDataChanged;
            detailPresenter.Show();
            detailPresenter.DataChanged -= OnDetailDataChanged;
        }

        private void OnDetailDataChanged(object? sender, Article e)
        {
            _mainModel.AddArticle(e);
        }
        #endregion

        #region Methoden
        public void Start()
        {
            Application.Run(_mainView);
        }
        #endregion
    }
}
