﻿using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class ProfessionalRepository
    {
        public void Insert(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("Professional", json);
        }

        public void Update(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("Professional/" + body.Id, json);
        }

        public void Delete(long id)
        {
            Request.Delete("Professional/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("Professional", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetUser(string userName)
        {
            string json = Request.Get("Professional/UserInfo/", userName);
            var retorno = new DataTable();
            if (json != null)
            {
                retorno = JsonConvert.DeserializeObject<DataTable>(json);
            }
            return retorno;
        }

        public DataTable GetIdNameid()
        {
            string json = Request.Get("Professional/IdNameId", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Professional GetById(long id)
        {
            string json = Request.Get("Professional/", id.ToString());
            return JsonConvert.DeserializeObject<Professional>(json);
        }
    }
}