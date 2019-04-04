using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace mybatis_generate_win.database
{
    public interface AbstractDatabaseConnector
    {
        DataSet ExecuteDataSet(string sql);

        DataTable ExecuteDataTable(string sql);

        DataRow ExecuteDataRow(string sql);
    }
}
