using System;
using System.Collections.Generic;
using SQLite;

namespace SearchPrice.App.Models
{
    public class DetailCoinModel : BaseModel
    {

        public int ParidadeCompra { get; set; }
        public int ParidadeVenda { get; set; }
        public float CotacaoCompra { get; set; }
        public float CotacaoVenda { get; set; }
        public DateTime DataHoraCotacao { get; set; }
        public string TipoBoletim { get; set; }

    }

    public class DetailCoins
    {
        public List<DetailCoinModel> Value { get; set; }
    }
}