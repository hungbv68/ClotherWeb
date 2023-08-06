using New_Clother_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotherService.DmItemService
{
    public interface IDm_Service
    {
        #region DM_ITEM
        Task<List<DmItem>> List_Dm_Item();
        void Delete_Dm_Item(DmItem item);
        Task<DmItem> Update_Dm_Item(DmItem item);
        Task<DmItem> Get_Dm_Item_ById(string itemId);
        #endregion

        #region DM_COLOR
        Task<List<DmColor>> List_Dm_Color();
        void Delete_Dm_Color(DmColor color);
        Task<DmColor> Update_Dm_Color(DmColor color);
        Task<DmColor> Get_Dm_Color_ById(string colorId);
        #endregion

        #region DM_ITEM_TYPE
        Task<List<DmItemType>> List_Dm_Item_Type();
        void Delete_Dm_Item_Type(DmItemType type);
        Task<DmItemType> Update_Dm_Item_Type(DmItemType type);
        Task<DmItemType> Get_Item_Type_ById(string typeId);

        #endregion
    }
}
