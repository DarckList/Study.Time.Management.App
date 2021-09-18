using Dapper;
using Microsoft.Extensions.Configuration;
using Study.Time.Management.Data.Models.DE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Study.Time.Management.Data
{
    public class Categories
    {

        private string _connection;
        string sqlMultipleSelect = @"select u.*, cr.*, r.*, c.*
                                    From Users as u 
                                    LEFT JOIN Credentials as cr 
                                        ON u.CredentialId = cr.Id 
                                    LEFT JOIN Rolls as r 
                                        ON u.RollId = r.Id 
                                    LEFT JOIN Clients as c 
                                        ON u.ClientId = c.Id";

        public Categories(string connection)
        {
            _connection = connection;
        }

        public  IEnumerable<Clients> GetCategorys()
        {
            using var connection = new NpgsqlConnection(_connection);
            //var categorys = connection.QueryAsync<User, Credential, RollDe, Clients, Tuple<User, Credential, RollDe, Clients>>(sqlMultipleSelect,
            //    map: (u, cr, r, c) => Tuple.Create(u, cr, r, c),
            //    param: new { ID = 2 });
            //var result = categorys.Result;
            var clientDE = connection.Query<Clients>("select id, birthday as bir from clients");
            return clientDE;
        }
    }
    public record User(int Id, string Nickname, byte[]avatar, int CredentialId, int RollId, int ClientId);
    public record Credential(int Id, string Password, string Email);
    public record RollDe (int Id, string Roll);
    public record Clients(int Id, DateTime Bir);
    public record CustomUsers(int Id, string NickName, string Password, string Email, string Roll, DateTime Birthday);
}
