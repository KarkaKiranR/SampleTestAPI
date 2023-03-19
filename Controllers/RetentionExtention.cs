using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPI.Modal;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RetentionExtentionController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            RetentionModal retentionExtention = new RetentionModal();
            return new JsonResult(retentionExtention.GetList());
        }

        [HttpGet("{Id}")]
        public ActionResult<Retention> Get(string Id)
        {
            RetentionModal retentionExtention = new RetentionModal();
            var retention = retentionExtention.GetList().FirstOrDefault(x => x.RequestID == Id);
            if(retention == null)
            {
                return NotFound();
            }
            return retention;
        }
    }
}
