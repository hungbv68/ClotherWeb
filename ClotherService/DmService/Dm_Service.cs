using Microsoft.EntityFrameworkCore;
using New_Clother_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotherService.DmItemService
{
    public class Dm_Service : IDm_Service
    {
        private NewClotherContext clotherContext;

        public Dm_Service(NewClotherContext context)
        {
            clotherContext = context;
        }

        #region DM_ITEM
        public void Delete_Dm_Item(DmItem item)
        {

            if (item != null)
                clotherContext.DmItems.Remove(item);
            clotherContext.SaveChanges();
        }

        public async Task<DmItem> Get_Dm_Item_ById(string itemId)
        {
            return await clotherContext.DmItems.FindAsync(itemId);
        }

        public async Task<List<DmItem>> List_Dm_Item()
        {
            return await clotherContext.DmItems.ToListAsync();
        }

        public async Task<DmItem> Update_Dm_Item(DmItem item)
        {
            DmItem dmItem = await clotherContext.DmItems.FindAsync(item.ItemId);
            if (dmItem != null)
            {
                dmItem = item;
                await clotherContext.SaveChangesAsync();
                return dmItem;
            }
            else
            {
                clotherContext.DmItems.Add(item);
                await clotherContext.SaveChangesAsync();
                return item;
            }
        }
        #endregion

        #region DM_COLOR
        public async Task<DmColor> Get_Dm_Color_ById(string colorId)
        {
            return await clotherContext.DmColors.FindAsync(colorId);
        }
        public async Task<DmColor> Update_Dm_Color(DmColor color)
        {
            DmColor dmColor = await clotherContext.DmColors.FindAsync(color.ColorId);
            if(dmColor != null)
            {
                dmColor = color;
                await clotherContext.SaveChangesAsync();
                return dmColor;
            }
            else
            {
                clotherContext.DmColors.Add(color);
                await clotherContext.SaveChangesAsync();
                return color;
            }
        }
        public async Task<List<DmColor>> List_Dm_Color()
        {
            return await clotherContext.DmColors.ToListAsync();
        }

        public void Delete_Dm_Color(DmColor color)
        {
            if(color == null)
                clotherContext.DmColors.Remove(color);
            clotherContext.SaveChanges();
        }

        #endregion

        #region DmItemType
        public async Task<List<DmItemType>> List_Dm_Item_Type()
        {
            return await clotherContext.DmItemTypes.ToListAsync();
        }

        public void Delete_Dm_Item_Type(DmItemType type)
        {
            if(type != null)
                clotherContext.DmItemTypes.Remove(type);
            clotherContext.SaveChanges();
        }

        public async Task<DmItemType> Update_Dm_Item_Type(DmItemType type)
        {
            DmItemType dmItemType = await clotherContext.DmItemTypes.FindAsync(type.ItemTypeId);
            if(dmItemType != null)
            {
                dmItemType = type;
                clotherContext.SaveChanges();
                return dmItemType;
            }
            else
            {
                clotherContext.DmItemTypes.Add(type);
                clotherContext.SaveChanges();
                return type;
            }
        }

        public async Task<DmItemType> Get_Item_Type_ById(string typeId)
        {
            return await clotherContext.DmItemTypes.FindAsync(typeId);
        }
        #endregion
    }
}
