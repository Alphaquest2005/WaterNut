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
	public partial class OverShortSuggestedDocumentDataModel_AutoGen 
	{
        private static readonly OverShortSuggestedDocumentDataModel_AutoGen instance;
        static OverShortSuggestedDocumentDataModel_AutoGen()
        {
            instance = new OverShortSuggestedDocumentDataModel_AutoGen();
        }

        public static  OverShortSuggestedDocumentDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<OverShortSuggestedDocument>> SearchOverShortSuggestedDocument(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new OverShortSuggestedDocumentService())
            {
                return await ctx.GetOverShortSuggestedDocumentsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
