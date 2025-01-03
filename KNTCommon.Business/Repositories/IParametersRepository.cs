﻿using KNTCommon.Business.DTOs;
using KNTCommon.Data.Models;

namespace KNTCommon.Business.Repositories
{
    public interface IParametersRepository
    {
        IEnumerable<ParameterDTO> GetParameters(string key);
        string GetParametersStr(string key);
        bool UpdateParameters(string name, string value);
    }
}