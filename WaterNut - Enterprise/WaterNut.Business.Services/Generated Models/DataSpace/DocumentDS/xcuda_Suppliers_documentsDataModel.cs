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
	public partial class xcuda_Suppliers_documentsDataModel_AutoGen 
	{
        private static readonly xcuda_Suppliers_documentsDataModel_AutoGen instance;
        static xcuda_Suppliers_documentsDataModel_AutoGen()
        {
            instance = new xcuda_Suppliers_documentsDataModel_AutoGen();
        }

        public static  xcuda_Suppliers_documentsDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Suppliers_documents>> Searchxcuda_Suppliers_documents(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Suppliers_documentsService())
            {
                return await ctx.Getxcuda_Suppliers_documentsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
