using System.Collections.Generic;
using SQLite;

namespace SearchPrice.App.Models
{
    [Table("Coin")]
    public class CoinModel : BaseModel
    {
        public string Simbolo { get; set; }
        public string NomeFormatado { get; set; }
        public string TipoMoeda { get; set; }

    }

    public class Coins
    {
        public List<CoinModel> Value { get; set; }
    }
}