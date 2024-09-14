using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSimpleApp
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            LoadUsers();
        }

        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        public void LoadUsers()
        {
            Users.Add(new User 
            { 
                Id = 1, 
                Name = "John Doe" 
            });
            Users.Add(new User 
            { 
                Id = 2, 
                Name = "Jane Doe" 
            });
            Users.Add(new User { 
                Id = 3, 
                Name = "John Smith" 
            });
            Users.Add(new User
            {
                Id = 4,
                Name = "Jane Smith"
            });
            Users.Add(new User
            {
                Id = 5,
                Name = "John Johnson"
            });
            Users.Add(new User
            {
                Id = 6,
                Name = "Jane Johnson"
            });
            Users.Add(new User
            {
                Id = 7,
                Name = "John Jackson"
            });
            Users.Add(new User
            {
                Id = 8,
                Name = "Jane Jackson"
            });
            Users.Add(new User
            {
                Id = 9,
                Name = "John Brown"
            });
            Users.Add(new User
            {
                Id = 10,
                Name = "Jane Brown"
            });
            Users.Add(new User
            {
                Id = 11,
                Name = "John White"
            });
            Users.Add(new User
            {
                Id = 12,
                Name = "Jane White"
            });
            Users.Add(new User
            {
                Id = 13,
                Name = "John Black"
            });
            Users.Add(new User
            {
                Id = 14,
                Name = "Jane Black"
            });
            Users.Add(new User
            {
                Id = 15,
                Name = "John Green"
            });
            Users.Add(new User
            {
                Id = 16,
                Name = "Jane Green"
            });
            Users.Add(new User
            {
                Id = 17,
                Name = "John Blue"
            });
            Users.Add(new User
            {
                Id = 18,
                Name = "Jane Blue"
            });
            Users.Add(new User
            {
                Id = 19,
                Name = "John Red"
            });
            Users.Add(new User
            {
                Id = 20,
                Name = "Jane Red"
            });
            Users.Add(new User
            {
                Id = 21,
                Name = "John Yellow"
            });
            Users.Add(new User
            {
                Id = 22,
                Name = "Jane Yellow"
            });
            Users.Add(new User
            {
                Id = 23,
                Name = "John Purple"
            });
            Users.Add(new User
            {
                Id = 24,
                Name = "Jane Purple"
            });
            Users.Add(new User
            {
                Id = 25,
                Name = "John Orange"
            });
            Users.Add(new User
            {
                Id = 26,
                Name = "Jane Orange"
            });
            Users.Add(new User
            {
                Id = 27,
                Name = "John Pink"
            });
            Users.Add(new User
            {
                Id = 28,
                Name = "Jane Pink"
            });
            Users.Add(new User
            {
                Id = 29,
                Name = "John Gray"
            });
            Users.Add(new User
            {
                Id = 30,
                Name = "Jane Gray"
            });

        }
    }

}
