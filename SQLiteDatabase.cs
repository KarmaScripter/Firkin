// <copyright file = "SQLiteDatabase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace Firkin
{
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedMethodReturnValue.Global" ) ]
    public class SQLiteDatabase
    {
        /// <summary>
        /// The sq lite connection
        /// </summary>
        private readonly SQLiteConnection _sqLiteConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteDatabase"/> class.
        /// </summary>
        public SQLiteDatabase()
        {
            SQLiteConnection.CreateFile( "MyDatabase.db" );

            _sqLiteConnection = new SQLiteConnection( "Data Source=MyDatabase.db;Version=3;" );
            _sqLiteConnection.Open();
        }

        /// <summary>
        /// Creates the table.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public int CreateTable( string name )
        {
            var _sql = "create table " + name + " (word varchar(200), image text)";
            var _cmd = new SQLiteCommand( _sql, _sqLiteConnection );
            return _cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Inserts the row.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="image">The image.</param>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public int InsertRow( string word, string image, string table )
        {
            var _sql = "insert into " + table + " (word,image) values(@word,@image)";
            var _sqLiteCommand = new SQLiteCommand( _sql, _sqLiteConnection );

            _sqLiteCommand.Parameters.AddWithValue( "@word", word );
            _sqLiteCommand.Parameters.AddWithValue( "@image", image );
            return _sqLiteCommand.ExecuteNonQuery();
        }
    }
}