using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

	#region Image Photo class
	public static class Photo {

		public static byte[] Resize(string path, int maxWidth = 100, int maxHeight = 100) {
			try {
				Image img = Image.FromFile(path);
				double ratioX = (double)maxWidth / img.Width;
				double ratioY = (double)maxHeight / img.Height;
				double ratio = Math.Min(ratioX, ratioY);
				int newWidth = (int)(img.Width * ratio);
				int newHeight = (int)(img.Height * ratio);
				Image mi = new Bitmap(newWidth, newHeight);
				//рисунок в памяти
				Graphics g = Graphics.FromImage(mi);
				g.DrawImage(img, 0, 0, newWidth, newHeight);
				MemoryStream ms = new MemoryStream();
				//поток для ввода|вывода байт из памяти
				mi.Save(ms, ImageFormat.Jpeg);
				ms.Flush();//выносим в поток все данные из буфера
				ms.Seek(0, SeekOrigin.Begin);
				BinaryReader br = new BinaryReader(ms);
				byte[] buf = br.ReadBytes((int)ms.Length);
				return buf;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Image error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public static Image Resize(Image img, int maxWidth = 100, int maxHeight = 100) {
			double ratioX = (double)maxWidth / img.Width;
			double ratioY = (double)maxHeight / img.Height;
			double ratio = Math.Min(ratioX, ratioY);
			int newWidth = (int)(img.Width * ratio);
			int newHeight = (int)(img.Height * ratio);
			Image mi = new Bitmap(newWidth, newHeight);
			Graphics g = Graphics.FromImage(mi);
			g.DrawImage(img, 0, 0, newWidth, newHeight);
			return mi;
		}

		public static Image ToImage(byte[] data) {
			try {
				return Image.FromStream(new MemoryStream(data));
			} catch {
				MessageBox.Show("Not convert byte to image", "Image error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
	#endregion

	public partial class DAL {
		public DataBindingList<DbDataRecord> dbDataRecords;
		private string sConnStr = ConfigurationManager.ConnectionStrings["HRBaseConnectionString"].ConnectionString;
		private NpgsqlConnection conn;

		public ConnectionState GetConnectionState() => conn != null ? conn.State : ConnectionState.Closed;
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
			if (conn.State == ConnectionState.Open)
				conn.Dispose();
			return true;
		}

		public bool Refresh() {
			dbDataRecords.Clear();
			GetEmploees();
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
				NpgsqlCommand cmd = new NpgsqlCommand("call insertemployee( @fname, @lname, @sname, @pos, @birstday, @startorder, @endorder, @photo, @login, @pswd)", this.conn);
				//cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@fname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = fname;
				cmd.Parameters["@fname"].IsNullable = false;
				cmd.Parameters.Add("@lname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = lname;
				cmd.Parameters["@lname"].IsNullable = false;
				cmd.Parameters.Add("@sname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = sname;
				cmd.Parameters["@sname"].IsNullable = true;
				cmd.Parameters.Add("@pos", NpgsqlTypes.NpgsqlDbType.Varchar).Value = position;
				cmd.Parameters["@pos"].IsNullable = true;
				cmd.Parameters.Add("@birstday", NpgsqlTypes.NpgsqlDbType.Date).Value = birstday;
				cmd.Parameters["@birstday"].IsNullable = true;
				cmd.Parameters.Add("@startorder", NpgsqlTypes.NpgsqlDbType.Varchar).Value = startorder;
				cmd.Parameters["@startorder"].IsNullable = true;
				cmd.Parameters.Add("@endorder", NpgsqlTypes.NpgsqlDbType.Varchar).Value = endorder;
				cmd.Parameters["@endorder"].IsNullable = true;
				cmd.Parameters.Add("@photo", NpgsqlTypes.NpgsqlDbType.Bytea).Value = (photo != "" ? Photo.Resize(photo, 150, 170) : null);
				cmd.Parameters["@photo"].IsNullable = true;
				cmd.Parameters.Add("@login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = login;
				cmd.Parameters["@login"].IsNullable = false;
				cmd.Parameters.Add("@pswd", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pswd;
				cmd.Parameters["@pswd"].IsNullable = false;
				cmd.ExecuteNonQuery();
				Refresh();
				return true;
			} else {
				return false;
			}
		}

		public bool RemEmploee(Guid id) {
			if (GetConnectionState() == ConnectionState.Open) {
				NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM employees WHERE id = @id", this.conn);
				cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Uuid).Value = id;
				cmd.ExecuteNonQuery();
				Refresh();
				return true;
			} else
				return false;
		}

	}
}
