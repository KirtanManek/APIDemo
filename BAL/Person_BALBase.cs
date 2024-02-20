using APIDemo.Models;
using APIDemo.DAL;

namespace APIDemo.BAL
{
	public class Person_BALBase
	{
		#region API_Person_SelectAll
		public List<PersonModel> API_Person_SelectAll()
		{
			try
			{
				Person_DALBase objPerson_DALBase = new();
				List<PersonModel> result = objPerson_DALBase.API_Person_SelectAll();
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
				Person_DALBase objPerson_DALBase = new();
				PersonModel result = objPerson_DALBase.API_Person_SelectByPersonID(PersonID);
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
				Person_DALBase objPerson_DALBase = new();
				int rowsAffected = objPerson_DALBase.API_Person_DeleteByPersonID(PersonID);
				return rowsAffected;
			}
			catch (Exception)
			{
				throw;
			}
		}
		#endregion
		#region API_Person_Insert
		public int API_Person_Insert(PersonModel objPersonModel)
		{
			try
			{
				Person_DALBase objPerson_DALBase = new();
				int rowsAffected = objPerson_DALBase.API_Person_Insert(objPersonModel);
				return rowsAffected;
			}
			catch (Exception)
			{
				throw;
			}
		}
		#endregion
		#region API_Person_Update
		public int API_Person_Update(PersonModel objPersonModel)
		{
			try
			{
				Person_DALBase objPerson_DALBase = new();
				int rowsAffected = objPerson_DALBase.API_Person_Update(objPersonModel);
				return rowsAffected;
			}
			catch (Exception)
			{
				throw;
			}
		}
		#endregion
	}
}
