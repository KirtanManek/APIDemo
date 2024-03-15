using APIDemo.BAL;
using APIDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	[Authorize]
	public class PersonController : Controller
	{
		#region Get All Persons
		[HttpGet]
		public IActionResult Get()
		{
			Person_BALBase objPerson_BALBase = new();
			List<PersonModel> persons = objPerson_BALBase.API_Person_SelectAll();
			Dictionary<string, dynamic> response = new();
			if (persons.Count > 0 && persons != null)
			{
				response.Add("status", true);
				response.Add("Message", "Data Found!");
				response.Add("data", persons);
				return Ok(response);
			}
			else
			{
				response.Add("status", false);
				response.Add("message", "No Data Found!");
				response.Add("data", null);
				return NotFound(response);
			}
		}
		#endregion
		#region Get Person By PersonID
		[HttpGet("{PersonID}")]
		public IActionResult Get(int PersonID)
		{
			Person_BALBase objPerson_BALBase = new();
			PersonModel person = objPerson_BALBase.API_Person_SelectByPersonID(PersonID);
			Dictionary<string, dynamic> response = new();
			if (person != null)
			{
				response.Add("status", true);
				response.Add("Message", "Data Found!");
				response.Add("data", person);
				return Ok(response);
			}
			else
			{
				response.Add("status", false);
				response.Add("message", "No Data Found!");
				response.Add("data", null);
				return NotFound(response);
			}
		}
		#endregion
		#region Delete Person By ID
		[HttpDelete("{PersonID}")]
		public IActionResult DeleteByPersonID(int PersonID)
		{
			Person_BALBase objPerson_BALBase = new();
			int rowsAffected = objPerson_BALBase.API_Person_DeleteByPersonID(PersonID);
			Dictionary<string, dynamic> response = new();
			if (rowsAffected != 0)
			{
				response.Add("status", true);
				response.Add("Message", "Data Deleted!");
				return Ok(response);
			}
			else
			{
				response.Add("status", false);
				response.Add("message", "No Data Deleted!");
				return NotFound(response);
			}
		}
		#endregion
		#region Insert Person
		[HttpPost]
		public IActionResult InsertPerson(PersonModel personModel)
		{
			Person_BALBase objPerson_BALBase = new();
			int rowsAffected = objPerson_BALBase.API_Person_Insert(personModel);
			Dictionary<string, dynamic> response = new();
			if (rowsAffected != 0)
			{
				response.Add("status", true);
				response.Add("Message", "Data Inserted!");
				return Ok(response);
			}
			else
			{
				response.Add("status", false);
				response.Add("message", "No Data Inserted!");
				return NotFound(response);
			}

		}
		#endregion
		#region Update Person
		[HttpPut]
		public IActionResult UpdatePerson(PersonModel personModel)
		{
			Person_BALBase objPerson_BALBase = new();
			int rowsAffected = objPerson_BALBase.API_Person_Update(personModel);
			Dictionary<string, dynamic> response = new();
			if (rowsAffected != 0)
			{
				response.Add("status", true);
				response.Add("Message", "Data Updated!");
				return Ok(response);
			}
			else
			{
				response.Add("status", false);
				response.Add("message", "No Data Updated!");
				return NotFound(response);
			}
		}
		#endregion
	}
}