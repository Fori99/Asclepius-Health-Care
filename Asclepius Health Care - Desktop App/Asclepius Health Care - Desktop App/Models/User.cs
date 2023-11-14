using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asclepius_Health_Care___Desktop_App.Models
{
    [Table("users")]
    internal class User
    {
        [Column("id")]  // use this annotation if the column name in the database is different
        public int Id { get; set; }

        [Column("fullname")]
        public string FullName { get; set; }

        [Column("roles")]
        public UserRole Roles { get; set; }

        [Column("usernmme")]  // this is an example where the DB column name doesn't match the property name
        public string Username { get; set; }

        [Column("pass")]
        public string Password { get; set; }

        public enum UserRole
        {
            Admin,
            Doctor,
            Frontdesk,
            Laboratory
        }
    }
}
