﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using DocumentDS.Business.Entities;
using DocumentDS.Business.Services;




namespace WaterNut.DataSpace.DocumentDS.DataModels
{
	public partial class xcuda_Border_officeDataModel_AutoGen 
	{
        private static readonly xcuda_Border_officeDataModel_AutoGen instance;
        static xcuda_Border_officeDataModel_AutoGen()
        {
            instance = new xcuda_Border_officeDataModel_AutoGen();
        }

        public static  xcuda_Border_officeDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Border_office>> Searchxcuda_Border_office(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Border_officeService())
            {
                return await ctx.Getxcuda_Border_officeByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		