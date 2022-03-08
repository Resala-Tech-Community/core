using resala.core.Domain.Models;

namespace resala.core.Domain.Services.Communication
{
    public class SaveResponse : BaseResponse
    {
        public BaseModel SavedModel { get; set; }

        public SaveResponse(bool success, string message , BaseModel savedModel) : base(success, message)
        {
            SavedModel = savedModel;
        }

        public SaveResponse(BaseModel savedModel) : this(true,string.Empty,savedModel)
        {
        }

        public SaveResponse(string message) : this(false,message,null)
        {
        }

    }
}
