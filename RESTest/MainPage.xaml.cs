using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
namespace RESTest
{
    public partial class MainPage : ContentPage
    {
        List<User> Users = new List<User>();

        public MainPage()
        {
            InitializeComponent();
            //User user1 = new User
            //{
            //    name = "Vidya",
            //    id = 0
            //};
            //User user2 = new User
            //{
            //    name = "Chandan",
            //    id = 1
            //};

            //Users.Add(user1);
            //Users.Add(user2);
        }
        protected async override void OnAppearing()
        {
            Service service = new Service();
            string result = await service.GetAsyc("https://jsonplaceholder.typicode.com/users");
            Console.WriteLine(result);
            Users = JsonConvert.DeserializeObject<List<User>>(result);

            EmployeeList.ItemsSource = Users;

            base.OnAppearing();
        }
    }
}
