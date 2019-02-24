using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RESTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<User> Users = new List<User>();
            User user1 = new User
            {
                name = "Vidya",
                id = 0
            };
            User user2 = new User
            {
                name = "Chandan",
                id = 1
            };

            Users.Add(user1);
            Users.Add(user2);
            EmployeeList.ItemsSource = Users;
        }
    }
}
