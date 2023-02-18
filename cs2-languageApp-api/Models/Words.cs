using System.ComponentModel.DataAnnotations;

namespace cs2_languageApp_api.Models
{
    public class Words
    {
        [Key]
        public int Id { set; get; }

        public string Word { set; get; }

        public string Translation { set; get; }


    }
}
