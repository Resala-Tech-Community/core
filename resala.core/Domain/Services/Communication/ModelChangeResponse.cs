using resala.core.Domain.Models;

namespace resala.core.Domain.Services.Communication
{
    public class ModelChangeResponse : BaseResponse
    {
        public BaseModel ChangedModel { get; set; }

        public ModelChangeResponse(bool success, string message , BaseModel savedModel) : base(success, message)
        {
            ChangedModel = savedModel;
        }

        public ModelChangeResponse(BaseModel savedModel) : this(true,string.Empty,savedModel)
        {
        }

        public ModelChangeResponse(string message) : this(false,message,null)
        {
        }

    }
}
