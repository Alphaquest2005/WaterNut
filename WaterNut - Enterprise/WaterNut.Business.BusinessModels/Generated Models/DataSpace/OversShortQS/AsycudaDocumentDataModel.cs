﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;
using SimpleMvvmToolkit;
using TrackableEntities;
using System;
using OversShortQS.Business.Entities;
using OversShortQS.Business.Services;




namespace WaterNut.DataSpace.OversShortQS.DataModels
{
	public partial class AsycudaDocumentDataModel_AutoGen 
	{
        private static readonly AsycudaDocumentDataModel_AutoGen instance;
        static AsycudaDocumentDataModel_AutoGen()
        {
            instance = new AsycudaDocumentDataModel_AutoGen();
        }

        public static  AsycudaDocumentDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<AsycudaDocument>> SearchAsycudaDocument(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new AsycudaDocumentService())
            {
                return await ctx.GetAsycudaDocumentsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
