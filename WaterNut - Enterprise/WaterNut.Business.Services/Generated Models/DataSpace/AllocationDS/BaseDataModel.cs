﻿// <autogenerated>
//   This file was generated by T4 code generator ViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using AllocationDS.Business.Entities;
using AllocationDS.Business.Services;

using System.Threading.Tasks;
using System.Collections.Generic;


//using WaterNut.Client.Repositories;



namespace WaterNut.DataSpace.AllocationDS.DataModels
{
	 public partial class BaseDataModel 
	{
        private static readonly BaseDataModel instance;
        static BaseDataModel()
        {
            instance = new BaseDataModel();
        }

        public static  BaseDataModel Instance
        {
            get { return instance; }
        }

       //Search Entities
   
        public async Task<IEnumerable<AsycudaDocument>> SearchAsycudaDocument(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new AsycudaDocumentService())
            {
                return await ctx.GetAsycudaDocumentByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveAsycudaDocument(AsycudaDocument i)
        {
            if (i == null) return;
            using (var ctx = new AsycudaDocumentService())
            {
                await ctx.UpdateAsycudaDocument(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<AsycudaLkpLst>> SearchAsycudaLkpLst(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new AsycudaLkpLstService())
            {
                return await ctx.GetAsycudaLkpLstByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveAsycudaLkpLst(AsycudaLkpLst i)
        {
            if (i == null) return;
            using (var ctx = new AsycudaLkpLstService())
            {
                await ctx.UpdateAsycudaLkpLst(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<AsycudaSalesAllocations>> SearchAsycudaSalesAllocations(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new AsycudaSalesAllocationsService())
            {
                return await ctx.GetAsycudaSalesAllocationsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveAsycudaSalesAllocations(AsycudaSalesAllocations i)
        {
            if (i == null) return;
            using (var ctx = new AsycudaSalesAllocationsService())
            {
                await ctx.UpdateAsycudaSalesAllocations(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<EntryData>> SearchEntryData(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new EntryDataService())
            {
                return await ctx.GetEntryDataByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveEntryData(EntryData i)
        {
            if (i == null) return;
            using (var ctx = new EntryDataService())
            {
                await ctx.UpdateEntryData(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<EntryDataDetails>> SearchEntryDataDetails(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new EntryDataDetailsService())
            {
                return await ctx.GetEntryDataDetailsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveEntryDataDetails(EntryDataDetails i)
        {
            if (i == null) return;
            using (var ctx = new EntryDataDetailsService())
            {
                await ctx.UpdateEntryDataDetails(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<EntryDataDetailsEx>> SearchEntryDataDetailsEx(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new EntryDataDetailsExService())
            {
                return await ctx.GetEntryDataDetailsExByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveEntryDataDetailsEx(EntryDataDetailsEx i)
        {
            if (i == null) return;
            using (var ctx = new EntryDataDetailsExService())
            {
                await ctx.UpdateEntryDataDetailsEx(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<EntryPreviousItems>> SearchEntryPreviousItems(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new EntryPreviousItemsService())
            {
                return await ctx.GetEntryPreviousItemsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveEntryPreviousItems(EntryPreviousItems i)
        {
            if (i == null) return;
            using (var ctx = new EntryPreviousItemsService())
            {
                await ctx.UpdateEntryPreviousItems(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<EX9AsycudaSalesAllocations>> SearchEX9AsycudaSalesAllocations(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new EX9AsycudaSalesAllocationsService())
            {
                return await ctx.GetEX9AsycudaSalesAllocationsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveEX9AsycudaSalesAllocations(EX9AsycudaSalesAllocations i)
        {
            if (i == null) return;
            using (var ctx = new EX9AsycudaSalesAllocationsService())
            {
                await ctx.UpdateEX9AsycudaSalesAllocations(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<InventoryItemAlias>> SearchInventoryItemAlias(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new InventoryItemAliasService())
            {
                return await ctx.GetInventoryItemAliasByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveInventoryItemAlias(InventoryItemAlias i)
        {
            if (i == null) return;
            using (var ctx = new InventoryItemAliasService())
            {
                await ctx.UpdateInventoryItemAlias(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<InventoryItems>> SearchInventoryItems(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new InventoryItemsService())
            {
                return await ctx.GetInventoryItemsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveInventoryItems(InventoryItems i)
        {
            if (i == null) return;
            using (var ctx = new InventoryItemsService())
            {
                await ctx.UpdateInventoryItems(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<Sales>> SearchSales(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new SalesService())
            {
                return await ctx.GetEntryDataByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveSales(Sales i)
        {
            if (i == null) return;
            using (var ctx = new SalesService())
            {
                await ctx.UpdateSales(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<SubItems>> SearchSubItems(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new SubItemsService())
            {
                return await ctx.GetSubItemsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveSubItems(SubItems i)
        {
            if (i == null) return;
            using (var ctx = new SubItemsService())
            {
                await ctx.UpdateSubItems(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<TariffCategory>> SearchTariffCategory(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new TariffCategoryService())
            {
                return await ctx.GetTariffCategoryByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveTariffCategory(TariffCategory i)
        {
            if (i == null) return;
            using (var ctx = new TariffCategoryService())
            {
                await ctx.UpdateTariffCategory(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<TariffCodes>> SearchTariffCodes(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new TariffCodesService())
            {
                return await ctx.GetTariffCodesByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveTariffCodes(TariffCodes i)
        {
            if (i == null) return;
            using (var ctx = new TariffCodesService())
            {
                await ctx.UpdateTariffCodes(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<TariffSupUnitLkps>> SearchTariffSupUnitLkps(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new TariffSupUnitLkpsService())
            {
                return await ctx.GetTariffSupUnitLkpsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SaveTariffSupUnitLkps(TariffSupUnitLkps i)
        {
            if (i == null) return;
            using (var ctx = new TariffSupUnitLkpsService())
            {
                await ctx.UpdateTariffSupUnitLkps(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xBondAllocations>> SearchxBondAllocations(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xBondAllocationsService())
            {
                return await ctx.GetxBondAllocationsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task SavexBondAllocations(xBondAllocations i)
        {
            if (i == null) return;
            using (var ctx = new xBondAllocationsService())
            {
                await ctx.UpdatexBondAllocations(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Goods_description>> Searchxcuda_Goods_description(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Goods_descriptionService())
            {
                return await ctx.Getxcuda_Goods_descriptionByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Goods_description(xcuda_Goods_description i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_Goods_descriptionService())
            {
                await ctx.Updatexcuda_Goods_description(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_HScode>> Searchxcuda_HScode(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_HScodeService())
            {
                return await ctx.Getxcuda_HScodeByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_HScode(xcuda_HScode i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_HScodeService())
            {
                await ctx.Updatexcuda_HScode(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Item>> Searchxcuda_Item(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_ItemService())
            {
                return await ctx.Getxcuda_ItemByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Item(xcuda_Item i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_ItemService())
            {
                await ctx.Updatexcuda_Item(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Item_Invoice>> Searchxcuda_Item_Invoice(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Item_InvoiceService())
            {
                return await ctx.Getxcuda_Item_InvoiceByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Item_Invoice(xcuda_Item_Invoice i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_Item_InvoiceService())
            {
                await ctx.Updatexcuda_Item_Invoice(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_PreviousItem>> Searchxcuda_PreviousItem(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_PreviousItemService())
            {
                return await ctx.Getxcuda_PreviousItemByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_PreviousItem(xcuda_PreviousItem i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_PreviousItemService())
            {
                await ctx.Updatexcuda_PreviousItem(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Supplementary_unit>> Searchxcuda_Supplementary_unit(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Supplementary_unitService())
            {
                return await ctx.Getxcuda_Supplementary_unitByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Supplementary_unit(xcuda_Supplementary_unit i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_Supplementary_unitService())
            {
                await ctx.Updatexcuda_Supplementary_unit(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Tarification>> Searchxcuda_Tarification(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_TarificationService())
            {
                return await ctx.Getxcuda_TarificationByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Tarification(xcuda_Tarification i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_TarificationService())
            {
                await ctx.Updatexcuda_Tarification(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Taxation>> Searchxcuda_Taxation(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_TaxationService())
            {
                return await ctx.Getxcuda_TaxationByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Taxation(xcuda_Taxation i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_TaxationService())
            {
                await ctx.Updatexcuda_Taxation(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Taxation_line>> Searchxcuda_Taxation_line(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Taxation_lineService())
            {
                return await ctx.Getxcuda_Taxation_lineByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Taxation_line(xcuda_Taxation_line i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_Taxation_lineService())
            {
                await ctx.Updatexcuda_Taxation_line(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Valuation_item>> Searchxcuda_Valuation_item(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Valuation_itemService())
            {
                return await ctx.Getxcuda_Valuation_itemByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Valuation_item(xcuda_Valuation_item i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_Valuation_itemService())
            {
                await ctx.Updatexcuda_Valuation_item(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Weight>> Searchxcuda_Weight(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_WeightService())
            {
                return await ctx.Getxcuda_WeightByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Weight(xcuda_Weight i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_WeightService())
            {
                await ctx.Updatexcuda_Weight(i).ConfigureAwait(false);
            }
        }
   
        public async Task<IEnumerable<xcuda_Weight_itm>> Searchxcuda_Weight_itm(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Weight_itmService())
            {
                return await ctx.Getxcuda_Weight_itmByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

        public async Task Savexcuda_Weight_itm(xcuda_Weight_itm i)
        {
            if (i == null) return;
            using (var ctx = new xcuda_Weight_itmService())
            {
                await ctx.Updatexcuda_Weight_itm(i).ConfigureAwait(false);
            }
        }
   
    

    }		
}
