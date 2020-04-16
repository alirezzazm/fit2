    using System;
    using Test2project.Models;

    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Windows.Input;
    using System.Threading.Tasks;
    using Test2project.DataService;
    using Xamarin.Forms;

namespace Test2project.ViewModels
{
    public class MainPostModel: INotifyPropertyChanged
    {
        private List<PostData> _postdata;
        private readonly string propertyName;
        private DataServicePost _dataServicepost = new DataServicePost();

        public PostData SelectedPost { get; set; }

        public List<PostData> PostData
        {
            get { return _postdata; }
            set
            {
                _postdata = value;
                OnPropertyChanged();
            }
        }
        public ICommand SendTodoCommand => new Command(async () =>
        {
            // SelectedTodo.UpdatedAt = DateTime.UtcNow;
            await _dataServicepost.PostData(SelectedTodo);
        });
        public MainPostModel()
        {
            SelectedTodo = new PostData();
            GetPostData();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async Task GetPostData()
        {


            PostData = await _dataServicepost.GetPostData();
        }

    }
}
