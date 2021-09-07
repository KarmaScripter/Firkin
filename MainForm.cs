// <copyright file = "MainForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace Firkin
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// The acess database
        /// </summary>
        private AccessConnector _acessDatabase;

        /// <summary>
        /// 
        /// </summary>
        private delegate void UpdateStatusDelegate();

        /// <summary>
        /// The update status delegate
        /// </summary>
        private UpdateStatusDelegate _updateStatusDelegate;

        /// <summary>
        /// The worker thread
        /// </summary>
        private Thread _workerThread;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when [select access button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSelectAccessButtonClicked( object sender, EventArgs e )
        {
            var _fileDialog = new OpenFileDialog();
            _fileDialog.Multiselect = false;
            _fileDialog.Filter = "Access database|*.mdb";
            _fileDialog.Title = "Select Access database...";

            if( _fileDialog.ShowDialog() == DialogResult.OK )
            {
                txtAccessPath.Text = _fileDialog.FileName;
                GetTables();
            }
        }

        /// <summary>
        /// Gets the tables.
        /// </summary>
        private void GetTables()
        {
            _acessDatabase = new AccessConnector( txtAccessPath.Text );
            var _tableNames = _acessDatabase.GetTableNames();

            foreach( var s in _tableNames )
            {
                checkTableNames.Items.Add( s );
            }
        }

        /// <summary>
        /// Called when [check table names item checked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ItemCheckEventArgs"/> instance containing the event data.</param>
        private void OnCheckTableNamesItemChecked( object sender, ItemCheckEventArgs e )
        {
        }

        /// <summary>
        /// BTNs the check all click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCheckAllClick( object sender, EventArgs e )
        {
            for( var i = 0; i < checkTableNames.Items.Count; i++ )
            {
                checkTableNames.SetItemChecked( i, true );
            }
        }

        /// <summary>
        /// Called when [button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnButtonClick( object sender, EventArgs e )
        {
            for( var i = 0; i < checkTableNames.Items.Count; i++ )
            {
                checkTableNames.SetItemChecked( i, false );
            }
        }

        /// <summary>
        /// Gets the selected tables.
        /// </summary>
        /// <returns></returns>
        private List<string> GetSelectedTables()
        {
            var result = new List<string>();

            for( var i = 0; i < checkTableNames.Items.Count; i++ )
            {
                if( checkTableNames.GetItemChecked( i ) )
                {
                    result.Add( checkTableNames.Items[ i ].ToString() );
                }
            }

            _selectedCount = result.Count;
            return result;
        }

        /// <summary>
        /// The counter
        /// </summary>
        private int _counter;

        /// <summary>
        /// The selected count
        /// </summary>
        private int _selectedCount;

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatus()
        {
            _counter++;
            lblstatus.Text = _counter + "/" + _selectedCount;

            if( _counter >= _selectedCount )
            {
                MessageBox.Show( "Operation completed" );
            }
        }

        /// <summary>
        /// BTNs the convert click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnConvertClick( object sender, EventArgs e )
        {
            if( txtAccessPath.Text == string.Empty )
            {
                MessageBox.Show( "please select database to convert", "error" );
                return;
            }

            _updateStatusDelegate = UpdateStatus;

            //running conversation in a thread to prevent windows from freezing! because of heavy operation
            _workerThread = new Thread( Convert );
            _workerThread.Start();
        }

        /// <summary>
        /// Converts this instance.
        /// </summary>
        private void Convert()
        {
            var selectedTables = GetSelectedTables();

            if( selectedTables.Count == 0 )
            {
                return;
            }

            var sqliteDb = new SQLiteDatabase();

            for( var i = 0; i < selectedTables.Count; i++ )
            {
                var table = selectedTables[ i ];
                sqliteDb.CreateTable( table );

                var dt = _acessDatabase.GetTable( table );

                for( var j = 0; j < dt.Rows.Count; j++ )
                {
                    var word = dt.Rows[ j ][ "word" ].ToString();
                    var image = dt.Rows[ j ][ "image" ].ToString();
                    sqliteDb.InsertRow( word, image, table );
                }

                //sending operation status to update current status
                Invoke( _updateStatusDelegate );
            }
        }
    }
}