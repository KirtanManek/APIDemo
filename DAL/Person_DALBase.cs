using APIDemo.Models;
using System.Data;
using System.Data.SqlClient;

namespace APIDemo.DAL
{
	public class Person_DALBase : DAL_Helpers
	{
		#region API_Person_SelectAll
		public List<PersonModel> API_Person_SelectAll()
		{
			try
			{
				List<PersonModel> result = new();
				using SqlConnection conn = new(ConnectionString);
				using SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "API_Person_SelectAll";
				conn.Open();
				using SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					PersonModel item = new()
					{
						PersonID = Convert.ToInt32(dr["PersonID"]),
						Name = Convert.ToString(dr["Name"]),
						Contact = Convert.ToString(dr["Contact"]),
						Email = Convert.ToString(dr["Email"])
					};
					result.Add(item);
				}
				conn.Close();
				return result;
			}
			catch (Exception)
			{
				throw;
			}
		}
		#endregion

		#region API_Person_SelectByPersonID
		public PersonModel API_Person_SelectByPersonID(int PersonID)
		{
			try
			{
				PersonModel result = new();
				using SqlConnection conn = new(ConnectionString);
				using SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "API_Person_SelectByPersonID";
				cmd.Parameters.Add(new SqlParameter("@PersonID", PersonID));
				conn.Open();
				using SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					result.PersonID = Convert.ToInt32(dr["PersonID"]);
					result.Name = Convert.ToString(dr["Name"]);
					result.Contact = Convert.ToString(dr["Contact"]);
					result.Email = Convert.ToString(dr["Email"]);
				}
				conn.Close();
				return result;
			}
			catch (Exception)
			{
				throw;
			}
		}
		#endregion

		#region API_Person_DeleteByPersonID
		public int API_Person_DeleteByPersonID(int PersonID)
		{
			try
			{
				using SqlConnection conn = new(ConnectionString);
				using SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "API_Person_DeleteByPersonID";
				cmd.Parameters.Add(new SqlParameter("@PersonID", PersonID));
				conn.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				conn.Close();
				return rowsAffected;
			}
			catch (Exception)
			{
				throw;
			}
		}
		#endregion
		#region API_Person_Insert
		public int API_Person_Insert(PersonModel personModel)
		{
			try
			{
				using SqlConnection conn = new(ConnectionString);
				using SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "API_Person_Insert";
				cmd.Parameters.Add(new SqlParameter("@Name", personModel.Name));
				cmd.Parameters.Add(new SqlParameter("@Contact", personModel.Contact));
				cmd.Parameters.Add(new SqlParameter("@Email", personModel.Email));
				conn.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				conn.Close();
				return rowsAffected;
			}
			catch
			{
				throw;
			}
		}
		#endregion
		#region API_Person_Update
		public int API_Person_Update(PersonModel personModel)
		{
			try
			{
				using SqlConnection conn = new(ConnectionString);
				using SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "API_Person_Update";
				cmd.Parameters.Add(new SqlParameter("@PersonID", personModel.PersonID));
				cmd.Parameters.Add(new SqlParameter("@Name", personModel.Name));
				cmd.Parameters.Add(new SqlParameter("@Contact", personModel.Contact));
				cmd.Parameters.Add(new SqlParameter("@Email", personModel.Email));
				conn.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				conn.Close();
				return rowsAffected;
			}
			catch
			{
				throw;
			}
		}
		#endregion
	}
}
