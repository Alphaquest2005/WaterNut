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


using Core.Common.Client.Services;
using Core.Common.Client.Repositories;
using CoreEntities.Client.Services;
using CoreEntities.Client.Entities;
using CoreEntities.Client.DTO;
using Core.Common.Business.Services;
using System.Diagnostics;


using System.Threading.Tasks;
using System.Linq;
using Core.Common;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using System.ServiceModel;
using TrackableEntities.Common;

using AsycudaDocumentItem = CoreEntities.Client.Entities.AsycudaDocumentItem;

namespace CoreEntities.Client.Repositories 
{
   
    public partial class AsycudaDocumentItemRepository : BaseRepository<AsycudaDocumentItemRepository>
    {

       private static readonly AsycudaDocumentItemRepository instance;
       static AsycudaDocumentItemRepository()
        {
            instance = new AsycudaDocumentItemRepository();
        }

       public static AsycudaDocumentItemRepository Instance
        {
            get { return instance; }
        }
        
        public async Task<IEnumerable<AsycudaDocumentItem>> AsycudaDocumentItems(List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return new List<AsycudaDocumentItem>().AsEnumerable();
            try
            {
                using (var t = new AsycudaDocumentItemClient())
                    {
                        var res = await t.GetAsycudaDocumentItems(includesLst).ConfigureAwait(continueOnCapturedContext: false);
                        if (res != null)
                        {
                            return res.Select(x => new AsycudaDocumentItem(x)).AsEnumerable();
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

		 public async Task<IEnumerable<AsycudaDocumentItem>> GetAsycudaDocumentItemsByExpression(string exp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<AsycudaDocumentItem>().AsEnumerable();
            try
            {
                using (var t = new AsycudaDocumentItemClient())
                    {
					    IEnumerable<DTO.AsycudaDocumentItem> res = null;
                        if(exp == "All")
                        {                       
						    res = await t.GetAsycudaDocumentItems(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetAsycudaDocumentItemsByExpression(exp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new AsycudaDocumentItem(x)).AsEnumerable();
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

		 public async Task<IEnumerable<AsycudaDocumentItem>> GetAsycudaDocumentItemsByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || expLst.Count == 0 || expLst.FirstOrDefault() == "None") return new List<AsycudaDocumentItem>().AsEnumerable();
            try
            {
                using (var t = new AsycudaDocumentItemClient())
                    {
					    IEnumerable<DTO.AsycudaDocumentItem> res = null;
                       
                        res = await t.GetAsycudaDocumentItemsByExpressionLst(expLst, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                      
                    
                        if (res != null)
                        {
                            return res.Select(x => new AsycudaDocumentItem(x)).AsEnumerable();
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


		 public async Task<IEnumerable<AsycudaDocumentItem>> GetAsycudaDocumentItemsByExpressionNav(string exp, Dictionary<string, string> navExp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<AsycudaDocumentItem>().AsEnumerable();
            try
            {
                using (var t = new AsycudaDocumentItemClient())
                    {
					    IEnumerable<DTO.AsycudaDocumentItem> res = null;
                        if(exp == "All" && navExp.Count == 0)
                        {                       
						    res = await t.GetAsycudaDocumentItems(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetAsycudaDocumentItemsByExpressionNav(exp, navExp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new AsycudaDocumentItem(x)).AsEnumerable();
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


        public async Task<AsycudaDocumentItem> GetAsycudaDocumentItem(string id, List<string> includesLst = null)
        {
             try
             {   
                 using (var t = new AsycudaDocumentItemClient())
                    {
                        var res = await t.GetAsycudaDocumentItemByKey(id,includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return new AsycudaDocumentItem(res)
                    {
                  // AsycudaDocument = (res.AsycudaDocument != null?new AsycudaDocument(res.AsycudaDocument): null),    
                     // SubItems = new System.Collections.ObjectModel.ObservableCollection<SubItems>(res.SubItems.Select(y => new SubItems(y))),    
                     // PreviousItems = new System.Collections.ObjectModel.ObservableCollection<EntryPreviousItems>(res.PreviousItems.Select(y => new EntryPreviousItems(y))),    
                     // xcuda_Supplementary_unit = new System.Collections.ObjectModel.ObservableCollection<xcuda_Supplementary_unit>(res.xcuda_Supplementary_unit.Select(y => new xcuda_Supplementary_unit(y)))    
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

        public async Task<AsycudaDocumentItem> UpdateAsycudaDocumentItem(AsycudaDocumentItem entity)
        {
            if (entity == null) return entity;
            var entitychanges = entity.ChangeTracker.GetChanges().FirstOrDefault();
            if (entitychanges != null)
            {
                try
                {
                    using (var t = new AsycudaDocumentItemClient())
                    {
     
                        var updatedEntity =  await t.UpdateAsycudaDocumentItem(entitychanges).ConfigureAwait(false);
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

        public async Task<AsycudaDocumentItem> CreateAsycudaDocumentItem(AsycudaDocumentItem entity)
        {
            try
            {   
                using (var t = new AsycudaDocumentItemClient())
                    {
                        return new AsycudaDocumentItem(await t.CreateAsycudaDocumentItem(entity.DTO).ConfigureAwait(continueOnCapturedContext: false));
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

        public async Task<bool> DeleteAsycudaDocumentItem(string id)
        {
            try
            {
             using (var t = new AsycudaDocumentItemClient())
                {
                    return await t.DeleteAsycudaDocumentItem(id).ConfigureAwait(continueOnCapturedContext: false);
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

		public async Task<Tuple<IEnumerable<AsycudaDocumentItem>, int>> LoadRange(int startIndex, int count, string exp, Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
			var overallCount = 0;
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None")
            {
                
                return new Tuple<IEnumerable<AsycudaDocumentItem>, int>(new List<AsycudaDocumentItem>().AsEnumerable(), overallCount);
            }
            
            try
            {
                using (var t = new AsycudaDocumentItemClient())
                {

                    IEnumerable<DTO.AsycudaDocumentItem> res = null;
                                         
						    res = await t.LoadRangeNav(startIndex, count, exp, navExp, includeLst).ConfigureAwait(continueOnCapturedContext: false);
						    overallCount = await t.CountNav(exp, navExp).ConfigureAwait(continueOnCapturedContext: false);
                   
                   
                                
                    if (res != null)
                    {
                        return new Tuple<IEnumerable<AsycudaDocumentItem>, int>(res.Select(x => new AsycudaDocumentItem(x)).AsEnumerable(), overallCount);
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

	 public async Task<IEnumerable<AsycudaDocumentItem>> GetAsycudaDocumentItemByAsycudaDocumentId(string AsycudaDocumentId, List<string> includesLst = null)
        {
             if (AsycudaDocumentId == "0") return null;
            try
            {
                 using (AsycudaDocumentItemClient t = new AsycudaDocumentItemClient())
                    {
                        var res = await t.GetAsycudaDocumentItemByAsycudaDocumentId(AsycudaDocumentId, includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return res.Select(x => new AsycudaDocumentItem(x)).AsEnumerable();
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
 	 public async Task<IEnumerable<AsycudaDocumentItem>> GetAsycudaDocumentItemByEntryDataDetailsId(string EntryDataDetailsId, List<string> includesLst = null)
        {
             if (EntryDataDetailsId == "0") return null;
            try
            {
                 using (AsycudaDocumentItemClient t = new AsycudaDocumentItemClient())
                    {
                        var res = await t.GetAsycudaDocumentItemByEntryDataDetailsId(EntryDataDetailsId, includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return res.Select(x => new AsycudaDocumentItem(x)).AsEnumerable();
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
                using (var t = new AsycudaDocumentItemClient())
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
                using (var t = new AsycudaDocumentItemClient())
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

