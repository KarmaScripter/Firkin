namespace Firkin
{
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public class AccessConnector
    {
        /// <summary>
        /// The connection
        /// </summary>
        private readonly OleDbConnection _connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessConnector"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public AccessConnector( string filePath )
        {
            _connection = new OleDbConnection( "provider=microsoft.jet.oledb.4.0;data source=" 
                + filePath
                + ";Jet OLEDB:Database Password=h@#%^ein;" );

            _connection.Open();
        }

        /// <summary>
        /// Gets the table names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetTableNames()
        {
            var _tableNames = new List<string>();
            var _restrictions = new string[ 4 ];
            _restrictions[ 3 ] = "Table";

            var _userTables = _connection?.GetSchema( "Tables", _restrictions );

            if( _userTables != null )
            {
                for( var i = 0; i < _userTables.Rows.Count; i++ )
                {
                    _tableNames?.Add( _userTables.Rows[ i ][ 2 ].ToString() );
                }
            }

            return _tableNames;
        }

        /// <summary>
        /// Gets the table.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <returns></returns>
        public DataTable GetTable( string tableName )
        {
            var _dataTable = new DataTable();

            var _dataAdapter = new OleDbDataAdapter( "SELECT * FROM " + tableName, _connection );
            _dataAdapter.Fill( _dataTable );
            return _dataTable;
        }

        /// <summary>
        /// Ges the column names.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <returns></returns>
        public List<string> GeColumnNames( string tableName )
        {
            var _res = new List<string>();

            using( var cmd = new OleDbCommand( "select * from " + tableName, _connection ) )
            {
                using( var reader = cmd.ExecuteReader( CommandBehavior.SchemaOnly ) )
                {
                    var _schemaTable = reader.GetSchemaTable();
                    var _dataColumn = _schemaTable?.Columns[ "ColumnName" ];

                    if( _schemaTable?.Rows != null )
                    {
                        foreach( DataRow row in _schemaTable?.Rows )
                        {
                            if( _dataColumn != null )
                            {
                                _res.Add( row[ _dataColumn ].ToString() );
                            }
                        }
                    }
                }
            }

            return _res;
        }
    }
}