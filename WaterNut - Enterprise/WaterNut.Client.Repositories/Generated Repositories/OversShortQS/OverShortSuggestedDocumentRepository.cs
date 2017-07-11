﻿// <autogenerated>
//   This file was generated by T4 code generator AllRepository.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using TrackableEntities.Common;
using Core.Common.Client.Services;
using Core.Common.Client.Repositories;
using OversShortQS.Client.Services;
using OversShortQS.Client.Entities;
using OversShortQS.Client.DTO;
using Core.Common.Business.Services;
using System.Diagnostics;
using TrackableEntities.Client;


using System.Threading.Tasks;
using System.Linq;
using Core.Common;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using System.ServiceModel;

using OverShortSuggestedDocument = OversShortQS.Client.Entities.OverShortSuggestedDocument;

namespace OversShortQS.Client.Repositories 
{
   
    public partial class OverShortSuggestedDocumentRepository : BaseRepository<OverShortSuggestedDocumentRepository>
    {

       private static readonly OverShortSuggestedDocumentRepository instance;
       static OverShortSuggestedDocumentRepository()
        {
            instance = new OverShortSuggestedDocumentRepository();
        }

       public static OverShortSuggestedDocumentRepository Instance
        {
            get { return instance; }
        }
        
        public async Task<IEnumerable<OverShortSuggestedDocument>> OverShortSuggestedDocuments(List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return new List<OverShortSuggestedDocument>().AsEnumerable();
            try
            {
                using (var t = new OverShortSuggestedDocumentClient())
                    {
                        var res = await t.GetOverShortSuggestedDocuments(includesLst).ConfigureAwait(continueOnCapturedContext: false);
                        if (res != null)
                        {
                            return res.Select(x => new OverShortSuggestedDocument(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

		 public async Task<IEnumerable<OverShortSuggestedDocument>> GetOverShortSuggestedDocumentsByExpression(string exp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<OverShortSuggestedDocument>().AsEnumerable();
            try
            {
                using (var t = new OverShortSuggestedDocumentClient())
                    {
					    IEnumerable<DTO.OverShortSuggestedDocument> res = null;
                        if(exp == "All")
                        {                       
						    res = await t.GetOverShortSuggestedDocuments(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetOverShortSuggestedDocumentsByExpression(exp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new OverShortSuggestedDocument(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

		 public async Task<IEnumerable<OverShortSuggestedDocument>> GetOverShortSuggestedDocumentsByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || expLst.Count == 0 || expLst.FirstOrDefault() == "None") return new List<OverShortSuggestedDocument>().AsEnumerable();
            try
            {
                using (var t = new OverShortSuggestedDocumentClient())
                    {
					    IEnumerable<DTO.OverShortSuggestedDocument> res = null;
                       
                        res = await t.GetOverShortSuggestedDocumentsByExpressionLst(expLst, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                      
                    
                        if (res != null)
                        {
                            return res.Select(x => new OverShortSuggestedDocument(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }


		 public async Task<IEnumerable<OverShortSuggestedDocument>> GetOverShortSuggestedDocumentsByExpressionNav(string exp, Dictionary<string, string> navExp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<OverShortSuggestedDocument>().AsEnumerable();
            try
            {
                using (var t = new OverShortSuggestedDocumentClient())
                    {
					    IEnumerable<DTO.OverShortSuggestedDocument> res = null;
                        if(exp == "All" && navExp.Count == 0)
                        {                       
						    res = await t.GetOverShortSuggestedDocuments(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetOverShortSuggestedDocumentsByExpressionNav(exp, navExp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new OverShortSuggestedDocument(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }


        public async Task<OverShortSuggestedDocument> GetOverShortSuggestedDocument(string id, List<string> includesLst = null)
        {
             try
             {   
                 using (var t = new OverShortSuggestedDocumentClient())
                    {
                        var res = await t.GetOverShortSuggestedDocumentByKey(id,includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return new OverShortSuggestedDocument(res)
                    {
                  // OversShortEX = (res.OversShortEX != null?new OversShortEX(res.OversShortEX): null)    
                  };
                    }
                    else
                    {
                        return null;
                    }                    
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

        public async Task<OverShortSuggestedDocument> UpdateOverShortSuggestedDocument(OverShortSuggestedDocument entity)
        {
            if (entity == null) return entity;
            var entitychanges = entity.ChangeTracker.GetChanges().FirstOrDefault();
            if (entitychanges != null)
            {
                try
                {
                    using (var t = new OverShortSuggestedDocumentClient())
                    {
     
                        var updatedEntity =  await t.UpdateOverShortSuggestedDocument(entitychanges).ConfigureAwait(false);
                        entity.EntityId = updatedEntity.EntityId;
                        entity.DTO.AcceptChanges();
                         //var  = entity.;
                        //entity.ChangeTracker.MergeChanges(,updatedEntity);
                        //entity. = ;
                        return entity;
                    }
                }
                catch (FaultException<ValidationFault> e)
                {
                    throw new Exception(e.Detail.Message, e.InnerException);
                }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
            }
            else
            {
                return entity;
            }

        }

        public async Task<OverShortSuggestedDocument> CreateOverShortSuggestedDocument(OverShortSuggestedDocument entity)
        {
            try
            {   
                using (var t = new OverShortSuggestedDocumentClient())
                    {
                        return new OverShortSuggestedDocument(await t.CreateOverShortSuggestedDocument(entity.DTO).ConfigureAwait(continueOnCapturedContext: false));
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

        public async Task<bool> DeleteOverShortSuggestedDocument(string id)
        {
            try
            {
             using (var t = new OverShortSuggestedDocumentClient())
                {
                    return await t.DeleteOverShortSuggestedDocument(id).ConfigureAwait(continueOnCapturedContext: false);
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }  
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }         
        }


		//Virtural List Implementation

		public async Task<Tuple<IEnumerable<OverShortSuggestedDocument>, int>> LoadRange(int startIndex, int count, string exp, Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
			var overallCount = 0;
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None")
            {
                
                return new Tuple<IEnumerable<OverShortSuggestedDocument>, int>(new List<OverShortSuggestedDocument>().AsEnumerable(), overallCount);
            }
            
            try
            {
                using (var t = new OverShortSuggestedDocumentClient())
                {

                    IEnumerable<DTO.OverShortSuggestedDocument> res = null;
                                         
						    res = await t.LoadRangeNav(startIndex, count, exp, navExp, includeLst).ConfigureAwait(continueOnCapturedContext: false);
						    overallCount = await t.CountNav(exp, navExp).ConfigureAwait(continueOnCapturedContext: false);
                   
                   
                                
                    if (res != null)
                    {
                        return new Tuple<IEnumerable<OverShortSuggestedDocument>, int>(res.Select(x => new OverShortSuggestedDocument(x)).AsEnumerable(), overallCount);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

        
		public decimal SumField(string whereExp, string sumExp)
        {
            try
            {
                using (var t = new OverShortSuggestedDocumentClient())
                {
                    return t.SumField(whereExp,sumExp);
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }

        }

        public async Task<decimal> SumNav(string whereExp, Dictionary<string, string> navExp, string sumExp)
        {
            try
            {
                using (var t = new OverShortSuggestedDocumentClient())
                {
                    return await t.SumNav(whereExp,navExp,sumExp).ConfigureAwait(false);
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }

        }
    }
}

