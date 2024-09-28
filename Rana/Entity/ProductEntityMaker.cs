using Rana.Enums;
using System;
using System.Collections.Generic;

namespace Rana.Entity
{
    internal static class ProductEntityMaker
    {
        internal static IEnumerable<ProductEntity> GetData()
        {
            var result = new List<ProductEntity>();

            foreach (PkgEnum pkg in Enum.GetValues(typeof(PkgEnum)))
            {
                result.Add(new ProductEntity((int)pkg, 0, 1, pkg.ToString()));

                foreach (SystemTypeEnum sysType in Enum.GetValues(typeof(SystemTypeEnum)))
                {
                    int _sysType = (int)pkg + (int)sysType;
                    result.Add(new ProductEntity(_sysType, (int)pkg, 1, sysType.ToString()));

                    foreach (CommandEnum cmd in Enum.GetValues(typeof(CommandEnum)))
                    {
                        int _cmd = (int)pkg + (int)sysType + (int)cmd;
                        result.Add(new ProductEntity(_cmd, _sysType, 2, cmd.ToString()));
                    }
                }
            }

            return result;
        }
    }
}