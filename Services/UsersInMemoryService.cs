﻿using AspNetCoreIntro.Models;

namespace AspNetCoreIntro.Services
{
    public class UsersInMemoryService : IUsersService
    {
        private List<UserModel> users = new List<UserModel>()
        {   new UserModel(1, "Paperino", "Paolino", new DateTime(1934,7,5), "San Francisco"),
            new UserModel(2, "Giuseppe", "Garibaldi", new DateTime(1934,7,5), "Fossano"),
            new UserModel(3, "Micheal", "Jordan", new DateTime(1934,7,5), "Savigliano"),
            new UserModel(4, "Kobe", "Bryant", new DateTime(1934,7,5), "Cuneo")

        };
        public IEnumerable<UserModel> GetUsers()
        {
            return users;
        }

        public UserModel? GetUsersById(int id)
        {
            return users.SingleOrDefault(u => u.Id == id);
        }

        public int DeleteUsersById(int id)
        {
            return users.RemoveAll(u => u.Id == id);
        }

        public UserModel AddUser(UserModel user)
        {
            user.Id = users.Max(u => u.Id) + 1;
            users.Add(user);

            return user;
        }
    }
}
