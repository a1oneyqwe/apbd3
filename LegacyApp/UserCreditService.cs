﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace LegacyApp
{
    public class UserCreditService : IUserCreditService, IDisposable
    {
        private readonly Dictionary<string, int> _database =
            new Dictionary<string, int>()
            {
                {"Kowalski", 200},
                {"Malewski", 20000},
                {"Smith", 10000},
                {"Doe", 3000},
                {"Kwiatkowski", 1000}
            };

        public void Dispose()
        {
        }

        public int GetCreditLimit(string lastName, DateTime dateOfBirth)
        {
            int randomWaitingTime = new Random().Next(3000);
            Thread.Sleep(randomWaitingTime);

            if (_database.ContainsKey(lastName))
                return _database[lastName];

            throw new ArgumentException($"Client {lastName} does not exist");
        }
    }
}