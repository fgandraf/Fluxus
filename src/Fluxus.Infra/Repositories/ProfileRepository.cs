﻿using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using Fluxus.Infra.Repositories.Contracts;

namespace Fluxus.Infra.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly IConnection _connection;

        public ProfileRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile);
            return _connection.Post("v1/profile", json);
        }

        public bool Update(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile);
            return _connection.Put("v1/profile", json);
        }

        public Profile GetById(int id)
        {
            string json = _connection.Get("v1/profile", string.Empty);
            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public Profile GetToPrint()
        {
            string json = _connection.Get("v1/profile/to-print", string.Empty);
            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public byte[] GetLogo()
        {
            string json = _connection.Get("v1/profile/logo", string.Empty);
            
            if (json != null)
                return JsonConvert.DeserializeObject<byte[]>(json);
            else
                return null;
        }

        public string GetTradingName()
        {
            return _connection.Get("v1/profile/trading-name", string.Empty);
        }

    }
}
