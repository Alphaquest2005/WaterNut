﻿// <autogenerated>
//   This file was generated by T4 code generator ViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using AllocationDS.Business.Entities;
using AllocationDS.Business.Services;




namespace WaterNut.DataSpace.AllocationDS.DataModels
{
	public partial class xcuda_Supplementary_unitDataModel_AutoGen 
	{
        private static readonly xcuda_Supplementary_unitDataModel_AutoGen instance;
        static xcuda_Supplementary_unitDataModel_AutoGen()
        {
            instance = new xcuda_Supplementary_unitDataModel_AutoGen();
        }

        public static  xcuda_Supplementary_unitDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Supplementary_unit>> Searchxcuda_Supplementary_unit(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Supplementary_unitService())
            {
                return await ctx.Getxcuda_Supplementary_unitByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		