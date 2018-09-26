using SalesDemo.Common.Models;
using SalesDemo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SalesDemo.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Product> _productList;

        //public ObservableCollection<Product> ProductList { get => _productList; set => _productList = value; }

        public ObservableCollection<Product> Products
        {
            get { return this._productList; }
            set { this.SetValue(ref this._productList, value); }
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
           var response = await apiService.GetList<Product>("https://kssalesdemoapi.azurewebsites.net", "/api","/products") ;
            if(!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);
        }
    }
}
