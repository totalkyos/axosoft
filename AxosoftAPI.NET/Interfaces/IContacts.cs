﻿using AxosoftAPI.NET.Core.Interfaces;
using AxosoftAPI.NET.Models;

namespace AxosoftAPI.NET.Interfaces
{
	public interface IContacts : IResource<Contact>
	{
		Result<Contact> GetInit();
	}
}
