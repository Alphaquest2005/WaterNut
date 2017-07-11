﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using EntryDataDS.Business.Entities;
using EntryDataDS.Business.Services;




namespace WaterNut.DataSpace.EntryDataDS.DataModels
{
	public partial class InventoryItemsExDataModel_AutoGen 
	{
        private static readonly InventoryItemsExDataModel_AutoGen instance;
        static InventoryItemsExDataModel_AutoGen()
        {
            instance = new InventoryItemsExDataModel_AutoGen();
        }

        public static  InventoryItemsExDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<InventoryItemsEx>> SearchInventoryItemsEx(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new InventoryItemsExService())
            {
                return await ctx.GetInventoryItemsExByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		