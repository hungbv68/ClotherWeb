using ClotherService.DmItemService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using New_Clother_Model.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClotherWeb.Controllers.DANH_MUC
{
    [Route("api/[controller]")]
    [ApiController]
    public class Dm_ItemController : ControllerBase
    {
        private IDm_Service dm_Service;

        [HttpGet]
        [Route("list-item")]
        public async Task<IActionResult> GetAll()
        {
            List<DmItem> list = await dm_Service.List_Dm_Item();
            return Ok(list);
        }

        [HttpPost]
        [Route("add-item")]
        public async Task<IActionResult> CreateNew([FromBody]DmItem item)
        {
            string message = "";
            string errorCode = "";
            var jsonObj = new JObject();
            try {
                item = await dm_Service.Update_Dm_Item(item);
                errorCode = "00";
                message = "thêm mới thành công";
                jsonObj.Add("Dm_Item", JsonConvert.SerializeObject(item));
            }catch(Exception ex) {
                errorCode = "500";
                message = "Lưu thất bại đã xảy ra lỗi";
            }
            jsonObj.Add("ErrorCode", errorCode);
            jsonObj.Add("message", message);
            return Ok(jsonObj.ToString());
        }
    }
}
