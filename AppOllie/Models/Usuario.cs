using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppOllie.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nomeres { get; set; }

        public int Nascres { get; set; }

        public string Estcivil { get; set; }

        public string Parentesco { get; set; }

        public string Nomecri { get; set; }

        public int Nasccri { get; set; }

        public char Email { get; set; }

        public char Senha { get; set; }
    }
}
