﻿using System.Collections.Generic;
using StabilityMatrix.Models.Packages;

namespace StabilityMatrix.Helper;

public interface IPackageFactory
{
    IEnumerable<BasePackage> GetAllAvailablePackages();
    BasePackage? FindPackageByName(string packageName);
}