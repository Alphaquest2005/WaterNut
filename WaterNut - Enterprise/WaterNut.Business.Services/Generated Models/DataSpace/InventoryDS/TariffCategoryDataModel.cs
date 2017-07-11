﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using InventoryDS.Business.Entities;
using InventoryDS.Business.Services;




namespace WaterNut.DataSpace.InventoryDS.DataModels
{
	public partial class TariffCategoryDataModel_AutoGen 
	{
        private static readonly TariffCategoryDataModel_AutoGen instance;
        static TariffCategoryDataModel_AutoGen()
        {
            instance = new TariffCategoryDataModel_AutoGen();
        }

        public static  TariffCategoryDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<TariffCategory>> SearchTariffCategory(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new TariffCategoryService())
            {
                return await ctx.GetTariffCategoriesByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
