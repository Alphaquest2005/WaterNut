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
using PreviousDocumentQS.Client.Services;
using PreviousDocumentQS.Client.Entities;
using PreviousDocumentQS.Client.DTO;
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

using PreviousItemsEx = PreviousDocumentQS.Client.Entities.PreviousItemsEx;

namespace PreviousDocumentQS.Client.Repositories 
{
   
    public partial class PreviousItemsExRepository : BaseRepository<PreviousItemsExRepository>
    {

       private static readonly PreviousItemsExRepository instance;
       static PreviousItemsExRepository()
        {
            instance = new PreviousItemsExRepository();
        }

       public static PreviousItemsExRepository Instance
        {
            get { return instance; }
        }
        
        public async Task<IEnumerable<PreviousItemsEx>> PreviousItemsExes(List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return new List<PreviousItemsEx>().AsEnumerable();
            try
            {
                using (var t = new PreviousItemsExClient())
                    {
                        var res = await t.GetPreviousItemsExes(includesLst).ConfigureAwait(continueOnCapturedContext: false);
                        if (res != null)
                        {
                            return res.Select(x => new PreviousItemsEx(x)).AsEnumerable();
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

		 public async Task<IEnumerable<PreviousItemsEx>> GetPreviousItemsExesByExpression(string exp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<PreviousItemsEx>().AsEnumerable();
            try
            {
                using (var t = new PreviousItemsExClient())
                    {
					    IEnumerable<DTO.PreviousItemsEx> res = null;
                        if(exp == "All")
                        {                       
						    res = await t.GetPreviousItemsExes(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetPreviousItemsExesByExpression(exp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new PreviousItemsEx(x)).AsEnumerable();
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

		 public async Task<IEnumerable<PreviousItemsEx>> GetPreviousItemsExesByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || expLst.Count == 0 || expLst.FirstOrDefault() == "None") return new List<PreviousItemsEx>().AsEnumerable();
            try
            {
                using (var t = new PreviousItemsExClient())
                    {
					    IEnumerable<DTO.PreviousItemsEx> res = null;
                       
                        res = await t.GetPreviousItemsExesByExpressionLst(expLst, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                      
                    
                        if (res != null)
                        {
                            return res.Select(x => new PreviousItemsEx(x)).AsEnumerable();
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


		 public async Task<IEnumerable<PreviousItemsEx>> GetPreviousItemsExesByExpressionNav(string exp, Dictionary<string, string> navExp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<PreviousItemsEx>().AsEnumerable();
            try
            {
                using (var t = new PreviousItemsExClient())
                    {
					    IEnumerable<DTO.PreviousItemsEx> res = null;
                        if(exp == "All" && navExp.Count == 0)
                        {                       
						    res = await t.GetPreviousItemsExes(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetPreviousItemsExesByExpressionNav(exp, navExp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new PreviousItemsEx(x)).AsEnumerable();
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


        public async Task<PreviousItemsEx> GetPreviousItemsEx(string id, List<string> includesLst = null)
        {
             try
             {   
                 using (var t = new PreviousItemsExClient())
                    {
                        var res = await t.GetPreviousItemsExByKey(id,includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return new PreviousItemsEx(res)
                    {
                  // PreviousDocumentItem = (res.PreviousDocumentItem != null?new PreviousDocumentItem(res.PreviousDocumentItem): null),    
                  // AsycudaDocumentItem = (res.AsycudaDocumentItem != null?new PreviousDocumentItem(res.AsycudaDocumentItem): null)    
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

        public async Task<PreviousItemsEx> UpdatePreviousItemsEx(PreviousItemsEx entity)
        {
            if (entity == null) return entity;
            var entitychanges = entity.ChangeTracker.GetChanges().FirstOrDefault();
            if (entitychanges != null)
            {
                try
                {
                    using (var t = new PreviousItemsExClient())
                    {
     
                        var updatedEntity =  await t.UpdatePreviousItemsEx(entitychanges).ConfigureAwait(false);
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

        public async Task<PreviousItemsEx> CreatePreviousItemsEx(PreviousItemsEx entity)
        {
            try
            {   
                using (var t = new PreviousItemsExClient())
                    {
                        return new PreviousItemsEx(await t.CreatePreviousItemsEx(entity.DTO).ConfigureAwait(continueOnCapturedContext: false));
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

        public async Task<bool> DeletePreviousItemsEx(string id)
        {
            try
            {
             using (var t = new PreviousItemsExClient())
                {
                    return await t.DeletePreviousItemsEx(id).ConfigureAwait(continueOnCapturedContext: false);
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

		public async Task<Tuple<IEnumerable<PreviousItemsEx>, int>> LoadRange(int startIndex, int count, string exp, Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
			var overallCount = 0;
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None")
            {
                
                return new Tuple<IEnumerable<PreviousItemsEx>, int>(new List<PreviousItemsEx>().AsEnumerable(), overallCount);
            }
            
            try
            {
                using (var t = new PreviousItemsExClient())
                {

                    IEnumerable<DTO.PreviousItemsEx> res = null;
                                         
						    res = await t.LoadRangeNav(startIndex, count, exp, navExp, includeLst).ConfigureAwait(continueOnCapturedContext: false);
						    overallCount = await t.CountNav(exp, navExp).ConfigureAwait(continueOnCapturedContext: false);
                   
                   
                                
                    if (res != null)
                    {
                        return new Tuple<IEnumerable<PreviousItemsEx>, int>(res.Select(x => new PreviousItemsEx(x)).AsEnumerable(), overallCount);
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

	 public async Task<IEnumerable<PreviousItemsEx>> GetPreviousItemsExByASYCUDA_Id(string ASYCUDA_Id, List<string> includesLst = null)
        {
             if (ASYCUDA_Id == "0") return null;
            try
            {
                 using (PreviousItemsExClient t = new PreviousItemsExClient())
                    {
                        var res = await t.GetPreviousItemsExByASYCUDA_Id(ASYCUDA_Id, includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return res.Select(x => new PreviousItemsEx(x)).AsEnumerable();
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
 	 public async Task<IEnumerable<PreviousItemsEx>> GetPreviousItemsExByPreviousDocumentItemId(string PreviousDocumentItemId, List<string> includesLst = null)
        {
             if (PreviousDocumentItemId == "0") return null;
            try
            {
                 using (PreviousItemsExClient t = new PreviousItemsExClient())
                    {
                        var res = await t.GetPreviousItemsExByPreviousDocumentItemId(PreviousDocumentItemId, includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return res.Select(x => new PreviousItemsEx(x)).AsEnumerable();
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
 	 public async Task<IEnumerable<PreviousItemsEx>> GetPreviousItemsExByAsycudaDocumentItemId(string AsycudaDocumentItemId, List<string> includesLst = null)
        {
             if (AsycudaDocumentItemId == "0") return null;
            try
            {
                 using (PreviousItemsExClient t = new PreviousItemsExClient())
                    {
                        var res = await t.GetPreviousItemsExByAsycudaDocumentItemId(AsycudaDocumentItemId, includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return res.Select(x => new PreviousItemsEx(x)).AsEnumerable();
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
                using (var t = new PreviousItemsExClient())
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
                using (var t = new PreviousItemsExClient())
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

