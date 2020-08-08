using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_ADO_Connection_HR_base_ {
	#region Data binding class
	public class DataBindingList<T> : BindingList<T>, IDisposable {
		private List<T> data;
		public DataBindingList(List<T> list) : base(list) {
			data = list;
		}
		public DataBindingList() : base() {
			data = new List<T>();
		}

		public void Dispose() {
			data.Clear();
		}

		public int RemoveAll(Predicate<T> match) {
			int cRemCount = data.RemoveAll(match);
			ResetBindings();
			return cRemCount;
		}

		public void Sort() {
			data?.Sort();
			ResetBindings();
		}

		public void Sort(Comparison<T> comparison) {
			data?.Sort(comparison);
			ResetBindings();
		}
		public void Sort(IComparer<T> comparer) {
			data?.Sort(comparer);
			ResetBindings();
		}

		public void Sort(int index, int count, IComparer<T> comparer) {
			data.Sort(index, count, comparer);
			ResetBindings();
		}

	}
	#endregion

	public partial class DAL {
		public DataBindingList<DbDataRecord> dbDataRecords;
		private string sConnStr = ConfigurationManager.ConnectionStrings["HRBaseConnectionString"].ConnectionString;
		private NpgsqlConnection conn;

		public ConnectionState GetConnectionState() => conn != null?conn.State:ConnectionState.Closed;
		public DAL() {
			dbdata = new List<IObserver>();
			dbDataRecords = new DataBindingList<DbDataRecord>();
		}
		public bool ConnectionOpen() {
			try {
				conn = new NpgsqlConnection(sConnStr);
				conn.Open();
				return true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message.ToString(), "Error connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
		}

		public bool ConnectionClose() {
			if(conn.State == ConnectionState.Open)
				conn.Dispose();
			return true;
		}

		public bool GetEmploees() {
			if (GetConnectionState() == ConnectionState.Open) {
				NpgsqlDataReader rdr = null;
				NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Employees", conn);
				rdr = cmd.ExecuteReader();
				foreach (DbDataRecord result in rdr) {
					dbDataRecords.Add(result);
				}
				rdr.Close();
				return true;
			}
			return false;
		}

		public bool NewEmploee(string fname, string lname, string sname,
			string position,
			DateTime birstday,
			string startorder,
			string endorder,
			string photo,
			string login,
			string pswd) {
			if (GetConnectionState() == ConnectionState.Open) {
				NpgsqlCommand cmd = new NpgsqlCommand("insertemployee", this.conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@fname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = fname;
				cmd.Parameters.Add("@lname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = lname;
				cmd.Parameters.Add("@sname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = sname.Length > 0 ? sname : null;
				cmd.Parameters.Add("@pos", NpgsqlTypes.NpgsqlDbType.Varchar).Value = position;
				cmd.Parameters.Add("@birstday", NpgsqlTypes.NpgsqlDbType.Date).Value = birstday;
				cmd.Parameters.Add("@startorder", NpgsqlTypes.NpgsqlDbType.Varchar).Value = startorder;
				cmd.Parameters.Add("@endorder", NpgsqlTypes.NpgsqlDbType.Varchar).Value = endorder;
				cmd.Parameters.Add("@photo", NpgsqlTypes.NpgsqlDbType.Bytea).Value =  System.IO.File.ReadAllBytes(photo);
				cmd.Parameters.Add("@login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = login;
				cmd.Parameters.Add("@pswd", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pswd;
				cmd.ExecuteNonQuery();

				return true;
			}else {
				return false;
			}
		}
	}
}
