using System.Collections.Generic;

namespace MvcSka.Models.ViewModel
{
    public class TableViewModel
    {
        public List<TableRow> List;

        public TableViewModel(List<TableRow> list)
        {
            List = list;
        }
    }
}