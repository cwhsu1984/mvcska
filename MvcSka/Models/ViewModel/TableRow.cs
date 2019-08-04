using System;

namespace MvcSka.Models.ViewModel
{
    public class TableRow
    {
        public int Id;
        public string Type;
        public DateTime Date;
        public int Amount;

        public TableRow(int Id, string Type, DateTime Date, int Amount)
        {
            this.Id = Id;
            this.Type = Type;
            this.Date = Date;
            this.Amount = Amount;
        }
    }
}