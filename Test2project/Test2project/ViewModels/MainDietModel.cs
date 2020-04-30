using System;
using Test2project.Models;
using Test2project.DataService;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test2project.ViewModels
{
    public class MainDietModel : INotifyPropertyChanged
    {
        private List<DietModels> _dietmodels;
        private readonly string propertyNameDiet;
        private DataServiceDiet _dataServicediet = new DataServiceDiet();

        public DietModels SelectedPost { get; set; }

        public List<DietModels> DietModels
        {
            get { return _dietmodels; }
            set
            {
                _dietmodels = value;
                OnPropertyChanged();
            }
        }
        public ICommand SendTodoCommand => new Command(async () =>
        {
            // SelectedPost.UpdatedAt = DateTime.UtcNow;
             await _dataServicediet.PostDietModels(SelectedPost);
        });
        public MainDietModel()
        {
               SelectedPost = new DietModels();
            GetPostData();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyNameDiet));
        }

        private async Task GetPostData()
        {


            DietModels = await _dataServicediet.GetDietModels();
        }

    }
}
