using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppUltimoAplicativoAno.Models
{
    internal class Produto
    {
        string _descricao;

        [PrimaryKey, AutoIncrement]
        public int Id {  get; set; }
        public string Descricao
        {
            get => _descricao;
            set
            { if(value == null) }
                
        }
    }
}
