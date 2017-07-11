﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using OversShortQS.Business.Entities;
using OversShortQS.Business.Services;




namespace WaterNut.DataSpace.OversShortQS.DataModels
{
	public partial class OverShortAllocationsEXDataModel_AutoGen 
	{
        private static readonly OverShortAllocationsEXDataModel_AutoGen instance;
        static OverShortAllocationsEXDataModel_AutoGen()
        {
            instance = new OverShortAllocationsEXDataModel_AutoGen();
        }

        public static  OverShortAllocationsEXDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<OverShortAllocationsEX>> SearchOverShortAllocationsEX(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new OverShortAllocationsEXService())
            {
                return await ctx.GetOverShortAllocationsEXesByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		